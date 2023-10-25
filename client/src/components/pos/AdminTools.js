import { Button, Col, Container, Form, Row, Table } from 'react-bootstrap';
import Utility from '../../utility';
import { useEffect, useState } from 'react';
import currency from 'currency.js';

import './AdminTools.css';
import { useNavigate } from 'react-router-dom';
import { deleteDrink } from '../../managers/drinksManager';

const utility = new Utility();
const AdminTools = ({ menuItems, loadMenuItems }) => {
    const navigate = useNavigate();
    const [selectedCategory, setSelectedCategory] = useState("drinks");
    const [itemList, setItemList] = useState([]);

    useEffect(() => {
        setItemList(menuItems[selectedCategory]);
    }, [selectedCategory, menuItems])

    useEffect(() => {
        loadMenuItems()
    }, [])

    const renderCategorySelect = () => {
        let categoryArr = [];
        for (const category in menuItems) {
            categoryArr.push(category);
        }
        return (
            <Form.Select size="lg" onChange={(e) => { setSelectedCategory(e.target.value) }}>
                {
                    categoryArr.map(c => {
                        return (
                            <option key={`${c}-option`} value={c}>{utility.capitalizeEveryFirstLetter(c)}</option>
                        )
                    })
                }
            </Form.Select>
        )
    }

    const handleDelete = (id) => {
        switch (selectedCategory) {
            case "drinks":
                deleteDrink(id);
                break;
            case "sides":
                break;
            case "burgers":
                break;
            case "combos":
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
                <Col>{renderCategorySelect()}</Col>
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