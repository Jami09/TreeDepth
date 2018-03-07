using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDepth
{
    public class TreeNodes<T>
    {
        // Contains the value of the node
        public T value;

        // Shows whether the current node has a parent or not
        public bool hasParent;

        // Contains the children of the node (zero or more)
        public List<TreeNodes<T>> children;

        // Constructs a tree node, “value” is the value of the node
        public TreeNodes(T value)
        {
            if (value != null)
            {
                this.value = value;
                this.children = new List<TreeNodes<T>>();
            }
        }

        public void AddChild(TreeNodes<T> child)
        {
            child.hasParent = true;
            this.children.Add(child);
        }

        public TreeNodes<T> GetChild(int index)
        {
            return children[index];
        }
    }
}
