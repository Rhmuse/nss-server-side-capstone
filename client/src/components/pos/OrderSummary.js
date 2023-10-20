import { useEffect, useState } from 'react';
import { Col, Container, Row } from 'react-bootstrap';
import currency from 'currency.js';
import Utility from '../../utility';

import "./OrderSummary.css";

const TAX = .08;

const utility = new Utility();

const OrderSummary = ({ order, menuItems }) => {
    const [subTotal, setSubTotal] = useState(0);
    useEffect(() => {
        let subTotal = 0;
        order.drinks.forEach(d => {
            subTotal += d.price * d.quantity;
        });
        order.sides.forEach(s => {
            subTotal += s.price * s.quantity;
        })
        setSubTotal(subTotal);
    }, [order])
    return (
        <Container id="orderSummaryContainer">
            <Row>
                <h4>Order Summary</h4>
                <Col>
                    {order.drinks.map(d => {
                        return (
                            <Row className='orderItem' key={`orderItem-${d.id}`}>
                                <Col sm md lg xl="1">{d.quantity}</Col>
                                <Col sm md lg xl="2">Med</Col>
                                <Col>{utility.capitalizeEveryFirstLetter(d.name)}</Col>
                                <Col className='orderSummaryMoneyCol' sm md lg xl="3">{currency(d.price * d.quantity).format()}</Col>
                            </Row>
                        )
                    })}
                    {order.sides.map(s => {
                        return (
                            <Row className='orderItem' key={`orderItem-${s.id}`}>
                                <Col sm md lg xl="1">{s.quantity}</Col>
                                <Col sm md lg xl="2">Sml</Col>
                                <Col>{utility.capitalizeEveryFirstLetter(s.name)}</Col>
                                <Col className='orderSummaryMoneyCol' sm md lg xl="3">{currency(s.price * s.quantity).format()}</Col>
                            </Row>
                        )
                    })}
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