import { NavLink as RRNavLink } from "react-router-dom";
import { logout } from "../managers/authManager";
import { Button, Nav, Navbar } from 'react-bootstrap';

export default function NavBar({ loggedInUser, setLoggedInUser }) {
  return (
    <div>
      <Navbar color="light" light fixed="true" expand="lg">
        <Navbar.Brand className="mr-auto" tag={RRNavLink} to="/">
          <img
            src=""
            alt="Krusty Krab Logo"
            height={50}
            style={{ marginRight: "8px" }}
          />
          Krusty Krab
        </Navbar.Brand>
        {loggedInUser ? (
          <>
            <Nav>
              <Nav.Item>
                <Nav.Link as={RRNavLink} to="/">
                  Home
                </Nav.Link>
              </Nav.Item>
              <Nav.Item>
                <Nav.Link as={RRNavLink} to="/menu">
                  Menu
                </Nav.Link>
              </Nav.Item>
            </Nav>
            <Button
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
              <Nav.Link tag={RRNavLink} to="/login">
                <Button color="primary">Login</Button>
              </Nav.Link>
            </Nav.Item>
          </Nav>
        )}
      </Navbar>
    </div>
  );
}
