using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public DateTime CreatedAt{get;set;}
        public ICollection<Product> Product { get; set; }
    }
}
