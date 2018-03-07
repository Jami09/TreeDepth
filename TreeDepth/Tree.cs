using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDepth
{
    public class Tree<T>
    {
        // The root of the tree
        public TreeNodes<T> root;
        /// <summary>Constructs the tree</summary>
        /// <param name="value">the value of the node</param>

        public Tree(T value)
        {
            if (value != null)
                this.root = new TreeNodes<T>(value);
        }

        public void DepthFirstSearch()
        {
            //create new stack
            Queue<TreeNodes<T>> stack = new Queue<TreeNodes<T>>();
            
            //put root in stack
            stack.Enqueue(root);

            while (stack.Count != 0)
            {
                //get first item of stack
                TreeNodes<T> v = stack.Dequeue();
                Console.WriteLine(v.value);

                foreach (TreeNodes<T> c in v.children)
                {
                    stack.Enqueue(c);
                }
            }
        }
    }
}
