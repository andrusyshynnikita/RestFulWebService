using Newtonsoft.Json;
using RestFulWebService.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestFulWebService.ViewModels
{
  public  class ListOfCitiesViewModel : BaseViewModel
    {
        public ListOfCitiesViewModel()
        {
          //  LoadCities();
        }

        public void LoadCities()
        {
            using (StreamReader r = new StreamReader("current.city.list.json"))
            {
                string json = r.ReadToEnd();
                List<CityModel> items = JsonConvert.DeserializeObject<List<CityModel>>(json);
            }
        }
    }
}
