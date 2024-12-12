import { Auth0Context, useAuth0 } from "@auth0/auth0-react";

type AuthorizationWrapper={
    children: React.ReactNode;
}

const AuthWrapper: React.FC<AuthorizationWrapper> =({children}) =>
{
    const isAuthentication = useAuth0();

    if(isAuthentication)
    {
        return(
        <>
            {children}
        </>);
    }
    else
    {
        return(
        <>
            <p> Your're </p>
        </>);
    }
}

export default AuthWrapper;


const AuthAdminWrapper: React.FC<AuthorizationWrapper> =({children}) =>
    {
        const isAuthentication = useAuth0().isAuthenticated;
        const isAdmin  = useAuth0().;
        const 
        if(isAuthentication && )
        {
            return(
            <>
                {children}
            </>);
        }
        else
        {
            return(
            <>
                <p> Your're </p>
            </>);
        }
}
    
export  {AuthAdminWrapper};
    