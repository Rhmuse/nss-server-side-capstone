import { Button, Col, Row } from 'react-bootstrap';
import { getAllDrinks } from "../../managers/drinksManager";

import "./MainPosView.css";
import { useEffect, useState } from 'react';
import Utility from '../../utility';
import { getAllSides } from '../../managers/sidesManager';
import { getAllCombos } from '../../managers/combosManager';
import ItemButton from './buttons/ItemButton';

const utility = new Utility();

const MainPosView = ({ order, setOrder, menuItems }) => {

    return (
        <div id="mainPosViewContainer">
            <Row id='numbersRow'>
                <Col><Button>0</Button></Col>
                <Col><Button>1</Button></Col>
                <Col><Button>2</Button></Col>
                <Col><Button>3</Button></Col>
                <Col><Button>4</Button></Col>
                <Col><Button>5</Button></Col>
                <Col><Button>6</Button></Col>
                <Col><Button>7</Button></Col>
                <Col><Button>8</Button></Col>
                <Col><Button>9</Button></Col>
            </Row>
            <Row id="centerRow">
                <Col id="sizeCol" md lg="1">
                    <Row><Button>S</Button></Row>
                    <Row><Button>M</Button></Row>
                    <Row><Button>L</Button></Row>
                </Col>
                <Col id="itemCol">
                    <Row id="combosAndBurgersRow">
                        <Button>Krabby Patty</Button>
                        <Button>Double Krabby Patty</Button>
                        {
                            menuItems.combos.map(c => {
                                return (
                                    <Button key={`combos-${c.id}`}>{utility.capitalizeEveryFirstLetter(c.name)}</Button>
                                )
                            })
                        }
                    </Row>
                    <Row id="drinksRow">
                        {
                            menuItems.drinks.map(d => {
                                return (
                                    <ItemButton key={d.id} item={d} order={order} setOrder={setOrder} type="drink" />
                                )
                            })
                        }
                    </Row>
                    <Row id='sidesRow'>
                        {
                            menuItems.sides.map(s => {
                                return (
                                    <ItemButton key={s.id} item={s} order={order} setOrder={setOrder} type="side" />
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