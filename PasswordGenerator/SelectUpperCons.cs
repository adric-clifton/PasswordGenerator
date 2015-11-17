using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
	class SelectUpperCons : Selector<char>
	{
		public SelectUpperCons()
		{
			TSource = new List<char> {
				'B', 'C', 'D', 'F', 'G', 'H', 'J',
				'K', 'L', 'M', 'N', 'P', 'Q', 'R', 
				'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
		}
	}
}
