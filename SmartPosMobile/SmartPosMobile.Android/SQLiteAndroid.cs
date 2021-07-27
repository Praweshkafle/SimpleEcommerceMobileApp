using SmartPosMobile.Droid;
using SmartPosMobile.Models;
using SQLite;
using System.IO;
using Xamarin.Forms;
 
[assembly: Dependency(typeof(SQLiteAndroid))]
namespace SmartPosMobile.Droid
{
   public static class SQLiteAndroid
    {
        private static SQLiteConnection Connection;

       static object obj = new object();
        public static SQLiteConnection GetConnection()
        {
            if (Connection == null)
                Create();
            var dbName = "smartPosDb.sqlite";
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbPath,dbName);
            var conn = new SQLiteConnection(path);
            return conn;
        }
        public static void Create()
        {
            Connection.CreateTable<Items>();
        }
        public static void Insert(Items model)
        {
            lock (obj)
            {
                GetConnection();
                Connection.Insert(model);
            }
        }
        public static void Delete(long Id)
        {
            lock (obj)
            {
                GetConnection();
                Connection.Delete(Id);
            }
        }
     
    }
}