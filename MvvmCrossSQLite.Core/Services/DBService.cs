using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Plugins.Sqlite;
using MvvmCrossSQLite.Core.Models;
using SQLite.Net;

namespace MvvmCrossSQLite.Core.Services
{
    public class DBService : IDBService
    {
        private readonly SQLiteConnection _connection;

        public DBService(IMvxSqliteConnectionFactory factory)
        {
            _connection = factory.GetConnection("data.dat");
            _connection.CreateTable<Category>();
            _connection.CreateTable<Product>();
        }

        public SQLiteConnection GetContext()
        {
            return _connection;
        }

        public void Save(Category item)
        {
            _connection.Insert(item);
        }

        public Category Load()
        {
            return _connection.Table<Category>().LastOrDefault();
        }


        public IEnumerable<Category> LoadItems()
        {
            return _connection.Table<Category>();
        }
    }
}
