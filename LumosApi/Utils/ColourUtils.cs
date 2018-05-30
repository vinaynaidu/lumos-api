using System.Collections.Generic;
using System.Drawing;

namespace LumosApi.Utils
{
    public class ColourUtils
    {
		public IList<Color> GetColourSteps(Color startColour, Color endColour, int steps)
		{
			List<Color> colorList = new List<Color>();

			for (int i = 0; i < steps; i++)
			{
				var rAverage = GetNthStepBetweenTwoNumbers(startColour.R, endColour.R, i, steps);
				var gAverage = GetNthStepBetweenTwoNumbers(startColour.G, endColour.G, i, steps);
				var bAverage = GetNthStepBetweenTwoNumbers(startColour.B, endColour.B, i, steps);

				colorList.Add(Color.FromArgb(rAverage, gAverage, bAverage));
			}

			return colorList;
		}

		private int GetNthStepBetweenTwoNumbers(int min, int max, int stepNumber, int totalSteps)
		{
			return min + ((max - min) * stepNumber / totalSteps);
		}
	}
}
