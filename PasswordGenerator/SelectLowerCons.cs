using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
	class SelectLowerCons : Selector<char>
	{
		public SelectLowerCons()
		{
			TSource = new List<char> {
				'b', 'c', 'd', 'f', 'g', 'h', 'j',
				'k', 'l', 'm', 'n', 'p', 'q', 'r', 
				's', 't', 'v', 'w', 'x', 'y', 'z' };
		}
	}
}
