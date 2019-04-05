using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using Refit;
using RestFulWebService.ViewModels;
using System;
using WebService.IOS.Services;

namespace WebService.IOS
{
    [MvxTabPresentation(WrapInNavigationController = true, TabName = "Current Weather")]
    public partial class CurrentWeatherView : MvxViewController<CurrentWeatherViewModel>
    {
        public CurrentWeatherView () : base (nameof(CurrentWeatherView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<CurrentWeatherView, CurrentWeatherViewModel>();
            set.Bind(CityName).To(vm => vm.CityName);
            set.Bind(WeatherDescription).To(vm => vm.WeatherDescription);
            set.Bind(Temp).To(vm => vm.CurrentTemp);
            set.Bind(WindSpeed).To(vm => vm.CurrentWind.speed);
            set.Bind(Pressure).To(vm => vm.CurrentPressure);
            set.Bind(Humidity).To(vm => vm.CurrentHumidity);
            set.Apply();
        }

    }
}