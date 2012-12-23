

namespace CodingInterview.BinarySearchTrees
{
	public class PrintPathsRootToLeaf : BST
	{
		public void RootToLeafPaths()
		{
			recPrintPaths(root, new int[1000], 0);
		}

		private static void recPrintPaths(BSTNode node, int[] paths, int len)
		{
			if (node == null) return;

			paths[len] = node.data;
			len++;

			if (node.left == null && node.right == null)
				printArray(paths, len);
			else
			{
				recPrintPaths(node.left, paths, len);
				recPrintPaths(node.right, paths, len);
			}
		}

		private static void printArray(int[] paths, int len)
		{
			for (int i = 0; i < len; i++)
			{
				Console.Write(paths[i]);
			}

			Console.WriteLine();
		}
	}
}