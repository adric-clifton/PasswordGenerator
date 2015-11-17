using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
	class SelectLowerVowels : Selector<char>
	{
		public SelectLowerVowels()
		{
			TSource = new List<char> { 'a', 'e', 'i', 'o', 'u' };
		}
	}
}
