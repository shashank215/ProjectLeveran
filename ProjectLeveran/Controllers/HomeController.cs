using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectLeveran.Models;
using System.Threading.Tasks;

namespace ProjectLeveran.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We run your errands while you do more important things in life.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get In Touch.";

            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Services We Offer";

            return View();
        }
        public ActionResult BookService()
        {
            ViewBag.Message = "Book A Service";

            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
       // public async Task<ActionResult> Book(BookServiceViewModel model, string returnUrl)
         public  ActionResult Book(BookServiceViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
             return RedirectToLocal(returnUrl);
            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            //var result=SignInStatus.Success//=await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);
            //switch (result)
            //{
            //    case SignInStatus.Success:
            //        return RedirectToLocal(returnUrl);
            //    case SignInStatus.LockedOut:
            //        return View("Lockout");
            //    case SignInStatus.RequiresVerification:
            //        return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
            //    case SignInStatus.Failure:
            //    default:
            //        ModelState.AddModelError("", "Invalid login attempt.");
            //        return View(model);
            //}
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

    }
}