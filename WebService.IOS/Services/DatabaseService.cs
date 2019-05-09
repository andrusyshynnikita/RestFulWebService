using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using RestFulWebService.Interfaces;
using SQLite;
using UIKit;

namespace WebService.IOS.Services
{
    public class DatabaseService : IDatabaseService
    {
        private SQLiteConnection _connect;
        public SQLiteConnection CreateDBConnection()
        {
            try
            {
                var dbName = "City.db";
                var path = Path.Combine(System.Environment.
                  GetFolderPath(System.Environment.
                  SpecialFolder.Personal), dbName);
                var existingDb = NSBundle.MainBundle.PathForResource("City", "db");
                if (!File.Exists(path))
                {
                    File.Copy(existingDb, path);
                }
                _connect = new SQLiteConnection(path);
                return _connect;
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return _connect;
            }
        }
    }
}