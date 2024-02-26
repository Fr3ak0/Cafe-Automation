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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTables frm = new frmTables();
            this.Close();
            frm.Show();
        }
        cOrder od = new cOrder();
        private void frmBill_Load(object sender, EventArgs e)
        {
            if (cGeneral.ServiceTypeNo == 1)
            {
                lblAdditionId.Text = cGeneral.AdditionId;
                od.getByOrder(lvProducts,Convert.ToInt32(lblAdditionId.Text));
                if (lvProducts.Items.Count > 0)
                {
                    decimal  summary = 0;
                    for (int i = 0; i < lvProducts.Items.Count; i++)
                    {
                        summary += Convert.ToDecimal(lvProducts.Items[i].SubItems[3].Text);
                    }
                    lblPricePrice.Text = string.Format("{0:0.000}",summary);
                    lblSubtotalPrice.Text = string.Format("{0:0.000}", summary);
                    decimal kdv = Convert.ToDecimal(lblPricePrice.Text)*20/100;                    
                    lblKdvPrice.Text = string.Format("{0:0.000}", kdv);
                }
            }
        }
        cTables tb = new cTables();
        private void button1_Click(object sender, EventArgs e)
        {
            if (cGeneral.ServiceTypeNo == 1)
            {

                int tableid =tb.TableGetbyNumber(cGeneral.buttonName);
                cPayment py = new cPayment();
                py.AdditionId1 = Convert.ToInt32(lblAdditionId.Text);
                py.Subtotal1 = Convert.ToDecimal(lblSubtotalPrice.Text);
                py.Total1 = Convert.ToDecimal(lblPricePrice.Text);
                py.KdvPrice1 = Convert.ToDecimal(lblKdvPrice.Text);

                bool result = py.billClose(py);
                if (result)
                {
                    MessageBox.Show("Bill Closed Succesfully.");
                    tb.setChangeTableState(Convert.ToString(tableid), 1);
                    cAddition ad = new cAddition();
                    ad.additionClose(Convert.ToInt32(lblAdditionId.Text), 0);
                    this.Close();
                    frmTables frm = new frmTables();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("While closing bill an error happened. Please contact with your Manager");
                }
            }
        }
        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        Font Header = new Font("Verdana",15,FontStyle.Bold);
        Font altHeader = new Font("Verdana", 12, FontStyle.Bold);
        Font iceik = new Font("Verdana", 10, FontStyle.Bold);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Cafe Automation", Header, sb, 350, 100, st);
            e.Graphics.DrawString("------------", altHeader, sb, 120, 100, st);
            e.Graphics.DrawString("Product Name       Count        Price", altHeader, sb, 150, 250, st);
            e.Graphics.DrawString("--------------------------------------------------", altHeader, sb, 150, 280, st);
            for (int i = 0; i < lvProducts.Items.Count; i++)
            {
                e.Graphics.DrawString(lvProducts.Items[i].SubItems[0].Text, iceik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvProducts.Items[i].SubItems[1].Text, iceik, sb, 350, 300 + i * 30, st);
                e.Graphics.DrawString(lvProducts.Items[i].SubItems[3].Text, iceik, sb, 420, 300 + i * 30, st);
            }
            e.Graphics.DrawString("--------------------------------------------------", altHeader, sb, 150, 300 + 30*lvProducts.Items.Count, st);
            e.Graphics.DrawString("KDV Tutarı        :-----------------"+lblKdvPrice.Text + "$", altHeader, sb, 250, 300 + 30 * (lvProducts.Items.Count + 1), st);
            e.Graphics.DrawString("Total Price       :-----------------" + lblPricePrice.Text + "$", altHeader, sb, 250, 300 + 30 * (lvProducts.Items.Count + 2), st);
            e.Graphics.DrawString("Paid Price        :-----------------" + lblSubtotalPrice.Text + "$", altHeader, sb, 250, 300 + 30 * (lvProducts.Items.Count + 3), st);



        }


    }
}
