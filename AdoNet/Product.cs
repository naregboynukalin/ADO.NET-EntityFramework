﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPice { get; set; }
        public int StockAmount { get; set; }

    }
}
