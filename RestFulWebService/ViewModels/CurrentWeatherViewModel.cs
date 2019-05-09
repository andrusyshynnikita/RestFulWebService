using MvvmCross.Navigation;
using Refit;
using RestFulWebService.Interfaces;
using RestFulWebService.Models;
using System;
using System.Collections.Generic;
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
        #endregion

        public CurrentWeatherViewModel(IMvxNavigationService mvxNavigationService,ILocationService locationService) : base(mvxNavigationService)
        {
            _locationService = locationService;
        }

        public override async void ViewAppearing()
        {
            base.ViewAppearing();
            await GetCurrentWeather();
        }

        #region Propertis
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

        private async Task GetCurrentWeather()
        {
            _latitude = _locationService.GetLatitude();
            _longitude = _locationService.GetLongitude();
            var apiService = RestService.For<IAPIService>("https://api.openweathermap.org");

            CurrentWeater = await apiService.GetCurrentWeatherByCoordinates(_latitude, _longitude, APIKey);
        }
    }
}

