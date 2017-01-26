using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;

namespace winFormsXtraTreeList
{
    public partial class frmTreeListX : Form
    {
        public frmTreeListX()
        {
            InitializeComponent();
        }

        private void frmTreeListX_Load(object sender, EventArgs e)
        {

        }


        #region TreeList Events

        /// <summary>
        /// Occurs after the PopupMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Check if a node's indicator cell is clicked.
                TreeListHitInfo hitInfo = (sender as TreeList)?.CalcHitInfo(e.Location);
                switch (hitInfo?.HitInfoType)
                {
                    case HitInfoType.Cell:
                        treeList.FocusedNode = hitInfo.Node;       //Mark as selected the clicked node.
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
            treeList.FocusedNode = e.Node;     //Auto focus after checked
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
            XtraMessageBox.Show("Selected node Name: " + treeList.FocusedNode.GetDisplayText(0));
        }

        private void barBtnDeleteNode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        #endregion

        #region Private Functionalities

        /// <summary>
        /// Delete all the selected nodes (and his children).
        /// </summary>
        /// <param name="treeList"></param>
        private void DeleteSelectedNodes(TreeList treeList)
        {
            this.treeList.LockReloadNodes();
            try
            {
                treeList.DeleteSelectedNodes();
            }
            finally
            {
                this.treeList.UnlockReloadNodes();
            }
        }

        private void DeleteAllNodes(TreeList treeList)
        {
            var tmpConfig = treeList.OptionsSelection.MultiSelect;
            this.treeList.LockReloadNodes();
            try
            {
                treeList.OptionsSelection.MultiSelect = true;
                treeList.SelectAll();
                treeList.DeleteSelectedNodes();
            }
            finally
            {
                treeList.OptionsSelection.MultiSelect = tmpConfig;
                this.treeList.UnlockReloadNodes();
            }
        }

        #endregion

        private void barBtnDeleteAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteAllNodes(treeList);
        }

        private void barBtnReloadNodes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


    }
}
