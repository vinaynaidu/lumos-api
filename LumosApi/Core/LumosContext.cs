using LifxNet;
using LumosApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumosApi.Core
{
    public class LumosContext : DbContext
    {
		public LumosContext(DbContextOptions<LumosContext> options)
			: base(options)
		{
		}

		public DbSet<LightBulb> Bulbs { get; set; }
	}
}
