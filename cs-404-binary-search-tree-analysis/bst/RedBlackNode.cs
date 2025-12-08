using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_404_binary_search_tree_analysis.bst
{
    internal class RedBlackNode<NodeData> : Node<NodeData>
    {
        public RedBlackNodeColor color;

        public override int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
