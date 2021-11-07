﻿using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Binary Search Tree");

            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(45);
            bst.Insert(12);
            bst.Insert(88);
            bst.Insert(55);
            bst.Insert(33);
            bst.Insert(64);
            bst.Display();
            bst.GetSize();
        }
    }
}
