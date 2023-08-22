using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    internal class Product
    {
        //Id
        public int Id { get; set; }

        //Kategori Id'si
        public int CategoryId { get; set; }

        //Ürün ismi
        public string ProductName { get; set; }

        //Ürün birim fiyatı
        public double UnitPrice { get; set; }

        //Ürünün stoktaki sayısı
        public int UnitsInStock { get; set; }


        //CRUD Create Read Update Delete
    }
}
