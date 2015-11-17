using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
	class SelectUpperVowels : Selector<char>
	{
		public SelectUpperVowels()
		{
			TSource = new List<char> { 'A', 'E', 'I', 'O', 'U' };
		}
	}
}
