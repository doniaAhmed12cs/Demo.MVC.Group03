﻿using Demo.DAL.Models;
using Demo.Pl.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.Pl.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser>userManager,
			SignInManager<ApplicationUser> signInManager)
		{
			_userManager = userManager;
            _signInManager = signInManager;
        }
		#region Register
		//Register
		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Register(RegisterViewModel model)
		{
			if (ModelState.IsValid)// Server Side Validation
			{
				var User = new ApplicationUser()
				{
					UserName = model.Email.Split('@')[0],
					Email = model.Email,
					IsAgree=model.IsAgree,
					FirstName = model.FirstName,
					LastName = model.LastName,

				};
				 var Result = await  _userManager.CreateAsync(User,model.Password);
				 if ( Result.Succeeded )
				{

					return RedirectToAction(nameof(Login));
				}
				else
				{
					foreach( var error in Result.Errors )
					{
						ModelState.AddModelError(string.Empty, error.Description);
					}
				}

			}
			return View(model);
		}

		#endregion
		#region Login
		// Login
		[HttpGet]
		 public IActionResult Login()
		{
return View();
		}
		[HttpPost]
		public async Task <IActionResult> Login (LoginViewModel model)
		{
			if (ModelState.IsValid)// Server Side Validation
			{
				 var User = await _userManager.FindByEmailAsync(model.Email);
				 if ( User is not null)
				{
					 var Result = await _userManager. CheckPasswordAsync(User, model.Password);
					if ( Result )
					{
						// Login
					 var LoginResult=await _signInManager.PasswordSignInAsync(User, model.Password, model.RememberMe, false);
                         if (LoginResult.Succeeded)
						{
							return RedirectToAction("index", "Home");
						}
					}
					else
					{
						ModelState.AddModelError(string.Empty, "Passowrd Is Incorrect");
					}

				}
				  else
				{
					ModelState.AddModelError(string.Empty, " Email is not Exists");
				}

			}


			return View(model);


		}
		#endregion
		#region SignOut
		public  new async Task <IActionResult>SignOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction(nameof(Login));
		}
		#endregion





		//Login
		//Sign Out
		// Forgert Passowrd
		// Reset Password

	}

}
