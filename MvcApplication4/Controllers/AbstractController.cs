using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication4.Controllers
{
    public class AbstractController : Controller
    {
        protected override void HandleUnknownAction(string actionName)
        {
            Response.Redirect("https://www.google.com.tw/");
        }
    }

    public class AbstractAction : ActionResult
    {

        public override void ExecuteResult(ControllerContext context)
        {           
            throw new NotImplementedException();
        }
    }
}
