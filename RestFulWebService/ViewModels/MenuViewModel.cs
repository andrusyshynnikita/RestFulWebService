using MvvmCross.Commands;
using MvvmCross.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestFulWebService.ViewModels
{
  public  class MenuViewModel : BaseViewModel
    {
        #region Variables

        #endregion

        #region Constructors
        public MenuViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
            ShowCurrentWeatherViewModelCommand = new MvxAsyncCommand(async () => await _mvxNavigationService.Navigate<CurrentWeatherViewModel>());
            ShowListOfCitiesViewModelCommand = new MvxAsyncCommand(async () => await _mvxNavigationService.Navigate<ListOfCitiesViewModel>());
        }
        #endregion

        #region LifeCycle
        #endregion

        #region Commands
        public IMvxAsyncCommand ShowCurrentWeatherViewModelCommand { get; private set; }
        public IMvxAsyncCommand ShowListOfCitiesViewModelCommand { get; private set; }
        #endregion

        #region Properties
        #endregion

        #region Methods

        #endregion
    }
}
