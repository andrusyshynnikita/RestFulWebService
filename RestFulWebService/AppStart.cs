using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using RestFulWebService.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestFulWebService
{
    public class AppStart : MvxAppStart
    {
        private IMvxNavigationService _mvxNavigationService;

        public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService)
            : base(app, mvxNavigationService)
        {
            _mvxNavigationService = mvxNavigationService;
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
           return _mvxNavigationService.Navigate<MainViewModel>();
        }
    }
}
