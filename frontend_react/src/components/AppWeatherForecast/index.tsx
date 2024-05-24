import axios from 'axios';
import React, { useEffect, useState } from 'react';

interface Props {}


interface WeatherForecast {
    date: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}

const AppWeatherForecast = (props: Props) => {


    const [serverData, setServerData] = useState<WeatherForecast[]>([]);

    const [ loadingData, setLoadingData ] = useState(true);

    useEffect(  () => {

        const fetchApiData = async() => {
            try{
                
                const response = await axios.get<WeatherForecast[]>("https://localhost:7002/WeatherForecast");
                console.log("Response from API:", response.data);
                setServerData(response.data);
                setLoadingData(false);            

            }catch(err)
            {
                console.error("Não consegui conectar" + err);
                setLoadingData(false);
            }
        }

        fetchApiData();

    }, []);

    if(loadingData)
    {
        return <div>Carregando...</div>;
    }

    return(
        <div>
            {serverData.map((item, index) => (
                <div key={index}>
                    <p><strong>Date:</strong> {new Date(item.date).toLocaleDateString()}</p>
                    <p><strong>Temperature:</strong> {item.temperatureC}°C ({item.temperatureF}°F)</p>
                    <p><strong>Summary:</strong> {item.summary}</p>
                </div>
            ))}
        </div>
    )
    
};

export default AppWeatherForecast;
