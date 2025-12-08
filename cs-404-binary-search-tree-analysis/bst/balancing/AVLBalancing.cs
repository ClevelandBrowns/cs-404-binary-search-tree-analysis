
namespace cs_404_binary_search_tree_analysis.bst.balancing
{
    internal class AVLBalancing<NodeData> : BalancingAlgorithm<AVLNode<NodeData>, NodeData> where NodeData : IComparable
    {
        public void BalanceTree(AVLNode<NodeData> nodeThatOperationWasPerformedOn, bool wasDeletion)
        {
            AVLNode<NodeData> evaluatedNode = nodeThatOperationWasPerformedOn;

            while (evaluatedNode.parent != null)
            {
                evaluatedNode.RecalculateHeight();
                switch (evaluatedNode.CalculateBalanceFactor())
                {
                    case > 1:
                        break;
                    case < -1:
                        break;
                }
                evaluatedNode = (AVLNode<NodeData>)evaluatedNode.parent;
            }
        }

        private void LLRotation()
        {

        }

        public Node<NodeData> CreateRootNode(NodeData value)
        {
            return new AVLNode<NodeData>(value);
        }

        AVLNode<NodeData> BalancingAlgorithm<AVLNode<NodeData>, NodeData>.CreateRootNode(NodeData value)
        {
            return new AVLNode<NodeData>(value);
        }

        //private bool checkIfTreeBalanced()
        //{

        //}
    }
}
