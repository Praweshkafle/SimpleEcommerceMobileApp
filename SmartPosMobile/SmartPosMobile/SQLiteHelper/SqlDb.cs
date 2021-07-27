using SmartPosMobile.Models;
using SmartPosMobile.SQLiteHelper;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Essentials;

namespace SmartPosMobile.Helper
{
  public class SqlDb
    {
        private static SQLiteConnection Connection;

        static object obj = new object();
        public static void GetConnection()
        {
            //if (Connection == null)
            //    Connection.CreateTable<Items>();
            //var dbName = "smartPosDb.sqlite";
            //var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            //var path = Path.Combine(dbPath, dbName);
            //Connection= new SQLiteConnection(path);
            //return Connection;
            if (Connection==null)
            {
                var databasePath = Path.Combine(FileSystem.AppDataDirectory, "SmartPOS");
                Connection = new SQLiteConnection(databasePath);
                Connection.CreateTable<Items>();
            }
        }

        public static void TableCreate()
        {
            GetConnection();
        }
        public static string getLocation
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, "SmartPOS");
            }
        }

        public static void DeleteCache()
        {
            try
            {
                File.Delete(getLocation);
            }
            catch
            {
            }
        }
        public static void Insert(Items model)
        {
            lock (obj)
            {
                if (Connection == null)
                {
                    TableCreate();
                }
                Connection.Insert(model);
            }
        }
        public static void Delete(long Id)
        {
            if (Connection== null)
            {
                TableCreate();
            }
                Connection.Delete<Items>(Id);
        }
        public static Items GetId(long Id)
        {
            lock (obj)
            {
                if (Connection == null)
                {
                    TableCreate();
                }
                return Connection.Table<Items>().FirstOrDefault(a => a.Id == Id);
            }
        }

        public static List<Items> GetAll()
        {
            if (Connection == null)
            {
                TableCreate();
            }
            return Connection.Table<Items>().ToList();
        }
    }
}

