import { Button, Col, Container, Form, Row, Table } from 'react-bootstrap';
import Utility from '../../utility';
import { useEffect, useState } from 'react';
import currency from 'currency.js';

import './AdminTools.css';
import { useNavigate } from 'react-router-dom';
import { deleteDrink } from '../../managers/drinksManager';
import { deleteSide } from '../../managers/sidesManager';
import { deleteBurger } from '../../managers/burgersManger';
import { deleteCombo } from '../../managers/combosManager';
import CategorySelect from './CategorySelect';
import { deleteTopping } from '../../managers/toppingsManager';

const utility = new Utility();
const AdminTools = ({ menuItems, loadMenuItems, selectedCategory, setSelectedCategory }) => {
    const navigate = useNavigate();
    const [itemList, setItemList] = useState([]);

    useEffect(() => {
        setItemList(menuItems[selectedCategory]);
    }, [selectedCategory, menuItems])

    useEffect(() => {
        loadMenuItems()
    }, [menuItems, loadMenuItems])

    const handleDelete = (id) => {
        switch (selectedCategory) {
            case "drinks":
                deleteDrink(id);
                break;
            case "sides":
                deleteSide(id);
                break;
            case "burgers":
                deleteBurger(id);
                break;
            case "combos":
                deleteCombo(id);
                break;
            case "toppings":
                deleteTopping(id);
                break;
            default:
                window.alert("Something went wrong!")
                break;
        }

        loadMenuItems();
    }

    return (
        <Container>
            <Row id='adminToolsCategoryRow'>
                <Col>
                    <CategorySelect menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                </Col>
                <Col>
                    <Button onClick={() => {
                        navigate(`${selectedCategory}/add`)
                    }}>New {utility.capitalizeEveryFirstLetter(selectedCategory).slice(0, -1)}</Button>
                </Col>
                <Col>
                    <Button onClick={() => { navigate("/") }}>Return to POS</Button>
                </Col>
            </Row>
            <Row>
                <Container>
                    <Table bordered striped responsive>
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Id</th>
                                <th>Price</th>
                                <th></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                itemList.map(i => {
                                    return (
                                        <tr key={i.id}>
                                            <td>{utility.capitalizeEveryFirstLetter(i.name)}</td>
                                            <td>{i.id}</td>
                                            <td>{currency(i.price).format()}</td>
                                            <td><Button>Edit</Button></td>
                                            <td><Button onClick={() => handleDelete(i.id)}>Delete</Button></td>
                                        </tr>
                                    )
                                })
                            }
                        </tbody>
                    </Table>
                </Container>
            </Row>
        </Container>
    )
}

export default AdminTools;