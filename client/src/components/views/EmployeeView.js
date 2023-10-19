import { Route, Routes } from 'react-router-dom';
import { AuthorizedRoute } from '../auth/AuthorizedRoute';
import { Button, Col, Container, Row } from "react-bootstrap";
import OrderSummary from '../pos/OrderSummary';
import PreviousOrdersList from '../pos/PreviousOrdersList';
import LoggedInUserDetails from '../pos/LoggedInUserDetails';
import MainPosView from '../pos/MainPosView';
import { logout } from '../../managers/authManager';

import "./EmployeeView.css";

const EmployeeView = ({ loggedInUser, setLoggedInUser }) => {
    return (
        <Routes>
            <Route path="/">
                <Route
                    index
                    element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container >
                                <Row>
                                    <Col lg md sm xl="2" >
                                        <Row>
                                            <OrderSummary />
                                        </Row>
                                        <Row>
                                            <PreviousOrdersList />
                                        </Row>
                                    </Col>
                                    <Col>
                                        <Row id='userDetailsRow'>
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
                                            <LoggedInUserDetails loggedInUser={loggedInUser} />
                                        </Row>
                                        <Row>
                                            <MainPosView />
                                        </Row>
                                    </Col>
                                </Row>
                            </Container>
                        </AuthorizedRoute>
                    }
                />
            </Route>
        </Routes>
    )
}

export default EmployeeView; 