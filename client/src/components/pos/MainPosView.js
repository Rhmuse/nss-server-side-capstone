import { Button, Col, Row } from 'react-bootstrap';
import Utility from '../../utility';
import ItemButton from './buttons/ItemButton';
import NumberButton from './buttons/NumberButton';
import SizeButton from './buttons/SizeButton';

import "./MainPosView.css";

const numberArr = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]

const utility = new Utility();

const MainPosView = ({ order, setOrder, menuItems, itemBuilder, setItemBuilder, setSelectedItem, selectedItem, setOrderSummary, orderSummary }) => {
    const handleDelete = () => {
        const orderCopy = { ...order };
        let orderSummaryCopy = [...orderSummary];
        let foundItemIndex;
        if (selectedItem.drinkId) {
            foundItemIndex = orderCopy.drinks.findIndex(d => d.drinkId === selectedItem.drinkId && d.sizeId === selectedItem.sizeId);
            orderCopy.drinks = orderCopy.drinks.slice(0, foundItemIndex).concat(orderCopy.drinks.slice(foundItemIndex + 1))

            const orderSummaryIndex = orderSummaryCopy.findIndex(d => d.drinkId === selectedItem.drinkId && d.sizeId === selectedItem.sizeId);
            orderSummaryCopy = orderSummaryCopy.slice(0, orderSummaryIndex).concat(orderCopy.drinks.slice(orderSummaryIndex + 1))
        }
        if (selectedItem.sideId) {
            foundItemIndex = orderCopy.sides.findIndex(s => s.sideId === selectedItem.sideId && s.sizeId === selectedItem.sizeId);
            orderCopy.sides = orderCopy.sides.slice(0, foundItemIndex).concat(orderCopy.sides.slice(foundItemIndex + 1))

            const orderSummaryIndex = orderSummaryCopy.findIndex(s => s.sideId === selectedItem.sideId && s.sizeId === selectedItem.sizeId);
            orderSummaryCopy = orderSummaryCopy.slice(0, orderSummaryIndex).concat(orderCopy.sides.slice(orderSummaryIndex + 1))
        }
        if (selectedItem.id) {
            foundItemIndex = orderCopy.burgers.findIndex(b => b.tempId === selectedItem.tempId);
            orderCopy.burgers = orderCopy.burgers.slice(0, foundItemIndex).concat(orderCopy.burgers.slice(foundItemIndex + 1))

            const orderSummaryIndex = orderSummaryCopy.findIndex(b => b.tempId === selectedItem.tempId);
            orderSummaryCopy = orderSummaryCopy.slice(0, orderSummaryIndex).concat(orderCopy.burgers.slice(orderSummaryIndex + 1))
        }
        setOrderSummary(orderSummaryCopy);
        setOrder(orderCopy);
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
                                    <ItemButton key={`burger-${b.id}`} setSelectedItem={setSelectedItem} order={order} item={b} setOrder={setOrder} type="burger" itemBuilder={itemBuilder} />
                                )
                            })
                        }
                        {
                            menuItems.combos.map(c => {
                                return (
                                    <Button key={`combos-${c.id}`} >{utility.capitalizeEveryFirstLetter(c.name)}</Button>
                                )
                            })
                        }
                    </Row>
                    <Row id="drinksRow">
                        {
                            menuItems.drinks.map(d => {
                                return (
                                    <ItemButton setSelectedItem={setSelectedItem} key={d.id} item={d} order={order} setOrder={setOrder} type="drink" setItemBuilder={setItemBuilder} itemBuilder={itemBuilder} />
                                )
                            })
                        }
                    </Row>
                    <Row id='sidesRow'>
                        {
                            menuItems.sides.map(s => {
                                return (
                                    <ItemButton setSelectedItem={setSelectedItem} key={s.id} item={s} order={order} setOrder={setOrder} type="side" setItemBuilder={setItemBuilder} itemBuilder={itemBuilder} />
                                )
                            })
                        }
                    </Row>
                </Col>
                <Col md lg="2" id="utilityCol">
                    <Row><Button>Here/ToGo</Button></Row>
                    <Row><Button>Cancel Order</Button></Row>
                    <Row><Button>Admin Tools</Button></Row>
                </Col>
            </Row>
            <Row id="bottomRow">
                <Col md lg="2" id='modDeleteCol'>
                    <Row><Button>Burger Modify</Button></Row>
                    <Row><Button onClick={() => { handleDelete() }}>Delete</Button></Row>
                </Col>
                <Col></Col>
                <Col id='completeCol' md lg="2"><Button>Complete Order</Button></Col>
            </Row>
        </ div>
    )
}

export default MainPosView;