import { useState } from "react";
import { register } from "../../managers/authManager";
import { Link, useNavigate } from "react-router-dom";
import { Form, Button } from 'react-bootstrap';

export default function Register({ setLoggedInUser }) {
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [userName, setUserName] = useState("");
  const [email, setEmail] = useState("");
  const [address, setAddress] = useState("");
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");

  const [passwordMismatch, setPasswordMismatch] = useState();

  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();

    if (password !== confirmPassword) {
      setPasswordMismatch(true);
    } else {
      const newUser = {
        firstName,
        lastName,
        userName,
        email,
        address,
        password,
      };
      register(newUser).then((user) => {
        setLoggedInUser(user);
        navigate("/");
      });
    }
  };

  return (
    <div className="container" style={{ maxWidth: "500px" }}>
      <h3>Sign Up</h3>
      <Form>
        <Form.Group>
          <Form.Label>First Name</Form.Label>
          <Form.Control
            type="text"
            value={firstName}
            onChange={(e) => {
              setFirstName(e.target.value);
            }}
          />
        </Form.Group>
        <Form.Group>
          <Form.Label>Last Name</Form.Label>
          <Form.Control
            type="text"
            value={lastName}
            onChange={(e) => {
              setLastName(e.target.value);
            }}
          />
        </Form.Group>
        <Form.Group>
          <Form.Label>Email</Form.Label>
          <Form.Control
            type="email"
            value={email}
            onChange={(e) => {
              setEmail(e.target.value);
            }}
          />
        </Form.Group>
        <Form.Group>
          <Form.Label>User Name</Form.Label>
          <Form.Control
            type="text"
            value={userName}
            onChange={(e) => {
              setUserName(e.target.value);
            }}
          />
        </Form.Group>
        <Form.Group>
          <Form.Label>Address</Form.Label>
          <Form.Control
            type="text"
            value={address}
            onChange={(e) => {
              setAddress(e.target.value);
            }}
          />
        </Form.Group>
        <Form.Group>
          <Form.Label>Password</Form.Label>
          <Form.Control
            invalid={passwordMismatch}
            type="password"
            value={password}
            onChange={(e) => {
              setPasswordMismatch(false);
              setPassword(e.target.value);
            }}
          />
        </Form.Group>
        <Form.Group>
          <Form.Label> Confirm Password</Form.Label>
          <Form.Control
            invalid={passwordMismatch}
            type="password"
            value={confirmPassword}
            onChange={(e) => {
              setPasswordMismatch(false);
              setConfirmPassword(e.target.value);
            }}
          />
          <Form.Control.Feedback>Passwords do not match!</Form.Control.Feedback>
        </Form.Group>
        <Button
          color="primary"
          onClick={handleSubmit}
          disabled={passwordMismatch}
        >
          Register
        </Button>
      </Form>
      <p>
        Already signed up? Log in <Link to="/login">here</Link>
      </p>
    </div>
  );
}
