using System.Diagnostics;
using cs_404_binary_search_tree_analysis.bst.balancing;

namespace cs_404_binary_search_tree_analysis.bst
{
    internal class BinarySearchTree<NodeData, BalancingAlgo, NodeType> 
        where BalancingAlgo : BalancingAlgorithm<NodeType, NodeData>, new() 
        where NodeData : IComparable
        where NodeType: Node<NodeData>, new()
    {
        public NodeType rootNode;

        public BinarySearchTree(NodeData value)
        {
            rootNode = new BalancingAlgo().CreateRootNode(value);
            Debug.WriteLine(value.ToString());
        }

        protected void BalanceTree() { 
            new BalancingAlgo().BalanceTree(rootNode);
        }

        public void InsertNode(Node<NodeData> nodeToInsert)
        {

        }

        public void DeleteNode(Node<NodeData> nodeToDelete)
        {
 
        }        
        
        public void SearchForNode(Node<NodeData> nodeToSearchFor)
        {

        }

        private bool checkNodeTypeParity(Node<NodeData> nodeToCheck)
        {
            if (nodeToCheck.GetType() == rootNode.GetType()) return true;
            else return false;
        }
    }
}
