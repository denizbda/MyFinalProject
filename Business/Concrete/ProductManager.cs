using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
       
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IEnumerable<object> GetByUnitPrice(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //iş kodları

            return _productDal.GetAll(); // bu bir Expression'dır. bunu kullanabilmek için  IEntityRepository^'da expression sytnax'ı eklenmelidir.


        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }
    }
}
