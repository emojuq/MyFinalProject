using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Order:IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }

        //Entities'te yeni bir class oluşturulurken şu yol izlenir;
        // 1-class IEntity ile eşleşir
        // 2-DataAccess'te Abstract kısmında IOrderDal adlı bir interface oluşturulur, IEntityRepositoryBase<Order> ile eşleşir
        // 3-DataAccess'te EntityFramework kısmında EfOrderDal adlı class oluşturulur, EfEntityRepositoryBase<Order,Northwindcontext>,IOrderDal ile eşleşir
        // 4-NorthwindContext adlı class'a gidilir   public DbSet<Order> Orders { get; set; } kodu ile sql tablo bağlantısı kurulur
        // 5-Business abstract içinde IOrderService adlı interface açılır
        // 6-Business Concrete içinde OrderManager yazılır IOrderService ile implemente edilir.
    }
}
