import { useEffect, useState } from 'react';
import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';
import CategorySelect from '../../CategorySelect';
import { updateTopping } from '../../../../managers/toppingsManager';

const EditToppingForm = ({ menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();
    const { id } = useParams();
    const [topping, setTopping] = useState(
        {
            name: "",
            price: "0",
        }
    );

    useEffect(() => {
        const foundTopping = menuItems.toppings.find(d => d.id === id);
        setTopping(foundTopping);
    }, [])

    const handleClick = () => {
        updateTopping(topping).then(() => {
            navigate("/admintools")
        })
    }

    return (
        <Container>
            <Row>
                <Col>
                    <h1>Edit Topping</h1>
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
                    <Form.Group className="mb-3" controlId="editToppingForm.name" >
                        <Form.Label>Name:</Form.Label>
                        <Form.Control value={topping.name} placeholder='Name of Topping...' type='text' onChange={(e) => {
                            const copy = { ...topping };
                            copy.name = e.target.value;
                            setTopping(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="editToppingForm.price" >
                        <Form.Label>Price:</Form.Label>
                        <Form.Control value={topping.price} placeholder='0' type='number' min={0} onChange={(e) => {
                            const copy = { ...topping };
                            copy.price = e.target.value;
                            setTopping(copy);
                        }} />
                    </Form.Group>
                </Form>
            </Row>
            <Row>
                <Col>
                    <Button onClick={() => handleClick()}>Save Changes</Button>
                </Col>
            </Row>
        </Container>
    )
}

export default EditToppingForm; 