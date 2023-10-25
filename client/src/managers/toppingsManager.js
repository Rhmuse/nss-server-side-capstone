const _API_URL = "/api/toppings"

export const getAllToppings = () => {
    return fetch(_API_URL).then(res => res.json());
}