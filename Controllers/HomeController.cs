using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TICTAC.Models;
using TICTAC.Services;

namespace TICTAC.Controllers
{
    public class HomeController : Controller
    {
        #region variables

        private readonly ITictacService _serviceTictac;

        #endregion

        #region ctr

        public HomeController(ITictacService serviceTictac)
        {
            this._serviceTictac = serviceTictac;
        }

        #endregion

        #region Actions

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ValueModel value)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    @TempData["Message"] = _serviceTictac.CheckValue(value.number);
                    return View();
                }
                else
                {
                    return View();
                }                
            }
            catch
            {
                var error = "An error occurred while processing your request. !!";
                TempData["Message"] = error;
                return View();
            }
        }

        #endregion
    }
}
