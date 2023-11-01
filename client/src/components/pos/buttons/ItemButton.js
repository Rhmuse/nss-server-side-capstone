import { Button, Col, Modal, Row } from 'react-bootstrap';
import ComboItemButton from './ComboItemButton';
import { capitalizeEveryFirstLetter } from '../../../utility';

import "./posButton.css";
import { useState } from 'react';

const MEDIUM_SIZE = "3baba7e3-f4ca-42bf-9092-929e013bd15f";

const generator = function* () {
    let i = 1;
    while (true) {
        yield i;
        i++
    }
}

const tempIdGenerator = generator();

const ItemButton = ({ item, type, order, setOrder, itemBuilder, setSelectedItem, menuItems }) => {
    const [show, setShow] = useState(false);
    const [comboItems, setComboItems] = useState({
        side: {},
        drink: {},
        burger: {},
    });

    const handleClose = () => setShow(false);
    const handleShow = () => {
        setShow(true);
        const copy = { ...comboItems };
        copy.burger = item.burger;
        setComboItems(copy)
    }

    const handleAddDrink = () => {
        let copy = { ...order };
        if (!itemBuilder.sizeId) itemBuilder.sizeId = MEDIUM_SIZE;
        const index = copy.drinks.findIndex(d => d.drinkId === item.id && d.sizeId === itemBuilder.sizeId)
        if (index >= 0) {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            copy.drinks[index].quantity = parseInt(copy.drinks[index].quantity) + parseInt(itemBuilder.quantity);
        } else {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            let newDrink = { drinkId: item.id, quantity: itemBuilder.quantity, name: item.name, price: item.price, sizeId: itemBuilder.sizeId };
            copy.drinks.push(newDrink);
        }
        setSelectedItem({});
        setOrder(copy);
    }

    const handleAddSide = () => {
        let copy = { ...order };
        if (!itemBuilder.sizeId) itemBuilder.sizeId = MEDIUM_SIZE;
        const index = copy.sides.findIndex(s => s.sideId === item.id && s.sizeId === itemBuilder.sizeId)
        if (index >= 0) {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            copy.sides[index].quantity = parseInt(copy.sides[index].quantity) + parseInt(itemBuilder.quantity);
        } else {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            let newSide = { sideId: item.id, quantity: itemBuilder.quantity, name: item.name, price: item.price, sizeId: itemBuilder.sizeId }
            copy.sides.push(newSide);
        }
        setSelectedItem({});
        setOrder(copy);
    }

    const handleAddBurger = () => {
        let copy = { ...order };
        const index = copy.burgers.findIndex(b => item.id === b.id && b.isModified === false)
        if (index >= 0) {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            copy.burgers[index].quantity = parseInt(copy.burgers[index].quantity) + parseInt(itemBuilder.quantity);
        } else {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            const foundBurger = menuItems.burgers.find(b => b.id === item.id);
            let newBurger = { id: item.id, quantity: itemBuilder.quantity, name: item.name, price: item.price, tempId: item.id + tempIdGenerator.next().value, isModified: false, burgerToppings: [...foundBurger.burgerToppings] }
            copy.burgers.push(newBurger);
        }
        setOrder(copy);
    }

    const handleAddCombo = () => {
        let copy = { ...order };
        let newCombo = { quantity: 1, id: item.id, name: item.name, items: [], price: 0, tempId: `${item.id}-${tempIdGenerator.next().value}` }
        newCombo.items.push(comboItems.side);
        newCombo.items.push(comboItems.drink);
        newCombo.items.push(comboItems.burger);
        newCombo.price += comboItems.side.price;
        newCombo.price += comboItems.drink.price;
        newCombo.price += comboItems.burger.price;
        newCombo.price += item.discount;
        copy.combos.push(newCombo);
        setOrder(copy);
    }

    const handleAddItem = (type) => {
        switch (type) {
            case "drink":
                handleAddDrink();
                break;
            case "side":
                handleAddSide();
                break;
            case "burger":
                handleAddBurger();
                break;
            case "combo":
                handleShow();
                break;
            default:
                break;
        }
    }

    return (
        <>
            <Button className="posButton" onClick={() => { handleAddItem(type) }}>{capitalizeEveryFirstLetter(item.name)}</Button>
            <Modal show={show} onHide={handleClose}>
                <Modal.Header closeButton>
                    <Modal.Title>{capitalizeEveryFirstLetter(item.name)}</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <Row>
                        <Col id="drinksCol">
                            <h3>Select a Drink:</h3>
                            {
                                menuItems.drinks.map(d => {
                                    return (
                                        <ComboItemButton key={d.id} item={d} order={order} setOrder={setOrder} comboItems={comboItems} setComboItems={setComboItems} type="drink" />
                                    )
                                })
                            }
                        </Col>
                        <Col id='sidesCol'>
                            <h3>Select a Side:</h3>
                            {
                                menuItems.sides.map(s => {
                                    return (
                                        <ComboItemButton key={s.id} item={s} order={order} setOrder={setOrder} comboItems={comboItems} setComboItems={setComboItems} type="side" />
                                    )
                                })
                            }
                        </Col>
                    </Row>
                </Modal.Body>
                <Modal.Footer>
                    <Button variant="primary" onClick={() => {
                        handleClose();
                        handleAddCombo();
                    }}>
                        Done
                    </Button>
                </Modal.Footer>
            </Modal>
        </>
    )
}

export default ItemButton;