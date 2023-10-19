const _API_URL = "/api/drinks";

export const getAllDrinks = () => {
    return fetch(_API_URL).then(res => res.json());
}