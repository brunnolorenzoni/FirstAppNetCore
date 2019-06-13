using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ualmarti.Models;
using Ualmarti.Models.ViewModel;
using Ualmarti.Services;

namespace Ualmarti.Controllers
{
    public class SellersController : Controller
    {

        //Injeção de independecia
        private readonly SellerService _sellerService;
        private readonly DepartamentService _departamentService;

        public SellersController(SellerService sellerService, DepartamentService departamentService)
        {
            _sellerService      = sellerService;
            _departamentService = departamentService;
        }

        public IActionResult Index()
        {
            var sellerList      = _sellerService.FindAll();
            
            return View(sellerList);
        }

        /*GET*/
        public IActionResult Create()
        {

            var departamentList = _departamentService.FindAll();

            var viewModel = new SellerFormViewModel { Departaments = departamentList };

            return View(viewModel);
        }

        /*POST*/
        [HttpPost]
        public IActionResult Create(Seller seller)
        {

            _sellerService.Insert(seller);

            return RedirectToAction("Index");

        }

    }
}