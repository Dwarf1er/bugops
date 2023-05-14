using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bugops.Controllers {
    public class RoleController : Controller {
        public IActionResult Index() {
            return View();
        }

        [Authorize(Policy = "RequireAdministrator")]
        public IActionResult Administrator() {
            return View();
        }
    }
}
