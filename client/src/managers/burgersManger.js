const _API_URL = "/api/burgers";

export const getAllBurgers = () => {
    return fetch(_API_URL).then(res => res.json());
}