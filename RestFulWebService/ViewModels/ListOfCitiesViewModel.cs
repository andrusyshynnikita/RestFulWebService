using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Newtonsoft.Json;
using RestFulWebService.Interfaces;
using RestFulWebService.Models;
using SQLite;
using System;
using System.IO;
using System.Threading.Tasks;

namespace RestFulWebService.ViewModels
{
    public class ListOfCitiesViewModel : BaseViewModel
    {
        #region Variables
        private readonly SQLiteConnection _databaseService;
        private MvxObservableCollection<CityModel> _cities;
        private int _coutCities = 0;
        #endregion

        #region Constructors
        public ListOfCitiesViewModel(IMvxNavigationService mvxNavigationService,IDatabaseService databaseService) : base(mvxNavigationService)
        {
            _databaseService = databaseService.CreateDBConnection();
            LoadMoreCitiesCommand = new MvxCommand(CitiesLazyLoad);
            CityClickCommand = new MvxAsyncCommand<CityModel>(OnCityClick);
        }
        #endregion

        #region LifeCycle
        public override void ViewAppearing()
        {
            CitiesLazyLoad();
        }
        #endregion

        #region Commands
        public IMvxCommand LoadMoreCitiesCommand { get; set; }
        public IMvxCommand<CityModel> CityClickCommand { get; set; }
        #endregion

        #region Properties
        public MvxObservableCollection<CityModel> Cities
        {
            get
            {
                if (_cities == null)
                {
                    _cities = new MvxObservableCollection<CityModel>();
                }
                return _cities;
            }
            set
            {
                _cities = value;
                RaisePropertyChanged(() => Cities);
            }
        }
        #endregion

        #region Methods
        private  void CitiesLazyLoad()
        {
            try
            {
                var items =  _databaseService.Query<CityModel>(String.Format("SELECT * FROM `CityModel` LIMIT {0}, 10", _coutCities));
                Cities.AddRange(items);
                _coutCities += 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private async Task OnCityClick(CityModel item)
        {
            await _mvxNavigationService.Navigate<WeatherForCityViewModel, CityModel>(item);
        }
        #endregion
    }
}
