const _API_URL = "/api/combos";

export const getAllCombos = () => {
    return fetch(_API_URL).then(res => res.json());
}

export const deleteCombo = (id) => {
    return fetch(`${_API_URL}/${id}`, {
        method: "DELETE"
    })
}

export const addCombo = (combo) => {
    return fetch(_API_URL, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(combo)
    }).then(res => res.json())
}

export const updateCombo = (combo) => {
    return fetch(_API_URL, {
        method: "PUT",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(combo)
    }).then(res => res.json())
}