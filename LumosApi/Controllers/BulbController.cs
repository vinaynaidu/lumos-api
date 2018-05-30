using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LumosApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LumosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/bulb")]
    public class BulbController : Controller
    {
		[HttpGet]
		public IEnumerable<Bulb> Get()
		{
			List<Bulb> bulbs = new List<Bulb>();

			// Return all bulb statuses
			return new List<Bulb>();
		}

		[HttpPost]
		public bool Post(int bulbId)
		{
			return true;
		}
    }
}