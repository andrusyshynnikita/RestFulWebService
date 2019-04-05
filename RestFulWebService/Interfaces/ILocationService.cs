using System;
using System.Collections.Generic;
using System.Text;

namespace RestFulWebService.Interfaces
{
  public  interface ILocationService
    {
        double GetLatitude();
        double GetLongitude();
    }
}
