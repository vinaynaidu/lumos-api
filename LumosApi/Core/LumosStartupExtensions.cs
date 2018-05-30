using LumosApi.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumosApi.Core
{
    public static class LumosStartupExtensions
    {
		public static IApplicationBuilder HandshakeBulbs(this IApplicationBuilder app)
		{
			var bulbHandshake = app.ApplicationServices.GetRequiredService<BulbService>();

			return app;
		}
    }
}
