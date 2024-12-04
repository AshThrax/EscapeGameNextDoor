import { createContext } from "vm";

type AuthContext = {
    authtoken?: string | null;
    currentuser?: User | null;
    handlelogin: () => promise<void>;
    handlelogout: () => Promise<void>;
}

const AuthContext = createContext<AuthContext | undefined>(undefined);
type AuthProvidersProps= PropsWithChildren;

export default function AuthProvider({children} : AuthProvidersProps)
{
    return <AuthContext.Provider> {children}</AuthContext.Provider>
}