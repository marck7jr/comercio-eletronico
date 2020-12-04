using System.Collections.Generic;

namespace ComercioEletronico.WebAPI.Data.Models
{
    public class Order : ApplicationDbContextEntry
    {
        public double Extras { get; set; }
        public List<Product> Products { get; set; }
        public Client Client { get; set; }
    }
}
