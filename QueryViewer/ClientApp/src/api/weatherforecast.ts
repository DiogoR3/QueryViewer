import axios, { AxiosResponse }  from 'axios'

const controller: string = 'weatherforecast'

export const weatherForecast = {
    getAll: (): Promise<AxiosResponse<WeatherForecast[]>> => axios.get<WeatherForecast[]>(controller),
}

interface WeatherForecast {
    date: Date,
    temperatureC: number,
    temperatureF: number,
    summary: string
}
