using System;
using System.Threading;

namespace CodingInterview.Maths
{
	public class ModeAndFrequency
	{
		public static void run()
		{
			int[] arr = {
			            	1, 2, 3, 4, 5, 6, 6, 7, 7, 7, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 77, 7, 3, 3, 3, 3
			            	, 3, 3, 3, 3, 3, 3, 3, 3, 3, 7, 8, 8, 9, 9, 5, 5, 4, 3, 7, 8, 8
			            };
			PrintModeAndFrequency(arr);

			Thread.Sleep(1000);
		}

		private static void PrintModeAndFrequency(int[] numbers)
		{
			System.Array.Sort(numbers);

			int finalFrequency = 0;
			int SIZE = numbers.Length;

			int curr = 0;
			int next = curr + 1;

			//Intialize.
			int mode = numbers[curr];
			int currentFreq = 1;

			while (next < SIZE) //Base case
			{
				if (numbers[curr] == numbers[next])
				{
					currentFreq++;
				}
				else
				{
					if (currentFreq > finalFrequency) // encounter higer order frequency
					{
						mode = numbers[curr]; // assign new mode
						finalFrequency = currentFreq; // copy new frequency
					}

					currentFreq = 1; //reset
				}

				//move ahead
				curr++;
				next++;
			}

			//Edge case. Cleanup
			if (currentFreq > finalFrequency)
			{
				mode = numbers[curr];
				finalFrequency = currentFreq;
			}

			Console.WriteLine(string.Format("Mode : {0} Frequency :{1}", mode, finalFrequency));
		}
	}
}