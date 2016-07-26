using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace MvvmCrossSQLite.Core.Models
{
    [Table("Product")]
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey(typeof(Category))]
        public int CategoryId { get; set; }
        
        [ManyToOne]
        public Category Category { get; set; }
    }
}
