import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse, CancelTokenSource } from 'axios';

class HttpService<T> {
    private baseUrl: string;
    private instance: AxiosInstance;

    constructor(baseUrl = '', timeout = 10000) { // Default timeout of 10 seconds
        this.baseUrl = baseUrl;
        this.instance = axios.create({
            baseURL: this.baseUrl,
            timeout,
        });
    }

    // Getter for default headers
    private get defaultHeaders() {
        const authToken = localStorage.getItem('Authorization');
        return {
            ...(authToken ? { Authorization: authToken } : {}),
            'Content-Type': 'application/json',
        };
    }

    // Generic request method
    private async request<R>(
        method: string,
        url: string,
        data: T | null = null,
        customHeaders: Record<string, string> = {}
    ): Promise<R> {
        const headers = { ...this.defaultHeaders, ...customHeaders };
        const source: CancelTokenSource = axios.CancelToken.source();

        const config: AxiosRequestConfig = {
            method,
            url,
            headers,
            cancelToken: source.token,
            data,
        };

        try {
            const response: AxiosResponse<R> = await this.instance.request<R>(config);
            return response.data;
        } catch (error) {
            if (axios.isAxiosError(error)) {
                console.error('Axios error:', error.response?.data || error.message);
            } else {
                console.error('Unknown error:', error);
            }
            throw error;
        }
    }

    // HTTP methods
    public get<R>(url: string, customHeaders: Record<string, string> = {}): Promise<R> {
        return this.request<R>('get', url, null, customHeaders);
    }

    public post<R>(url: string, data: T, customHeaders: Record<string, string> = {}): Promise<R> {
        return this.request<R>('post', url, data, customHeaders);
    }

    public put<R>(url: string, data: T, customHeaders: Record<string, string> = {}): Promise<R> {
        return this.request<R>('put', url, data, customHeaders);
    }

    public delete<R>(url: string, customHeaders: Record<string, string> = {}): Promise<R> {
        return this.request<R>('delete', url, null, customHeaders);
    }

    // Update the base URL
    public setBaseUrl(newUrl: string): void {
        this.baseUrl = newUrl;
        this.instance.defaults.baseURL = newUrl;
    }

    // Update default headers dynamically
    public setHeader(key: string, value: string): void {
        this.instance.defaults.headers.common[key] = value;
    }

    public removeHeader(key: string): void {
        delete this.instance.defaults.headers.common[key];
    }
}

export default HttpService;