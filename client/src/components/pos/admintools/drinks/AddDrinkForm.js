import { useState } from 'react';
import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';
import { addDrink } from '../../../../managers/drinksManager';
import CategorySelect from '../../CategorySelect';

const AddDrinkForm = ({ loadMenuItems, menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();
    const [newDrink, setNewDrink] = useState(
        {
            name: "",
            price: "0",
        }
    );

    const handleClick = () => {
        addDrink(newDrink).then(() => {
            loadMenuItems()
            navigate("/admintools")
        })
    }

    return (
        <Container>
            <Row>
                <Col>
                    <h1>New Drink</h1>
                </Col>
                <Col>
                    <CategorySelect menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                </Col>
                <Col>
                    <Col>
                        <Button onClick={() => { navigate("/") }}>Return to POS</Button>
                        <Button onClick={() => { navigate("/admintools") }} >Back to List</Button>
                    </Col>
                </Col>
            </Row>
            <Row>
                <Form>
                    <Form.Group className="mb-3" controlId="newDrinkForm.name" >
                        <Form.Label>Name:</Form.Label>
                        <Form.Control placeholder='Name of Drink...' type='text' onChange={(e) => {
                            const copy = { ...newDrink };
                            copy.name = e.target.value;
                            setNewDrink(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="newDrinkForm.price" >
                        <Form.Label>Price:</Form.Label>
                        <Form.Control placeholder='0' type='number' min={0} onChange={(e) => {
                            const copy = { ...newDrink };
                            copy.price = e.target.value;
                            setNewDrink(copy);
                        }} />
                    </Form.Group>
                </Form>
            </Row>
            <Row>
                <Col>
                    <Button onClick={() => handleClick()}>Save Drink</Button>
                </Col>
            </Row>
        </Container>
    )
}

export default AddDrinkForm;