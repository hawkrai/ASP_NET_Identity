using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Test.Model.Model;

namespace Test_Aut_Project.Controllers
{
	public class HomeController : Controller
	{
		
		public ActionResult Index()
		{
			var userM = new ApplicationUserManager();
			userM.Create(new ApplicationUser(){UserName = "admin"},"12345678");
			return View();
		}

		
	}
}