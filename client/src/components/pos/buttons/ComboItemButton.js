import { Button } from 'react-bootstrap'
import Utility from '../../../utility';

import "./posButton.css";
import "./ComboItemButton.css";

const MEDIUM_SIZE = "3baba7e3-f4ca-42bf-9092-929e013bd15f";
const utility = new Utility();

const ComboItemButton = ({ item, type, comboItems, setComboItems }) => {

    const handleAddDrink = () => {
        let copy = { ...comboItems };
        copy.drink = {
            sizeId: MEDIUM_SIZE,
            drinkId: item.id,
            name: item.name,
            price: item.price
        };
        setComboItems(copy);
    }

    const handleAddSide = () => {
        let copy = { ...comboItems };
        copy.side = {
            sizeId: MEDIUM_SIZE,
            sideId: item.id,
            name: item.name,
            price: item.price
        }
        setComboItems(copy);
    }

    const handleAddItem = (type) => {
        switch (type) {
            case "drink":
                handleAddDrink();
                break;
            case "side":
                handleAddSide();
                break;
            default:
                break;
        }
    }

    return (
        <>
            {
                comboItems.drink.drinkId === item.id || comboItems.side.sideId === item.id
                    ? <Button className="posButton selectedComboItem" onClick={() => { handleAddItem(type) }}>{utility.capitalizeEveryFirstLetter(item.name)}</Button>
                    : <Button className="posButton" onClick={() => { handleAddItem(type) }}>{utility.capitalizeEveryFirstLetter(item.name)}</Button>
            }
        </>
    )
}

export default ComboItemButton;