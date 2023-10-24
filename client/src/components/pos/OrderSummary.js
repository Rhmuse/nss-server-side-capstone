import { useEffect, useState } from 'react';
import { Col, Container, Row } from 'react-bootstrap';
import currency from 'currency.js';
import Utility from '../../utility';

import "./OrderSummary.css";

const TAX = .08;

const utility = new Utility();

const OrderSummary = ({ order, menuItems, itemBuilder, setItemBuilder }) => {
    const [subTotal, setSubTotal] = useState(0);
    const [orderSummary, setOrderSummary] = useState([]);

    useEffect(() => {
        let subTotal = 0;
        order.drinks.forEach(d => {
            subTotal += d.price * d.quantity;
        });
        order.sides.forEach(s => {
            subTotal += s.price * s.quantity;
        })
        setSubTotal(subTotal);
        let orderSummaryCopy = [...orderSummary];
        order.drinks.forEach(d => {
            const drinkIndex = orderSummaryCopy.findIndex(i => i.drinkId === d.drinkId && i.sizeId === d.sizeId);
            if (drinkIndex < 0) {
                orderSummaryCopy.push(d);
            } else {
                orderSummaryCopy[drinkIndex].quantity = d.quantity;
            }
        })
        order.sides.forEach(s => {
            const sideIndex = orderSummaryCopy.findIndex(i => i.sideId === s.sideId && i.sizeId === s.sizeId);
            if (sideIndex < 0) {
                orderSummaryCopy.push(s);
            } else {
                orderSummaryCopy[sideIndex].quantity = s.quantity;
            }
        })
        order.burgers.forEach(b => {
            const burgerIndex = orderSummaryCopy.findIndex(i => i.id === b.id);
            if (burgerIndex < 0) {
                orderSummaryCopy.push(b);
            } else {
                orderSummaryCopy[burgerIndex].quantity = b.quantity;
            }
        })
        setOrderSummary(orderSummaryCopy);
        setItemBuilder({ quantity: "", sizeId: "" })
    }, [order])

    const parseSizeId = (guid) => {
        const size = menuItems.sizes.find(s => s.id === guid);
        if (size) return size.shortHand.toUpperCase();
    }

    return (
        <Container id="orderSummaryContainer">
            <Row>
                <h4>Order Summary</h4>
                <Col>
                    {
                        orderSummary.map(i => {
                            return (
                                <Row className='orderItem' key={`orderItem-${i.sizeId}-${i.name}`}>
                                    <Col sm md lg xl="1">{i.quantity}</Col>
                                    <Col sm md lg xl="2">{parseSizeId(i.sizeId)}</Col>
                                    <Col>{utility.capitalizeEveryFirstLetter(i.name)}</Col>
                                    <Col className='orderSummaryMoneyCol' sm md lg xl="3">{currency(i.price * i.quantity).format()}</Col>
                                </Row>
                            )
                        })
                    }
                    {
                        <Row className='orderItem'>
                            <Col sm md lg xl="1">{itemBuilder.quantity}</Col>
                            <Col sm md lg xl="2">{parseSizeId(itemBuilder.sizeId)}</Col>
                            <Col></Col>
                            <Col className='orderSummaryMoneyCol' sm md lg xl="3"></Col>
                        </Row>
                    }
                </Col>
            </Row>
            <div id='totalsContainer'>
                <Row className='orderItem'>
                    <Col sm md lg xl="2"><b>Subtotal:</b></Col>
                    <Col sm md lg xl="2"></Col>
                    <Col></Col>
                    <Col className='orderSummaryMoneyCol' sm md lg xl="3">{currency(subTotal).format()}</Col>
                </Row>
                <Row className='orderItem'>
                    <Col sm md lg xl="1"><b>Tax:</b></Col>
                    <Col></Col>
                    <Col sm md lg xl="2"></Col>
                    <Col className='orderSummaryMoneyCol' sm md lg xl="3">{currency(subTotal * TAX).format()}</Col>
                </Row>
                <Row className='orderItem'>
                    <Col sm md lg xl="1"><b>Total:</b></Col>
                    <Col sm md lg xl="2"></Col>
                    <Col></Col>
                    <Col className='orderSummaryMoneyCol' sm md lg xl="3"><b>{currency(subTotal + (subTotal * TAX)).format()}</b></Col>
                </Row>
            </div>
        </Container>
    )
}

export default OrderSummary;