﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ANSCodeUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnManageBrand_Click(object sender, EventArgs e)
        {
            frmBrandList brandList = new frmBrandList();
            brandList.TopLevel = false;
            panelContainer.Controls.Add(brandList);
            brandList.BringToFront();
            brandList.Show();
        }
    }
}