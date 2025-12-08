using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_404_binary_search_tree_analysis.bst
{
    internal class AVLNode<NodeData> : Node<NodeData>
    {
        public int height;

        public AVLNode()
        {
        }

        internal void RecalculateHeight()
        {
            if (leftChild == null && rightChild == null) 
                return;
            else if(leftChild == null)
                height = 1 + ((AVLNode<NodeData>)rightChild).height;
            else if(rightChild == null)
                height = 1 + ((AVLNode<NodeData>)leftChild).height;
            else 
                height = 1 + Math.Max(((AVLNode<NodeData>)leftChild).height, ((AVLNode<NodeData>)rightChild).height);
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

        internal int CalculateBalanceFactor()
        {
            return ((AVLNode<NodeData>)leftChild).height - ((AVLNode<NodeData>)rightChild).height;
        }
    }
}
