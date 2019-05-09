// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace WebService.IOS.Views.Cells
{
    [Register ("CityViewCell")]
    partial class CityViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CityName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel countre { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CityName != null) {
                CityName.Dispose ();
                CityName = null;
            }

            if (countre != null) {
                countre.Dispose ();
                countre = null;
            }
        }
    }
}