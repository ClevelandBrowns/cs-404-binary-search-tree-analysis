using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
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
        }

        protected void BalanceTree(NodeType nodeOperationWasPerformedOn, bool wasDeletion) { 
            rootNode = new BalancingAlgo().BalanceTree(nodeOperationWasPerformedOn, wasDeletion);
        }

        public void InsertNode(Node<NodeData> nodeToInsert)
        {
            Node<NodeData> searchedNode = rootNode;

            int comparison = searchedNode.CompareTo(nodeToInsert);

            while (comparison != 0) //if comparison is zero, do nothing, duplicates not allowed.
            {
                switch(comparison)
                {
                    case -1:
                        if (searchedNode.leftChild == null) { searchedNode.leftChild = nodeToInsert; nodeToInsert.parent = searchedNode; BalanceTree((NodeType)nodeToInsert, false); return; }
                        else searchedNode = searchedNode.leftChild;
                        break;
                    case 1:
                        if (searchedNode.rightChild == null) { searchedNode.rightChild = nodeToInsert; nodeToInsert.parent = searchedNode; BalanceTree((NodeType)nodeToInsert, false); return; }
                        else searchedNode = searchedNode.rightChild;
                        break;
                }

                comparison = searchedNode.CompareTo(nodeToInsert);
            }
        }

        public void DeleteNode(Node<NodeData> nodeToDelete)
        {
 
        }        
        
        public void SearchForNode(Node<NodeData> nodeToSearchFor)
        {

        }

        private List<List<string>> recursiveToString(List<List<string>> table, Node<NodeData> searchedNode, int depth = 0)
        {
            if (table.Count < depth + 1) table.Add(new List<string>());

            if (searchedNode.leftChild == null && searchedNode.rightChild == null)
            {
                table[depth].Add(searchedNode.value.ToString());
                return table;
            }
            
            if(searchedNode.leftChild != null)
            {
                recursiveToString(table, searchedNode.leftChild, depth+1);
            }

            if (searchedNode.rightChild != null)
            {
                recursiveToString(table, searchedNode.rightChild, depth+1);
            }

            table[depth].Add(searchedNode.value.ToString());
            return table;
        }

        public List<List<string>> ToTable()
        {
            StringBuilder sb = new StringBuilder();

            List<List<string>> table = new List<List<string>>();

            return recursiveToString(table, rootNode);
        }
    }
}
