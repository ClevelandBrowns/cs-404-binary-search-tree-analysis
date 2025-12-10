using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_404_binary_search_tree_analysis.bst.balancing;

namespace cs_404_binary_search_tree_analysis.bst
{
    internal class AVLTestCases
    {
        public BinarySearchTree<int, AVLBalancing<int>, AVLNode<int>> Execute(int randNodeNum)
        {
            var tree = new BinarySearchTree<int, AVLBalancing<int>, AVLNode<int>>(30);


            for( int i = 0; i < randNodeNum; i++)
            {
                //tree.InsertNode();
            }

            return tree;
        }
    }
}
