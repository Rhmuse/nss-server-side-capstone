import { useEffect, useState } from 'react';
import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';
import { updateBurger } from '../../../../managers/burgersManger';
import currency from 'currency.js';
import Utility from '../../../../utility';
import CategorySelect from '../../CategorySelect';

const utility = new Utility();
const EditBurgerForm = ({ menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();
    const { id } = useParams();

    const [checkedState, setCheckedState] = useState(
        new Array(menuItems.toppings.length).fill(false)
    );

    const [burger, setBurger] = useState(
        {
            name: "",
            toppings: [],
            pattyAmount: 0,
        }
    );

    useEffect(() => {
        if (menuItems.burgers.length > 0) {
            const foundBurger = menuItems.burgers.find(b => b.id === id);
            const burgerObj = {
                name: foundBurger.name,
                toppings: [],
                pattyAmount: 0,
            }
            let checkedStateCopy = [...checkedState];
            let pattyCount = 0;
            foundBurger.burgerToppings.forEach(t => {
                if (t.topping.name === "patty") pattyCount++;
                burgerObj.toppings.push({ toppingId: t.toppingId, extra: false })
                const toppingIndex = menuItems.toppings.findIndex(top => top.id === t.toppingId);
                checkedStateCopy[toppingIndex] = true;
            })
            burgerObj.pattyAmount = pattyCount;
            setCheckedState(checkedStateCopy);
            setBurger(burgerObj);
        }
    }, [menuItems])

    const handleClick = () => {
        const burgerDTO = { name: burger.name, toppings: burger.toppings, id: id }
        updateBurger(burgerDTO).then(() => {
            navigate("/admintools")
        })
    }

    return (
        <Container>
            <Row>
                <Col>
                    <h1>Edit Burger</h1>
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
                    <Form.Group className='mb-3' controlId='burgerForm.name'>
                        <Form.Label>Name:</Form.Label>
                        <Form.Control value={burger.name} placeholder='Name of Burger...' type='text' onChange={(e) => {
                            const copy = { ...burger };
                            copy.name = e.target.value;
                            setBurger(copy);
                        }}
                        />
                    </Form.Group>
                    <Form.Group className='mb-3' controlId='burgerForm.toppings'>
                        {
                            menuItems.toppings.map(({ id, name, price, isDeleted }, index) => {
                                if (name === "patty") {
                                    return (
                                        <div key={`topping-${id}`}>
                                            <br />
                                            <Form.Label>Number of Patties:</Form.Label>
                                            <Form.Control value={burger.pattyAmount} type='number' min={0} onChange={(e) => {
                                                const burgerCopy = { ...burger };
                                                burgerCopy.toppings = burgerCopy.toppings.filter(i => i.toppingId !== id);
                                                for (let i = 0; i < parseInt(e.target.value); i++) {
                                                    burgerCopy.toppings.push({ toppingId: id });
                                                }
                                                burgerCopy.pattyAmount = e.target.value;
                                                setBurger(burgerCopy);
                                            }} />
                                        </div>
                                    )
                                }
                                return (
                                    <Form.Check onChange={() => {
                                        let checkedStateCopy = [...checkedState]
                                        checkedStateCopy[index] = !checkedStateCopy[index];
                                        let burgerCopy = { ...burger };
                                        const foundToppingIndex = burgerCopy.toppings.findIndex(t => t.toppingId === id)
                                        if (foundToppingIndex > -1) {
                                            burgerCopy.toppings = burgerCopy.toppings.filter(t => t.toppingId !== id)
                                        } else {
                                            burger.toppings.push({ toppingId: id })
                                        }
                                        setCheckedState(checkedStateCopy);
                                        setBurger(burgerCopy);

                                    }} checked={checkedState[index]} inline value={id} type="checkbox" key={`topping-${id}`} label={`${utility.capitalizeEveryFirstLetter(name)} ${currency(price).format()} ${isDeleted ? "(Deleted)" : ""}`} />
                                )
                            })
                        }
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

export default EditBurgerForm;