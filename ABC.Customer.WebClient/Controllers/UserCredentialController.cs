using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABCDiscountWebSite.Areas.Security.Controllers
{
    public class UserCredentialController : Controller
    {
        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}
