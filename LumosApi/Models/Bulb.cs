using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumosApi.Models
{
    public class Bulb
    {
		public bool IsOn { get; set; }
		public string Label { get; set; }
		public string Hue { get; set; }
		public string Saturation { get; set; }
		public string Version { get; set; }

		public Colour Colour { get; set; }
	}
}
