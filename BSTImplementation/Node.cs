using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableAndBST.BSTImplementation
{
    public class Node
    {
        //Define members
        public int data;
        public Node left, right;
        /// <summary>
        /// node creation constructor
        /// </summary>
        /// <param name="item"></param>
        public Node(int item)
        {
            this.data = item;
        }
    }
}
