
namespace cs_404_binary_search_tree_analysis.bst.balancing
{
    internal class AVLBalancing<NodeData> : BalancingAlgorithm<Node<NodeData>, NodeData> where NodeData : IComparable
    {
        public void BalanceTree(Node<NodeData> rootNode)
        {
            if (rootNode.GetType() != typeof(AVLNode<string>)) return;
            throw new NotImplementedException();
        }

        public Node<NodeData> CreateRootNode(NodeData value)
        {
            return new AVLNode<NodeData>(value);
        }

        private void RecalculateHeights(AVLNode<NodeData> rootNode)
        {

        }

        //private bool checkIfTreeBalanced()
        //{

        //}
    }
}
