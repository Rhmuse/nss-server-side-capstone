import { Button } from 'react-bootstrap'
import { capitalizeEveryFirstLetter } from '../../../utility';

import "./posButton.css";
import "./ComboItemButton.css";

const ComboItemButton = ({ item, type, comboItems, setComboItems, menuItems }) => {

    const handleAddDrink = () => {
        const mediumSize = menuItems.sizes.find(s => s.name === "medium");
        let copy = { ...comboItems };
        copy.drink = {
            sizeId: mediumSize.id,
            drinkId: item.id,
            name: item.name,
            price: item.price
        };
        setComboItems(copy);
    }

    const handleAddSide = () => {
        const mediumSize = menuItems.sizes.find(s => s.name === "medium");
        let copy = { ...comboItems };
        copy.side = {
            sizeId: mediumSize.id,
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
                    ? <Button className="posButton selectedComboItem" onClick={() => { handleAddItem(type) }}>{capitalizeEveryFirstLetter(item.name)}</Button>
                    : <Button className="posButton" onClick={() => { handleAddItem(type) }}>{capitalizeEveryFirstLetter(item.name)}</Button>
            }
        </>
    )
}

export default ComboItemButton;