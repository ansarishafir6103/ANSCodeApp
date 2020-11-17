namespace ANSCodeUI
{
    partial class frmSettle
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblBrandModule = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.lblBrandModule);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(243, 37);
            this.panelHeader.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.btnExit.Image = global::ANSCodeUI.Properties.Resources.Cancel;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(184, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblBrandModule
            // 
            this.lblBrandModule.AutoSize = true;
            this.lblBrandModule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.lblBrandModule.Location = new System.Drawing.Point(27, 13);
            this.lblBrandModule.Name = "lblBrandModule";
            this.lblBrandModule.Size = new System.Drawing.Size(113, 21);
            this.lblBrandModule.TabIndex = 0;
            this.lblBrandModule.Text = "Settel Payment";
            // 
            // txtSale
            // 
            this.txtSale.Enabled = false;
            this.txtSale.Location = new System.Drawing.Point(11, 44);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(229, 25);
            this.txtSale.TabIndex = 3;
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(10, 80);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(229, 25);
            this.txtCash.TabIndex = 4;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(9, 116);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(229, 25);
            this.txtChange.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEnter);
            this.panel3.Controls.Add(this.btn00);
            this.panel3.Controls.Add(this.btn3);
            this.panel3.Controls.Add(this.btn2);
            this.panel3.Controls.Add(this.btn1);
            this.panel3.Controls.Add(this.btn0);
            this.panel3.Controls.Add(this.btn6);
            this.panel3.Controls.Add(this.btn5);
            this.panel3.Controls.Add(this.btn4);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btn9);
            this.panel3.Controls.Add(this.btn8);
            this.panel3.Controls.Add(this.btn7);
            this.panel3.Location = new System.Drawing.Point(9, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 214);
            this.panel3.TabIndex = 6;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.LightGray;
            this.btnEnter.Location = new System.Drawing.Point(7, 163);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(210, 46);
            this.btnEnter.TabIndex = 17;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.Color.LightGray;
            this.btn00.Location = new System.Drawing.Point(174, 112);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(45, 46);
            this.btn00.TabIndex = 16;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = false;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightGray;
            this.btn3.Location = new System.Drawing.Point(121, 112);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 46);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightGray;
            this.btn2.Location = new System.Drawing.Point(64, 112);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 46);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightGray;
            this.btn1.Location = new System.Drawing.Point(7, 112);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 46);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.LightGray;
            this.btn0.Location = new System.Drawing.Point(173, 60);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(45, 46);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.LightGray;
            this.btn6.Location = new System.Drawing.Point(121, 60);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 46);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LightGray;
            this.btn5.Location = new System.Drawing.Point(64, 60);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 46);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LightGray;
            this.btn4.Location = new System.Drawing.Point(7, 60);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 46);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Location = new System.Drawing.Point(172, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 46);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.LightGray;
            this.btn9.Location = new System.Drawing.Point(117, 7);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 46);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.LightGray;
            this.btn8.Location = new System.Drawing.Point(62, 7);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 46);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.LightGray;
            this.btn7.Location = new System.Drawing.Point(7, 8);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 46);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // frmSettle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 361);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.txtSale);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSettle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblBrandModule;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        public System.Windows.Forms.TextBox txtSale;
        public System.Windows.Forms.TextBox txtCash;
        public System.Windows.Forms.TextBox txtChange;
    }
}