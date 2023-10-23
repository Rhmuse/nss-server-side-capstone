import { Button } from 'react-bootstrap'
import Utility from '../../../utility';

import "./posButton.css";

const utility = new Utility();
const ItemButton = ({ item, type, order, setOrder, itemBuilder, setItemBuilder }) => {

    const handleAddDrink = () => {
        let copy = { ...order };
        if (!itemBuilder.sizeId) itemBuilder.sizeId = "40cc063c-7222-49b5-ab71-0297fdf1f86c";
        const index = copy.drinks.findIndex(d => d.drinkId === item.id && d.sizeId === itemBuilder.sizeId)
        if (index >= 0) {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            copy.drinks[index].quantity = parseInt(copy.drinks[index].quantity) + parseInt(itemBuilder.quantity);
        } else {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            let newDrink = { drinkId: item.id, quantity: itemBuilder.quantity, name: item.name, price: item.price, sizeId: itemBuilder.sizeId };
            copy.drinks.push(newDrink);
        }
        setOrder(copy);
    }

    const handleAddSide = () => {
        let copy = { ...order };
        if (!itemBuilder.sizeId) itemBuilder.sizeId = "40cc063c-7222-49b5-ab71-0297fdf1f86c";
        const index = copy.sides.findIndex(s => s.sideId === item.id && s.sizeId === itemBuilder.sizeId)
        if (index >= 0) {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            copy.sides[index].quantity = parseInt(copy.sides[index].quantity) + parseInt(itemBuilder.quantity);
        } else {
            if (!itemBuilder.quantity) itemBuilder.quantity = 1;
            let newSide = { sideId: item.id, quantity: itemBuilder.quantity, name: item.name, price: item.price, sizeId: itemBuilder.sizeId }
            copy.sides.push(newSide);
        }
        setOrder(copy);
    }

    const handleAddBurger = () => {
        // let copy = { ...order };
        // copy.burgers.push({ burgerId: item.id, quantity: 1 })
        // setOrder(copy);
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