using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nexsus.Model.Model;
using Nexsus.Repository.Repository;

namespace Nexsus.BLL.Manager
{
   public class SupplierManger
    {
        SupplierRepository _supplierRepository = new SupplierRepository();
        public bool Add(SupplierModel supplierModel)
        {
            return _supplierRepository.Add(supplierModel);
        }

        public List<SupplierModel> GetAll()
        {
            return _supplierRepository.GetAll();
        }
    }
}
