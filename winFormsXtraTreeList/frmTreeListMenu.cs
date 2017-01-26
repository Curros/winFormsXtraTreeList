using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Menu;
using DevExpress.XtraTreeList.Nodes;

namespace winFormsXtraTreeList
{
    public partial class frmTreeListMenu : Form
    {
        public frmTreeListMenu()
        {
            InitializeComponent();
        }

        private void frmTreeListMenu_Load(object sender, EventArgs e)
        {
            LoadNodes();
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

        private void treeList1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            //if (e.Menu is TreeListNodeMenu)
            //{
            //    treeList1.FocusedNode = ((TreeListNodeMenu)e.Menu).Node;
            //}
        }

        /// <summary>
        /// Occurs after the PopupMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Check if a node's indicator cell is clicked.
                TreeListHitInfo hitInfo = (sender as TreeList).CalcHitInfo(e.Location);
                if (hitInfo.HitInfoType == HitInfoType.Cell)
                {
                    treeList1.FocusedNode = hitInfo.Node;   //Mark as selected the clicked node.
                    popupMenu.ShowPopup(Cursor.Position);   //Open the popupMenu, if a node is clicked.
                }
            }
        }

        private void barBtnRowInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show( "Selected node Name: " + treeList1.FocusedNode.GetDisplayText(0) );
        }
    }
}
