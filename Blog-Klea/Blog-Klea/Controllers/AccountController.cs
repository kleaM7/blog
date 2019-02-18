using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Blog_Klea.Models;

namespace Blog_Klea.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnurl)
        {
            return View(new LoginModel() {
                ReturnURL = returnurl
            }
            );
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
                return View(loginModel);
            var user = await _userManager.FindByNameAsync(loginModel.UserName);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginModel.Password, false, false);
                if(result.Succeeded)
                {
                    if(string.IsNullOrEmpty(loginModel.ReturnURL))
                        return RedirectToAction("Index", "Home");
                    return Redirect(loginModel.ReturnURL);
                }
            }
            ModelState.AddModelError("", "Username/password not found");
            return View(loginModel);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Register(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = loginModel.UserName };
                var result = await _userManager.CreateAsync(user, loginModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(loginModel);
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }
    }
}