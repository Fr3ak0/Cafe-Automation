using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class frmTables : Form
    {
        public frmTables()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable1.Text.Length; 
            cGeneral.buttonValue=btnTable1.Text.Substring(uzunluk-6,6);
            cGeneral.buttonName = btnTable1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable2.Text.Length;
            cGeneral.buttonValue = btnTable2.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable3.Text.Length;
            cGeneral.buttonValue = btnTable3.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable4.Text.Length;
            cGeneral.buttonValue = btnTable4.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable5.Text.Length;
            cGeneral.buttonValue = btnTable5.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable5.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable6.Text.Length;
            cGeneral.buttonValue = btnTable6.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable6.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable7.Text.Length;
            cGeneral.buttonValue = btnTable7.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable7.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable8.Text.Length;
            cGeneral.buttonValue = btnTable8.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable8.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable9.Text.Length;
            cGeneral.buttonValue = btnTable9.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable9.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable10.Text.Length;
            cGeneral.buttonValue = btnTable10.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable10.Name;
            this.Close();
            frm.ShowDialog();
        }
        cGeneral gnl = new cGeneral();
        private void frmTables_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select SITUATION,ID From Tables", con);
            SqlDataReader dr = null;
            if (con.State == ConnectionState.Closed) con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name=="btnTable" + dr["ID"].ToString() && dr["SITUATION"].ToString() == "1")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources._3100540);
                        }
                        else if (item.Name == "btnTable" + dr["ID"].ToString() && dr["SITUATION"].ToString() == "2")
                        {
                            cTables tb = new cTables();
                            DateTime dt1 = Convert.ToDateTime(tb.SessionSum(2, dr["ID"].ToString()));
                            DateTime dt2 = DateTime.Now;
                            string st1 = Convert.ToDateTime(tb.SessionSum(2, dr["ID"].ToString())).ToShortTimeString();
                            string st2 = DateTime.Now.ToShortTimeString();
                            DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);
                            var fark = t2 - t1;
                            item.Text = String.Format("{0}{1}{2}",
                                fark.Days > 0 ? string.Format("{0} day", fark.Days) : "",
                                fark.Hours > 0 ? string.Format("{0} hour", fark.Hours) : "",
                                fark.Minutes > 0 ? string.Format("{0} minute", fark.Minutes) : "").Trim()+"\n\n\nTable " + dr["ID"].ToString();

                            item.BackColor = Color.Red;
                            item.BackgroundImage = (System.Drawing.Image)Properties.Resources.dolu;
                        }

                    }
                }
            }



        }

        private void btnTable11_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable11.Text.Length;
            cGeneral.buttonValue = btnTable11.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable11.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable12_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable12.Text.Length;
            cGeneral.buttonValue = btnTable12.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable12.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable13_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable13.Text.Length;
            cGeneral.buttonValue = btnTable13.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable13.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable14_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable14.Text.Length;
            cGeneral.buttonValue = btnTable14.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable14.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable15_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable15.Text.Length;
            cGeneral.buttonValue = btnTable15.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable15.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable16_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable16.Text.Length;
            cGeneral.buttonValue = btnTable16.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable16.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable17_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable17.Text.Length;
            cGeneral.buttonValue = btnTable17.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable17.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable18_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable18.Text.Length;
            cGeneral.buttonValue = btnTable18.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable18.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable19_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable19.Text.Length;
            cGeneral.buttonValue = btnTable19.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable19.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable20_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable20.Text.Length;
            cGeneral.buttonValue = btnTable20.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable20.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable21_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable21.Text.Length;
            cGeneral.buttonValue = btnTable21.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable21.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable22_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable22.Text.Length;
            cGeneral.buttonValue = btnTable22.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable22.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable23_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable23.Text.Length;
            cGeneral.buttonValue = btnTable23.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable23.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable24_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable24.Text.Length;
            cGeneral.buttonValue = btnTable24.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable24.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable25_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable25.Text.Length;
            cGeneral.buttonValue = btnTable25.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable25.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable26_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable26.Text.Length;
            cGeneral.buttonValue = btnTable26.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable26.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable27_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable27.Text.Length;
            cGeneral.buttonValue = btnTable27.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable27.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable28_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable28.Text.Length;
            cGeneral.buttonValue = btnTable28.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable28.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable29_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable29.Text.Length;
            cGeneral.buttonValue = btnTable29.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable29.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void btnTable30_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            int uzunluk = btnTable30.Text.Length;
            cGeneral.buttonValue = btnTable30.Text.Substring(uzunluk - 6, 6);
            cGeneral.buttonName = btnTable30.Name;
            this.Close();
            frm.ShowDialog();
        }
    }
}
