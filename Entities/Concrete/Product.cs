
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity //using abstractı sil,entities projesine sağ tıkla project reference'ı seç core'a tıkla ve IEntity' üstüne tıkla using de
    {
         //Projede ilk burayı yaptık.
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
