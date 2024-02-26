using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnTableOrder_Click(object sender, EventArgs e)
        {
            frmTables frm = new frmTables();
            this.Close();
            frm.Show();
        }

        private void btnKasaİşlemleri_Click(object sender, EventArgs e)
        {
            frmKasaİşlemleri frm = new frmKasaİşlemleri();
            this.Close();
            frm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            this.Close();
            frm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            this.Close();
            frm.Show();
        }
        
        private void btnKitchen_Click_1(object sender, EventArgs e)
        {
            frmKitchen frm = new frmKitchen();
            this.Close();
            frm.Show();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            frmLock frm = new frmLock();
            this.Close();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
