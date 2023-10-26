const _API_URL = "/api/toppings"

export const getAllToppings = () => {
    return fetch(_API_URL).then(res => res.json());
}

export const addTopping = (topping) => {
    return fetch(_API_URL, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(topping)
    }).then(res => res.json())
}

export const deleteTopping = (id) => {
    return fetch(`${_API_URL}/${id}`, {
        method: "DELETE"
    })
}