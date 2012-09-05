namespace CodingInterview.BinarySearchTrees
{
	public class SameTree
	{
		public bool AreSame(BST tree1, BST tree2)
		{
			return recAreSame(tree1.Root, tree2.Root);
		}

		private bool recAreSame(BST.BSTNode node1, BST.BSTNode node2)
		{
			//when both empty they are same
			if (node1 == null && node2 == null) return true;
			//if (node1 == null && node2 != null) return false;
			//if (node1 != null && node2 == null) return false;

			if (node1 != null && node2 != null)
			{
				return node1.data == node2.data && //same data value
				       recAreSame(node1.left, node2.left) && //compare left
				       recAreSame(node1.right, node2.right); //compare right
			}
			//not same
			return false;
		}
	}
}