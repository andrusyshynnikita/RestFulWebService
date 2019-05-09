using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestFulWebService.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        #region Variables
        private bool _isNetChecking;
        protected readonly IMvxNavigationService _mvxNavigationService;
        #endregion

        #region Constructors
        public BaseViewModel(IMvxNavigationService mvxNavigationService) : this()
        {
            _mvxNavigationService = mvxNavigationService;
        }
        public BaseViewModel()
        {
            CheckCurrentConnectivity();

            CrossConnectivity.Current.ConnectivityChanged += delegate { CheckCurrentConnectivity(); };
        }
        #endregion

        #region LifeCycle
        #endregion

        #region Properties
        public bool IsNetChecking
        {
            get
            {
                return _isNetChecking;
            }
            set

            {
                _isNetChecking = value;
                RaisePropertyChanged(() => IsNetChecking);
            }
        }
        #endregion

        #region Methods
        public void CheckCurrentConnectivity()
        {

            if (CrossConnectivity.Current.IsConnected)
            {
                IsNetChecking = true;
            }

            if (!CrossConnectivity.Current.IsConnected)
            {
                IsNetChecking = false;
            }
        }
        #endregion
    }

    public abstract class BaseParameterViewModel<TParameter> : BaseViewModel, IMvxViewModel<TParameter>, IMvxViewModel
    {
        private TParameter _parameter;

        public abstract void Prepare(TParameter parameter);
    }
}
