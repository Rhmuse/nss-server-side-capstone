import { useNavigate, useParams } from 'react-router-dom';
import { capitalizeEveryFirstLetter } from '../../../../utility';
import { Button, Col, Container, Form, Row } from 'react-bootstrap';
import { useEffect, useState } from 'react';
import CategorySelect from '../../CategorySelect';
import { updateCombo } from '../../../../managers/combosManager';

const EditComboForm = ({ menuItems, setSelectedCategory }) => {
    const navigate = useNavigate();
    const { id } = useParams();

    const [combo, setCombo] = useState(
        {
            name: "",
            discount: 0,
            burgerId: "",
        }
    );

    const handleClick = () => {
        updateCombo(combo).then(() => {
            navigate("/admintools")
        })
    }

    useEffect(() => {
        const foundCombo = menuItems.combos.find(c => c.id === id);
        setCombo({
            id: id,
            name: foundCombo.name,
            discount: foundCombo.discount,
            burgerId: foundCombo.burgerId
        })
    }, [])
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
                    <Form.Group className='mb-3' controlId='comboForm.name'>
                        <Form.Label>Name:</Form.Label>
                        <Form.Control placeholder='Name of Combo...' value={combo.name} type='text' onChange={(e) => {
                            const copy = { ...combo };
                            copy.name = e.target.value;
                            setCombo(copy);
                        }}
                        />
                    </Form.Group>
                    <Form.Group className='mb-3' controlId='comboForm.discount'>
                        <Form.Label>Discount:</Form.Label>
                        <Form.Control max={0} type='number' value={combo.discount} onChange={(e) => {
                            const copy = { ...combo };
                            copy.discount = e.target.value;
                            setCombo(copy);
                        }} />
                    </Form.Group>
                    <Form.Group className='mb-3' controlId='comboForm.burgerSelect'>
                        <Form.Label>Burger:</Form.Label>
                        <Form.Select value={combo.burgerId} onChange={(e) => {

                            const copy = { ...combo };
                            copy.burgerId = e.target.value;
                            setCombo(copy);
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
                    <Button onClick={() => handleClick()}>Save Changes</Button>
                </Col>
            </Row>
        </Container>
    )
}

export default EditComboForm;