import { Route, Routes } from 'react-router-dom';
import { AuthorizedRoute } from '../auth/AuthorizedRoute';
import { Col, Container, Row } from "react-bootstrap";
import { useEffect, useState } from 'react';
import OrderSummary from '../pos/OrderSummary';
import PreviousOrdersList from '../pos/PreviousOrdersList';
import LoggedInUserDetails from '../pos/LoggedInUserDetails';
import MainPosView from '../pos/MainPosView';
import AdminTools from '../pos/AdminTools';
import AddDrinkForm from '../pos/admintools/drinks/AddDrinkForm';
import AddBurgerForm from '../pos/admintools/burgers/AddBurgerForm';
import AddSideForm from '../pos/admintools/sides/AddSideForm';
import AddToppingForm from '../pos/admintools/toppings/AddToppingForm';
import EditDrinkForm from '../pos/admintools/drinks/EditDrinkForm';
import EditToppingForm from '../pos/admintools/toppings/EditToppingForm';
import EditSideForm from '../pos/admintools/sides/EditSideForm';
import EditBurgerForm from '../pos/admintools/burgers/EditBurgerForm';
import AddComboForm from '../pos/admintools/combos/AddComboForm';
import EditComboForm from '../pos/admintools/combos/EditComboForm';
import AddSizeForm from '../pos/admintools/sizes/AddSizeForm';
import EditSizeForm from '../pos/admintools/sizes/EditSizeForm';
import { getAllDrinks } from '../../managers/drinksManager';
import { getAllSides } from '../../managers/sidesManager';
import { getAllCombos } from '../../managers/combosManager';
import { getAllSizes } from '../../managers/sizesManager';
import { getAllBurgers } from '../../managers/burgersManger';
import { getAllToppings } from '../../managers/toppingsManager';
import "./EmployeeView.css";
import { getAllOrders } from '../../managers/orderManager';
import { getAllOrderTypes } from '../../managers/orderTypesManager';


const EmployeeView = ({ loggedInUser, setLoggedInUser }) => {
    const [orderSummary, setOrderSummary] = useState([]);
    const [selectedCategory, setSelectedCategory] = useState("drinks");
    const [itemBuilder, setItemBuilder] = useState({
        quantity: "",
        sizeId: "",
    });
    const [orders, setOrders] = useState([]);

    useEffect(() => {
        loadMenuItems();
        loadOrders();
    }, []);

    const [order, setOrder] = useState({
        order: {
            orderTypeId: "",
            employeeId: loggedInUser.id
        },
        drinks: [],
        burgers: [],
        sides: [],
        combos: [],
    });

    const [menuItems, setMenuItems] = useState(
        {
            drinks: [],
            sides: [],
            combos: [],
            sizes: [],
            burgers: [],
            toppings: [],
            orderTypes: [],
        }
    );

    const [selectedItem, setSelectedItem] = useState({});


    const loadMenuItems = () => {
        let menuItems = {};
        Promise.all([getAllDrinks(), getAllSides(), getAllCombos(), getAllSizes(), getAllBurgers(), getAllToppings(), getAllOrderTypes()]).then(res => {
            menuItems.drinks = res[0];
            menuItems.sides = res[1];
            menuItems.combos = res[2];
            menuItems.sizes = res[3];
            menuItems.burgers = res[4];
            menuItems.toppings = res[5];
            menuItems.orderTypes = res[6];
            setMenuItems(menuItems);
        })
    };

    const loadOrders = () => {
        getAllOrders().then(setOrders)
    }
    return (
        <Routes>
            <Route path="/">
                <Route
                    index
                    element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container id='employeeViewContainer'>
                                <Row id='employeeViewRow'>
                                    <Col lg md sm xl="3" >
                                        <Row id="orderSummaryRow">
                                            <OrderSummary orderSummary={orderSummary} setOrderSummary={setOrderSummary} selectedItem={selectedItem} setSelectedItem={setSelectedItem} menuItems={menuItems} order={order} itemBuilder={itemBuilder} setItemBuilder={setItemBuilder} />
                                        </Row>
                                        <Row id='previousOrdersContainerRow'>
                                            <PreviousOrdersList orders={orders} />
                                        </Row>
                                    </Col>
                                    <Col id='employeeViewRightCol'>
                                        <LoggedInUserDetails loggedInUser={loggedInUser} />
                                        <Row id='mainPosViewRow'>
                                            <MainPosView orderSummary={orderSummary} setOrderSummary={setOrderSummary} setSelectedItem={setSelectedItem} selectedItem={selectedItem} menuItems={menuItems} order={order} setOrder={setOrder} setItemBuilder={setItemBuilder} itemBuilder={itemBuilder} loggedInUser={loggedInUser} loadOrders={loadOrders} />
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

                    {/* Drinks */}
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

                    {/* Combos */}
                    <Route path='combos/add' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <AddComboForm loadMenuItems={loadMenuItems} menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                            </Container>
                        </AuthorizedRoute>
                    } />

                    <Route path='combos/edit/:id' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <EditComboForm loadMenuItems={loadMenuItems} setSelectedCategory={setSelectedCategory} menuItems={menuItems} />
                            </Container>
                        </AuthorizedRoute>
                    } />

                    {/* Burgers */}
                    <Route path='burgers/add' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <AddBurgerForm loadMenuItems={loadMenuItems} menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                            </Container>
                        </AuthorizedRoute>
                    } />

                    <Route path='burgers/edit/:id' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <EditBurgerForm loadMenuItems={loadMenuItems} setSelectedCategory={setSelectedCategory} menuItems={menuItems} />
                            </Container>
                        </AuthorizedRoute>
                    } />

                    {/* Sides */}
                    <Route path='sides/add' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <AddSideForm loadMenuItems={loadMenuItems} menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                            </Container>
                        </AuthorizedRoute>
                    } />

                    <Route path='sides/edit/:id' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <EditSideForm loadMenuItems={loadMenuItems} setSelectedCategory={setSelectedCategory} menuItems={menuItems} />
                            </Container>
                        </AuthorizedRoute>
                    } />

                    {/* Sizes */}

                    <Route path='sizes/add' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <AddSizeForm loadMenuItems={loadMenuItems} menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                            </Container>
                        </AuthorizedRoute>
                    } />

                    <Route path='sizes/edit/:id' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <EditSizeForm loadMenuItems={loadMenuItems} setSelectedCategory={setSelectedCategory} menuItems={menuItems} />
                            </Container>
                        </AuthorizedRoute>
                    } />

                    {/* Toppings */}
                    <Route path='toppings/add' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <AddToppingForm loadMenuItems={loadMenuItems} menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                            </Container>
                        </AuthorizedRoute>
                    } />
                    <Route path='toppings/edit/:id' element={
                        <AuthorizedRoute loggedInUser={loggedInUser}>
                            <Container>
                                <LoggedInUserDetails loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
                                <EditToppingForm loadMenuItems={loadMenuItems} setSelectedCategory={setSelectedCategory} menuItems={menuItems} />
                            </Container>
                        </AuthorizedRoute>
                    } />
                </Route>
            </Route>
        </Routes>
    )
}

export default EmployeeView; 