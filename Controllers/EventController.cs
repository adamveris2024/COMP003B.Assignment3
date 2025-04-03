using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers
{
    public class EventController : Controller
    {
        [HttpGet("event/register/{eventCode}")]
        public IActionResult Register(string eventCode)
        {
            return View(eventCode);
        }

        [HttpGet("Event/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("Event/Register")]
        public IActionResult Post([FromForm] EventRegistration eventRegistration)
        {
            if (!ModelState.IsValid)
            {
                return View(eventRegistration);
            }

            return RedirectToAction("Success", eventRegistration);
        }

        [Route("success")]
        public IActionResult Success(EventRegistration eventRegistration)
        {
            return View(eventRegistration);
        }
    }
}
