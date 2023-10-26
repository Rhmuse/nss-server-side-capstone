import { Button, Col, Container, Row, Table } from 'react-bootstrap';
import { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { deleteDrink } from '../../managers/drinksManager';
import { deleteSide } from '../../managers/sidesManager';
import { deleteBurger } from '../../managers/burgersManger';
import { deleteCombo } from '../../managers/combosManager';
import { deleteTopping } from '../../managers/toppingsManager';
import Utility from '../../utility';
import currency from 'currency.js';
import CategorySelect from './CategorySelect';

import './AdminTools.css';

const utility = new Utility();

const AdminTools = ({ menuItems, loadMenuItems, selectedCategory, setSelectedCategory }) => {
    const navigate = useNavigate();
    const [itemList, setItemList] = useState([]);

    useEffect(() => {
        setItemList(menuItems[selectedCategory]);
    }, [selectedCategory, menuItems])

    useEffect(() => {
        loadMenuItems()
    }, [])



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

    const handleEdit = (id) => {
        navigate(`${selectedCategory}/edit/${id}`);
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
                                            <td><Button onClick={() => {
                                                handleEdit(i.id)
                                            }}>Edit</Button></td>
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