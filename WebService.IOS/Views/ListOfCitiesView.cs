using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using RestFulWebService.ViewModels;
using System;
using WebService.IOS.Sources;

namespace WebService.IOS
{
    [MvxTabPresentation(WrapInNavigationController = true, TabName = "List of Cities")]
    public partial class ListOfCitiesView : MvxViewController<ListOfCitiesViewModel>
    {

        public ListOfCitiesView() : base(nameof(ListOfCitiesView), null)
        {
        }

        public override void ViewDidLoad()
        {
            var loadmoreHandler = new Action(() =>  ViewModel.LoadMoreCitiesCommand.Execute());

           base.ViewDidLoad();

            var source = new CityTableViewSource(ListOfCities, loadmoreHandler);
            ListOfCities.Source = source;

            var set = this.CreateBindingSet<ListOfCitiesView, ListOfCitiesViewModel>();
            set.Bind(source).To(vm => vm.Cities);
            set.Bind(source).For(v => v.SelectionChangedCommand).To(vm => vm.CityClickCommand);
            set.Apply();
        }
    }
}