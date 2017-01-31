using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
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
            _treeListNodes.Add(new NodeData(1, "type Layer", TreeListConstants.NodeType.LAYER));
            _treeListNodes.Add(new NodeData(2, "secondTest Group", TreeListConstants.NodeType.GROUP));
            _treeListNodes.Add(new NodeData(3, "secondTest Group", TreeListConstants.NodeType.STYLE),1);

            LoadNodes(treeList);
        }

        private void LoadNodes(TreeList _treeList)
        {
            _treeList.BeginUpdate();
            _treeList.DataSource = _treeListNodes;
            _treeList.EndUpdate();
            _treeList.UnlockReloadNodes();
            _treeList.ForceInitialize();
            _treeList.ExpandAll();

            LoadCheckedNodes(treeList.Nodes);
        }

        #region [ TreeList Events ]

        /// <summary>
        /// Actions to perform, used for the popUpMenus.
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

                        var nodeType = _treeListNodes[_treeList.FocusedNode.GetValue("Name").ToString()]?.Type;
                        if(nodeType == TreeListConstants.NodeType.LAYER)
                            popTreeLayer.ShowPopup(Cursor.Position);    //Open the popupMenu, if a node layer is clicked.

                        break;
                    case HitInfoType.Empty:
                        popTreeEmpty.ShowPopup(Cursor.Position);
                        break;
                }
            }
        }

        /// <summary>
        /// Method to change/set the checked state of the node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList1_AfterCheckNode(object sender, NodeEventArgs e)
        {
            TreeList _treeList = (sender as TreeList);
            _treeList.FocusedNode = e.Node;             //Auto focus after check
            var tmpNode = _treeListNodes[_treeList.FocusedNode.GetValue("Name").ToString()];
            tmpNode.IsChecked = _treeList.FocusedNode.Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList1_CustomDrawNodeCheckBox(object sender, CustomDrawNodeCheckBoxEventArgs e)
        {
            var _treeList = (TreeList)sender;

            //Check type of node to Hide
            TreeListConstants.NodeType? _nodeType = _treeListNodes[e.Node.GetValue("Name")?.ToString()]?.Type;
            if (_treeList != null &&
                _nodeType != TreeListConstants.NodeType.LAYER &&
                _nodeType != TreeListConstants.NodeType.GROUP)
            {
                HideCheckBoxTreeList(_treeList, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList_AfterExpand(object sender, NodeEventArgs e)
        {
            LoadCheckedNodes(e.Node.Nodes);  //Set childs.
        }

        #endregion [ TreeList Events ]

        #region [ Popup Events ]

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

        private void barBtnDeleteAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barBtnReloadNodes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        #endregion [ Popup Events ]

        #region [ Private Functionalities ]

        /// <summary>
        /// Delete all the selected nodes (and his children).
        /// </summary>
        /// <param name="treeList"></param>
        private void DeleteSelectedNodes(TreeList treeList)
        {
        }

        private void DeleteAllNodes(TreeList treeList)
        {
        }

        /// <summary>
        /// Establish the check property of the node, using the model.
        /// </summary>
        /// <param name="_nodes"></param>
        private void LoadCheckedNodes(TreeListNodes _nodes)
        {
            if (_nodes.Count < 1) { return; }

            foreach (TreeListNode _node in _nodes)
            {
                var tmpNode = _treeListNodes[_node.GetValue("Name")?.ToString()];
                _node.Checked = tmpNode?.IsChecked ?? false;

                //If not expanded, the _node.Nodes.Count is 0
                if (_node.HasChildren && _node.Expanded)
                    LoadCheckedNodes(_node.Nodes);
            }
        }

        /// <summary>
        /// ReDraw on white the checkBox if you don't want to show it.
        /// </summary>
        /// <param name="_treeList"></param>
        private void HideCheckBoxTreeList(TreeList _treeList, CustomDrawNodeCheckBoxEventArgs e)
        {
            DevExpress.XtraTreeList.ViewInfo.IndentInfo ii = _treeList.ViewInfo.RowsInfo[e.Node].IndentInfo;
            int x2 = e.Bounds.Left + ii.LevelWidth / 2;
            int y2 = e.Bounds.Top + e.Bounds.Height / 2;
            int h2 = e.Bounds.Height / 2 + 1;
            Rectangle r1 = new Rectangle(e.Bounds.Left, y2, e.Bounds.Width, 1);
            Rectangle r2 = new Rectangle(x2, y2, 1, h2);
            Brush brush = _treeList.ViewInfo.RC.TreeLineBrush == null ? Brushes.Transparent : _treeList.ViewInfo.RC.TreeLineBrush;
            e.Graphics.FillRectangle(brush, r1);
            if (e.Node.Expanded)
            {
                e.Graphics.FillRectangle(brush, r2);
            }
            e.Handled = true;
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

        #endregion [ Private Functionalities ]
        
    }
}
