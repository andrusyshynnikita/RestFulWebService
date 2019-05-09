using Refit;
using RestFulWebService.Interfaces;
using RestFulWebService.Models;
using System;
using System.Threading.Tasks;

namespace RestFulWebService.ViewModels
{
    
    public class CurrentWeatherViewModel : BaseViewModel
    {
        #region Variables
        const string APIKey = "6606b02e3ce087d49d7135fd602953eb";
        private ILocationService _locationService;
        private double _latitude;
        private double _longitude;
        private CurrentWeather _currentWeather;
        private string _citiName;
        private double _currentTemp;
        private string _weatherDescription;
        private Wind _currentWind;
        private int _currentHumidity;
        #endregion

        public CurrentWeatherViewModel(ILocationService locationService)
        {
            _locationService = locationService;
        }

        public override async void ViewAppeared()
        {
            base.ViewAppeared();
           await  GetCurrentWeather();
        }
        
        #region Propertis
        public string CityName
        {
            get
            {
                return _citiName;
            }
            set
            {
                _citiName = value;
                RaisePropertyChanged(() => CityName);
            }
        }

        public double CurrentTemp
        {
            get
            {
                return _currentTemp;
            }
            set
            {
                _currentTemp = value;
                RaisePropertyChanged(() => CurrentTemp);
            }
        }

        public string WeatherDescription
        {
            get
            {
                return _weatherDescription;
            }
            set
            {
                _weatherDescription = value;
                RaisePropertyChanged(() => WeatherDescription);
            }
        }

        public Wind CurrentWind
        {
            get
            {
                return _currentWind;
            }
            set
            {
                _currentWind = value;
                RaisePropertyChanged(() => CurrentWind);
            }
        }

        public int CurrentPressure
        {
            get
            {
                return _currentHumidity;
            }
            set
            {
                _currentHumidity = value;
                RaisePropertyChanged(() => CurrentPressure);
            }
        }

        public int CurrentHumidity
        {
            get
            {
                return _currentHumidity;
            }
            set
            {
                _currentHumidity = value;
                RaisePropertyChanged(() => CurrentHumidity);
            }
        }
        
        #endregion

        private async Task GetCurrentWeather()
        {
            try
            {
                _latitude = _locationService.GetLatitude();
                _longitude = _locationService.GetLongitude();
                var apiService = RestService.For<IAPIService>("https://api.openweathermap.org");

                _currentWeather  = await apiService.GetCurrentWeatherByCoordinates(_latitude,_longitude, APIKey);
                if(_currentWeather!= null)
                {
                    CityName = _currentWeather.name;
                    CurrentTemp = _currentWeather.main.temp;
                    WeatherDescription = _currentWeather.weather[0].description;
                    CurrentWind = _currentWeather.wind;
                    CurrentPressure = _currentWeather.main.pressure;
                    CurrentHumidity = _currentWeather.main.humidity;




                }
            }
            catch (Exception e)
            {
                var te = e.Message;
            }
        }
    }
}

