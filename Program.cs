using System;
using System.Collections.Generic;
using CodingInterview.BinarySearchTrees;
using CodingInterview.HashMaps;

namespace CodingInterview
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//UniqueTripletsOfSumZero.run();
			//PairEqualsGivenSum.run();
			//ModeAndFrequency.run();

			//var bst1 = new BST();
			//bst1.Insert(12);
			//bst1.Insert(6);
			//bst1.Insert(22);
			//bst1.Insert(18);
			//bst1.Insert(14);
			//bst1.Insert(13);
			//bst1.Insert(12);

			//var bst2 = new BST();
			//bst2.Insert(12);
			//bst2.Insert(6);
			//bst2.Insert(22);
			//bst2.Insert(18);
			//bst2.Insert(14);
			//bst2.Insert(13);
			//bst2.Insert(12);

			//var tree = new SameTree();

			var map = new LinearProbingHashMap(5);

			map.Put(1023, "Apple");
			map.Put(1123, "Samsung");
			map.Put(1323, "Toyota");
			map.Put(1433, "Microsoft");
			//map.Put(1093, "Square");
			//map.Put(1983, "Twitter");
			//map.Put(1013, "Google");

			Console.WriteLine(map.Get(1023));
			//Console.WriteLine(tree.AreSame(bst1, bst2));

			//Console.WriteLine(new IsBinarySearchTree().IsBST(bst1));

		}
	}
}