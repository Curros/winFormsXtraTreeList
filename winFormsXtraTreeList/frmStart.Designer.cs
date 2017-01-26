namespace winFormsXtraTreeList
{
    partial class frmStart
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
            this.btnOpen1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnOpen2 = new DevExpress.XtraEditors.SimpleButton();
            this.lblFormTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnOpen3 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnOpen1
            // 
            this.btnOpen1.Location = new System.Drawing.Point(255, 69);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(170, 40);
            this.btnOpen1.TabIndex = 0;
            this.btnOpen1.Text = "Abrir";
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(12, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(219, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ejemplo sencillo con multiples nodos con hijos.";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.Location = new System.Drawing.Point(12, 125);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(219, 39);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ejemplo sencillo con multiples nodos con hijos, añadiendo menu de opciones en dis" +
    "tintos lugares del control.";
            // 
            // btnOpen2
            // 
            this.btnOpen2.Location = new System.Drawing.Point(255, 125);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(170, 40);
            this.btnOpen2.TabIndex = 2;
            this.btnOpen2.Text = "Abrir";
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Appearance.Options.UseFont = true;
            this.lblFormTitle.Location = new System.Drawing.Point(119, 12);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(195, 25);
            this.lblFormTitle.TabIndex = 4;
            this.lblFormTitle.Text = "Prueba de TreeList";
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl3.Location = new System.Drawing.Point(12, 187);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(219, 26);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Ejemplo sencillo con multiples nodos con hijos, añadiendo distintas columnas.";
            // 
            // btnOpen3
            // 
            this.btnOpen3.Location = new System.Drawing.Point(255, 181);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(170, 40);
            this.btnOpen3.TabIndex = 5;
            this.btnOpen3.Text = "Abrir";
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen3_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 297);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnOpen3);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnOpen1);
            this.Name = "frmStart";
            this.Text = "Tree List Tests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOpen1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnOpen2;
        private DevExpress.XtraEditors.LabelControl lblFormTitle;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnOpen3;
    }
}