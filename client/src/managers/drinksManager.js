const _API_URL = "/api/drinks";

export const getAllDrinks = () => {
    return fetch(_API_URL).then(res => res.json());
}

export const addDrink = (drink) => {
    return fetch(_API_URL, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(drink)
    }).then(res => res.json())
}

export const deleteDrink = (id) => {
    return fetch(`${_API_URL}/${id}`, {
        method: "DELETE"
    })
}

export const updateDrink = (drink) => {
    return fetch(_API_URL, {
        method: "PUT",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(drink)
    }).then(res => res.json())
}