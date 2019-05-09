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
            ShowCurrentWeatherViewModelCommand = new MvxAsyncCommand(async () => await _mvxNavigationService.Navigate<CurrentWeatherViewModel>());
            ShowListOfCitiesViewModelCommand = new MvxAsyncCommand(async () => await _mvxNavigationService.Navigate<ListOfCitiesViewModel>());
            ShowMenuViewModelCommand = new MvxAsyncCommand(async () => await _mvxNavigationService.Navigate<MenuViewModel>());
        }


        public IMvxAsyncCommand ShowCurrentWeatherViewModelCommand { get; private set; }
        public IMvxAsyncCommand ShowListOfCitiesViewModelCommand { get; private set; }
        public IMvxAsyncCommand ShowMenuViewModelCommand { get; private set; }
    }
}
