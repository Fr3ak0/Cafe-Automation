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
    public partial class frmKasaİşlemleri : Form
    {
        public frmKasaİşlemleri()
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

        private void btnCalcDailyTr_Click(object sender, EventArgs e)
        {
            
            lblTodayxx.Visible = true;
            
            DailySalesCalculator calc = new DailySalesCalculator();
            lblTodayxx.Text= "Your total turnover in this day :"  + calc.GetTotalPaymentsForToday().ToString() +"$";
        }

        private void btnCalcMonthlyTr_Click(object sender, EventArgs e)
        {
            
            lblMonthxx.Visible = true;
            
            DailySalesCalculator calc = new DailySalesCalculator();
            lblMonthxx.Text = "Your total turnover in this month :"+calc.GetTotalPaymentsForMonth().ToString()+"$";
        }
    }
}
