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
    [Register ("ListOfCitiesView")]
    partial class ListOfCitiesView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView ListOfCities { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ListOfCities != null) {
                ListOfCities.Dispose ();
                ListOfCities = null;
            }
        }
    }
}