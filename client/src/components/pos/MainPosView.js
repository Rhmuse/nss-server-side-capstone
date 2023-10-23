import { Button, Col, Row } from 'react-bootstrap';
import Utility from '../../utility';
import ItemButton from './buttons/ItemButton';
import NumberButton from './buttons/NumberButton';

import "./MainPosView.css";
import SizeButton from './buttons/SizeButton';
import { useState } from 'react';

const numberArr = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]

const utility = new Utility();

const MainPosView = ({ order, setOrder, menuItems }) => {
    const [itemBuilder, setItemBuilder] = useState({
        quantity: "",
        sizeId: "",
    });

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
                        <Button>Krabby Patty</Button>
                        <Button>Double Krabby Patty</Button>
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
                                    <ItemButton key={d.id} item={d} order={order} setOrder={setOrder} type="drink" setItemBuilder={setItemBuilder} itemBuilder={itemBuilder} />
                                )
                            })
                        }
                    </Row>
                    <Row id='sidesRow'>
                        {
                            menuItems.sides.map(s => {
                                return (
                                    <ItemButton key={s.id} item={s} order={order} setOrder={setOrder} type="side" setItemBuilder={setItemBuilder} itemBuilder={itemBuilder} />
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
                    <Row><Button>Delete</Button></Row>
                </Col>
                <Col></Col>
                <Col id='completeCol' md lg="2"><Button>Complete Order</Button></Col>
            </Row>
        </ div>
    )
}

export default MainPosView;