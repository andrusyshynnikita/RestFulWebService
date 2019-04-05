using Foundation;
using MvvmCross.Platforms.Ios.Core;
using RestFulWebService;
using UIKit;

namespace WebService.IOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);
            return result;
        }
    }
}


