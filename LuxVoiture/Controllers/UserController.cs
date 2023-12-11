using LuxVoiture.DBOps;
using LuxVoiture.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuxVoiture.Controllers
{
    public class UserController : Controller
    {

        UserOps userOps = new UserOps();

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp() 
        {   
            return View();
        
        }

        [HttpPost]
        public JsonResult RegisterUser([FromBody]UserModel user) {

            if (user.UserPwd != user.UserPwdConf)
            {
                int result = 406; // not acceptable
                return Json(result);
            }
            else
            {
                user.Id = Guid.NewGuid().ToString();
                int result = userOps.SaveUser(user);
                return Json(result);
            }
        }
    }
}
