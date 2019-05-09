// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace WebService.IOS
{
    [Register ("WeatherForCityView")]
    partial class WeatherForCityView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CityName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Humidity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView leftVIew { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Pressure { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Temp { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView topview { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel WeatherDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel WindSpeed { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CityName != null) {
                CityName.Dispose ();
                CityName = null;
            }

            if (Humidity != null) {
                Humidity.Dispose ();
                Humidity = null;
            }

            if (leftVIew != null) {
                leftVIew.Dispose ();
                leftVIew = null;
            }

            if (Pressure != null) {
                Pressure.Dispose ();
                Pressure = null;
            }

            if (Temp != null) {
                Temp.Dispose ();
                Temp = null;
            }

            if (topview != null) {
                topview.Dispose ();
                topview = null;
            }

            if (WeatherDescription != null) {
                WeatherDescription.Dispose ();
                WeatherDescription = null;
            }

            if (WindSpeed != null) {
                WindSpeed.Dispose ();
                WindSpeed = null;
            }
        }
    }
}