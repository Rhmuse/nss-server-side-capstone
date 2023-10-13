import { useState } from "react";
import { NavLink as RRNavLink } from "react-router-dom";
import { logout } from "../managers/authManager";
import { Button, Nav, Navbar } from 'react-bootstrap';

export default function NavBar({ loggedInUser, setLoggedInUser }) {
  const [open, setOpen] = useState(false);
  const toggleNavbar = () => setOpen(!open);
  return (
    <div>
      <Navbar color="light" light fixed="true" expand="lg">
        <Navbar.Brand className="mr-auto" tag={RRNavLink} to="/">
          <img
            src="./bike.png"
            alt="bike"
            height={50}
            style={{ marginRight: "8px" }}
          />
          Bianca's Bike Shop
        </Navbar.Brand>
        {loggedInUser ? (
          <>
            <Navbar.Toggle onClick={toggleNavbar} />
            <NavBar.Collapse isOpen={open} navbar>
              <Nav navbar>
                <Nav.Item onClick={() => setOpen(false)}>
                  <Nav.Link tag={RRNavLink} to="/bikes">
                    Bikes
                  </Nav.Link>
                </Nav.Item>
                <Nav.Item onClick={() => setOpen(false)}>
                  <Nav.Link tag={RRNavLink} to="/workorders">
                    Work Orders
                  </Nav.Link>
                </Nav.Item>
                {loggedInUser.roles.includes("Admin") && (
                  <Nav.Item onClick={() => setOpen(false)}>
                    <Nav.Link tag={RRNavLink} to="/employees">
                      Employees
                    </Nav.Link>
                  </Nav.Item>
                )}
              </Nav>
            </NavBar.Collapse>
            <Button
              color="primary"
              onClick={(e) => {
                e.preventDefault();
                setOpen(false);
                logout().then(() => {
                  setLoggedInUser(null);
                  setOpen(false);
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
