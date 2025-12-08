using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_404_binary_search_tree_analysis.bst
{
    internal class RedBlackNode<NodeData> : Node<NodeData> where NodeData : IComparable
    {
        public RedBlackNodeColor color;

        public override int CompareTo(object? obj)
        {
            if (obj.GetType() != typeof(RedBlackNode<NodeData>)) return -2;

            var newObj = (RedBlackNode<NodeData>)obj;

            return newObj.value.CompareTo(this.value);
        }
    }
}
