using cs_404_binary_search_tree_analysis.bst.balancing;

namespace cs_404_binary_search_tree_analysis.bst
{
    internal class BinarySearchTree<NodeData, BalancingAlgo> where BalancingAlgo : BalancingAlgorithm<NodeData>, new()
    {
        Node<NodeData> rootNode;

        public BinarySearchTree(Node<NodeData> rootNode)
        {
            this.rootNode = rootNode;
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
    }
}
