using Heron.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heron.Controllers
{
    [Route("/[controller]")]
    public class NestController : Controller
    {
        private readonly Nest _nest;

        public NestController(IOptions<Nest> nestAccessor)
        {
            _nest = nestAccessor.Value;

        }

        [HttpGet(Name = nameof(GetNest))]
        public IActionResult GetNest()
        {
            _nest.Href = Url.Link(nameof(GetNest), null);
            return Ok(_nest);
        }
    }
}
