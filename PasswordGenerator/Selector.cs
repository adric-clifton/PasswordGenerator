using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
	class Selector<T>
	{
		protected List<T> TSource = new List<T>();
		protected Random noiseSource = new Random();

		protected Dictionary<int, T> resultsList = new Dictionary<int, T>();

		public T GetNew()
		{
			return TSource[noiseSource.Next(TSource.Count)];
		}

		public T GetAndStoreNew(int index)
		{
			T result = GetNew();
			resultsList.Add(index, result);
			return result;
		}

		public T GetPrev(int index)
		{
			T result;
			resultsList.TryGetValue(index, out result);
			return result;
		}

		public bool IsInSource(T toCheck)
		{
			return TSource.Contains(toCheck);
		}

		public void AddSource(T toAdd)
		{
			TSource.Add(toAdd);
		}
	}
}
