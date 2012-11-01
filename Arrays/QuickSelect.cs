using System;

namespace CodingInterview
{
	public class QuickSelect
	{
		public static void run ()
		{
			int [] array = new [] {5,6,2,8,1,7};

			Console.WriteLine(selectKth(array, 4));
		}

		private static int selectKth(int[] arr, int k) {
			if (arr == null || arr.Length <= k)
				throw new Exception();
			
			int from = 0, to = arr.Length - 1;
			
			// if from == to we reached the kth element
			while (from < to) {
				int r = from, w = to;
				int mid = arr[(r + w) / 2];
				
				// stop if the reader and writer meets
				while (r < w) {
					
					if (arr[r] >= mid) { // put the large values at the end
						int tmp = arr[w];
						arr[w] = arr[r];
						arr[r] = tmp;
						w--;
					} else { // the value is smaller than the pivot, skip
						r++;
					}
				}
				
				// if we stepped up (r++) we need to step one down
				if (arr[r] > mid)
					r--;
				
				// the r pointer is on the end of the first k elements
				if (k <= r) {
					to = r;
				} else {
					from = r + 1;
				}
			}
			
			return arr[k];
		}
	}
}

