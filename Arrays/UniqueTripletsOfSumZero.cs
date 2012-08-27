using System;
using System.Collections;

namespace CodingInterview.Array
{
	public class UniqueTripletsOfSumZero
	{
		public static void run()
		{
			//Given array is sorted.
			int[] numbers = {-1, 0, 1, 2, -1, 4};

			ArrayList results = threeSums(numbers);

			foreach (ArrayList result in results)
			{
				Console.WriteLine(string.Join(", ", result.ToArray()));
			}
		}

		private static ArrayList threeSums(int[] numbers)
		{
			var sums = new ArrayList();

			for (int i = 0; i < numbers.Length - 1; i++)
			{
				int j = i + 1; // start from i+1
				int k = numbers.Length - 1; //start from end

				while (j < k) // pointer positions
				{
					int sum = numbers[i] + numbers[j] + numbers[k];

					if (sum == 0)
					{
						var sumZeroList = new ArrayList {numbers[i], numbers[j], numbers[k]};
						if (!sums.Contains(sumZeroList)) //duplicates not allowed
						{
							sums.Add(sumZeroList);
						}
					}

					if (sum < 0) // core logic
					{
						j++; //since sum is less than zero search for higher order number
					}
					else
					{
						k--; // since sum is greater than zero search for lower order numbers
					}
				}
			}

			return sums;
		}
	}
}