using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordGenerator
{
	// Singleton class
	public sealed class Parser
	{
		Selector<Selector<char>> selectors = new Selector<Selector<char>>();
		SelectLowerCons lowCon = new SelectLowerCons();
		SelectLowerVowels lowVow = new SelectLowerVowels();
		SelectUpperCons uppCon = new SelectUpperCons();
		SelectUpperVowels uppVow = new SelectUpperVowels();
		SelectNumbers number = new SelectNumbers();
		SelectSpecials speshl = new SelectSpecials();
		
		private static readonly Parser instance = new Parser();
		public static Parser Instance { get { return instance; } }

		private Parser()
		{
			selectors.AddSource(lowCon);
			selectors.AddSource(lowVow);
			selectors.AddSource(uppCon);
			selectors.AddSource(uppVow);
			selectors.AddSource(number);
			selectors.AddSource(speshl);
		}

		/// <summary>
		/// Does the heavy lifting of converting a pattern into a random password.
		/// </summary>
		public string Parse(string pattern, int length)
		{
			//pattern = "cv(c)\\10c\\1v(c)\\2";

			string result = pattern;
			
			result = CharReplace(result, length);

			result = ReplaceLiterals(result);

			result = GenerateDoubles(result);

			try { result = result.Remove(length); }
			catch (Exception e) { }

			return result;
		}

		/// <summary>
		/// Removes square brackets from "literal" characters.
		/// </summary>
		private string ReplaceLiterals(string input)
		{
			List<char> store = new List<char>();
			string result = input;

			Match matches = Regex.Match(result, @"\[.\]");

			while (matches.Success)
			{
				Capture cap = matches.Captures[0];
				store.Add(cap.ToString().ElementAt(1));
				matches = matches.NextMatch();
			}

			int i = 1;
			foreach (char c in store)
			{
				string s = c.ToString();
				result = Regex.Replace(result, @"\[" + s + @"\]", s);
			}

			return result;
		}

		/// <summary>
		/// Randomly selects replacement characters to fit [pattern].
		/// Pads to [length] with random selections, if necessary.
		/// </summary>
		private string CharReplace(string pattern, int length)
		{
			string result = "";
			string pad = "";
			int index = 0;

			while (index < length)
			{
				bool bSkip = false;

				foreach (char c in pattern)
				{
					// creates a 3-size string to check for various bracket types
					pad = Cycle(pad, c);

					// does not count slash characters against length limit
					if (c == '\\')
						bSkip = true;
					else if (bSkip && (c < '0' || c > '9'))
						bSkip = false;

					// tracks length of generated string
					if (!bSkip && !Regex.IsMatch(c.ToString(), @"[\(\)\[\]]"))
						index++;

					// removes brackets for character literals
					if (Regex.IsMatch(pad, @"\[.\]"))
					{
						result = result.Remove(result.Length - 1);
						result += pad[1];
					}

					// appends a new random character to the result string
					switch (c)
					{
						case 'c':
							result += lowCon.GetNew();
							break;
						case 'v':
							result += lowVow.GetNew();
							break;
						case 'C':
							result += uppCon.GetNew();
							break;
						case 'V':
							result += uppVow.GetNew();
							break;
						case '$':
							result += number.GetNew();
							break;
						case '%':
							result += speshl.GetNew();
							break;
						case 'r':
							result += selectors.GetNew().GetNew();
							break;
						// or adds the literal character to the result string
						default:
							result += c;
							break;
					}
				}
			}

			return result;
		}

		/// <summary>
		/// Goes through the string and replaces requests (e.g. \1) with their
		/// backreferenced values.
		/// </summary>
		private string GenerateDoubles(string input)
		{
			List<string> store = new List<string>();
			string result = input;

			// finds all bracketed expressions
			Match matches = Regex.Match(result, @"\(.\)");

			while (matches.Success)
			{
				// adds the contents of each one to a list
				string cap = matches.Captures[0].ToString();
				store.Add(cap.Substring(1, cap.Length - 2));
				matches = matches.NextMatch();
			}

			// working backwards to prevent errors
			store.Reverse();
			int i = store.Count;

			foreach (string s in store)
			{
				// finds the reference and replaces both it and the request
				result = Regex.Replace(result, @"\\" + i--, s);
				result = Regex.Replace(result, @"\(" + s + @"\)", s);
			}

			return result;
		}

		/// <summary>
		/// Creates a new string by discarding the first character of [toCycle]
		/// and appending [end].
		/// </summary>
		private string Cycle(string toCycle, char end)
		{
			if (toCycle.Length < 3)
				return toCycle + end;
			else
				return toCycle.Substring(1) + end;
		}
	}
}
