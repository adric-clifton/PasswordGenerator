using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
	class SelectNumbers : Selector<char>
	{
		public SelectNumbers()
		{
			TSource = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
		}
	}
}
