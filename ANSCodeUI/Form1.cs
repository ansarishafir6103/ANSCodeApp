using System;
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

        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            frmCategoryList categoryList = new frmCategoryList();
            categoryList.TopLevel = false;
            panelContainer.Controls.Add(categoryList);
            categoryList.BringToFront();
            categoryList.Show();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            frmProductList productList = new frmProductList();
            productList.TopLevel = false;
            panelContainer.Controls.Add(productList);
            productList.BringToFront();
            productList.LoadRecords();
            productList.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            frmStockIn stockIn = new frmStockIn();
            stockIn.LoadProduct();
            stockIn.Show();
        }
    }
}
