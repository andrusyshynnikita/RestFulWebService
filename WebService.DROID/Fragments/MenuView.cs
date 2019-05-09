using System.Threading.Tasks;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using RestFulWebService.ViewModels;

namespace WebService.DROID.Fragments
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.navigation_frame)]
    public class MenuView : MvxFragment<MenuViewModel>, NavigationView.IOnNavigationItemSelectedListener
    {
        private NavigationView _navigationView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.MenuLayout, null);
            _navigationView = view.FindViewById<NavigationView>(Resource.Id.navigation_view);
            _navigationView.SetNavigationItemSelectedListener(this);
            return view;
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            Navigate(item.ItemId);

            return true;
        }

        private async Task Navigate(int itemId)
        {
            switch (itemId)
            {
                case Resource.Id.nav_currentWeather:
                    ViewModel.ShowCurrentWeatherViewModelCommand.Execute(null);
                    break;
                case Resource.Id.nav_listOfCities:
                    ViewModel.ShowListOfCitiesViewModelCommand.Execute(null);
                    break;
            }
        }
    }
}