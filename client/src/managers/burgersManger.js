const _API_URL = "/api/burgers";

export const getAllBurgers = () => {
    return fetch(_API_URL).then(res => res.json());
}

export const deleteBurger = (id) => {
    return fetch(`${_API_URL}/${id}`, {
        method: "DELETE"
    })
}