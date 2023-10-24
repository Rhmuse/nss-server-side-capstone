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
import { getAllSizes } from '../../managers/sizesManager';
import { getAllBurgers } from '../../managers/burgersManger';

const EmployeeView = ({ loggedInUser, setLoggedInUser }) => {
    const [itemBuilder, setItemBuilder] = useState({
        quantity: "",
        sizeId: "",
    });

    const [order, setOrder] = useState({
        order: {
            orderTypeId: "",
            employeeId: loggedInUser.id
        },
        drinks: [],
        burgers: [],
        sides: [],
    });

    const [menuItems, setMenuItems] = useState(
        {
            drinks: [],
            sides: [],
            combos: [],
            sizes: [],
            burgers: [],
        }
    );

    useEffect(() => {
        loadMenuItems();
    }, []);

    const loadMenuItems = () => {
        let menuItems = {};
        Promise.all([getAllDrinks(), getAllSides(), getAllCombos(), getAllSizes(), getAllBurgers()]).then(res => {
            menuItems.drinks = res[0];
            menuItems.sides = res[1];
            menuItems.combos = res[2];
            menuItems.sizes = res[3];
            menuItems.burgers = res[4];
            setMenuItems(menuItems);
        })
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
                                            <OrderSummary menuItems={menuItems} order={order} itemBuilder={itemBuilder} setItemBuilder={setItemBuilder} />
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
                                            <MainPosView menuItems={menuItems} order={order} setOrder={setOrder} setItemBuilder={setItemBuilder} itemBuilder={itemBuilder} />
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