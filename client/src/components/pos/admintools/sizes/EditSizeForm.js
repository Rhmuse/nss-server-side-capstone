import { useEffect, useState } from 'react';
import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';
import { updateSize } from '../../../../managers/sizesManager';
import CategorySelect from '../../CategorySelect';

const EditSizeForm = ({ menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();
    const { id } = useParams();

    const [size, setSize] = useState(
        {
            id: id,
            name: "",
            price: "0",
            shortHand: "",
        }
    );

    useEffect(() => {
        const foundSize = menuItems.sizes.find(s => s.id === id);
        setSize({
            id: id,
            name: foundSize.name,
            price: foundSize.price,
            shortHand: foundSize.shortHand
        })
    }, [])

    const handleClick = () => {
        updateSize(size).then(() => {
            navigate("/admintools")
        })
    }

    return (
        <Container>
            <Row>
                <Col>
                    <h1>Edit Size</h1>
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
                    <Form.Group className="mb-3" controlId="sizeForm.name" >
                        <Form.Label>Name:</Form.Label>
                        <Form.Control value={size.name} placeholder='Name of Size...' type='text' onChange={(e) => {
                            const copy = { ...size };
                            copy.name = e.target.value;
                            setSize(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="sizeForm.shortHand" >
                        <Form.Label>Shorthand Name:</Form.Label>
                        <Form.Control value={size.shortHand} placeholder='Shorthand Name of Size...' type='text' onChange={(e) => {
                            const copy = { ...size };
                            copy.shortHand = e.target.value;
                            setSize(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="sizeForm.price" >
                        <Form.Label>Price:</Form.Label>
                        <Form.Control value={size.price} placeholder='0' type='number' min={0} onChange={(e) => {
                            const copy = { ...size };
                            copy.price = e.target.value;
                            setSize(copy);
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

export default EditSizeForm;