namespace CodingInterview.BinarySearchTrees
{
	public class HasRootToLeafSumPath : BST
	{
		public bool HasSumPath(int sum)
		{
			return recHasSumPath(root, sum);
		}

		private static bool recHasSumPath(BSTNode node, int sum)
		{
			//base case
			if (node == null)
				//core logic
				return sum == 0;
			else
			{
				//reduce problem set
				int subSum = sum - node.data;
				//sum == 0 could be in left or right sub tree.
				return recHasSumPath(node.left, subSum) || recHasSumPath(node.right, subSum);
			}
		}
	}
}