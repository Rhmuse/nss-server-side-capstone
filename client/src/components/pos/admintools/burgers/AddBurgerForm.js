import { useState } from 'react';
import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';
import { addBurger } from '../../../../managers/burgersManger';
import Utility from '../../../../utility';
import CategorySelect from '../../CategorySelect';

const utility = new Utility();
const AddBurgerForm = ({ loadMenuItems, menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();

    const [checkedState, setCheckedState] = useState(
        new Array(menuItems.toppings.length).fill(false)
    );

    const [newBurger, setNewBurger] = useState(
        {
            name: "",
            toppings: [],
        }
    );

    const handleClick = () => {
        addBurger(newBurger).then(() => {
            navigate("/admintools")
        })
    }

    return (
        <Container>
            <Row>
                <Col>
                    <h1>New Burger</h1>
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
                    <Form.Group className='mb-3' controlId='newBurgerForm.name'>
                        <Form.Label>Name:</Form.Label>
                        <Form.Control placeholder='Name of Burger...' type='text' onChange={(e) => {
                            const copy = { ...newBurger };
                            copy.name = e.target.value;
                            setNewBurger(copy);
                        }}
                        />
                    </Form.Group>
                    <Form.Group className='mb-3' controlId='newBurgerForm.toppings'>
                        {
                            menuItems.toppings.map(({ id, name }, index) => {
                                if (name === "patty") {
                                    return (
                                        <>
                                            <br />
                                            <Form.Label>Number of Patties:</Form.Label>
                                            <Form.Control type='number' min={0} onChange={(e) => {
                                                const newBurgerCopy = { ...newBurger };
                                                newBurgerCopy.toppings = newBurgerCopy.toppings.filter(i => i.id !== id);
                                                for (let i = 0; i < parseInt(e.target.value); i++) {
                                                    newBurgerCopy.toppings.push({ toppingId: id });
                                                }
                                                setNewBurger(newBurgerCopy);
                                            }} />
                                        </>
                                    )
                                }
                                return (
                                    <Form.Check onChange={() => {
                                        let checkedStateCopy = [...checkedState]
                                        checkedStateCopy[index] = !checkedStateCopy[index];
                                        let newBurgerCopy = { ...newBurger };
                                        const foundToppingIndex = newBurgerCopy.toppings.findIndex(t => t.id === id)
                                        if (foundToppingIndex > -1) {
                                            newBurgerCopy.toppings = newBurgerCopy.toppings.filter(t => t.id !== id)
                                        } else {
                                            newBurger.toppings.push({ toppingId: id })
                                        }
                                        setCheckedState(checkedStateCopy);
                                        setNewBurger(newBurgerCopy);

                                    }} checked={checkedState[index]} inline value={id} type="checkbox" key={`topping-${id}`} label={utility.capitalizeEveryFirstLetter(name)} />
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