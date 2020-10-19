using System.Collections.Generic;

namespace Ogorodik.DataProvider.Models
{
    public class Order
    {
        public Order()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
