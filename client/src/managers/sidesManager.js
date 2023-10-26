const _API_URL = "/api/sides";

export const getAllSides = () => {
    return fetch(_API_URL).then(res => res.json());
}

export const deleteSide = (id) => {
    return fetch(`${_API_URL}/${id}`, {
        method: "DELETE"
    })
}

export const addSide = (side) => {
    return fetch(_API_URL, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(side)
    }).then(res => res.json())
}