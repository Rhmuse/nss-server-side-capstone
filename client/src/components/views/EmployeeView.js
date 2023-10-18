import { Route, Routes } from 'react-router-dom';
import { AuthorizedRoute } from '../auth/AuthorizedRoute';
import { Col, Container, Row } from "react-bootstrap";
import OrderSummary from '../pos/OrderSummary';
import PreviousOrdersList from '../pos/PreviousOrdersList';
import LoggedInUserDetails from '../pos/LoggedInUserDetails';
import MainPosView from '../pos/MainPosView';

import "./EmployeeView.css";

const EmployeeView = ({ loggedInUser }) => {
    return (
        <Routes>
            <Route path="/">
                <Route
                    index
                    element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <Row id="mainRow">
                                    <Col lg md sm xl="2" id="orderSummaryCol">
                                        <Row>
                                            <OrderSummary />
                                        </Row>
                                        <Row>
                                            <PreviousOrdersList />
                                        </Row>
                                    </Col>
                                    <Col id="mainViewCol">
                                        <Row>
                                            <LoggedInUserDetails />
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