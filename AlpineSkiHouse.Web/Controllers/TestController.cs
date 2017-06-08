using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace AlpineSkiHouse.Web.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            dynamic result = new ExpandoObject();
            result.FirstName = "Adrian";
            result.LastName = "Sanchez";
            return new JsonResult(result);
        }
    }
}
