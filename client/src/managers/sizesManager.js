const _API_URL = "/api/sizes";

export const getAllSizes = () => {
    return fetch(_API_URL).then(res => res.json());
}