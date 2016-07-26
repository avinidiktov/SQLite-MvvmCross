using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCrossSQLite.Core.Models;
using SQLite.Net;

namespace MvvmCrossSQLite.Core.Services
{
    public interface IDBService
    {
        void Save(Category item);

        Category Load();

        SQLiteConnection GetContext();

        IEnumerable<Category> LoadItems();
    }
}
