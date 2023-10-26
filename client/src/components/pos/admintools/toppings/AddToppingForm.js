import { Button, Col, Container, Row, Form } from 'react-bootstrap';
import CategorySelect from '../../CategorySelect';
import { useNavigate } from 'react-router-dom';
import { useState } from 'react';
import { addTopping } from '../../../../managers/toppingsManager';

const AddToppingForm = ({ menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();
    const [newTopping, setNewTopping] = useState(
        {
            name: "",
            price: "0",
        }
    );

    const handleClick = () => {
        addTopping(newTopping).then(() => {
            navigate("/admintools")
        })
    }

    return (
        <Container>
            <Row>
                <Col>
                    <h1>New Topping</h1>
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
                    <Form.Group className="mb-3" controlId="newToppingForm.name" >
                        <Form.Label>Name:</Form.Label>
                        <Form.Control placeholder='Name of Topping...' type='text' onChange={(e) => {
                            const copy = { ...newTopping };
                            copy.name = e.target.value;
                            setNewTopping(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="newToppingForm.price" >
                        <Form.Label>Price:</Form.Label>
                        <Form.Control placeholder='0' type='number' min={0} onChange={(e) => {
                            const copy = { ...newTopping };
                            copy.price = e.target.value;
                            setNewTopping(copy);
                        }} />
                    </Form.Group>
                </Form>
            </Row>
            <Row>
                <Col>
                    <Button onClick={() => handleClick()}>Save Topping</Button>
                </Col>
            </Row>
        </Container>
    )
}

export default AddToppingForm;