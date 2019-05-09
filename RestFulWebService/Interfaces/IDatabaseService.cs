using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestFulWebService.Interfaces
{
  public  interface IDatabaseService
    {
        SQLiteConnection CreateDBConnection();
    }
}
