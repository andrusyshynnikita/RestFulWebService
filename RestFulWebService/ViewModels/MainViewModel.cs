using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Refit;
using RestFulWebService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestFulWebService.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(IMvxNavigationService mvxNavigationService) : base(mvxNavigationService)
        {
            ShowCurrentWeatherViewModelCommand = new MvxAsyncCommand(ShowCurrentWeatherViewModel);
            ShowListOfCitiesViewModelCommand = new MvxAsyncCommand(ShowListOfCitiesViewModel);
        }

        public IMvxAsyncCommand ShowCurrentWeatherViewModelCommand { get; private set; }

        private async Task ShowCurrentWeatherViewModel()
        {
            await _mvxNavigationService.Navigate<CurrentWeatherViewModel>();
        }

        public IMvxAsyncCommand ShowListOfCitiesViewModelCommand { get; private set; }

        private async Task ShowListOfCitiesViewModel()
        {
            await _mvxNavigationService.Navigate<ListOfCitiesViewModel>();
        }

    }
}
