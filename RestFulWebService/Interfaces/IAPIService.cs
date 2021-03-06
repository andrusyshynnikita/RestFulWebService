﻿using Refit;
using RestFulWebService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestFulWebService.Interfaces
{
    [Headers("Accept: application/json")]
    public interface IAPIService
    {
        [Get("/data/2.5/weather?lat={lat}&lon={lon}&appid={APIKEY}&units=metric")]
        Task<CurrentWeather> GetCurrentWeatherByCoordinates(double lat, double lon, string APIKEY);

        [Get("/data/2.5/weather?id={id}&appid={APIKEY}&units=metric")]
        Task<CurrentWeather> GetCurrentWeatherByCityId(int id, string APIKEY);
    }
}
