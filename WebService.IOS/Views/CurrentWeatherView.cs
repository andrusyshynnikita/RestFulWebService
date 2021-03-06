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
            set.Bind(CityName).To(vm => vm.CurrentWeater.name);
            set.Bind(WeatherDescription).To(vm => vm.CurrentWeater.weather[0].description);
            set.Bind(Temp).To(vm => vm.CurrentWeater.main.temp).WithConversion("TempToString");
            set.Bind(WindSpeed).To(vm => vm.CurrentWeater.wind.speed).WithConversion("WindToString");
            set.Bind(Pressure).To(vm => vm.CurrentWeater.main.pressure).WithConversion("PressureToString");
            set.Bind(Humidity).To(vm => vm.CurrentWeater.main.humidity).WithConversion("HumidityTOString");
            set.Apply();
        }

    }
}