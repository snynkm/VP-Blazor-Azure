﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Menu
{
    public class ToppingDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? PriceMod { get; set; }
        public bool? IsChecked { get; set; } = false;


    }
}
