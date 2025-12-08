using System.Windows;
using cs_404_binary_search_tree_analysis.bst.balancing;
using cs_404_binary_search_tree_analysis.bst;
using System.Diagnostics;
using System.Text;

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
            var tree = new BinarySearchTree<int, AVLBalancing<int>, AVLNode<int>>(30);

            tree.InsertNode(new AVLNode<int>(20));
            tree.InsertNode(new AVLNode<int>(10));
            tree.InsertNode(new AVLNode<int>(100));
            tree.InsertNode(new AVLNode<int>(80));
            tree.InsertNode(new AVLNode<int>(70));
            tree.InsertNode(new AVLNode<int>(60));
            tree.InsertNode(new AVLNode<int>(65));
            tree.InsertNode(new AVLNode<int>(75));
            tree.InsertNode(new AVLNode<int>(90));

            StringBuilder sb = new StringBuilder();

            foreach(List<string> s in tree.ToTable())
            {
                foreach(string str in s)
                {
                    sb.Append(str);
                    sb.Append("   ");

                }
                sb.AppendLine("");
            }

            TextBox.AppendText(sb.ToString());
        }
    }
}