using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nexsus.Model.Model;
using Nexsus.DatabaseContext.DatabaseContext;

namespace Nexsus.Repository.Repository
{
  public  class SupplierRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public bool Add(SupplierModel supplierModel)
        {
            //int i = _dbContext.SupplierDataBaseSet
            //    .Where(c => c.Code == supplierModel.Code || c.Name == supplierModel.Name).Count();



            //if (i > 0)
            //{
            //    return false;
            //}

            _dbContext.SupplierDataBaseSet.Add(supplierModel);
            return _dbContext.SaveChanges() > 0;
        }

        public List<SupplierModel> GetAll()
        {

            return _dbContext.SupplierDataBaseSet.ToList();
        }

        //public CategoryModel GetById(int id)
        //{

        //    return _dbContext.CategoryDatabaSet.FirstOrDefault((c => c.Id == id));
        //}

        //public bool Update(CategoryModel category)
        //{
        //    CategoryModel aCategoryModel = _dbContext.CategoryDatabaSet.FirstOrDefault(c => c.Id == category.Id);
        //    if (aCategoryModel != null)
        //    {
        //        aCategoryModel.Code = category.Code;
        //        aCategoryModel.Name = category.Name;

        //    }

        //    return _dbContext.SaveChanges() > 0;
        //}
    }
}
