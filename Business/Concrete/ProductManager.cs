using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
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
        
        
	

	
      

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorResult();
            }

            // bu bir Expression'dır. bunu kullanabilmek için  IEntityRepository^'da expression sytnax'ı eklenmelidir.
            return new SuccessDataReuslt<List<Product>>(_productDal.GetAll(), true, "ürünler listelendi");
                 

        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
           
            }
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }



        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        IDataResult<List<Product>> IProductService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Product>> IProductService.GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Product>> IProductService.GetAllByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<ProductDetailDto>> IProductService.GetProductDetails()
        {
            throw new NotImplementedException();
        }

        IDataResult<Product> IProductService.GetById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
