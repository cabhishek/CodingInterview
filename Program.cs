using System;
using CodingInterview.BinarySearchTrees;

namespace CodingInterview
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//UniqueTripletsOfSumZero.run();
			//PairEqualsGivenSum.run();
			//ModeAndFrequency.run();

			var bst1 = new BST();
			bst1.Insert(12);
			bst1.Insert(6);
			bst1.Insert(22);
			bst1.Insert(18);
			bst1.Insert(14);
			bst1.Insert(13);
			bst1.Insert(12);

			//var bst2 = new BST();
			//bst2.Insert(12);
			//bst2.Insert(6);
			//bst2.Insert(22);
			//bst2.Insert(18);
			//bst2.Insert(14);
			//bst2.Insert(13);
			//bst2.Insert(12);

			//var tree = new SameTree();

			//Console.WriteLine(tree.AreSame(bst1, bst2));

			Console.WriteLine(new IsBinarySearchTree().IsBST(bst1));
		}
	}
}