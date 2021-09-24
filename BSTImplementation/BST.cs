using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableAndBST.BSTImplementation
{
    public class BST
    {
        /// <summary>
        /// BST main function
        /// </summary>
        public static void bStFunction()
        {
            Node root = new Node(56);
            BinarySearchTree tree = new BinarySearchTree();
            tree.insert(root, 30);
            tree.insert(root, 70);
            Console.WriteLine("****************************************************************\n");
            tree.preOrder(root);
            Console.Write("\n");
        }
    }
}
