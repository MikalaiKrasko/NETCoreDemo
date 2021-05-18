using System.Collections.Generic;

namespace Blog.DataProvider.Models
{
    public class Order
    {
        public Order()
        {
            Products = new HashSet<Post>();
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Post> Products { get; set; }
    }
}
