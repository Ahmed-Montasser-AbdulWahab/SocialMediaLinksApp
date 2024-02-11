using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SocialMediaLinksApp.Models.Options;

namespace SocialMediaLinksApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<SocialMediaLinks> _socialMediaLinks;

        public HomeController(IOptions<SocialMediaLinks> socialMediaLinks)
        {
            _socialMediaLinks = socialMediaLinks;
        }

        [Route("/")]
        public IActionResult Index()
        {

            return View(model:_socialMediaLinks.Value);
        }
    }
}
