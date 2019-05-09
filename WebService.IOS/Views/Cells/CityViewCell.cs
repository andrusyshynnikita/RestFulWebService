using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using RestFulWebService.Models;
using UIKit;

namespace WebService.IOS.Views.Cells
{
    public partial class CityViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("CityViewCell");
        public static readonly UINib Nib = UINib.FromName("CityViewCell", NSBundle.MainBundle);

        protected CityViewCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<CityViewCell, CityModel>();
                set.Bind(CityName).To(vm => vm.name);
                set.Bind(countre).To(vm => vm.country);
                set.Apply();
            });
        }

        public static CityViewCell Create()
        {
            return Nib.Instantiate(null, null)[0] as CityViewCell;
        }
    }
}
