
import { useAuth0 } from "@auth0/auth0-react";

const LoginButton = () => {
  const { loginWithRedirect } = useAuth0();

  const handleLog=(()=> {
        loginWithRedirect();
        console.log("submit")
  });
  return <button 
            className="text-red-300" onClick={() => handleLog()}>Log In
        </button>;
};

export default LoginButton;