// Add-Migration "first migration"
//Update-Database
// Add-Migration "second migration"
//Update-Database
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Models
{
    public class Item

    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }

        // one to one
        public int? SeriaNumberId { get; set; }
        public SeriaNumber? SeriaNumber { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        public List<ItemClient>? ItemClients { get; set; }
    }
    //   /item/overview  controller class name, action method is after
}
