import { Button } from 'react-bootstrap'
import Utility from '../../../utility';

import "./posButton.css";

const utility = new Utility();
const ItemButton = ({ item, type, order, setOrder }) => {

    const handleAddDrink = () => {
        let copy = { ...order };
        const index = copy.drinks.findIndex(d => d.drinkId === item.id)
        if (index >= 0) {
            copy.drinks[index].quantity += 1;
        } else {
            copy.drinks.push({ drinkId: item.id, quantity: 1, name: item.name, price: item.price })
        }
        setOrder(copy);
    }

    const handleAddSide = () => {
        let copy = { ...order };
        const index = copy.sides.findIndex(s => s.sideId === item.id)
        if (index >= 0) {
            copy.sides[index].quantity += 1;
        } else {
            copy.sides.push({ sideId: item.id, quantity: 1, name: item.name, price: item.price })
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

    return <Button className="posButton" onClick={() => { handleAddItem(type, item) }}>{utility.capitalizeEveryFirstLetter(item.name)}</Button>
}

export default ItemButton;