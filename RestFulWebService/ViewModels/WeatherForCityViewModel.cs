using Refit;
using RestFulWebService.Interfaces;
using RestFulWebService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestFulWebService.ViewModels
{
    public class WeatherForCityViewModel : BaseParameterViewModel<CityModel>
    {
        #region Variables
        const string APIKey = "6606b02e3ce087d49d7135fd602953eb";
        private CurrentWeather _currentWeather;
        #endregion

        #region Constructors
        public WeatherForCityViewModel()
        {

        }
        #endregion

        #region LifeCycle
        public override void Prepare(CityModel parameter)
        {
            GetCurrentWeatherForCity(parameter.id);
        }
        #endregion

        #region Commands
        #endregion

        #region Properties
        public CurrentWeather CurrentWeater
        {
            get
            {
                return _currentWeather;
            }
            set
            {
                SetProperty(ref _currentWeather, value, "CurrentWeater");
            }
        }
        #endregion

        #region Methods
        private async Task GetCurrentWeatherForCity(int id)
        {
            var apiService = RestService.For<IAPIService>("https://api.openweathermap.org");
            try
            {
                CurrentWeater = await apiService.GetCurrentWeatherByCityId(id, APIKey);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion


    }
}
