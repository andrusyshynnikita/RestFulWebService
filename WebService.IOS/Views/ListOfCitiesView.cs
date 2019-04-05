using Foundation;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using RestFulWebService.ViewModels;
using System;

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
            base.ViewDidLoad();
        }
    }
}