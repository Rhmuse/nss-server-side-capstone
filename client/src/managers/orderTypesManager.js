const _API_URL = "/api/orderTypes";

export const getAllOrderTypes = () => {
    return fetch(_API_URL).then(res => res.json());
}