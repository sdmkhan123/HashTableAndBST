using HashTableAndBST.HashTable;
using System.Collections.Generic;
using System.Text;
using System;

namespace HashTableAndBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************\n");
            Console.WriteLine("----------------Welcome to  Hash Table and BST----------------\n");
            Console.WriteLine("****************************************************************\n");
            while (true)
            {
                Console.WriteLine("****************************************************************");
                Console.WriteLine("Press 1 : For Hash Map\nPress 0 : To exit");
                Console.WriteLine("****************************************************************\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine("Welcome to  Hash Table");
                        Console.WriteLine("****************************************************************\n");
                        HashMap.hashFunction();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
