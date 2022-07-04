using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.VBTest = "Thử viewbag xem thế nào";

            var message = new MessageModel();
            message.welcome = "Thử dùng model để tạo message ra màn hình xem sao";
            return View(message);
        }
    }
}
