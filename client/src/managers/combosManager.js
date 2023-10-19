const _API_URL = "/api/combos";

export const getAllCombos = () => {
    return fetch(_API_URL).then(res => res.json());
}