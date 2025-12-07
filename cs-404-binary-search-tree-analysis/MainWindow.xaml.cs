using System.Windows;
using cs_404_binary_search_tree_analysis.bst.balancing;
using cs_404_binary_search_tree_analysis.bst;

namespace cs_404_binary_search_tree_analysis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new BinarySearchTree<string, AVLBalancing<string>>(new Node<string>());

        }
    }
}