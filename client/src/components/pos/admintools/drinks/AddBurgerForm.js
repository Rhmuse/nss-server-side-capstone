import { useState } from 'react';
import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';
import { addBurger } from '../../../../managers/burgersManger';
import Utility from '../../../../utility';

const utility = new Utility();
const AddBurgerForm = ({ loadMenuItems, menuItems }) => {
    const navigate = useNavigate();

    const [newBurger, setNewBurger] = useState(
        {
            name: "",
            toppings: [],
        }
    );

    const handleClick = () => {
        addBurger(newBurger).then(() => {
            loadMenuItems()
            navigate("/admintools")
        })
    }
    return (
        <Container>
            <Row>
                <Col>
                    <h1>New Burger</h1>
                </Col>
                <Col></Col>
                <Col>
                    <Button onClick={() => { navigate("/") }}>Return to POS</Button>
                </Col>
            </Row>
            <Row>
                <Form>
                    <Form.Group className='mb-3' controlId='newBurgerForm.name'>
                        <Form.Label>Name:</Form.Label>
                        <Form.Control placeholder='Name of Drink...' type='text' onChange={(e) => {
                            const copy = { ...newBurger };
                            copy.name = e.target.value;
                            setNewBurger(copy);
                        }}
                        />
                    </Form.Group>
                    <Form.Group className='mb-3' controlId='newBurgerForm.toppings'>
                        {
                            menuItems.toppings.map(t => {
                                return (
                                    <Form.Check value={t.id} type="checkbox" key={`topping-${t.id}`} label={utility.capitalizeEveryFirstLetter(t.name)} />
                                )
                            })
                        }
                    </Form.Group>
                </Form>
            </Row>
            <Row>
                <Col>
                    <Button onClick={() => handleClick()}>Save Burger</Button>
                </Col>
            </Row>
        </Container>
    )
}

export default AddBurgerForm;