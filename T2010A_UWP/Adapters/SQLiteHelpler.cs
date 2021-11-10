using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using Windows.Storage;
using System.IO;
namespace T2010A_UWP.Adapters
{
    class SQLiteHelpler
    {
        private readonly string dbName = "t2010a.db";

        private static SQLiteHelpler instance;

        
        private SQLiteHelpler()
        {
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);
            SQLiteConnection = new SQLiteConnection(path); // tao ket noi db cua SQLite

            // tao bang Cart: Id Name Image Price Qty
            var sql_txt = @"create table if not exists Cart(Id integer primary key,Name varchar(255), Image varchar(255), Price integer,Qty integer)";
            var statement = SQLiteConnection.Prepare(sql_txt);
            statement.Step();

        }

        public SQLiteConnection SQLiteConnection { get; set; }

        public static SQLiteHelpler GetInstance()
        {
            if (instance == null)
                instance = new SQLiteHelpler();
            return instance;
        }
    }
}
