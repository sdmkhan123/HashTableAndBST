using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableAndBST.BSTImplementation
{
    public class BinarySearchTree
    {
		/// <summary>
		/// insert a node into given tree
		/// </summary>
		/// <param name="root"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public Node insert(Node root, int value)
		{
			if (root == null)
			{
				root = new Node(value);
				return root;
			}
			//left check
			if (value < root.data)
				root.left = insert(root.left, value);
			//right check
			else if (value > root.data)
				root.right = insert(root.right, value);
			return root;
		}
		/// <summary>
		/// Display the data of tree using pre order travarsal
		/// </summary>
		/// <param name="root"></param>
		public void preOrder(Node root)
		{
			if (root != null)
			{
				Console.Write(root.data + " ");
				preOrder(root.left);
				preOrder(root.right);
			}
			return;
		}
		/// <summary>
		/// return the maximum of 2 num
		/// </summary>
		/// <param name="max1"></param>
		/// <param name="max2"></param>
		/// <returns></returns>
		private int max(int max1, int max2)
		{
			if (max1 > max2)
			{
				return max1;
			}
			else
			{
				return max2;
			}
		}
		/// <summary>
		/// calculate the height of BST
		/// </summary>
		/// <param name="root"></param>
		/// <returns></returns>
		public int height(Node root)
		{
			if (root == null || (root.left == null && root.right == null))
			{
				return 0;
			}
			else
			{
				return (1 + max(height(root.left), height(root.right)));
			}
		}
		/// <summary>
		/// Search a Node present or not in given BST
		/// </summary>
		/// <param name="root"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public bool search(Node root, int value)
		{
			while (root != null)
			{
				if (root.data == value)
				{
					return true;
				}
				else if (root.data > value)
				{
					return search(root.left, value);
				}
				else
				{
					return search(root.right, value);
				}
			}
			return false;
		}
	}
}