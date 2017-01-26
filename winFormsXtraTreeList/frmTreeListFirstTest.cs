using System;
using System.Windows.Forms;

using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;


namespace winFormsXtraTreeList
{
    public partial class frmTreeListFirstTest : Form
    {
        public frmTreeListFirstTest()
        {
            InitializeComponent();
        }

        private void frmTreeListTest_Load(object sender, EventArgs e)
        {
            LoadNodes();    //Se cargan los datos de los nodos de ejemplo.

        }

        private void LoadNodes()
        {
            //Parents
            TreeListNode codeNode = treeList1.AppendNode(null, null);
            codeNode.SetValue("Name", "Code");

            TreeListNode docsNode = treeList1.AppendNode(null, null);
            docsNode.SetValue("Name", "Documents");

            TreeListNode videosNode = treeList1.AppendNode(null, null);
            videosNode.SetValue("Name", "Videos");

            //Childs
            TreeListNode childNode = null;
            childNode = treeList1.AppendNode(null, codeNode);
            childNode.SetValue("Name", "Data layer");

            childNode = treeList1.AppendNode(null, codeNode);
            childNode.SetValue("Name", "Another data layer");

            childNode = treeList1.AppendNode(null, docsNode);
            childNode.SetValue("Name", "Data layer");

            childNode = treeList1.AppendNode(null, docsNode);
            childNode.SetValue("Name", "Another data layer");

            childNode = treeList1.AppendNode(null, videosNode);
            childNode.SetValue("Name", "Data layer");

            childNode = treeList1.AppendNode(null, videosNode);
            childNode.SetValue("Name", "Another data layer");

            childNode = treeList1.AppendNode(null, videosNode);
            childNode.SetValue("Name", "Another another data layer");
        }
    }
}
