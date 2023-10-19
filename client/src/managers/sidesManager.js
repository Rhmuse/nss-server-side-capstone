const _API_URL = "/api/sides";

export const getAllSides = () => {
    return fetch(_API_URL).then(res => res.json());
}