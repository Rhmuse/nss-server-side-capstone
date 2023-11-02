import { NavLink as RRNavLink } from "react-router-dom";
import { logout } from "../managers/authManager";
import { Button, Nav, Navbar } from 'react-bootstrap';
import "./Navbar.css";


export default function NavBar({ loggedInUser, setLoggedInUser }) {
  return (
    <div>
      <Navbar fixed="true" expand="lg">
        <Navbar.Brand className="mr-auto" tag={RRNavLink} to="/">
          <img
            src="https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.pngkey.com%2Fpng%2Ffull%2F190-1905067_krabby-patty-png.png&f=1&nofb=1&ipt=d382e63fb7dedc0aad73c7997355764d1d205ccba7b450996d853a3d53b6be72&ipo=images"
            alt="Krusty Krab Logo"
            height={200}
            style={{ marginRight: "8px" }}
          />
        </Navbar.Brand>
        {loggedInUser ? (
          <>
            <Nav>
            </Nav>
            <Button
              className='loginButton'
              color="primary"
              onClick={(e) => {
                e.preventDefault();
                logout().then(() => {
                  setLoggedInUser(null);
                });
              }}
            >
              Logout
            </Button>
          </>
        ) : (
          <Nav navbar>
            <Nav.Item>
              <Nav.Link as={RRNavLink} to="/login">
                <Button className='loginButton' color="primary">Login</Button>
              </Nav.Link>
            </Nav.Item>
          </Nav>
        )}
      </Navbar>
    </div>
  );
}
