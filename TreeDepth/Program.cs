using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDepth
{
    class Program
    {
        static void Main(string[] args)
        {            
            Tree<int> tree = new Tree<int>(8);
            TreeNodes<int> three = new TreeNodes<int>(10);
            TreeNodes<int> ten = new TreeNodes<int>(14);
            TreeNodes<int> one = new TreeNodes<int>(13);
            TreeNodes<int> six = new TreeNodes<int>(3);
            TreeNodes<int> fourteen = new TreeNodes<int>(6);
            TreeNodes<int> four = new TreeNodes<int>(7);
            TreeNodes<int> seven = new TreeNodes<int>(4);
            TreeNodes<int> thirteen = new TreeNodes<int>(1);

            tree.root.AddChild(three);
            tree.root.AddChild(ten);
            three.AddChild(one);
            three.AddChild(six);
            six.AddChild(four);
            six.AddChild(seven);
            ten.AddChild(fourteen);
            fourteen.AddChild(thirteen);

            tree.DepthFirstSearch();

            Console.ReadLine();
        }
    }
}
