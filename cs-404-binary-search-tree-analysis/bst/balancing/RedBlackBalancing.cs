using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_404_binary_search_tree_analysis.bst.balancing
{
    internal class RedBlackBalancing<NodeData> : BalancingAlgorithm<RedBlackNode<NodeData>, NodeData> where NodeData : IComparable
    {
        public RedBlackNode<NodeData> CreateRootNode(NodeData value)
        {
            throw new NotImplementedException();
        }

        RedBlackNode<NodeData> BalancingAlgorithm<RedBlackNode<NodeData>, NodeData>.BalanceTree(RedBlackNode<NodeData> rootNode, bool wasDeletion)
        {
            //after adding, go up through tree and see 
            return null;
        }
    }
}
