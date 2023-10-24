import { Button, Col, Container, Row, Table, Form } from 'react-bootstrap';
import LoggedInUserDetails from './LoggedInUserDetails';
import { logout } from '../../managers/authManager';
import Utility from '../../utility';
import { useEffect, useState } from 'react';
import currency from 'currency.js';

import './AdminTools.css';

const utility = new Utility();
const AdminTools = ({ loggedInUser, setLoggedInUser, menuItems }) => {
    const [selectedCategory, setSelectedCategory] = useState("drinks");
    const [itemList, setItemList] = useState([]);


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

    useEffect(() => {
        setItemList(menuItems[selectedCategory]);
    }, [selectedCategory, menuItems])

    return (
        <Container>
            <Row id='userDetailsRow'>
                <Button
                    color="primary"
                    onClick={(e) => {
                        e.preventDefault();
                        logout().then(() => {
                            setLoggedInUser(null);
                        });
                    }}
                >Logout</Button>
                <LoggedInUserDetails loggedInUser={loggedInUser} />
            </Row>
            <Row id='adminToolsCategoryRow'>
                <Col>{renderCategorySelect()}</Col>
                <Col></Col>
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
                                            <td><Button>Delete</Button></td>
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