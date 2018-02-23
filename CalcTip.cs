using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcluatetip
{
	public class CalcTip
	{
		public static string CalcWithTax (double total, double tip)
		{
			double _total = total * (1.0 * tip);

			string _newTotal = Convert.ToString(_total);

			return _newTotal;
		}

		public static string CalcWithoutTax(double total, double tip)
		{
			double _total = (total / 1.13) * (1.0 * tip);

			string _newTotal = Convert.ToString(_total);

			return _newTotal;
		}
	}
}
