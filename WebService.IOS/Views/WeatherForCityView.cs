using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using RestFulWebService.ViewModels;
using System;

namespace WebService.IOS
{
    public partial class WeatherForCityView : MvxViewController<WeatherForCityViewModel>
    {
        public WeatherForCityView() : base(nameof(WeatherForCityView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<WeatherForCityView, WeatherForCityViewModel>();
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