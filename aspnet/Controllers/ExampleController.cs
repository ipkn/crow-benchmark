using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnet.Controllers
{
  [Route("/")]
    public class ExampleController : Controller
  {
    // GET api/values
    [HttpGet]
      public string Get()
      {
        return "Hello World!";
      }

    [HttpGet("about")]
      public string GetAbout()
      {
        return "About ASP .NET Core example.";
      }

    [HttpGet("json")]
      public Response GetJson()
      {
        Response response = new Response();
        response.message = "Hello, World!";
        return response;
      }

    [HttpGet("add/{a}/{b}")]
      public int GetAdd(int a, int b)
      {
        return a + b;
      }

    // POST api/values
    [HttpPost]
      public int PostAddJson([FromBody]AddRequest value)
      {
        int sum = value.a + value.b;
        return sum;
      }
  }
}
