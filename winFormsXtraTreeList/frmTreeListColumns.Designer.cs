namespace winFormsXtraTreeList
{
    partial class frmTreeListColumns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeListColumns));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colStyle = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemPictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.popTreeLayer = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barBtnRowInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteNode = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barBtnDeleteAll = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnReloadNodes = new DevExpress.XtraBars.BarButtonItem();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.lblTest = new DevExpress.XtraEditors.LabelControl();
            this.popTreeEmpty = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu3 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popTreeLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popTreeEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colID,
            this.colStyle});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.Location = new System.Drawing.Point(16, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Single;
            this.treeList1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeList1.OptionsView.AnimationType = DevExpress.XtraTreeList.TreeListAnimationType.AnimateAllContent;
            this.treeList1.OptionsView.ShowCheckBoxes = true;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit});
            this.treeList1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.Default;
            this.treeList1.Size = new System.Drawing.Size(398, 231);
            this.treeList1.TabIndex = 1;
            this.treeList1.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterCheckNode);
            this.treeList1.CustomDrawNodeCheckBox += new DevExpress.XtraTreeList.CustomDrawNodeCheckBoxEventHandler(this.treeList1_CustomDrawNodeCheckBox);
            this.treeList1.PopupMenuShowing += new DevExpress.XtraTreeList.PopupMenuShowingEventHandler(this.treeList1_PopupMenuShowing);
            this.treeList1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseUp);
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 34;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 380;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Right;
            this.colID.Name = "colID";
            this.colID.OptionsColumn.FixedWidth = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            this.colID.Width = 20;
            // 
            // colStyle
            // 
            this.colStyle.Caption = " ";
            this.colStyle.ColumnEdit = this.repositoryItemPictureEdit;
            this.colStyle.FieldName = "Style";
            this.colStyle.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Right;
            this.colStyle.Name = "colStyle";
            this.colStyle.OptionsColumn.AllowEdit = false;
            this.colStyle.OptionsColumn.FixedWidth = true;
            this.colStyle.ToolTip = "Shows some styles.";
            this.colStyle.Visible = true;
            this.colStyle.VisibleIndex = 2;
            this.colStyle.Width = 20;
            // 
            // repositoryItemPictureEdit
            // 
            this.repositoryItemPictureEdit.AllowFocused = false;
            this.repositoryItemPictureEdit.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemPictureEdit.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemPictureEdit.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemPictureEdit.Name = "repositoryItemPictureEdit";
            this.repositoryItemPictureEdit.NullText = " ";
            this.repositoryItemPictureEdit.ShowMenu = false;
            this.repositoryItemPictureEdit.ZoomAccelerationFactor = 1D;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertImage(global::winFormsXtraTreeList.Properties.Resources.loading, "loading", typeof(global::winFormsXtraTreeList.Properties.Resources), 0);
            this.imageCollection.Images.SetKeyName(0, "loading");
            // 
            // popTreeLayer
            // 
            this.popTreeLayer.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnRowInfo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDeleteNode, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.popTreeLayer.Manager = this.barManager;
            this.popTreeLayer.Name = "popTreeLayer";
            // 
            // barBtnRowInfo
            // 
            this.barBtnRowInfo.Caption = "Show Row Info";
            this.barBtnRowInfo.CategoryGuid = new System.Guid("620d9883-0b22-4792-a712-4c4d6ba5d9be");
            this.barBtnRowInfo.Id = 0;
            this.barBtnRowInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRowInfo.ImageOptions.Image")));
            this.barBtnRowInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnRowInfo.ImageOptions.LargeImage")));
            this.barBtnRowInfo.Name = "barBtnRowInfo";
            this.barBtnRowInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRowInfo_ItemClick);
            // 
            // barBtnDeleteNode
            // 
            this.barBtnDeleteNode.Caption = "Delete Node";
            this.barBtnDeleteNode.Id = 1;
            this.barBtnDeleteNode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteNode.ImageOptions.Image")));
            this.barBtnDeleteNode.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteNode.ImageOptions.LargeImage")));
            this.barBtnDeleteNode.Name = "barBtnDeleteNode";
            this.barBtnDeleteNode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeleteNode_ItemClick);
            // 
            // barManager
            // 
            this.barManager.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("PopupMenu", new System.Guid("620d9883-0b22-4792-a712-4c4d6ba5d9be"))});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnRowInfo,
            this.barBtnDeleteNode,
            this.barBtnDeleteAll,
            this.barBtnReloadNodes});
            this.barManager.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(426, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 296);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(426, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 296);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(426, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 296);
            // 
            // barBtnDeleteAll
            // 
            this.barBtnDeleteAll.Caption = "Delete All Nodes";
            this.barBtnDeleteAll.Id = 2;
            this.barBtnDeleteAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteAll.ImageOptions.Image")));
            this.barBtnDeleteAll.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDeleteAll.ImageOptions.LargeImage")));
            this.barBtnDeleteAll.Name = "barBtnDeleteAll";
            this.barBtnDeleteAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeleteAll_ItemClick);
            // 
            // barBtnReloadNodes
            // 
            this.barBtnReloadNodes.Caption = "Reload Nodes";
            this.barBtnReloadNodes.Id = 3;
            this.barBtnReloadNodes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnReloadNodes.ImageOptions.Image")));
            this.barBtnReloadNodes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnReloadNodes.ImageOptions.LargeImage")));
            this.barBtnReloadNodes.Name = "barBtnReloadNodes";
            this.barBtnReloadNodes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnReloadNodes_ItemClick);
            // 
            // pictureEdit
            // 
            this.pictureEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit.Location = new System.Drawing.Point(379, 249);
            this.pictureEdit.MenuManager = this.barManager;
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit.Properties.NullText = " ";
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit.Size = new System.Drawing.Size(35, 35);
            this.pictureEdit.TabIndex = 6;
            // 
            // lblTest
            // 
            this.lblTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTest.Location = new System.Drawing.Point(311, 259);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(58, 13);
            this.lblTest.TabIndex = 11;
            this.lblTest.Text = "Bitmap test:";
            // 
            // popTreeEmpty
            // 
            this.popTreeEmpty.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDeleteAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnReloadNodes)});
            this.popTreeEmpty.Manager = this.barManager;
            this.popTreeEmpty.Name = "popTreeEmpty";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDeleteAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnReloadNodes)});
            this.popupMenu1.Manager = this.barManager;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // popupMenu2
            // 
            this.popupMenu2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDeleteAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnReloadNodes)});
            this.popupMenu2.Manager = this.barManager;
            this.popupMenu2.Name = "popupMenu2";
            // 
            // popupMenu3
            // 
            this.popupMenu3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnRowInfo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDeleteNode, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.popupMenu3.Manager = this.barManager;
            this.popupMenu3.Name = "popupMenu3";
            // 
            // frmTreeListColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 296);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.pictureEdit);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTreeListColumns";
            this.Text = "Tree List Menu";
            this.Load += new System.EventHandler(this.frmTreeListMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popTreeLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popTreeEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraBars.PopupMenu popTreeLayer;
        private DevExpress.XtraBars.BarButtonItem barBtnRowInfo;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colStyle;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colID;
        private DevExpress.XtraEditors.LabelControl lblTest;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraBars.BarButtonItem barBtnDeleteNode;
        private DevExpress.XtraBars.PopupMenu popTreeEmpty;
        private DevExpress.XtraBars.BarButtonItem barBtnDeleteAll;
        private DevExpress.XtraBars.BarButtonItem barBtnReloadNodes;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraBars.PopupMenu popupMenu3;
    }
}