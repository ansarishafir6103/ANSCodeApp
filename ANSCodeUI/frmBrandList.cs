using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANSCodeUI
{
    public partial class frmBrandList : Form
    {
        #region Variables
        private const string _msgHeader = "Barnd List Form";

        #endregion
        #region Constructors  
        #region frmBrandList
        public frmBrandList()
        {
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                grvData.Rows.Add(i, "1", "BRAND1" + i);
            }

        }
        #endregion

        #endregion

        #region Events
        #region btnAdd_Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrand frmBrand = new frmBrand();
                frmBrand.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, _msgHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #endregion


    }
}
