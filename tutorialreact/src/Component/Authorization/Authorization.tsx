import React, { useState } from "react"



type Authwrapper = 
{
    name:string;
    Role:string;
    Children: React.ReactNode
}



const Authorization: FC<Authwrapper>=>({name,Role,Children}) => {

    const [authorized,setauthorized] =useState<boolean>(false);

    
    return(
        <>
            {(authorized) ? {Children}: <p> Not authorized</p>}
        </>
    )

}