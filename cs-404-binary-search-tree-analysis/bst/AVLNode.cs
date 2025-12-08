using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_404_binary_search_tree_analysis.bst
{
    internal class AVLNode<NodeData> : Node<NodeData>
    {
        public int balanceFactor;
        public override int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
