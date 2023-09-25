using CBTeam_Model_View_Controller.Models;
using Microsoft.AspNetCore.Mvc;
namespace CBTeam_Model_View_Controller.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        [Route("obtener-todos")]
        public IActionResult GetList()
        {
            var user = new UserModel
            {
                Name = "Tomás",
                Surname = "Barrera"
            };
            return View("Index", user);
        }
    }
}
