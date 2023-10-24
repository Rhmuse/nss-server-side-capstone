import { Button } from 'react-bootstrap'
import Utility from '../../../utility';

import "./posButton.css";

const MEDIUM_SIZE = "52e7feb2-ce4b-41ff-954b-bf1530547817";

const utility = new Utility();
const generator = function* () {
    let i = 1;
    while (true) {
        yield i;
        i++
    }
}

const tempIdGenerator = generator();

const ItemButton = ({ item, type, order, setOrder, itemBuilder, setSelectedItem }) => {

    const handleAddDrink = () => {
        let copy = { ...order };
        if (!itemBuilder.sizeId) itemBuilder.sizeId = MEDIUM_SIZE;
        const index = copy.drinks.findIndex(d => d.drinkId === item.id && d.sizeId === itemBuilder.sizeId)
        if (index >= 0) {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            copy.drinks[index].quantity = parseInt(copy.drinks[index].quantity) + parseInt(itemBuilder.quantity);
        } else {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            let newDrink = { drinkId: item.id, quantity: itemBuilder.quantity, name: item.name, price: item.price, sizeId: itemBuilder.sizeId };
            copy.drinks.push(newDrink);
        }
        setSelectedItem({});
        setOrder(copy);
    }

    const handleAddSide = () => {
        let copy = { ...order };
        if (!itemBuilder.sizeId) itemBuilder.sizeId = MEDIUM_SIZE;
        const index = copy.sides.findIndex(s => s.sideId === item.id && s.sizeId === itemBuilder.sizeId)
        if (index >= 0) {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            copy.sides[index].quantity = parseInt(copy.sides[index].quantity) + parseInt(itemBuilder.quantity);
        } else {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            let newSide = { sideId: item.id, quantity: itemBuilder.quantity, name: item.name, price: item.price, sizeId: itemBuilder.sizeId }
            copy.sides.push(newSide);
        }
        setSelectedItem({});
        setOrder(copy);
    }

    const handleAddBurger = () => {
        let copy = { ...order };
        const index = copy.burgers.findIndex(b => item.id === b.id && b.isModified === false)
        if (index >= 0) {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            copy.burgers[index].quantity = parseInt(copy.burgers[index].quantity) + parseInt(itemBuilder.quantity);
        } else {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            let newBurger = { id: item.id, quantity: itemBuilder.quantity, name: item.name, price: item.price, tempId: item.id + tempIdGenerator.next().value, isModified: false }
            copy.burgers.push(newBurger);
        }
        setOrder(copy);
    }

    const handleAddCombo = () => {

    }

    const handleAddItem = (type) => {
        switch (type) {
            case "drink":
                handleAddDrink();
                break;
            case "side":
                handleAddSide();
                break;
            case "burger":
                handleAddBurger();
                break;
            case "combo":
                handleAddCombo();
                break;
            default:
                break;
        }
    }

    return <Button className="posButton" onClick={() => { handleAddItem(type) }}>{utility.capitalizeEveryFirstLetter(item.name)}</Button>
}

export default ItemButton;