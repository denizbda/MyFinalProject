using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{   // product veritabanı ile ilgili öperasyonlar buraya yazılır.
   public interface IProductDal:IEntityRepository<Product>
    {
    }


}
