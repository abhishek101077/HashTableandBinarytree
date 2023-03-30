using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashandtable
{
    class Binarysearchtree<T> where T : IComparable<T>
    { 

        public T NodeData { get; set; }
        public Binarysearchtree<T> leftTree { get; set; }
        public Binarysearchtree<T> rightTree { get; set; }
        //constructor
        public Binarysearchtree(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;
        }
        //intialize variables
        int leftCount; int rightCount;
        //define insert method
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new Binarysearchtree<T>(item);
                }
                else
                    this.leftTree.Insert(item);
                this.leftCount++;
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new Binarysearchtree<T>(item);
                }
                else
                    this.rightTree.Insert(item);
                this.rightCount++;
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {

                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData);
            if (this.rightTree != null)
            {

                this.rightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}
