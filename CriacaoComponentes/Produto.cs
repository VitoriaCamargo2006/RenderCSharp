﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoComponentes
{
    internal class Produto
    {
      

        private string Name { get; set; }
        private double Price { get; set; }
        private int Quant { get; set; }
        private string Desc { get; set; }

        public Produto(string name, double price, string desc, int quant)
        {
            Name = name;
            Price = price;
            Quant = quant;
            Desc = desc;
            
        }
    }
}
