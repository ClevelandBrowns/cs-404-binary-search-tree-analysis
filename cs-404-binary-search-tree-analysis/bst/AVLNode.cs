using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_404_binary_search_tree_analysis.bst
{
    internal class AVLNode<NodeData> : Node<NodeData>
    {
        // height is always equal to 
        public int height;

        public AVLNode()
        {
        }

        internal void RecalculateHeight()
        {
            height = 1 + (((AVLNode<NodeData>)leftChild).height - ((AVLNode<NodeData>)rightChild).height);
        }

        public AVLNode(NodeData value)
        {
            base.value = value;
        }

        public override int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.value.ToString();
        }
    }
}
