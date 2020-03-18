using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        static private string uname = "";
        static private string uemail = "";
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.username = uname;
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.username = uname;
            ViewBag.email = uemail;
            return View();
        }

        [HttpPost]
        [Route("/User/Add")]
        public IActionResult Add(User user, string verify)
        {
            uname = user.Username;
            uemail = user.Email;

            if (user.Password != null && verify != null)
            {
                if (user.Password.Equals(verify))
                {
                    return Redirect("/User");
                }
                else
                {
                    return Redirect("/User/Add");
                }
            }
            else
            {
                return View();
            }
        }
    }
}
