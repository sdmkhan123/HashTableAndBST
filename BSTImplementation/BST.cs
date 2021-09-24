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
            tree.insert(root, 22);
            tree.insert(root, 40);
            tree.insert(root, 60);
            tree.insert(root, 95);
            tree.insert(root, 11);
            tree.insert(root, 65);
            tree.insert(root, 3);
            tree.insert(root, 16);
            tree.insert(root, 63);
            tree.insert(root, 67);
            tree.insert(root, 11);
            Console.WriteLine("****************************************************************\n");
            tree.preOrder(root);
            Console.Write("\n");
            Console.WriteLine("****************************************************************\n");
            int h = tree.height(root);
            Console.WriteLine("Height of the given BST is " + h + "\n");
        }
    }
}
