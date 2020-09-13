namespace ANSCodeUI
{
    partial class frmProduct
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblProductModule = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInitialQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Controls.Add(this.lblProductModule);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(713, 37);
            this.panelHeader.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(632, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 35);
            this.panel1.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.btnExit.Image = global::ANSCodeUI.Properties.Resources.Cancel;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(16, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblProductModule
            // 
            this.lblProductModule.AutoSize = true;
            this.lblProductModule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.lblProductModule.Location = new System.Drawing.Point(27, 13);
            this.lblProductModule.Name = "lblProductModule";
            this.lblProductModule.Size = new System.Drawing.Size(121, 21);
            this.lblProductModule.TabIndex = 0;
            this.lblProductModule.Text = "Product Module";
            // 
            // txtProductCode
            // 
            this.txtProductCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.txtProductCode.Location = new System.Drawing.Point(193, 65);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(471, 25);
            this.txtProductCode.TabIndex = 8;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.lblBrandName.Location = new System.Drawing.Point(106, 69);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(88, 17);
            this.lblBrandName.TabIndex = 9;
            this.lblBrandName.Text = "Product Code";
            // 
            // txtDescription
            // 
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.txtDescription.Location = new System.Drawing.Point(193, 96);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(471, 25);
            this.txtDescription.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(106, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(106, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Brand";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(193, 127);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(471, 25);
            this.cmbBrand.TabIndex = 14;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(193, 158);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(471, 25);
            this.cmbCategory.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.label3.Location = new System.Drawing.Point(106, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Category";
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.txtPrice.Location = new System.Drawing.Point(193, 190);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(471, 25);
            this.txtPrice.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.label4.Location = new System.Drawing.Point(106, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Price";
            // 
            // txtInitialQty
            // 
            this.txtInitialQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.txtInitialQty.Location = new System.Drawing.Point(193, 222);
            this.txtInitialQty.Name = "txtInitialQty";
            this.txtInitialQty.Size = new System.Drawing.Size(471, 25);
            this.txtInitialQty.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.label5.Location = new System.Drawing.Point(106, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Initial Qty";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.btnUpdate.Image = global::ANSCodeUI.Properties.Resources.Save;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(274, 253);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 30);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.btnReset.Image = global::ANSCodeUI.Properties.Resources.Reset;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(367, 253);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Cancel";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.btnSave.Image = global::ANSCodeUI.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(191, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 380);
            this.ControlBox = false;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInitialQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblBrandName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblProductModule;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblBrandName;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtInitialQty;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.ComboBox cmbBrand;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.Button btnReset;
    }
}