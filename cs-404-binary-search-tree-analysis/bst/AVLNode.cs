using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_404_binary_search_tree_analysis.bst
{
    internal class AVLNode<NodeData> : Node<NodeData> where NodeData : IComparable
    {
        public int height;

        public AVLNode()
        {
        }

        internal void RecalculateHeight()
        {
            if (leftChild == null && rightChild == null) 
                height = 1;
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
            if (obj.GetType() != typeof(AVLNode<NodeData>)) return -2;

            var newObj = (AVLNode<NodeData>)obj;

            return newObj.value.CompareTo(this.value);
        }

        public override string ToString()
        {
            return base.value.ToString();
        }

        internal int CalculateBalanceFactor()
        {
            if (leftChild == null && rightChild == null) return 0;
            else if (leftChild == null) return -((AVLNode<NodeData>)rightChild).height;
            else if (rightChild == null) return ((AVLNode<NodeData>)leftChild).height;
            else return ((AVLNode<NodeData>)leftChild).height - ((AVLNode<NodeData>)rightChild).height;
        }

        internal void CalculateChildBalanceFactors(out int leftChildBF, out int rightChildBF)
        {
            leftChildBF = 0;
            rightChildBF = 0;

            if(leftChild != null) leftChildBF = ((AVLNode<NodeData>)leftChild).CalculateBalanceFactor();
            if(rightChild != null) rightChildBF = ((AVLNode<NodeData>)rightChild).CalculateBalanceFactor();
        }
    }
}
