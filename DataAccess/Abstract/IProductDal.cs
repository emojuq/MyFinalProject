using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Dal - DataAccessLayer
    //IEntityRepository'i Core'dan sonra hata veriyorsa üstüne tıkla add reference core de

   public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
     
    }
}
