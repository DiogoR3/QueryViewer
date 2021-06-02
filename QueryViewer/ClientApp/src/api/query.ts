import axios, { AxiosResponse } from 'axios'

const controller: string = process.env.BASE_URL + 'api/query'

function getAllQueries(): Promise<AxiosResponse<QueryNames>> {
    return axios.get(controller)
}

function getQueryResult(id: number): Promise<AxiosResponse<QueryResult>> {
    return axios.get(`${controller}/${id}`)
}

export interface QueryNames {
    name: string[]
}

export interface QueryResult {
    headers: string[],
    rows: string[][]
}

export default {
    getAllQueries,
    getQueryResult
}
 