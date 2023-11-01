import { Button } from 'react-bootstrap'
import { capitalizeEveryFirstLetter } from '../../../utility';

import "./BurgerModButton.css";

const BurgerModButton = ({ topping, order, setOrder, selectedItem, type, selected, menuItems }) => {
    const handleClick = () => {
        const orderCopy = { ...order };
        const foundBurger = orderCopy.burgers.find(b => b.id === selectedItem.id);
        foundBurger.isModified = true;
        if (!foundBurger.modifications) foundBurger.modifications = [];
        let foundModIndex = foundBurger.modifications.findIndex(m => m.topping.id === topping.id);
        if (foundModIndex > -1) {
            if (foundBurger.modifications[foundModIndex].modification === type) {
                foundBurger.modifications = foundBurger.modifications.slice(0, foundModIndex).concat(foundBurger.modifications.slice(foundModIndex + 1))
                setOrder(orderCopy);
                return;
            } else {
                foundBurger.modifications[foundModIndex].modification = type;
            }
        } else {
            foundBurger.modifications.push({
                topping,
                modification: type,
            })
            foundModIndex = foundBurger.modifications.findIndex(m => m.topping.id === topping.id);
        }
        switch (type) {
            case "ex":
                foundBurger.price += foundBurger.modifications[foundModIndex].topping.price * 2;
                break;
            case "no":
                foundBurger.price -= foundBurger.modifications[foundModIndex].topping.price;
                break;
            case "add":
                foundBurger.price += foundBurger.modifications[foundModIndex].topping.price;
                break;
            default:
                break;
        }
        setOrder(orderCopy);
    }

    if (topping.name === "patty") return;
    if (type === "no") {
        return (
            <Button onClick={() => { handleClick() }} className={`posButton selectedTopping toppingNo burgerModButton`}>No {capitalizeEveryFirstLetter(topping.name)}</Button>
        )
    } else if (type === "extra") {
        if (topping.name === "bun") return;
        const foundBurger = menuItems.burgers.find(b => b.id === selectedItem.id)
        if (foundBurger.burgerToppings.find(bt => bt.toppingId === topping.id)) return;
        return (
            <Button onClick={() => { handleClick() }} className={`posButton selectedTopping toppingEx burgerModButton`}>Ex {capitalizeEveryFirstLetter(topping.name)}</Button>
        )
    } else if (type === "add") {
        if (topping.name === "bun") return;
        const foundBurger = menuItems.burgers.find(b => b.id === selectedItem.id)
        if (foundBurger.burgerToppings.find(bt => bt.toppingId === topping.id)) return;
        return (
            <Button onClick={() => { handleClick() }} className={`posButton selectedTopping toppingAdd burgerModButton`}>Add {capitalizeEveryFirstLetter(topping.name)}</Button>
        )
    }


}

export default BurgerModButton;