namespace ANSCodeUI
{
    partial class Form1
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.btnsystemSettings = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnManageBrand = new System.Windows.Forms.Button();
            this.btnManageCategory = new System.Windows.Forms.Button();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.btnManageSales = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.userNameLable = new System.Windows.Forms.Label();
            this.pbUserName = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1198, 37);
            this.panelHeader.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.panelLeft.Controls.Add(this.btnSignOut);
            this.panelLeft.Controls.Add(this.btnUserSettings);
            this.panelLeft.Controls.Add(this.btnsystemSettings);
            this.panelLeft.Controls.Add(this.btnRecords);
            this.panelLeft.Controls.Add(this.btnManageBrand);
            this.panelLeft.Controls.Add(this.btnManageCategory);
            this.panelLeft.Controls.Add(this.btnManageProduct);
            this.panelLeft.Controls.Add(this.btnManageSales);
            this.panelLeft.Controls.Add(this.btnDashboard);
            this.panelLeft.Controls.Add(this.userNameLable);
            this.panelLeft.Controls.Add(this.pbUserName);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 37);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 561);
            this.panelLeft.TabIndex = 1;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Image = global::ANSCodeUI.Properties.Resources.SignOut;
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(13, 448);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(222, 30);
            this.btnSignOut.TabIndex = 11;
            this.btnSignOut.Text = "Sing Out";
            this.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserSettings.FlatAppearance.BorderSize = 0;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.ForeColor = System.Drawing.Color.White;
            this.btnUserSettings.Image = global::ANSCodeUI.Properties.Resources.UserSettings;
            this.btnUserSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSettings.Location = new System.Drawing.Point(13, 412);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(222, 30);
            this.btnUserSettings.TabIndex = 10;
            this.btnUserSettings.Text = "User Settings";
            this.btnUserSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserSettings.UseVisualStyleBackColor = true;
            // 
            // btnsystemSettings
            // 
            this.btnsystemSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsystemSettings.FlatAppearance.BorderSize = 0;
            this.btnsystemSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsystemSettings.ForeColor = System.Drawing.Color.White;
            this.btnsystemSettings.Image = global::ANSCodeUI.Properties.Resources.SystemSettings;
            this.btnsystemSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsystemSettings.Location = new System.Drawing.Point(13, 375);
            this.btnsystemSettings.Name = "btnsystemSettings";
            this.btnsystemSettings.Size = new System.Drawing.Size(222, 30);
            this.btnsystemSettings.TabIndex = 9;
            this.btnsystemSettings.Text = "System Settings";
            this.btnsystemSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsystemSettings.UseVisualStyleBackColor = true;
            // 
            // btnRecords
            // 
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.ForeColor = System.Drawing.Color.White;
            this.btnRecords.Image = global::ANSCodeUI.Properties.Resources.Records;
            this.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.Location = new System.Drawing.Point(13, 336);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(222, 30);
            this.btnRecords.TabIndex = 8;
            this.btnRecords.Text = "Records";
            this.btnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecords.UseVisualStyleBackColor = true;
            // 
            // btnManageBrand
            // 
            this.btnManageBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageBrand.FlatAppearance.BorderSize = 0;
            this.btnManageBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBrand.ForeColor = System.Drawing.Color.White;
            this.btnManageBrand.Image = global::ANSCodeUI.Properties.Resources.Brand;
            this.btnManageBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBrand.Location = new System.Drawing.Point(13, 299);
            this.btnManageBrand.Name = "btnManageBrand";
            this.btnManageBrand.Size = new System.Drawing.Size(222, 30);
            this.btnManageBrand.TabIndex = 7;
            this.btnManageBrand.Text = "Manage Brand";
            this.btnManageBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageBrand.UseVisualStyleBackColor = true;
            this.btnManageBrand.Click += new System.EventHandler(this.btnManageBrand_Click);
            // 
            // btnManageCategory
            // 
            this.btnManageCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCategory.FlatAppearance.BorderSize = 0;
            this.btnManageCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCategory.ForeColor = System.Drawing.Color.White;
            this.btnManageCategory.Image = global::ANSCodeUI.Properties.Resources.Category;
            this.btnManageCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCategory.Location = new System.Drawing.Point(13, 261);
            this.btnManageCategory.Name = "btnManageCategory";
            this.btnManageCategory.Size = new System.Drawing.Size(222, 30);
            this.btnManageCategory.TabIndex = 6;
            this.btnManageCategory.Text = "Manage Category";
            this.btnManageCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageCategory.UseVisualStyleBackColor = true;
            this.btnManageCategory.Click += new System.EventHandler(this.btnManageCategory_Click);
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageProduct.FlatAppearance.BorderSize = 0;
            this.btnManageProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProduct.ForeColor = System.Drawing.Color.White;
            this.btnManageProduct.Image = global::ANSCodeUI.Properties.Resources.Product;
            this.btnManageProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProduct.Location = new System.Drawing.Point(13, 224);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(222, 30);
            this.btnManageProduct.TabIndex = 5;
            this.btnManageProduct.Text = "Manage Product";
            this.btnManageProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageProduct.UseVisualStyleBackColor = true;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // btnManageSales
            // 
            this.btnManageSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSales.FlatAppearance.BorderSize = 0;
            this.btnManageSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSales.ForeColor = System.Drawing.Color.White;
            this.btnManageSales.Image = global::ANSCodeUI.Properties.Resources.Sales;
            this.btnManageSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageSales.Location = new System.Drawing.Point(13, 188);
            this.btnManageSales.Name = "btnManageSales";
            this.btnManageSales.Size = new System.Drawing.Size(222, 30);
            this.btnManageSales.TabIndex = 4;
            this.btnManageSales.Text = "Manage Sales";
            this.btnManageSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageSales.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::ANSCodeUI.Properties.Resources.Dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(13, 151);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(222, 30);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // userNameLable
            // 
            this.userNameLable.AutoSize = true;
            this.userNameLable.ForeColor = System.Drawing.Color.White;
            this.userNameLable.Location = new System.Drawing.Point(73, 108);
            this.userNameLable.Name = "userNameLable";
            this.userNameLable.Size = new System.Drawing.Size(76, 17);
            this.userNameLable.TabIndex = 2;
            this.userNameLable.Text = "USERNAME";
            this.userNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbUserName
            // 
            this.pbUserName.BackColor = System.Drawing.Color.White;
            this.pbUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserName.Image = global::ANSCodeUI.Properties.Resources.AdminSettings;
            this.pbUserName.Location = new System.Drawing.Point(78, 37);
            this.pbUserName.Name = "pbUserName";
            this.pbUserName.Size = new System.Drawing.Size(68, 68);
            this.pbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserName.TabIndex = 0;
            this.pbUserName.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 37);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(948, 561);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 598);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pbUserName;
        private System.Windows.Forms.Label userNameLable;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManageCategory;
        private System.Windows.Forms.Button btnManageProduct;
        private System.Windows.Forms.Button btnManageSales;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnManageBrand;
        private System.Windows.Forms.Button btnUserSettings;
        private System.Windows.Forms.Button btnsystemSettings;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel panelContainer;
    }
}

