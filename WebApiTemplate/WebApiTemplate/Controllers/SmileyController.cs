using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiTemplate.Service;
using WebApiTemplate.Service.Models;

namespace WebApiTemplate.Controllers
{
    [RoutePrefix("api")]
    public class SmileyController : ApiController
    {
        [Dependency]
        public ISmileyService SmileyService { get; set; }

        [HttpGet]
        [Route("Smile")]
        public async Task<IEnumerable<SmileyDto>> Get()
        {
            return await SmileyService.GetSmileysAsync();
        }
    }
}
