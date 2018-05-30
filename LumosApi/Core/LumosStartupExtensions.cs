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
		public static void InitialiseBulbs(this IApplicationBuilder app)
		{
			var bulbService = app.ApplicationServices.GetRequiredService<BulbStartupService>();
			bulbService.InitialiseBulbs();
		}
    }
}
