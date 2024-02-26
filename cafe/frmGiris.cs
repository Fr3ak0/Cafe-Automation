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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            cGeneral gnl = new cGeneral();
            cEmployees emp = new cEmployees();
            bool result = emp.employeEntryControl(textPassword.Text,cGeneral.employeId);
            if (result)
            {
                cEmployeMovments em = new cEmployeMovments();
                em.EmployeId1 = cGeneral.employeId;
                em.Process1 = "Login";
                em.Date1 = DateTime.Now;
                em.PersonalActionSave(em);
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password","Warning !!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            cEmployees emp = new cEmployees();
            emp.employeGetbyInformation(cbUser);
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            cEmployees emp = (cEmployees)cbUser.SelectedItem;
            cGeneral.employeId = emp.EmployeId1;
            cGeneral.jobId = emp.JobId1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
