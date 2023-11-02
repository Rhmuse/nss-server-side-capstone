const _API_URL = "/api/orders";

export const getAllOrders = () => {
    return fetch(_API_URL).then(res => res.json());
}

export const postOrder = (order) => {
    const orderCopy = {
        order: order.order,
        orderDrinkDtos: [],
        orderSideDtos: [],
        burgerDtos: [],
        comboDtos: []
    };

    order.drinks.forEach(d => {
        const newDrinkObj = {
            drinkId: d.drinkId,
            quantity: d.quantity,
            sizeId: d.sizeId
        }
        orderCopy.orderDrinkDtos.push(newDrinkObj);
    })

    order.sides.forEach(s => {
        const newSideObj = {
            sideId: s.sideId,
            quantity: s.quantity,
            sizeId: s.sizeId,
        }
        orderCopy.orderSideDtos.push(newSideObj);
    })

    order.burgers.forEach(b => {
        const newBurgerObj = {
            id: b.id,
            quantity: b.quantity,
            isModified: b.isModified,
            price: b.price,
            burgerToppingDtos: [],
        }
        b.burgerToppings.forEach(bt => {
            if (b.isModified) {
                const foundMod = b.modifications.find(m => m.topping.id === bt.toppingId);
                if (foundMod) {
                    let newBurgerToppingObj;
                    switch (foundMod.modification) {
                        case 'no':
                            break;
                        case 'add':
                            newBurgerToppingObj = {
                                toppingId: foundMod.topping.id,
                                extra: false
                            }
                            newBurgerObj.burgerToppingDtos.push(newBurgerToppingObj);
                            break;
                        case 'extra':
                            newBurgerToppingObj = {
                                toppingId: foundMod.topping.id,
                                extra: true
                            }
                            newBurgerObj.burgerToppingDtos.push(newBurgerToppingObj);
                            break;
                        default:
                            break;
                    }
                } else {
                    const newBurgerToppingObj = {
                        toppingId: bt.toppingId,
                        extra: bt.extra
                    }
                    newBurgerObj.burgerToppingDtos.push(newBurgerToppingObj);
                }
            } else {
                const newBurgerToppingObj = {
                    toppingId: bt.toppingId,
                    extra: bt.extra
                }
                newBurgerObj.burgerToppingDtos.push(newBurgerToppingObj);
            }
        })
        if (b.isModified) {
            b.modifications.forEach(m => {
                const foundTopping = b.burgerToppings.find(bt => bt.topping.id === m.topping.id)
                if (!foundTopping) {
                    let newBurgerToppingObj;
                    switch (m.modification) {
                        case 'no':
                            break;
                        case 'add':
                            newBurgerToppingObj = {
                                toppingId: m.topping.id,
                                extra: false
                            }
                            newBurgerObj.burgerToppingDtos.push(newBurgerToppingObj);
                            break;
                        case 'extra':
                            newBurgerToppingObj = {
                                toppingId: m.topping.id,
                                extra: true
                            }
                            newBurgerObj.burgerToppingDtos.push(newBurgerToppingObj);
                            break;
                        default:
                            break;
                    }
                }
            })
        }
        orderCopy.burgerDtos.push(newBurgerObj);
    })

    order.combos.forEach(c => {
        const newComboObj = {
            id: c.id,
            orderSideDto: {},
            orderDrinkDto: {},
            burgerDto: {},
            quantity: c.quantity
        }
        c.items.forEach(i => {
            if (i.sideId) {
                const newSideObj = {
                    sizeId: i.sizeId,
                    sideId: i.sideId,
                    isInCombo: true,
                    quantity: c.quantity,
                }
                newComboObj.orderSideDto = newSideObj;
            } else if (i.drinkId) {
                const newDrinkObj = {
                    sizeId: i.sizeId,
                    drinkId: i.drinkId,
                    isInCombo: true,
                    quantity: c.quantity,
                }
                newComboObj.orderDrinkDto = newDrinkObj;
            } else {
                const newBurgerObj = {
                    quantity: c.quantity,
                    price: i.price,
                    isModified: false,
                    burgerToppingDtos: [],
                }
                i.burgerToppings.forEach(bt => {
                    if (i.isModified) {
                        const foundMod = i.modifications.find(m => m.topping.id === bt.toppingId);
                        if (foundMod) {
                            let newBurgerToppingObj;
                            switch (foundMod.modification) {
                                case 'no':
                                    break;
                                case 'add':
                                    newBurgerToppingObj = {
                                        toppingId: foundMod.topping.id,
                                        extra: false
                                    }
                                    newBurgerObj.burgerToppingDtos.push(newBurgerToppingObj);
                                    break;
                                case 'extra':
                                    newBurgerToppingObj = {
                                        toppingId: foundMod.topping.id,
                                        extra: true
                                    }
                                    newBurgerObj.burgerToppingDtos.push(newBurgerToppingObj);
                                    break;
                                default:
                                    break;
                            }
                        } else {
                            const newBurgerToppingObj = {
                                toppingId: bt.toppingId,
                                extra: bt.extra
                            }
                            newBurgerObj.burgerToppingDtos.push(newBurgerToppingObj);
                        }
                    } else {
                        const newBurgerToppingObj = {
                            toppingId: bt.toppingId,
                            extra: bt.extra
                        }
                        newBurgerObj.burgerToppingDtos.push(newBurgerToppingObj);
                    }
                    newComboObj.burgerDto = newBurgerObj;
                })
            }
        })
        orderCopy.comboDtos.push(newComboObj);
    })

    return fetch(_API_URL, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(orderCopy)
    })
}