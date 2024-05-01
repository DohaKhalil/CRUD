using Crud.core.Model;
using System.ComponentModel.DataAnnotations;

namespace CRUDSystem.Model
{
    //The system should provide a user interface with fields such as item name, description, quantity,
    public class Producte : BaseEntity
    {

        public string ProducteName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; } //Foreign key :Not Allow Null
        public Categorey ProducteCategory { get; set; } //Navigation proprety [One to]
    }
}



