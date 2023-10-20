import { Route, Routes } from 'react-router-dom';
import { AuthorizedRoute } from '../auth/AuthorizedRoute';
import { Button, Col, Container, Row } from "react-bootstrap";
import { logout } from '../../managers/authManager';
import { useEffect, useState } from 'react';
import OrderSummary from '../pos/OrderSummary';
import PreviousOrdersList from '../pos/PreviousOrdersList';
import LoggedInUserDetails from '../pos/LoggedInUserDetails';
import MainPosView from '../pos/MainPosView';

import "./EmployeeView.css";
import { getAllDrinks } from '../../managers/drinksManager';
import { getAllSides } from '../../managers/sidesManager';
import { getAllCombos } from '../../managers/combosManager';

const EmployeeView = ({ loggedInUser, setLoggedInUser }) => {
    const [order, setOrder] = useState({
        order: {
            orderTypeId: "",
            employeeId: loggedInUser.id
        },
        drinks: [],
        burgers: [],
        sides: []
    });

    const [menuItems, setMenuItems] = useState(
        {
            drinks: [],
            sides: [],
            combos: [],
        }
    );

    useEffect(() => {
        loadMenuItems();
    }, []);

    const loadMenuItems = () => {
        let menuItems = {};
        getAllDrinks().then((res) => {
            menuItems.drinks = res;
            getAllSides().then(res => {
                menuItems.sides = res;
                getAllCombos().then(res => {
                    menuItems.combos = res
                    setMenuItems(menuItems);
                });
            });
        });
    };

    return (
        <Routes>
            <Route path="/">
                <Route
                    index
                    element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container >
                                <Row>
                                    <Col lg md sm xl="3" >
                                        <Row id="orderSummaryRow">
                                            <OrderSummary menuItems={menuItems} order={order} />
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
                                            <MainPosView menuItems={menuItems} order={order} setOrder={setOrder} />
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