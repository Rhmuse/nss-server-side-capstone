import { Button, Col, Modal, Row } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';
import { useState } from 'react';
import { capitalizeEveryFirstLetter } from '../../utility';
import { postOrder } from '../../managers/orderManager';
import ItemButton from './buttons/ItemButton';
import NumberButton from './buttons/NumberButton';
import SizeButton from './buttons/SizeButton';
import BurgerModButton from './buttons/BurgerModButton';

import "./MainPosView.css";

const numberArr = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]

const MainPosView = ({ order, setOrder, menuItems, itemBuilder, setItemBuilder, setSelectedItem, selectedItem, setOrderSummary, orderSummary, loggedInUser, loadOrders }) => {
    const navigate = useNavigate();

    const [show, setShow] = useState(false);

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    const handleDelete = () => {
        const orderCopy = { ...order };
        let orderSummaryCopy = [...orderSummary];
        if (selectedItem.drinkId) {
            const foundItemIndex = orderCopy.drinks.findIndex(d => d.drinkId === selectedItem.drinkId && d.sizeId === selectedItem.sizeId);
            orderCopy.drinks = orderCopy.drinks.slice(0, foundItemIndex).concat(orderCopy.drinks.slice(foundItemIndex + 1))

            const orderSummaryIndex = orderSummaryCopy.findIndex(d => d.drinkId === selectedItem.drinkId && d.sizeId === selectedItem.sizeId);
            orderSummaryCopy = orderSummaryCopy.slice(0, orderSummaryIndex).concat(orderCopy.drinks.slice(orderSummaryIndex + 1))
        }
        if (selectedItem.sideId) {
            const foundItemIndex = orderCopy.sides.findIndex(s => s.sideId === selectedItem.sideId && s.sizeId === selectedItem.sizeId);
            orderCopy.sides = orderCopy.sides.slice(0, foundItemIndex).concat(orderCopy.sides.slice(foundItemIndex + 1))

            const orderSummaryIndex = orderSummaryCopy.findIndex(s => s.sideId === selectedItem.sideId && s.sizeId === selectedItem.sizeId);
            orderSummaryCopy = orderSummaryCopy.slice(0, orderSummaryIndex).concat(orderCopy.sides.slice(orderSummaryIndex + 1))
        }
        if (selectedItem.tempId) {
            const foundBurgerIndex = orderCopy.burgers.findIndex(b => b.tempId === selectedItem.tempId);
            if (foundBurgerIndex > -1) {
                orderCopy.burgers = orderCopy.burgers.slice(0, foundBurgerIndex).concat(orderCopy.burgers.slice(foundBurgerIndex + 1))
                const orderSummaryIndex = orderSummaryCopy.findIndex(b => b.tempId === selectedItem.tempId);
                orderSummaryCopy = orderSummaryCopy.slice(0, orderSummaryIndex).concat(orderCopy.burgers.slice(orderSummaryIndex + 1))
            } else {
                const foundComboIndex = orderCopy.combos.findIndex(b => b.tempId === selectedItem.tempId);
                orderCopy.combos = orderCopy.combos.slice(0, foundComboIndex).concat(orderCopy.combos.slice(foundComboIndex + 1))
                const orderSummaryIndex = orderSummaryCopy.findIndex(b => b.tempId === selectedItem.tempId);
                orderSummaryCopy = orderSummaryCopy.slice(0, orderSummaryIndex).concat(orderCopy.combos.slice(orderSummaryIndex + 1))
            }
        }
        setSelectedItem({});
        setOrderSummary(orderSummaryCopy);
        setOrder(orderCopy);
    }

    const handleCancel = () => {
        const hereOrderType = menuItems.orderTypes.find(ot => ot.name === "here");
        setOrder({
            order: {
                orderTypeId: hereOrderType.id,
                employeeId: loggedInUser.id
            },
            drinks: [],
            burgers: [],
            sides: [],
            combos: [],
        });
        setOrderSummary([]);
    }

    const handleModify = () => {
        if (selectedItem.tempId) {
            if (selectedItem.burger) {
                handleShow();
                return;
            }
            handleShow();
        }
    }

    const handleCompleteOrder = () => {
        const mediumOrderType = menuItems.orderTypes.find(ot => ot.name === "here");
        const orderCopy = { ...order };
        if (order.order.orderTypeId === "") {
            orderCopy.order.orderTypeId = mediumOrderType.id;
        }
        postOrder(orderCopy).then(() => {
            loadOrders();
            setOrder({
                order: {
                    orderTypeId: "f859731c-a421-493e-bc41-e7f16fbcc530",
                    employeeId: loggedInUser.id,
                },
                drinks: [],
                burgers: [],
                sides: [],
                combos: [],
            });
            setOrderSummary([]);
        });
    }

    return (
        <div id="mainPosViewContainer">
            <Row id='numbersRow'>
                {
                    numberArr.map(n => {
                        return (
                            <Col key={`numberButton-${n}`}><NumberButton value={n} setItemBuilder={setItemBuilder} itemBuilder={itemBuilder} /></Col>
                        )
                    })
                }
            </Row>
            <Row id="centerRow">
                <Col id="sizeCol" md lg="1">
                    {
                        menuItems.sizes.map(s => {
                            return (
                                <Row key={`size-${s.id}`}><SizeButton size={s} setItemBuilder={setItemBuilder} itemBuilder={itemBuilder} /></Row>
                            )
                        })
                    }
                </Col>
                <Col id="itemCol">
                    <Row id="combosAndBurgersRow">
                        {
                            menuItems.burgers.map(b => {
                                return (
                                    <ItemButton key={`burger-${b.id}`} setSelectedItem={setSelectedItem} order={order} item={b} setOrder={setOrder} type="burger" itemBuilder={itemBuilder} menuItems={menuItems} />
                                )
                            })
                        }
                        {
                            menuItems.combos.map(c => {
                                return (
                                    <ItemButton key={`combos-${c.id}`} setSelectedItem={setSelectedItem} order={order} item={c} setOrder={setOrder} type="combo" itemBuilder={itemBuilder} menuItems={menuItems} />)
                            })
                        }
                    </Row>
                    <Row id="drinksRow">
                        {
                            menuItems.drinks.map(d => {
                                return (
                                    <ItemButton setSelectedItem={setSelectedItem} key={d.id} item={d} order={order} setOrder={setOrder} type="drink" setItemBuilder={setItemBuilder} itemBuilder={itemBuilder} menuItems={menuItems} />
                                )
                            })
                        }
                    </Row>
                    <Row id='sidesRow'>
                        {
                            menuItems.sides.map(s => {
                                return (
                                    <ItemButton setSelectedItem={setSelectedItem} key={s.id} item={s} order={order} setOrder={setOrder} type="side" setItemBuilder={setItemBuilder} itemBuilder={itemBuilder} menuItems={menuItems} />
                                )
                            })
                        }
                    </Row>
                </Col>
                <Col md lg="2" id="utilityCol">
                    <Row><Button className='posButton'>Here/ToGo</Button></Row>
                    <Row><Button className='posButton' onClick={() => handleCancel()}>Cancel Order</Button></Row>
                    {loggedInUser.roles.includes("Admin") && <Row><Button className='posButton' onClick={() => navigate('admintools')}>Admin Tools</Button></Row>}
                </Col>
            </Row>
            <Row id="bottomRow">
                <Col md lg="2" id='modDeleteCol'>
                    <Row><Button className='posButton' onClick={() => { handleModify() }}>Modify</Button></Row>
                    <Row><Button className='posButton' onClick={() => { handleDelete() }}>Delete</Button></Row>
                </Col>
                <Col></Col>
                <Col id='completeCol' md lg="2"><Button onClick={() => handleCompleteOrder()} className='posButton'>Complete Order</Button></Col>
            </Row>
            <Modal show={show} onHide={handleClose} size='xl' id="modifyModal">
                <Modal.Header closeButton>
                    <Modal.Title>Modify {capitalizeEveryFirstLetter(selectedItem.burger ? selectedItem.burger.name : selectedItem.name)} </Modal.Title>
                </Modal.Header>
                <Modal.Body id='burgerModToppingsContainer'>
                    <Row>
                        <Col className='burgerModToppingCol'>
                            {
                                selectedItem?.burgerToppings?.map(t => {
                                    return (
                                        <BurgerModButton key={`topping-button-${t.toppingId}-no`} topping={t.topping} order={order} setOrder={setOrder} selected={false} type="no" selectedItem={selectedItem} menuItems={menuItems} />
                                    )
                                })
                            }
                        </Col>
                        <Col className='burgerModToppingCol'>
                            {
                                menuItems.toppings.map(t => {
                                    return (
                                        <BurgerModButton key={`topping-button-${t.id}-extra`} topping={t} order={order} setOrder={setOrder} selected={false} type="extra" selectedItem={selectedItem} menuItems={menuItems} />
                                    )
                                })
                            }
                        </Col>
                        <Col className='burgerModToppingCol'>
                            {
                                menuItems.toppings.map(t => {
                                    return (
                                        <BurgerModButton key={`topping-button-${t.id}-add`} topping={t} order={order} setOrder={setOrder} selected={false} type="add" selectedItem={selectedItem} menuItems={menuItems} />
                                    )
                                })
                            }
                        </Col>
                    </Row>
                </Modal.Body>
                <Modal.Footer>
                    <Button className='posButton' onClick={handleClose}>
                        Done
                    </Button>
                </Modal.Footer>
            </Modal>
        </ div>
    )
}

export default MainPosView;