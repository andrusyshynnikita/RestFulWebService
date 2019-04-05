using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreLocation;
using Foundation;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using RestFulWebService.ViewModels;
using UIKit;

namespace WebService.IOS.Views
{
    [MvxRootPresentation]
    public  class MainView: MvxViewController<MainViewModel>
    {
        private bool _firstTimePresented = true;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {           
            base.ViewWillAppear(animated);

            if (_firstTimePresented)
            {
                _firstTimePresented = false;

                ViewModel.ShowCurrentWeatherViewModelCommand.Execute(null);
                ViewModel.ShowListOfCitiesViewModelCommand.Execute(null);

            }
        }
    }
}