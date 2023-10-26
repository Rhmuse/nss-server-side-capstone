const _API_URL = "/api/combos";

export const getAllCombos = () => {
    return fetch(_API_URL).then(res => res.json());
}

export const deleteCombo = (id) => {
    return fetch(`${_API_URL}/${id}`, {
        method: "DELETE"
    })
}