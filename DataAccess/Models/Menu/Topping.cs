using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Menu
{
    public class Topping
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public decimal? PriceMod { get; set; }


        public Topping()
        {
            
        }

        public Topping(int id, string? name, decimal? price)
        {
            Id = id;
            Name = name;
            PriceMod = price;
        }

    }


}
