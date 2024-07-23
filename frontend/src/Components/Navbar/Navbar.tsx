  import React from "react";
  import logo from "./logo.png";
  import "./Navbar.css";
  import { Link } from "react-router-dom";
  import { useAuth } from "../../Context/UseAuth";

  interface Props {}

  const Navbar = (props: Props) => {
    const{ isLoggedin,user,logout } = useAuth();
    return (
      <nav className="relative container mx-auto p-6">
        <div className="flex items-center justify-between">
          <div className="flex items-center space-x-20">
            <Link to="/">
              <img src="logo.png" alt="" />
            </Link>
            <img src={logo} alt="" />
            <div className="hidden font-bold lg:flex">
              <Link to="/search"className="text-black hover:text-darkBlue">
                Search
              </Link>
            </div>
          </div>
          {isLoggedin() ? (

  <div className="hidden lg:flex items-center space-x-6 text-back">
            <div className="hover:text-darkBlue">Welcome, {user?.userName}</div>
            <a
              onClick={logout}
              href=""
              className="px-8 py-3 font-bold rounded text-white bg-lightGreen hover:opacity-70"
            >
              Logout
            </a>
            </div>
          ): (
            <div className="hidden lg:flex items-center space-x-6 text-back">
          <Link to="/login"className="hover:text-darkBlue">Login</Link>
          <Link
          to="/register"
            className="px-8 py-3 font-bold rounded text-white bg-lightGreen hover:opacity-70"
          >
            Sign up
          </Link>
        </div>

          )}
        </div>
      </nav>
    );
  };

export default Navbar;