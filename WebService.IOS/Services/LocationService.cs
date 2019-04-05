using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreLocation;
using Foundation;
using RestFulWebService.Interfaces;
using UIKit;

namespace WebService.IOS.Services
{
   public class LocationService: ILocationService
    {
        CLLocationManager locationManager;
        public LocationService()
        {
            locationManager = new CLLocationManager();
            locationManager.RequestWhenInUseAuthorization();

        }

        public double GetLatitude()
        {
            var latitude= locationManager.Location.Coordinate.Latitude;
            return latitude;
        }

        public double GetLongitude()
        {
            var longitude = locationManager.Location.Coordinate.Longitude;
            return longitude;
        }
    }
}