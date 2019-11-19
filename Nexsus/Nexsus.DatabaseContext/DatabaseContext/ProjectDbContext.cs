using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using  Nexsus.Model.Model;

namespace Nexsus.DatabaseContext.DatabaseContext
{
   public class ProjectDbContext : DbContext
    {
        public DbSet<CategoryModel> CategoryDatabaSet { set; get; }
        public DbSet<SupplierModel> SupplierDataBaseSet { set; get; }



    }
}
