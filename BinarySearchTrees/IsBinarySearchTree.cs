namespace CodingInterview.BinarySearchTrees
{
	public class IsBinarySearchTree
	{
		public bool IsBST(BST tree)
		{
			return recIsBST(tree.Root, int.MinValue, int.MaxValue);
		}

		//Returns true if the given tree is a BST and its 
		//values are >= min and <= max. 
		private static bool recIsBST(BST.BSTNode node, int min, int max)
		{
			if (node == null) return true;

			// false if this node violates the min/max constraint
			if (node.data < min || node.data > max)
				return false;

			// otherwise check the subtrees recursively, 
			// tightening the min or max constraint 
			return recIsBST(node.left, min, node.data) && recIsBST(node.right, node.data, max);
		}
	}
}