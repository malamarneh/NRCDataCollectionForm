using System.Web.Mvc;

namespace NRCDataCollectionForm.Web.Controllers
{
    public class HomeController : NRCDataCollectionFormControllerBase
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
	}
}