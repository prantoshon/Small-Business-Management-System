using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Nexsus.Model.Model;
using Nexsus.Models;
using Nexsus.BLL.Manager;

namespace Nexsus.Controllers
{
    public class SupplierController : Controller
    {
        // GET: Supplier

        SupplierModel  _supplierModel = new SupplierModel();
         SupplierManger _supplierManger = new SupplierManger();


         public ActionResult Add()
         {

             SupplierViewModel supplierViewModel = new SupplierViewModel();

             supplierViewModel.Suppliers = _supplierManger.GetAll();
             return View(supplierViewModel);
         }


         [HttpPost]
         public ActionResult Add(SupplierViewModel supplierViewModel)
         {



             string message;
             if (ModelState.IsValid)
             {


                 SupplierModel supplier = Mapper.Map<SupplierModel>(supplierViewModel);
                
                 
                     if (_supplierManger.Add(supplier))
                     {

                         message = "Saved";
                     }
                     else
                     {
                         message = "Not Saved";
                     }
                 


             }
             else
             {
                 message = "ModelState Failed";
             }



          
             ViewBag.Message = message;
             supplierViewModel.Suppliers = _supplierManger.GetAll();
             return View(supplierViewModel);
         }
    }
}