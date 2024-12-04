import React, {useState, useEffect, createContext} from 'react';
import { Navigate } from 'react-router-dom';
import {User} from "../../Interface/user";


const UserContext= createContext({});

function AuthorizeView (props: {children: React.ReactNode})
{
    const [authorized , setauthorized]= useState<boolean>(false);
    const [loading, setloading] = useState<boolean>(true) //add loading stat

    let emptyuser : User = {email: ""};

    const [user ,setUser]= useState(emptyuser);

    useEffect(()=> {
        const  retryCount : number = 0;
        const maxRetries : number = 10;
        const  delay : number =1000;

        //define a  delay function thtat returns a promise 
        function wait (delay: number)
        {
            return new Promise((resolve) =>setTimeout(resolve,delay));
        }

        async function fetchWithRetry(url: string, option: any)
        {
            try
            {
                let response =  await fetch(url,option);
                if(response.status ==200)
                {
                    console.log("Authorized");
                    let j: any = await response.json();
                    setUser({email:j.email});
                    setauthorized(true);
                    return(response);
                    
                }
                else if( response.status == 401)
                {
                    console.log("Unauthorized");
                    return response;
                }
                else
                {
                    throw Error("" + response.status);
                }
            }
            catch(error)
            {
                retryCount ++;
                if(retryCount > maxRetries)
                {
                    throw error
                }
                else{
                    await wait(delay);
                    return fetchWithRetry(url,option);
                }
            }
        }
        fetchWithRetry("/pingauth", {method: "GET"}).catch((error) => 
            {
                console.log(error.message);
            }).finally(()=>{setloading(false)})
    },[]);
    if(loading)
    {
        return(
        <>
        <p>loading</p>
        </>);
    }
    else{ 
        if(authorized && !loading)
        {
            <>
                <UserContext.Provider value={user}>{props.children}</UserContext.Provider>
            </>
        }
        else{
            return(
                <>
                    <Navigate to="/login" />
                </>
            )
        }
    }
}

export function AuthorizedUser( props: {value: string })
{
    const user: any = React.useContext(UserContext);

    if(props.value == "email")
        return <>{user.email}</>
    else
        return <></>
}

export default AuthorizeView;