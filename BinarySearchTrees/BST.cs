namespace CodingInterview.BinarySearchTrees
{
	public class BST
	{
		private int nodeCount;
		protected BSTNode root;

		public BST()
		{
			root = null;
			nodeCount = 0;
		}

		public BSTNode Root
		{
			get { return root; }
		}

		public int NodeCount
		{
			get { return nodeCount; }
		}

		public void Insert(int item)
		{
			nodeCount++;
			root = recInsert(item, root);
		}

		private static BSTNode recInsert(int item, BSTNode node)
		{
			if (node == null)
			{
				node = new BSTNode {left = null, right = null, data = item};
			}
			else if (item.CompareTo(node.data) < 0)
			{
				node.left = recInsert(item, node.left); //insert at the left
			}
			else
			{
				node.right = recInsert(item, node.right); // insert at right
			}

			return node;
		}

		#region Nested type: BSTNode

		public class BSTNode
		{
			public int data;
			public BSTNode left;
			public BSTNode right;
		}

		#endregion
	}
}