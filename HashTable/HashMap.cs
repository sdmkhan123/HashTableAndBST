using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableAndBST.HashTable
{
    public class HashMap
    {
        public static void hashFunction()
        {
            string[] str = "to be or not to be".Split(" ");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(5);
            for(int i=0; i<str.Length; i++)
            {
                hash.Add(i , str[i]);
            }
            string hash5 = hash.Get(5);
            Console.WriteLine("Fifth index is: {0} ", hash5);
            string hash2 = hash.Get(2);
            Console.WriteLine("Second index is: {0} ", hash2);
        }
    }
}