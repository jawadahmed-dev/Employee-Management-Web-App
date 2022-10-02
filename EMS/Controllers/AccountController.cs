using EMS.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly SignInManager<IdentityUser> _signInManager;

		public AccountController(UserManager<IdentityUser> userManager, 
			SignInManager<IdentityUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}
		[HttpGet]
		public ViewResult Register() {
			
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(RegisterViewModel model)
		{
			if (ModelState.IsValid) {
				
				var user = new IdentityUser { UserName = model.Email, Email = model.Email };
				var identityResult = await _userManager.CreateAsync(user, model.Password);

				if (identityResult.Succeeded) {
					await _signInManager.SignInAsync(user, false);
					return RedirectToAction("index", "home");
				}

				var errorList = identityResult.Errors;
				foreach (var error in errorList) {
					ModelState.AddModelError("", error.Description);
				}

			}

			 
			return View(model);
		}
	}
}
