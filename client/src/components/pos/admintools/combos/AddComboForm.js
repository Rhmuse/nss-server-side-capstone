import { useNavigate } from 'react-router-dom';
import { capitalizeEveryFirstLetter } from '../../../../utility';
import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import { useState } from 'react';
import CategorySelect from '../../CategorySelect';
import { addCombo } from '../../../../managers/combosManager';

const AddComboForm = ({ menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();

    const [newCombo, setNewCombo] = useState(
        {
            name: "",
            discount: 0,
            burgerId: "",
        }
    );

    const handleClick = () => {
        addCombo(newCombo).then(() => {
            navigate("/admintools")
        })
    }
    return (
        <Container>
            <Row>
                <Col>
                    <h1>New Combo</h1>
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
                    <Form.Group className='mb-3' controlId='newComboForm.name'>
                        <Form.Label>Name:</Form.Label>
                        <Form.Control placeholder='Name of Combo...' value={newCombo.name} type='text' onChange={(e) => {
                            const copy = { ...newCombo };
                            copy.name = e.target.value;
                            setNewCombo(copy);
                        }}
                        />
                    </Form.Group>
                    <Form.Group className='mb-3' controlId='newComboForm.discount'>
                        <Form.Label>Discount:</Form.Label>
                        <Form.Control max={0} type='number' value={newCombo.discount} onChange={(e) => {
                            const copy = { ...newCombo };
                            copy.discount = e.target.value;
                            setNewCombo(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className='mb-3' controlId='newComboForm.burgerSelect'>
                        <Form.Label>Burger:</Form.Label>
                        <Form.Select onChange={(e) => {
                            const copy = { ...newCombo };
                            copy.burgerId = e.target.value;
                            setNewCombo(copy);
                        }}>
                            <option key="defaultBurger-option" value={""}>Select a Burger...</option>
                            {
                                menuItems.burgers.map(b => {
                                    return (
                                        <option key={`${b.id}-option`} value={b.id}>{capitalizeEveryFirstLetter(b.name)}</option>
                                    )
                                })
                            }
                        </Form.Select>
                    </Form.Group>
                </Form>
            </Row>
            <Row>
                <Col>
                    <Button onClick={() => handleClick()}>Save Combo</Button>
                </Col>
            </Row>
        </Container>
    )
}

export default AddComboForm;