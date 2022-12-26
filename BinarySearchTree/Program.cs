using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
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

        static void Main(string[] args)
        {
        }
    }
}
