using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_404_binary_search_tree_analysis.bst
{
    internal abstract class Node<NodeData> : IComparable
    {
        protected Node<NodeData>? parent;
        protected Node<NodeData>? leftChild;
        protected Node<NodeData>? rightChild;
        protected NodeData value;

        public abstract int CompareTo(object? obj);
    }
}
