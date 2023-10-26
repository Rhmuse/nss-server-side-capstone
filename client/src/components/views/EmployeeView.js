import { Route, Routes } from 'react-router-dom';
import { AuthorizedRoute } from '../auth/AuthorizedRoute';
import { Col, Container, Row } from "react-bootstrap";
import { useEffect, useState } from 'react';
import OrderSummary from '../pos/OrderSummary';
import PreviousOrdersList from '../pos/PreviousOrdersList';
import LoggedInUserDetails from '../pos/LoggedInUserDetails';
import MainPosView from '../pos/MainPosView';
import { getAllDrinks } from '../../managers/drinksManager';
import { getAllSides } from '../../managers/sidesManager';
import { getAllCombos } from '../../managers/combosManager';
import { getAllSizes } from '../../managers/sizesManager';
import { getAllBurgers } from '../../managers/burgersManger';
import AdminTools from '../pos/AdminTools';
import AddDrinkForm from '../pos/admintools/drinks/AddDrinkForm';
import { getAllToppings } from '../../managers/toppingsManager';
import AddBurgerForm from '../pos/admintools/burgers/AddBurgerForm';
import AddSideForm from '../pos/admintools/sides/AddSideForm';
import "./EmployeeView.css";
import AddToppingForm from '../pos/admintools/toppings/AddToppingForm';
import EditDrinkForm from '../pos/admintools/drinks/EditDrinkForm';


const EmployeeView = ({ loggedInUser, setLoggedInUser }) => {
    const [orderSummary, setOrderSummary] = useState([]);
    const [selectedCategory, setSelectedCategory] = useState("drinks");
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
            toppings: [],
        }
    );

    const [selectedItem, setSelectedItem] = useState({});

    useEffect(() => {
        loadMenuItems();
    }, []);

    const loadMenuItems = () => {
        let menuItems = {};
        Promise.all([getAllDrinks(), getAllSides(), getAllCombos(), getAllSizes(), getAllBurgers(), getAllToppings()]).then(res => {
            menuItems.drinks = res[0];
            menuItems.sides = res[1];
            menuItems.combos = res[2];
            menuItems.sizes = res[3];
            menuItems.burgers = res[4];
            menuItems.toppings = res[5];
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
                                            <OrderSummary orderSummary={orderSummary} setOrderSummary={setOrderSummary} selectedItem={selectedItem} setSelectedItem={setSelectedItem} menuItems={menuItems} order={order} itemBuilder={itemBuilder} setItemBuilder={setItemBuilder} />
                                        </Row>
                                        <Row>
                                            <PreviousOrdersList />
                                        </Row>
                                    </Col>
                                    <Col>
                                        <LoggedInUserDetails loggedInUser={loggedInUser} />
                                        <Row>
                                            <MainPosView orderSummary={orderSummary} setOrderSummary={setOrderSummary} setSelectedItem={setSelectedItem} selectedItem={selectedItem} menuItems={menuItems} order={order} setOrder={setOrder} setItemBuilder={setItemBuilder} itemBuilder={itemBuilder} loggedInUser={loggedInUser} />
                                        </Row>
                                    </Col>
                                </Row>
                            </Container>
                        </AuthorizedRoute>
                    }
                />
                <Route path='admintools'>
                    <Route index element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <AdminTools loadMenuItems={loadMenuItems} loggedInUser={loggedInUser} menuItems={menuItems} setSelectedCategory={setSelectedCategory} selectedCategory={selectedCategory} />
                            </Container>
                        </AuthorizedRoute>
                    }
                    />
                    <Route path='drinks/add' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <AddDrinkForm loadMenuItems={loadMenuItems} setSelectedCategory={setSelectedCategory} menuItems={menuItems} />
                            </Container>
                        </AuthorizedRoute>
                    } />
                    <Route path='drinks/edit/:id' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <EditDrinkForm loadMenuItems={loadMenuItems} setSelectedCategory={setSelectedCategory} menuItems={menuItems} />
                            </Container>
                        </AuthorizedRoute>
                    } />
                    <Route path='burgers/add' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <AddBurgerForm loadMenuItems={loadMenuItems} menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                            </Container>
                        </AuthorizedRoute>
                    } />
                    <Route path='sides/add' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <AddSideForm loadMenuItems={loadMenuItems} menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                            </Container>
                        </AuthorizedRoute>
                    } />
                    <Route path='toppings/add' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <AddToppingForm loadMenuItems={loadMenuItems} menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                            </Container>
                        </AuthorizedRoute>
                    } />
                </Route>
            </Route>
        </Routes>
    )
}

export default EmployeeView; 