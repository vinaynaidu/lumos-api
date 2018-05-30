using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LumosApi.Core;
using LumosApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LumosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/bulb")]
    public class BulbController : Controller
    {
		private readonly LumosContext lumosContext;

		protected BulbController(LumosContext lumosContext)
		{
			this.lumosContext = lumosContext;
		}

		[HttpGet]
		public IEnumerable<Bulb> Get()
		{
			List<Bulb> bulbs = new List<Bulb>();

			foreach(var bulb in this.lumosContext.Bulbs)
			{
				//Bulb b = new Bulb(b);
				//bulbs.Add(b);
			}

			// Return all bulb statuses
			return new List<Bulb>();
		}
    }
}