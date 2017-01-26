using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Menu;
using DevExpress.XtraTreeList.Nodes;

namespace winFormsXtraTreeList
{
    public partial class frmTreeListColumns : Form
    {

        Bitmap image = null;

        public frmTreeListColumns()
        {
            InitializeComponent();
        }

        private void frmTreeListMenu_Load(object sender, EventArgs e)
        {
            #region Image/Graphic

            Rectangle rect = new Rectangle(0, 0, 16, 16);
            image = new Bitmap(rect.Width, rect.Height);
            using (Graphics g = Graphics.FromImage(image))
            {
                g.FillRectangle(new SolidBrush(Color.Red), rect);
                g.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(0, 0, rect.Width - 1, rect.Height - 1));
                g.PageUnit = GraphicsUnit.Pixel;
            }

            pictureEdit.Image = image;

            #endregion

            LoadNodes(treeList1);
        }

        private void LoadNodes(TreeList treeList)
        {
            //Parents
            TreeListNode codeNode = treeList.AppendNode(null, null);
            codeNode.SetValue("Name", "Group");
            codeNode.SetValue("Style", null);

            TreeListNode docsNode = treeList.AppendNode(null, null);
            docsNode.SetValue("Name", "Documents");
            docsNode.SetValue("Style", null);

            TreeListNode videosNode = treeList.AppendNode(null, null);
            videosNode.SetValue("Name", "Videos");
            videosNode.SetValue("Style", null);

            //Children
            //Code
            TreeListNode childNode = null;

            childNode = treeList.AppendNode(null, codeNode);
            childNode.SetValue(colName, "Layer with Styles");
            childNode.SetValue(colID, "1");

            TreeListNode childNode2 = null;
            childNode2 = treeList.AppendNode(null, childNode);
            childNode2.SetValue(colName, "Style layer");
            childNode2.SetValue(colID, "1a");
            childNode2.SetValue(colStyle, image);     //Adding Image (Be careful with selector.)

            codeNode.Expanded = true;   //Better do after the Children are added.
            codeNode.Checked = true;
            childNode.Expanded = true;   //Better do after the Children are added.

            childNode = treeList.AppendNode(null, codeNode);
            childNode.SetValue("Name", "Layer Loading");
            childNode.SetValue(colID, "2");
            childNode.SetValue(colStyle, Properties.Resources.loading);     //Adding Image (Be careful with selector.)

            //Docs
            childNode = treeList.AppendNode(null, docsNode);
            childNode.SetValue("Name", "Data layer");
            childNode.SetValue("Style", null);

            childNode = treeList.AppendNode(null, docsNode);
            childNode.SetValue("Name", "Another data layer");
            childNode.SetValue("Style", null);

            //Video
            childNode = treeList.AppendNode(null, videosNode);
            childNode.SetValue("Name", "Data layer");
            childNode.SetValue("Style", null);

            childNode = treeList.AppendNode(null, videosNode);
            childNode.SetValue("Name", "Another data layer");
            childNode.SetValue("Style", null);

            childNode = treeList.AppendNode(null, videosNode);
            childNode.SetValue("Name", "Another another data layer");
            childNode.SetValue("Style", null);
        }

        #region TreeList Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    popTreeLayer.ShowPopup(Cursor.Position);   //Open the popupMenu, if a node is clicked.
                }

                switch (hitInfo.HitInfoType)
                {
                    case HitInfoType.Cell:
                        treeList1.FocusedNode = hitInfo.Node;       //Mark as selected the clicked node.
                        popTreeLayer.ShowPopup(Cursor.Position);    //Open the popupMenu, if a node is clicked.
                        break;
                    case HitInfoType.Empty:
                        popTreeEmpty.ShowPopup(Cursor.Position);
                        break;
                }

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList1_AfterCheckNode(object sender, NodeEventArgs e)
        {
            treeList1.FocusedNode = e.Node;     //Auto focus after checked
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList1_CustomDrawNodeCheckBox(object sender, CustomDrawNodeCheckBoxEventArgs e)
        {

        }

        #endregion

        #region Popup Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barBtnRowInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Selected node Name: " + treeList1.FocusedNode.GetDisplayText(0));
        }

        private void barBtnDeleteNode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (treeList1.AllNodesCount == 0) return;
            DeleteSelectedNodes(treeList1);
        }

        #endregion

        #region Private Functionalities

        /// <summary>
        /// Delete all the selected nodes (and his children).
        /// </summary>
        /// <param name="treeList"></param>
        private void DeleteSelectedNodes(TreeList treeList)
        {
            treeList1.LockReloadNodes();
            try
            {
                treeList.DeleteSelectedNodes();
            }
            finally
            {
                treeList1.UnlockReloadNodes();
            }
        }

        private void DeleteAllNodes(TreeList treeList)
        {
            var tmpConfig = treeList.OptionsSelection.MultiSelect;
            treeList1.LockReloadNodes();
            try
            {
                treeList.OptionsSelection.MultiSelect = true;
                treeList.SelectAll();
                treeList.DeleteSelectedNodes();
            }
            finally
            {
                treeList.OptionsSelection.MultiSelect = tmpConfig;
                treeList1.UnlockReloadNodes();
            }
        }

        #endregion

        private void barBtnDeleteAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteAllNodes(treeList1);
        }

        private void barBtnReloadNodes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteAllNodes(treeList1);
            LoadNodes(treeList1);
        }
    }
}
