using EShop.Core.Convertors;
using EShop.Core.DTOs.User;
using EShop.Core.Generator;
using EShop.Core.Security;
using EShop.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Controllers
{
    public class AccountController(IUserService service) : Controller
    {
        [HttpGet("Register")]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if(await service.IsExistUserName(model.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری وارد شده تکراری است");
                return View(model);
            }

            if (await service.IsExistEmail(FixedEmail.FixEmail(model.Email)))
            {
                ModelState.AddModelError("Email",errorMessage:"ایمیل وارد شده تکراری میباشد");
                return View(model);
            }

            var user = new User()
            {
                UserName = model.UserName,
                Email =FixedEmail.FixEmail(model.Email) ,
                Password =PasswordHelper.EncodePasswordMd5(model.Password) ,
                IsActive = false,
                RegisterDate = DateTime.Now,
                ActiveCode = CodeGenerator.GenerateUniqCode(),
                Avatar = "default.png"

            };
             await service.AddUser(user);

            return View("SuccessRegister",user);
        }
    }
}
