﻿using System.Globalization;
using System;

namespace HerancaPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (USED) " +
                "Manufacture date: " +
                ManufactureDate.ToString("dd/MM/yyyy");
        }
    }
}
