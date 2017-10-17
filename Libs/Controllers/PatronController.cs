using Libs.Models.Patron;
using LibsData.Models;
using LibsService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libs.Controllers
{

    public class PatronController : Controller
    {
        private LibsMethodsServices _services;
        public PatronController(LibsMethodsServices services)
        {
            _services = services;
        }
        public IActionResult PatronIndex()
        {
            IEnumerable<Patron> patronModels = _services.GetAllPatrons();

            var listingResult = patronModels
                .Select(result => new PatronModel
                {
                    Id = result.id,
                    FirstName = result.FirstName,
                    LastName = result.LastName
                });
            var model = new PatronModelCollection()
            {
                ListOfPatronModels = listingResult
            };
            return View(model);
        }

    }
}
