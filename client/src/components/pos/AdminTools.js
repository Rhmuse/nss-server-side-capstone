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
import { deleteSize } from '../../managers/sizesManager';

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
                deleteDrink(id).then(() => {
                    loadMenuItems();
                });
                break;
            case "sides":
                deleteSide(id).then(() => {
                    loadMenuItems();
                });
                break;
            case "burgers":
                deleteBurger(id).then(() => {
                    loadMenuItems();
                });
                break;
            case "combos":
                deleteCombo(id).then(() => {
                    loadMenuItems();
                });
                break;
            case "toppings":
                deleteTopping(id).then(() => {
                    loadMenuItems();
                });
                break;
            case "sizes":
                deleteSize(id).then(() => {
                    loadMenuItems();
                })
                break;
            default:
                window.alert("Something went wrong!")
                break;
        }


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
                                <th>{selectedCategory === "combos" ? "Discount" : "Price"}</th>
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
                                            <td>{selectedCategory === "combos" ? `${currency(parseInt(i.discount) * -1).format()}` : currency(i.price).format()}</td>
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