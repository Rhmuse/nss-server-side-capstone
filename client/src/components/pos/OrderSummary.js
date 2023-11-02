import { useEffect, useState } from 'react';
import { Col, Container, Row } from 'react-bootstrap';
import currency from 'currency.js';
import { capitalizeEveryFirstLetter } from '../../utility';

import "./OrderSummary.css";

const TAX = .08;

const OrderSummary = ({ order, menuItems, itemBuilder, setItemBuilder, setSelectedItem, selectedItem, orderSummary, setOrderSummary }) => {
    const [subTotal, setSubTotal] = useState(0);

    useEffect(() => {
        let subTotal = 0;
        order.drinks.forEach(d => {
            subTotal += (d.price + parseSizePrice(d.sizeId)) * d.quantity;
        });
        order.sides.forEach(s => {
            subTotal += (s.price + parseSizePrice(s.sizeId)) * s.quantity;
        })
        order.combos.forEach(c => {
            subTotal += c.price;
        })
        order.burgers.forEach(b => {
            subTotal += b.price * b.quantity;
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
        order.combos.forEach(c => {
            const comboIndex = orderSummaryCopy.findIndex(i => i.tempId === c.tempId);
            if (comboIndex < 0) {
                orderSummaryCopy.push(c);
            }

        })

        setOrderSummary(orderSummaryCopy);
        setItemBuilder({ quantity: "", sizeId: "" })
    }, [order])

    const parseSizeShortHand = (guid) => {
        const size = menuItems.sizes.find(s => s.id === guid);
        if (size) return size.shortHand;
    }
    const parseSizePrice = (guid) => {
        const size = menuItems.sizes.find(s => s.id === guid);
        if (size) return size.price;
    }

    const calculatePrice = (item) => {
        if (item.sizeId) {
            return (item.price + parseSizePrice(item.sizeId)) * item.quantity;
        }
        return item.price * item.quantity;
    }

    const handleClick = (e, item) => {
        e.preventDefault();
        if (selectedItemMatches(item)) {
            if (e.target.className === "comboSubItem row selectedItem") {
                e.target.className = "comboSubItem row"
            } else {
                e.target.className = 'orderItem row'
            }
            setSelectedItem({});
        } else {
            if (e.target.className === "comboSubItem row") {
                e.target.className = "comboSubItem row selectedItem"
            } else {
                e.target.className = 'orderItem selectedItem row';
            }
            setSelectedItem(item)
        }
    };

    const selectedItemMatches = (item) => {
        if (item.drinkId) {
            if (item.drinkId === selectedItem.drinkId && item.sizeId === selectedItem.sizeId) return true;
        }
        if (item.sideId) {
            if (item.sideId === selectedItem.sideId && item.sizeId === selectedItem.sizeId) return true;
        }
        if (item.id) {
            if (item.tempId === selectedItem.tempId) return true;
        }
        return false;
    }

    const handleSelectedItem = (i) => {
        if (selectedItemMatches(i)) {
            return (
                <div key={`orderItem-${i.id}-${i.name}-${i.sizeId}`}>
                    <Row className='orderItem selectedItem' onClick={(e) => handleClick(e, i)}>
                        <Col className='orderItemCol' sm md lg xl="1">{i.quantity}</Col>
                        <Col className='orderItemCol' sm md lg xl="2">{parseSizeShortHand(i.sizeId)}</Col>
                        <Col className='orderItemCol' >{capitalizeEveryFirstLetter(i.name)}</Col>
                        <Col className='orderSummaryMoneyCol orderItemCol' sm md lg xl="3">{currency(calculatePrice(i)).format()}</Col>
                    </Row>
                    {
                        i.items
                            ? i.items.map(item => {
                                return (
                                    <Row key={`comboItem-${item.name}-${i.id}`} className='comboSubItem' onClick={(e) => handleClick(e, i)}>
                                        <Col className='comboSubItemCol' sm md lg xl="1"></Col>
                                        <Col className='comboSubItemCol' sm md lg xl="2">{parseSizeShortHand(item.sizeId)}</Col>
                                        <Col className='comboSubItemCol' >{capitalizeEveryFirstLetter(item.name)}</Col>
                                        <Col className='orderSummaryMoneyCol comboSubItemCol' sm md lg xl="3"></Col>
                                    </Row>
                                )
                            })
                            : ""
                    }
                    {
                        i.isModified
                            ? i.modifications.map(mod => {
                                return (
                                    <Row key={`modification-${mod.topping.id}-${i.id}`}>
                                        <Col className='comboSubItemCol' sm md lg xl="1">-</Col>
                                        <Col className='comboSubItemCol' sm md lg xl="2">{capitalizeEveryFirstLetter(mod.modification)}</Col>
                                        <Col className='comboSubItemCol' >{capitalizeEveryFirstLetter(mod.topping.name)}</Col>
                                        <Col className='orderSummaryMoneyCol comboSubItemCol' sm md lg xl="3"></Col>
                                    </Row>
                                )
                            })
                            : ""
                    }
                </div>
            )
        } else {
            return (
                <div key={`orderItem-${i.id}-${i.name}-${i.sizeId}`}>
                    <Row className='orderItem' onClick={(e) => handleClick(e, i)}>
                        <Col sm md lg xl="1">{i.quantity}</Col>
                        <Col sm md lg xl="2">{parseSizeShortHand(i.sizeId)}</Col>
                        <Col>{capitalizeEveryFirstLetter(i.name)}</Col>
                        <Col className='orderSummaryMoneyCol' sm md lg xl="3">{currency(calculatePrice(i)).format()}</Col>
                    </Row>
                    {
                        i.items
                            ? i.items.map(item => {
                                return (
                                    <Row key={`comboItem-${item.name}-${i.id}`} className='comboSubItem' onClick={(e) => handleClick(e, i)}>
                                        <Col className='comboSubItemCol' sm md lg xl="1"></Col>
                                        <Col className='comboSubItemCol' sm md lg xl="2">{parseSizeShortHand(item.sizeId)}</Col>
                                        <Col className='comboSubItemCol' >{capitalizeEveryFirstLetter(item.name)}</Col>
                                        <Col className='orderSummaryMoneyCol comboSubItemCol' sm md lg xl="3"></Col>
                                    </Row>
                                )
                            })
                            : ""
                    }
                    {
                        i.isModified
                            ? i.modifications.map(mod => {
                                return (
                                    <Row key={`modification-${mod.topping.id}-${i.id}`}>
                                        <Col className='comboSubItemCol' sm md lg xl="1">-</Col>
                                        <Col className='comboSubItemCol' sm md lg xl="2">{capitalizeEveryFirstLetter(mod.modification)}</Col>
                                        <Col className='comboSubItemCol' >{capitalizeEveryFirstLetter(mod.topping.name)}</Col>
                                        <Col className='orderSummaryMoneyCol comboSubItemCol' sm md lg xl="3"></Col>
                                    </Row>
                                )
                            })
                            : ""
                    }
                </div>
            )
        }
    }

    const renderOrderSummaryItems = () => {
        return (
            <Col>
                {
                    orderSummary.map(i => {
                        return handleSelectedItem(i)
                    })
                }
                {
                    <Row className='orderItem'>
                        <Col sm md lg xl="1">{itemBuilder.quantity}</Col>
                        <Col sm md lg xl="2">{parseSizeShortHand(itemBuilder.sizeId)}</Col>
                        <Col></Col>
                        <Col className='orderSummaryMoneyCol' sm md lg xl="3"></Col>
                    </Row>
                }
            </Col>
        )
    }

    return (
        <Container id="orderSummaryContainer">
            <Row>
                <h4>Order Summary</h4>
                {renderOrderSummaryItems()}
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