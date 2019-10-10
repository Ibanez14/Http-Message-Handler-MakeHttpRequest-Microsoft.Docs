using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeHttpRequest.HttpHandlers;
using Microsoft.AspNetCore.Mvc;

namespace MakeHttpRequest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly GithubService gitService;

        public ValuesController(GithubService gitService)
        {
            this.gitService = gitService;

            gitService.Send();

        }



        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

    
    }
}
