namespace CodingInterview.HashMaps
{
	public class LinearProbingHashMap
	{
		private readonly int SIZE;
		private readonly object[] data;
		private int count;

		public LinearProbingHashMap(int size)
		{
			SIZE = size;
			data = new object[SIZE];
			count = 0;
		}

		public void Put(int key, string value)
		{
			int index = getHash(key);

			while (data[index] != null)
			{
				//very imp to keep array within bounds
				index = (index + 1)%SIZE;
			}

			data[index] = new MapData {key = key, value = value};
			count++;
		}

		public string Get(int key)
		{
			int index = getHash(key);
			//to avoid infinte looping.
			int startIndex = index;

			do
			{
				var mapData = (MapData) data[index];

				//core logic
				if (mapData != null && mapData.key == key)
					return mapData.value;
				//move ahead within bounds.
				index = (index + 1)%SIZE;
			} while (index != startIndex);

			//not found.
			return null;
		}

		private int getHash(int key)
		{
			return key%SIZE;
		}

		internal class MapData
		{
			public int key { get; set; }
			public string value { get; set; }
		}
	}
}