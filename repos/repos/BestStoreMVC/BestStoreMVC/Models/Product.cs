using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BestStoreMVC.Models
{

    /**
     Domain Model (Entity Model) que te permite crear una tabla y hacer operaciones CRUD
     */
    public class Product
    {

        [MaxLength(100)] //Límite del atributo en la base de datos
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = "";
        [MaxLength(100)]
        public string Brand { get; set; } = "";
        [MaxLength(100)]
        public string Category { get; set; } = "";
        [Precision(16,2)] //Límite del precio
        public decimal Price { get; set; }
        [MaxLength(100)]
        public string Description { get; set; } = "";
        [MaxLength(100)]
        public string ImageFileName { get; set; } = "";
        public DateTime CreateAt { get; set; }
    }
}
