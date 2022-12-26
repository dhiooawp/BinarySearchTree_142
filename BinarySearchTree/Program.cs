using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class node
    {
        public string info;
        public node lchild;
        public node rchild;

        public node(string i, node l, node r)
        {
            info = i;
            lchild = l;
            rchild = r;
        }
    }
    class BinarySeacrhTree
    {
        public node ROOT;
        public BinarySeacrhTree()
        {
            ROOT = null;
        }
        public void insert(string element)
        {
            node tmp, parent = null, currentnode = null;
            find(element, ref parent, ref currentnode);
            if (currentnode != null)
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
