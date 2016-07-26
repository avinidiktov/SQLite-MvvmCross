using System.Collections.Generic;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace MvvmCrossSQLite.Core.Models
{
    [Table("Category")]
    public class Category
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Value { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeRead | CascadeOperation.CascadeInsert)]
        public List<Product> Products { get; set; }
    }
}
