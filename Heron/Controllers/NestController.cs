using Heron.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Heron.Controllers
{
    [Route("/[controller]")]
    public class NestController : Controller
    {

        [HttpGet(Name = nameof(GetNests))]
        public IActionResult GetNests()
        {
            NestCollection nestCol = new NestCollection();
            var nestDir = Path.Combine(Directory.GetCurrentDirectory() ,"wwwroot");
            var nestFiles = Directory.GetFiles(nestDir);
            nestCol.Href = Url.Link(nameof(GetNests), null);
            nestCol.NestFiles = nestFiles;
            return Ok(nestCol);
        }


        public IActionResult GetEggs(string nest, string egg)
        {
            Nest nestObj = new Nest();
            
            var nestFile= Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", nest);
            // TODO: Read the nest file and return the value for the egg info
            nestObj.Href = Url.Link(nameof(GetEggs), null);
            return Ok(nestObj);
        }
    }
}
