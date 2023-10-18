import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import { login } from "../../managers/authManager";
import { Form, FormLabel, InputGroup, Button } from "react-bootstrap";

export default function Login({ setLoggedInUser }) {
  const navigate = useNavigate();
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [failedLogin, setFailedLogin] = useState(false);

  const handleSubmit = (e) => {
    e.preventDefault();
    login(email, password).then((user) => {
      if (!user) {
        setFailedLogin(true);
      } else {
        setLoggedInUser(user);
        navigate("/");
      }
    });
  };

  return (
    <div className="container" style={{ maxWidth: "500px" }}>
      <h3>Login</h3>
      <Form>
        <Form.Group>
          <Form.Label>Email</Form.Label>
          <Form.Control
            type="text"
            value={email}
            onChange={(e) => {
              setFailedLogin(false);
              setEmail(e.target.value);
            }}
          />
        </Form.Group>
        <Form.Group>
          <FormLabel>Password</FormLabel>
          <Form.Control
            type="password"
            value={password}
            onChange={(e) => {
              setFailedLogin(false);
              setPassword(e.target.value);
            }}
          />
        </Form.Group>




        <Button color="primary" onClick={handleSubmit}>
          Login
        </Button>
      </Form>
      <p>
        Not signed up? Register <Link to="/register">here</Link>
      </p>
    </div>
  );
}
