using System.Diagnostics;
using cs_404_binary_search_tree_analysis.bst.balancing;

namespace cs_404_binary_search_tree_analysis.bst
{
    internal class BinarySearchTree<NodeData, BalancingAlgo> 
        where BalancingAlgo : BalancingAlgorithm<Node<NodeData>, NodeData>, new() 
        where NodeData : IComparable
    {
        public Node<NodeData> rootNode;

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
            if (checkNodeTypeParity(nodeToInsert)) {
                
            } else
            {
                //TODO: handle
            }
        }

        public void DeleteNode(Node<NodeData> nodeToDelete)
        {
            if (checkNodeTypeParity(nodeToDelete))
            {

            }
            else
            {
                //TODO: handle
            }
        }        
        
        public void SearchForNode(Node<NodeData> nodeToSearchFor)
        {
            if (checkNodeTypeParity(nodeToSearchFor))
            {

            }
            else
            {
                //TODO: handle
            }
        }

        private bool checkNodeTypeParity(Node<NodeData> nodeToCheck)
        {
            if (nodeToCheck.GetType() == rootNode.GetType()) return true;
            else return false;
        }
    }
}
