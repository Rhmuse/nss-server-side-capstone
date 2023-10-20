import { Route, Routes } from 'react-router-dom';
import { AuthorizedRoute } from '../auth/AuthorizedRoute';
import { Button, Col, Container, Row } from "react-bootstrap";
import { logout } from '../../managers/authManager';
import { useState } from 'react';
import OrderSummary from '../pos/OrderSummary';
import PreviousOrdersList from '../pos/PreviousOrdersList';
import LoggedInUserDetails from '../pos/LoggedInUserDetails';
import MainPosView from '../pos/MainPosView';

import "./EmployeeView.css";

const EmployeeView = ({ loggedInUser, setLoggedInUser }) => {
    const [order, setOrder] = useState({
        order: {
            orderTypeId: "",
            employeeId: loggedInUser.id
        },
        drinks: {},
        burgers: {},
        sides: {}
    });

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
                                            <OrderSummary order={order} />
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
                                            <MainPosView order={order} setOrder={setOrder} />
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