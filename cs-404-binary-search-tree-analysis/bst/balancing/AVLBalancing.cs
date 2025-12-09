
namespace cs_404_binary_search_tree_analysis.bst.balancing
{
    internal class AVLBalancing<NodeData> : BalancingAlgorithm<AVLNode<NodeData>, NodeData> where NodeData : IComparable
    {
        /*
        * Left-Left (LL)	Node BF = +2, Left child BF ≥ 0	Right rotation at node 
        * Right-Right (RR)	Node BF = –2, Right child BF ≤ 0	Left rotation at node
        * Left-Right (LR)	Node BF = +2, Left child BF < 0	Left rotation at left child, then right rotation at node
        * Right-Left (RL)	Node BF = –2, Right child BF > 0	Right rotation at right child, then left rotation at node
        */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodeThatOperationWasPerformedOn"></param>
        /// <param name="wasDeletion"></param>
        /// <returns>New root node.</returns>
        public AVLNode<NodeData> BalanceTree(AVLNode<NodeData> nodeThatOperationWasPerformedOn, bool wasDeletion)
        {
            AVLNode<NodeData> evaluatedNode = nodeThatOperationWasPerformedOn;

            AVLNode<NodeData> rootNode = null;

            while (evaluatedNode != null)
            {
                evaluatedNode.RecalculateHeight();
                switch (evaluatedNode.CalculateBalanceFactor())
                {
                    case < -1:
                        evaluatedNode.CalculateChildBalanceFactor(false, out int rightChildBF);
                        if (rightChildBF <= 0)
                        {
                            evaluatedNode = LeftRotation(evaluatedNode);
                        } else
                        {
                            evaluatedNode = RightLeftRotation(evaluatedNode);
                        }
                        break;
                    case > 1:
                        evaluatedNode.CalculateChildBalanceFactor(true, out int leftChildBF);
                        if (leftChildBF >= 0)
                        {
                            evaluatedNode = RightRotation(evaluatedNode);
                        }
                        else
                        {
                            evaluatedNode = LeftRightRotation(evaluatedNode);
                        }
                        break;
                }

                if (evaluatedNode.parent != null) evaluatedNode = (AVLNode<NodeData>)evaluatedNode.parent;
                else return evaluatedNode;
            }

            return evaluatedNode;
        }

        private AVLNode<NodeData> RightRotation(AVLNode<NodeData> imbalancedNode) 
        {
            bool wasImbalancedNodeRoot = imbalancedNode.parent == null ? true : false;

            AVLNode<NodeData> leftChildOfImbalanced = (AVLNode<NodeData>)imbalancedNode.leftChild;

            imbalancedNode.leftChild = leftChildOfImbalanced.rightChild;
            if(imbalancedNode.leftChild != null) imbalancedNode.leftChild.parent = imbalancedNode;

            leftChildOfImbalanced.rightChild = imbalancedNode;

            //update heights, first A, then B
            imbalancedNode.RecalculateHeight();
            leftChildOfImbalanced.RecalculateHeight();

            if(!wasImbalancedNodeRoot)
            {
                if (imbalancedNode.parent.leftChild != null && imbalancedNode.parent.leftChild.Equals(imbalancedNode))
                {
                    imbalancedNode.parent.leftChild = leftChildOfImbalanced;
                } else {
                    imbalancedNode.parent.rightChild = leftChildOfImbalanced;
                }

            }
            
            leftChildOfImbalanced.parent = imbalancedNode.parent;
            imbalancedNode.parent = leftChildOfImbalanced;

            return leftChildOfImbalanced;
        }

        private AVLNode<NodeData> LeftRotation(AVLNode<NodeData> imbalancedNode) 
        {
            bool wasImbalancedNodeRoot = imbalancedNode.parent == null ? true : false;

            AVLNode<NodeData> rightChildOfImbalanced = (AVLNode<NodeData>)imbalancedNode.rightChild;

            imbalancedNode.rightChild = rightChildOfImbalanced.leftChild;
            if(imbalancedNode.rightChild != null) imbalancedNode.rightChild.parent = imbalancedNode;


            rightChildOfImbalanced.leftChild = imbalancedNode;

            //update heights, first A, then B
            imbalancedNode.RecalculateHeight();
            rightChildOfImbalanced.RecalculateHeight();

            if (!wasImbalancedNodeRoot)
            {
                if (imbalancedNode.parent.leftChild.Equals(imbalancedNode))
                {
                    imbalancedNode.parent.leftChild = rightChildOfImbalanced;
                }
                else
                {
                    imbalancedNode.parent.rightChild = rightChildOfImbalanced;
                }

            }
            
            rightChildOfImbalanced.parent = imbalancedNode.parent;
            imbalancedNode.parent = rightChildOfImbalanced;

            return rightChildOfImbalanced;
        }

        private AVLNode<NodeData> LeftRightRotation(AVLNode<NodeData> imbalancedNode) {
            LeftRotation((AVLNode<NodeData>)imbalancedNode.leftChild);
            return RightRotation(imbalancedNode);
        }

        private AVLNode<NodeData> RightLeftRotation(AVLNode<NodeData> imbalancedNode) 
        {
            RightRotation((AVLNode<NodeData>)imbalancedNode.rightChild);
            return LeftRotation(imbalancedNode);
        }

        AVLNode<NodeData> BalancingAlgorithm<AVLNode<NodeData>, NodeData>.CreateRootNode(NodeData value)
        {
            return new AVLNode<NodeData>(value);
        }

    }
}
