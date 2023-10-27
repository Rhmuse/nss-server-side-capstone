import { useState } from 'react';
import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';
import { addSize } from '../../../../managers/sizesManager';
import CategorySelect from '../../CategorySelect';

const AddSizeForm = ({ menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();
    const [newSize, setNewSize] = useState(
        {
            name: "",
            price: "0",
            shortHand: "",
        }
    );

    const handleClick = () => {
        addSize(newSize).then(() => {
            navigate("/admintools")
        })
    }

    return (
        <Container>
            <Row>
                <Col>
                    <h1>New Size</h1>
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
                    <Form.Group className="mb-3" controlId="newSizeForm.name" >
                        <Form.Label>Name:</Form.Label>
                        <Form.Control value={newSize.name} placeholder='Name of Size...' type='text' onChange={(e) => {
                            const copy = { ...newSize };
                            copy.name = e.target.value;
                            setNewSize(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="newSizeForm.shortHand" >
                        <Form.Label>Shorthand Name:</Form.Label>
                        <Form.Control value={newSize.shortHand} placeholder='Shorthand Name of Size...' type='text' onChange={(e) => {
                            const copy = { ...newSize };
                            copy.shortHand = e.target.value;
                            setNewSize(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="newSizeForm.price" >
                        <Form.Label>Price:</Form.Label>
                        <Form.Control value={newSize.price} placeholder='0' type='number' min={0} onChange={(e) => {
                            const copy = { ...newSize };
                            copy.price = e.target.value;
                            setNewSize(copy);
                        }} />
                    </Form.Group>
                </Form>
            </Row>
            <Row>
                <Col>
                    <Button onClick={() => handleClick()}>Save Size</Button>
                </Col>
            </Row>
        </Container>
    )
}

export default AddSizeForm;