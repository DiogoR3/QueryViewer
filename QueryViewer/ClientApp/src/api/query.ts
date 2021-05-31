import axios, { AxiosResponse } from 'axios'

const controller: string = 'query'

export function getAllQueries(): Promise<AxiosResponse<QueryNames>> {
    return axios.get(controller)
}

export function getQueryResult(id: number): Promise<AxiosResponse<QueryResult>> {
    return axios.get(`${controller}/${id}`)
}

interface QueryNames {
    name: string[]
}

interface QueryResult {
    headers: string[],
    rows: string[][]
}

