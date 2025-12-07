using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_404_binary_search_tree_analysis.bst.balancing
{
    internal interface BalancingAlgorithm<NodeData>
    {
        public void BalanceTree(Node<NodeData> rootNode);

        public Node<NodeData> CreateRootNode();
    }
}
