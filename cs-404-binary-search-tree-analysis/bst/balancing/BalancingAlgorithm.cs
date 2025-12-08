using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_404_binary_search_tree_analysis.bst.balancing
{
    internal interface BalancingAlgorithm<NodeType, NodeData> 
        where NodeType : Node<NodeData>
        where NodeData : IComparable
    {
        public void BalanceTree(NodeType rootNode, bool wasDeletion);

        public NodeType CreateRootNode(NodeData value);
    }
}
