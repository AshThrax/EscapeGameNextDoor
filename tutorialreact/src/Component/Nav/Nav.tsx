import {Link} from 'react-router-dom';
import {
  Menubar,
  MenubarContent,
  MenubarItem,
  MenubarMenu,
  MenubarSeparator,
  MenubarTrigger,
} from "@/components/ui/menubar"

import './Nav.css';
import { FC,useState } from 'react';
import { useAuth0 } from '@auth0/auth0-react';
import LogoutButton from '../Login/Authlogout';
import LoginButton from '../Login/AuthLogin';


const Nav: React.FC = () => {


  const {isAuthenticated} =useAuth0()
  return(
  <>
  <header className=''>
    <div className=' m-4 p-4'>
        <div className='float-start row fixed-top text-red-500'>  
          <div className='float-start me-4'>
         

          </div>
              <Menubar>
                  <MenubarMenu>
                    <MenubarTrigger><Link to="/" >Home |</Link> </MenubarTrigger>
              
                  </MenubarMenu>
                  <MenubarSeparator />
                  <MenubarMenu>
                    <MenubarTrigger><Link to="about">About |</Link></MenubarTrigger>
                  
                  </MenubarMenu>
                  <MenubarSeparator />
                  <MenubarMenu>
                    <MenubarTrigger><Link to="service" >Service |</Link></MenubarTrigger>
                  
                  </MenubarMenu>
                  <MenubarSeparator />
                  <MenubarMenu>
                    <MenubarTrigger><Link to="contact">Contact </Link></MenubarTrigger>
                  
                  </MenubarMenu>
              </Menubar>  
       </div>
          
        
          <div>
            <div className=' float-end '>
                {isAuthenticated ? <AuthDisplay/>:<LoginButton/>}
               
              </div>
          </div>
            <br/>
    
    </div>
  </header>
  </>)

};
export default Nav;

const AuthDisplay: FC=() =>
{

  return (
    <>
    <div className='text-red-400'>
      <Menubar>
        <MenubarMenu>
          <MenubarTrigger>User session</MenubarTrigger>
          <MenubarContent>
          <MenubarItem>
              <LogoutButton />
            </MenubarItem>
            <MenubarItem>
              <Link to="profile">Profile</Link>
            </MenubarItem>
            <MenubarItem>
              <Link to="notification">Notification</Link>
            </MenubarItem>
            <MenubarItem>
              <Link to="about">Article</Link>
            </MenubarItem>
          </MenubarContent>
        </MenubarMenu>
        <MenubarSeparator />
      </Menubar>
    </div> 
    </>
  )
}
