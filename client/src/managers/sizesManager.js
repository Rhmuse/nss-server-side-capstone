const _API_URL = "/api/sizes";

export const getAllSizes = () => {
    return fetch(_API_URL).then(res => res.json());
}

export const addSize = (size) => {
    return fetch(_API_URL, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(size)
    }).then(res => res.json())
}

export const deleteSize = (id) => {
    return fetch(`${_API_URL}/${id}`, {
        method: "DELETE"
    })
}

export const updateSize = (size) => {
    return fetch(_API_URL, {
        method: "PUT",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(size)
    }).then(res => res.json())
}