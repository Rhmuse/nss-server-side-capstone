import { useEffect, useState } from 'react';
import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';
import CategorySelect from '../../CategorySelect';
import { updateSide } from '../../../../managers/sidesManager';

const EditSideForm = ({ menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();
    const { id } = useParams();
    const [side, setSide] = useState(
        {
            name: "",
            price: "0",
        }
    );

    useEffect(() => {
        const foundSide = menuItems.sides.find(d => d.id === id);
        setSide(foundSide);
    }, [])

    const handleClick = () => {
        updateSide(side).then(() => {
            navigate("/admintools")
        })
    }

    return (
        <Container>
            <Row>
                <Col>
                    <h1>Edit Side</h1>
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
                    <Form.Group className="mb-3" controlId="editSideForm.name" >
                        <Form.Label>Name:</Form.Label>
                        <Form.Control value={side.name} placeholder='Name of Side...' type='text' onChange={(e) => {
                            const copy = { ...side };
                            copy.name = e.target.value;
                            setSide(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="editSideForm.price" >
                        <Form.Label>Price:</Form.Label>
                        <Form.Control value={side.price} placeholder='0' type='number' min={0} onChange={(e) => {
                            const copy = { ...side };
                            copy.price = e.target.value;
                            setSide(copy);
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

export default EditSideForm;