using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal productDal)
        {
            _categoryDal = productDal;
        }
        public List<Category> GetAll()
        {
            //iş kodları
           return _categoryDal.GetAll();
        }

        public List<Category> GetById(int categoryId)
        {
            return _categoryDal.GetAll(p => p.CategoryId == categoryId).ToList();
        }
    }
}
