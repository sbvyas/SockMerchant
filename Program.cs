using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMerchantHackerRank
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] aArr = new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
			int aCount = sockMerchant(aArr.Count(), aArr);
			Console.WriteLine(aCount);
			Console.ReadLine();
		}
		static int sockMerchant(int n, int[] ar)
		{
			int aCount = 0;
			var aDictionary = new Dictionary<int, int>();
			foreach (var aArray in ar)
			{
				if (aDictionary.ContainsKey(aArray))
				{
					aDictionary[aArray]++;
				}
				else
				{
					aDictionary.Add(aArray, 1);
				}

			}

			foreach (var aValue in aDictionary)
			{
				if (aValue.Value % 2 == 0)
				{
					aCount += aValue.Value / 2;					
				}
				else
				{
					if (aValue.Value % 2 != 0)
					{
						aCount += (aValue.Value - 1) / 2;
					}
				}
				
			}
			return aCount;
		}
	}
}
