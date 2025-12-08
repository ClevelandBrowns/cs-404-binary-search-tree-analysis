using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_404_binary_search_tree_analysis.bst.balancing
{
    internal class RedBlackBalancing<NodeData> : BalancingAlgorithm<Node<NodeData>, NodeData> where NodeData : IComparable
    {
        public void BalanceTree(Node<NodeData> rootNode)
        {
            throw new NotImplementedException();
        }

        public Node<NodeData> CreateRootNode(NodeData value)
        {
            return new RedBlackNode<NodeData>();
        }
    }
}
