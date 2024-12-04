import React, {  FC, useEffect, useState } from 'react';
import './Login.css';
import { SignUp } from '../../Interface/Login';


const UserSignUp : FC=()=> 
    {
        const [inputform,setInputform] = useState<SignUp>(
            {
                Name: "",
                Username: "",
                Email: "",
                Password: "",
            });
        
            

        const handlesubmit=(event: React.FormEvent)=>
        {
            event.preventDefault();
            console.log(`${inputform.Name} `);
            console.log(`${inputform.Username}`);
            console.log(`${inputform.Email}`);
            console.log(`${inputform.Password}`);
        }
        useEffect(() => {

        },[]);
        return(
            <>
            <div className='logBackground columns-1 items-center p-2'>
            <h2 className="mb-5">Sign Up</h2>
            <hr />
                <form className='bg-white rounded-md text-black shadow-sm px-10'>
                    <div className='sizeDiv'>
                        <label >Nom</label>
                        <input className='bg-red-100 '  type='text' value={inputform.Name} onChange={e =>setInputform(e.target.value)} />
                  
                    </div>
                    <div className='sizeDiv'>
                        <label>Prenom</label>
                        <input className='bg-red-100 '  type='text' value={inputform.Username} onChange={e =>setInputform(e.target.value)} />
              
                    </div>
                    <div className='sizeDiv'>
                        <label>Email</label>
                        <input className='bg-red-100 '  type='text' value={inputform.Email} onChange={e =>setInputform(e.target.value)} />
                   
                    </div>
                    <div className='sizeDiv'>
                        <label>Password</label>
                        <input className='bg-red-100 '  type='text' value={inputform.Password} onChange={e =>setInputform(e.target.value)} />
                       
                    </div>
                    <button type='submit' className='mt-5 bg-red-500 shadow-md' onClick={handlesubmit}>Submit</button>
                </form>
            </div>
        </>);
    }
    export default UserSignUp;
