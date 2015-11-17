using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
	class SelectSpecials : Selector<char>
	{
		public SelectSpecials()
		{
			TSource = new List<char> { '!', '@', '#', '$', '%', '&', '*', '?', '|', '/' };
		}
	}
}
