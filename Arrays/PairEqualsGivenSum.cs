using System;
using System.Collections;

namespace CodingInterview.Array
{
	public class PairEqualsGivenSum
	{
		public static void run()
		{
			//given a sorted array
			var numbers = new[] {1, 2, 3, 4, 5};

			ArrayList pairs = findPairs(numbers, 6);

			foreach (ArrayList pair in pairs)
			{
				Console.WriteLine(string.Join(", ", pair.ToArray()));
			}
		}

		private static ArrayList findPairs(int[] numbers, int desiredSum)
		{
			var pairs = new ArrayList();
			int first = 0;
			int last = numbers.Length - 1;

			while (first < last)
			{
				int sum = numbers[first] + numbers[last];

				if (sum == desiredSum) //desired condition
				{
					pairs.Add(new ArrayList
					          	{
					          		numbers[first],
					          		numbers[last]
					          	});
				}

				if (sum < desiredSum) // since sum is less than desired search for higer order numbers ie right side
				{
					first++;
				}
				else //since sum is more than desired search for lower order numbers ie left side
				{
					last--;
				}
			}

			return pairs;
		}
	}
}