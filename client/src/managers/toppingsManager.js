const _API_URL = "/api/toppings"

export const getAllToppings = () => {
    fetch(_API_URL).then(res => res.json());
}