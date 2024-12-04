import { Route, Routes} from 'react-router-dom';
import './App.css';
import { lazy, Suspense } from 'react';

const ContactLazy = lazy(() => import("./Pages/Contact/Contact"));
const ServiceLazy = lazy(() => import("./Pages/Service/Services"));
const AboutLazy = lazy(() => import("./Pages/About/About"));
const Homelazy= lazy(() => import("./Pages/Home/Home"));
const ProfileLazy = lazy(()=> import("./Pages/Profile/Profile"));
const Notificationlazy = lazy(()=> import("./Pages/Notification/Notification"));

const LazySignUp= lazy (()=> import("./Component/Login/SignUp"));
//const Servicelazy = lazy(()=> import("./Pages/Service/Services"))
const App: React.FC = () => 
  {
    return(
          <>
                  <div className=" container text-center">
                    <Suspense fallback={<Loading/>} >
                        <Routes>
                            <Route index element={<Homelazy />} />
                            <Route path="about" element={<AboutLazy/>}/>
                            <Route path="service" element={<ServiceLazy />} />
                            <Route path="contact" element={<ContactLazy />}/>
                            <Route path="profile" element= {<ProfileLazy/>}/>
                            <Route path="Notification" element= {<Notificationlazy/>}/>
                            <Route path="signup" element= {<LazySignUp/>}/>
                        </Routes>
                    </Suspense>
                  
                </div>
          </>
    );
  }
export default App;

const Loading = ()=>
{
  return(
    <>
      <div className="spinner-border text-center" role="status">
        <span className="visually-hidden">Loading...</span>
      </div>
    </>
  )
}