import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import CategorySelect from '../../CategorySelect';
import { useNavigate } from 'react-router-dom';
import { useState } from 'react';
import { addSide } from '../../../../managers/sidesManager';

const AddSideForm = ({ menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();
    const [newSide, setNewSide] = useState(
        {
            name: "",
            price: "0",
        }
    );

    const handleClick = () => {
        addSide(newSide).then(() => {
            navigate("/admintools")
        })
    }

    return (
        <Container>
            <Row>
                <Col>
                    <h1>New Side</h1>
                </Col>
                <Col>
                    <CategorySelect menuItems={menuItems} setSelectedCategory={setSelectedCategory} />
                </Col>
                <Col>
                    <Button onClick={() => { navigate("/") }}>Return to POS</Button>
                    <Button onClick={() => { navigate("/admintools") }} >Back to List</Button>
                </Col>
            </Row>
            <Row>
                <Form>
                    <Form.Group className='mb-3' controlId='newSideForm.name'>
                        <Form.Label>Name:</Form.Label>
                        <Form.Control placeholder='Name of Side...' type='text' onChange={(e) => {
                            const copy = { ...newSide };
                            copy.name = e.target.value;
                            setNewSide(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="newSideForm.price" >
                        <Form.Label>Price:</Form.Label>
                        <Form.Control placeholder='0' type='number' min={0} onChange={(e) => {
                            const copy = { ...newSide };
                            copy.price = e.target.value;
                            setNewSide(copy);
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

export default AddSideForm;