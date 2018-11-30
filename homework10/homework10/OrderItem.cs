﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    public class OrderItem
    {
        [Key]
        public string Id { get; set; }
        public string Product { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity{ get; set; }

        public OrderItem()
        {
            Id = Guid.NewGuid().ToString();
        }
        public OrderItem(string id,string product,double unitprice,int quantity)
        {
            Id = id;
            Product = product;
            UnitPrice = unitprice;
            Quantity = quantity;
        }
    }
}
