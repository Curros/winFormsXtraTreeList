using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using winFormsXtraTreeList.Models;

namespace winFormsXtraTreeList
{
    public partial class frmTreeListX : Form
    {
        NodeData _treeListNodes = new NodeData();

        public frmTreeListX()
        {
            InitializeComponent();
        }

        private void frmTreeListX_Load(object sender, EventArgs e)
        {
            _treeListNodes.Add(new NodeData(1, "test", NodeType.LAYER));
            _treeListNodes.Add(new NodeData(2, "secondTest", NodeType.GROUP));

            _treeListNodes.Add(new NodeData(3, "secondTest", NodeType.GROUP),1);

            LoadNodes(treeList);
        }

        private void LoadNodes(TreeList _treeList)
        {
            _treeList.BeginUpdate();
            _treeList.DataSource = _treeListNodes;
            _treeList.EndUpdate();
        }


        #region TreeList Events

        /// <summary>
        /// Occurs after the PopupMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList_MouseUp(object sender, MouseEventArgs e)
        {
            TreeList _treeList = (sender as TreeList);
            if (e.Button == MouseButtons.Right && _treeList != null)
            {
                // Check indicator clicked.
                TreeListHitInfo hitInfo = _treeList.CalcHitInfo(e.Location);
                switch (hitInfo?.HitInfoType)
                {
                    case HitInfoType.Cell:
                        _treeList.FocusedNode = hitInfo.Node;       //Mark as selected the clicked node.
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

        private void treeList_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            TreeList trList = (TreeList)sender;
            try
            {
                var tmp = Convert.ChangeType(e.Value, trList.FocusedNode[trList.FocusedColumn].GetType());
            }
            catch
            {
                e.Valid = false;
                //throw;
            }
        }

        private void treeList_Click(object sender, EventArgs e)
        {
            var x = e;
        }
    }
}
