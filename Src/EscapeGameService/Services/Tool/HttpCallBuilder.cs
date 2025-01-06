using System.Text;
using Newtonsoft.Json;

namespace EscapeGameService.Services.Tool
{
    public class HttpCallBuilder<T>
    {
        private string baseUrl =string.Empty;
        private string method =string.Empty;
        T? Value;
        private HttpClient? _httpClient;

        public HttpCallBuilder<T> setAddress(string address)
        { 
            baseUrl = address; 
            return this;
        }
        public HttpCallBuilder<T> Post()
        {
            method = "POST";
            return this;
        }
        public HttpCallBuilder<T> SendValue(T data)
        {

            Value = data;
            return this;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpCallBuilder<T> Get()
        {
            method = "GET";
            return this;
        }


        public async Task<T?> CallAsync()
        {
            _httpClient = new HttpClient();
            try 
            {
                if (method == "GET")
                {
                    var response = await _httpClient.GetAsync(baseUrl);
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(content);
                }
                else if (method == "POST")
                {
                    var jsonData = JsonConvert.SerializeObject(Value);
                    var httpContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await _httpClient.PostAsync(baseUrl, httpContent);

                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(content);
                }
                else
                {
                    throw new ArgumentException("no methodes parameter ");
                }
            }
            catch(Exception) 
            { 
                throw;
            }
        }
    }

}
