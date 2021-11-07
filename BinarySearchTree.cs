using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; } //generic get and set method for LeftTre
        public BinarySearchTree<T> LeftTree { get; set; } //generic get and set method for RightTree
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData)  //initilizing parameterized constructor 
        {
            this.NodeData = nodeData; //NodeData assign the value from nodeData instance variable
            this.LeftTree = null; //LeftTree node is assigned to null value
            this.RightTree = null; ////RightTree node is assigned to null value
        }

        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData; //create a new Node

            if((currentNodeValue.CompareTo(item)) > 0) //compare current node value and checking the condition
            {
                if (this.LeftTree == null) //LeftTree is null then assigned to newNode
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else
                    this.LeftTree.Insert(item); //LeftTree is not null then insert data
            }
            else
            {
                if (this.RightTree == null) //RightTree is null then assigned to newNode
                {
                    this.RightTree = new BinarySearchTree<T>(item);
                }
                else
                    this.RightTree.Insert(item); //RightTree is not null then insert data
            }
        }

        public void Display()
        {
            if(this.LeftTree != null)
            {
                this.leftCount++; //count left node and increment
                this.LeftTree.Display(); //recursive call display method
            }
            Console.WriteLine(this.NodeData.ToString());

            if(this.RightTree != null)
            {
                this.rightCount++; //count right node and increment
                this.RightTree.Display(); //recursive call display method
            }
        }

        public void GetSize()
        {
            Console.WriteLine("\nSize" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}
