import { useEffect, useState } from 'react';
import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';
import CategorySelect from '../../CategorySelect';
import { updateDrink } from '../../../../managers/drinksManager';

const EditDrinkForm = ({ loadMenuItems, menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();
    const { id } = useParams();
    console.log(id);
    const [drink, setDrink] = useState(
        {
            name: "",
            price: "0",
        }
    );

    useEffect(() => {
        const foundDrink = menuItems.drinks.find(d => d.id === id);
        setDrink(foundDrink);
    }, [])

    const handleClick = () => {
        updateDrink(drink).then(() => {
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
                    <Form.Group className="mb-3" controlId="editDrinkForm.name" >
                        <Form.Label>Name:</Form.Label>
                        <Form.Control value={drink.name} placeholder='Name of Drink...' type='text' onChange={(e) => {
                            const copy = { ...drink };
                            copy.name = e.target.value;
                            setDrink(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className="mb-3" controlId="editDrinkForm.price" >
                        <Form.Label>Price:</Form.Label>
                        <Form.Control value={drink.price} placeholder='0' type='number' min={0} onChange={(e) => {
                            const copy = { ...drink };
                            copy.price = e.target.value;
                            setDrink(copy);
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

export default EditDrinkForm;