import { useState } from 'react';
import { Form } from 'react-bootstrap';

const AddDrinkForm = () => {
    const [newDrink, setNewDrink] = useState(
        {
            name: "",
            price: "0",
        }
    );
    return (
        <Form>
            <Form.Group className="mb-3" controlId="newDrinkForm.name" >
                <Form.Label>Name:</Form.Label>
                <Form.Control onChange={(e) => {
                    const copy = { ...newDrink };
                    copy.name = e.target.value;
                    setNewDrink(copy);
                }} />
            </Form.Group>
            <Form.Group className="mb-3" controlId="newDrinkForm.price" >
                <Form.Label>Price:</Form.Label>
                <Form.Control type='number' min={0} onChange={(e) => {
                    const copy = { ...newDrink };
                    copy.price = e.target.value;
                    setNewDrink(copy);
                }} />
            </Form.Group>

        </Form>
    )
}

export default AddDrinkForm;