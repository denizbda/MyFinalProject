using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager(ICategoryDal categoryDal)
    {   
        

        public List<Category> GetAll()
        {   //iş kodları
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            
        }
    }
}
