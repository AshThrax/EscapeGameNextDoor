import { Outlet,Link } from "react-router-dom";
import "./Layout.css";
const Layout = () => {
    return (
        <>
            <nav className="navcustom">
                 
                <div>
                   <h4 className ="spin_test">
                    navbar tutorial
                    </h4> 
                </div>
                <div className="navcontour">
                    <ul>
                        <li>
                            <Link to="/">Home</Link> 
                        </li>
                        <li>
                            <Link to="service">Service</Link>
                        </li>
                        <li>
                            <Link to="about">About</Link>
                        </li>
                        <li>
                            <Link to="contact">Contact</Link>
                        </li>
                    </ul>
                </div>
            </nav>
            <Outlet/>
        </>
    )
};
export default Layout;