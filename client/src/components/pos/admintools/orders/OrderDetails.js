import { useEffect, useState } from 'react';
import { Button, Col, Container, Row } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';
import CategorySelect from '../../CategorySelect';
import { capitalizeEveryFirstLetter } from '../../../../utility';
import "./OrderDetails.css";
import currency from 'currency.js';

const OrderDetails = ({ orders, selectedCategory, setSelectedCategory, menuItems }) => {
    const { orderId } = useParams();
    const navigate = useNavigate();
    const [order, setOrder] = useState({});

    useEffect(() => {
        const foundOrder = orders.find(o => o.id === orderId);
        if (foundOrder) setOrder(foundOrder);
    }, [])

    return (
        <Container id='orderDetailsContainer'>
            <h1>Order - {order.id}</h1>
            <Row id='adminToolsCategoryRow'>
                <Col>
                    <CategorySelect menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                </Col>
                <Col>
                </Col>
                <Col className='adminTools-col3'>
                    <Button className='posButton' onClick={() => { navigate("/") }}>Return to POS</Button>
                </Col>
            </Row>
            <Row>
                <Col sm md lg="4"><b>Quantity, Type, and Id</b></Col>
                <Col sm md lg="4"><b>Price</b></Col>
                <Col><b>Details</b></Col>
            </Row>
            <Row>
                <Col>
                    {
                        order?.burgers?.map(b => {
                            return (
                                <Row key={`orderBurger-${b.id}-${order.id}`} className='lineItem'>
                                    <Col sm md lg="4"><b>{b.quantity} Burger {b.id}</b></Col>
                                    <Col sm md lg="4"><b>{currency(b.price * b.quantity).format()}</b></Col>
                                    <Col className='orderBurgerToppingDetailsCol'>
                                        {
                                            b.burgerToppings.map(bt => {
                                                return (
                                                    <div className='orderBurgerToppingDetails' key={`orderBurgerTopping-${b.id}-${bt.id}`}>
                                                        <b>{bt.extra ? "Extra " : ""}{capitalizeEveryFirstLetter(bt.topping.name)}</b>
                                                    </div>
                                                )
                                            })
                                        }
                                    </Col>
                                </Row>
                            )
                        })
                    }
                    {
                        order?.orderDrinks?.map(d => {
                            return (
                                <Row key={`orderDrink-${d.id}-${order.id}`} className='lineItem'>
                                    <Col sm md lg="4"><b>{d.quantity} Drink {d.id}</b></Col>
                                    <Col sm md lg="4"><b>{currency(d.price * d.quantity).format()}</b></Col>
                                    <Col className='orderBurgerToppingDetailsCol'>
                                        <b>{capitalizeEveryFirstLetter(d.drink.name)}</b>
                                    </Col>
                                </Row>
                            )
                        })
                    }
                    {
                        order?.orderSides?.map(s => {
                            return (
                                <Row key={`orderSide-${s.id}-${order.id}`} className='lineItem'>
                                    <Col sm md lg="4"><b>{s.quantity} Side {s.id}</b></Col>
                                    <Col sm md lg="4"><b>{currency(s.price * s.quantity).format()}</b></Col>
                                    <Col className='orderBurgerToppingDetailsCol'>
                                        <b>{capitalizeEveryFirstLetter(s.side.name)}</b>
                                    </Col>
                                </Row>
                            )
                        })
                    }
                    {
                        order?.orderCombos?.map(oc => {
                            const foundCombo = menuItems.combos.find(o => o.id === oc.orderId)
                            return (
                                <Row key={`orderCombo-${oc.id}-${order.id}`} className='lineItem'>
                                    <Col sm md lg="4"><b>{oc.quantity} Combo {oc.id}</b></Col>
                                    <Col sm md lg="4"><b>{currency(oc.price * oc.quantity).format()}</b></Col>
                                    <Col className='orderBurgerToppingDetailsCol'>
                                        <b>{foundCombo.name} {currency(foundCombo.discount).format()}</b>
                                    </Col>
                                </Row>
                            )
                        })
                    }
                    <Row key={`orderTotal}-${order.id}`} className='lineItem'>
                        <Col sm md lg="4"></Col>
                        <Col sm md lg="4"></Col>
                        <Col className='orderBurgerToppingDetailsCol orderDetailsTotal'>
                            Total: {currency(order.total).format()}
                        </Col>
                    </Row>
                </Col>
            </Row>
        </Container>
    )
}

export default OrderDetails;