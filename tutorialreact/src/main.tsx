
import { createRoot } from 'react-dom/client';
import { BrowserRouter} from 'react-router-dom';
import { Auth0Provider} from '@auth0/auth0-react';
import { Sidebar, SidebarProvider, SidebarTrigger, SidebarGroup, SidebarGroupLabel, SidebarGroupContent, SidebarMenu, SidebarMenuItem, SidebarContent, SidebarInset, SidebarHeader } from './components/ui/sidebar.tsx';
import './index.css';
import App from './App.tsx';
import Footer from './Component/Footer/Footer.tsx';
import Nav from './Component/Nav/Nav.tsx';
import authconfig from './auth_config.json';


createRoot(document.getElementById('root')!).render(
  <>
  <Auth0Provider
            domain={authconfig.domain}
            clientId={authconfig.clientId}
            authorizationParams={{
                          audience:authconfig.audience,
                          redirect_uri: window.location.origin
                          }}>
    <BrowserRouter>
     <div className='h-20 m-0 p-0 rounded-sm'>
        <SidebarProvider defaultOpen={true}>
                <Sidebar>
                     <SidebarHeader />
                      <SidebarContent>
                      <SidebarGroup />
                        <SidebarGroupLabel>
                          <h2>
                            Application test
                          </h2>
                        </SidebarGroupLabel>
                        <SidebarGroupContent>
                            <SidebarMenu>
                              <SidebarMenuItem>
                                
                                <p> profile</p>
                              </SidebarMenuItem>
                              <SidebarMenuItem>
                                
                                <p> profile</p>
                              </SidebarMenuItem>
                              <SidebarMenuItem>
                                
                                <p> profile</p>
                              </SidebarMenuItem>
                              <SidebarMenuItem>
                                
                                <p> profile</p>
                              </SidebarMenuItem>
                              <SidebarMenuItem>
                                
                                <p> profile</p>
                              </SidebarMenuItem>
                            </SidebarMenu>
                        </SidebarGroupContent>
                      <SidebarGroup />
                    </SidebarContent>
  
                </Sidebar>
                <SidebarInset>
                <main>
                <SidebarTrigger className="bg-red-100 float-start start-10" />
                </main>
                 
               
                  <div className="flex flex-1 flex-col gap-4 p-4">
                  <Nav />
                      <App />
                  </div>
                </SidebarInset>
            </SidebarProvider>
     </div>
    </BrowserRouter>
    <Footer/>
    </Auth0Provider>
    </>

)
