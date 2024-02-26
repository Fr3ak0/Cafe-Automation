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
    public partial class frmSettings : Form
    {
        public frmSettings()
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

        private void frmSettings_Load(object sender, EventArgs e)
        {
            cEmployees em = new cEmployees();
            cEmployeJob ej = new cEmployeJob();
            string job = ej.tanimEmployeJob(cGeneral.jobId);
            if (job == "Manager" )
            {
                em.employeGetbyInformation(cbEmploye);
                ej.getEmployeJob(cbJob);
                em.getEmployeInformationsLV(lvEmployees);
                btnNewEmp.Enabled = true;
                btnDelete.Enabled = false;
                
                btnSave.Enabled = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                txtPassword.ReadOnly = true;
                txtApass.ReadOnly = true;
                lblInfo.Text = "Position : Manager / Authority unlimited / User: " + em.getEmployeName(cGeneral.employeId);
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                lblInfo.Text = "Position : Manager / Authority limited / User: " + em.getEmployeName(cGeneral.employeId);

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim() !="" || txtANewPassword.Text.Trim() != "" )
            {
                if (txtNewPassword.Text == txtANewPassword.Text)
                {
                    if (txtEmployeId.Text != "")
                    {
                        cEmployees em = new cEmployees();
                        bool result = em.employeChangePassword(Convert.ToInt32(txtEmployeId.Text), txtNewPassword.Text);
                        if (result)
                        {
                            MessageBox.Show("Password Changed Succesfully");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Choose Employee");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not same.");
                }
            }
            else
            {
                MessageBox.Show("Please fill the password area.");
            }
        }

        private void cbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            cEmployeJob ej = (cEmployeJob)cbJob.SelectedItem;
            txtJobId.Text = Convert.ToString(ej.EmployeJobId1);
        }

        private void cbEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            cEmployees em = (cEmployees)cbEmploye.SelectedItem;
            txtEmployeId.Text = Convert.ToString(em.EmployeId1);
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            btnNewEmp.Enabled = false;
            btnSave.Enabled = true;
            
            btnDelete.Enabled = false;
            txtPassword.ReadOnly = false;
            txtApass.ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedItems.Count > 0)
            {

                if (MessageBox.Show("Are you sure deleting this user", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cEmployees em = new cEmployees();
                    bool result = em.employeDelete(Convert.ToInt32(lvEmployees.SelectedItems[0].Text));
                    if (result)
                    {
                        MessageBox.Show("Deleted Succesfully.");
                        em.getEmployeInformationsLV(lvEmployees);
                        txtName.Clear();
                        txtSurname.Clear();
                        
                    }
                    else
                    {
                        MessageBox.Show("While deleting an error occured.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select any item.");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != ""&txtSurname.Text.Trim() != "" & txtPassword.Text.Trim() != "" & txtApass.Text!="" & txtJobId.Text.Trim() != "")
            {
                if (txtPassword.Text.Trim() == txtApass.Text.Trim())
                {
                    cEmployees em = new cEmployees();
                    em.EmployeName1 = txtName.Text.Trim();
                    em.EmployeSurname1 = txtSurname.Text.Trim();
                    em.EmployePassword1 = txtPassword.Text.Trim();
                    em.JobId1= Convert.ToInt32(txtJobId.Text.Trim());
                    bool result =em.employeAdd(em);
                    if (result)
                    {
                        MessageBox.Show("Added Succesfully.");
                        em.getEmployeInformationsLV(lvEmployees);
                        txtName.Clear();
                        txtSurname.Clear();
                        txtPassword.Clear();
                        txtApass.Clear();

                    }
                    else
                    {
                        MessageBox.Show("While adding an error occured.");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not same.");
                }
                        
            }
            else
            {
                MessageBox.Show("Please fill all areas.");
            }
        }

        

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            if (txtNewPassword1.Text.Trim() != "" || txtANewPassword1.Text.Trim() != "")
            {
                if (txtNewPassword1.Text == txtANewPassword1.Text)
                {
                    if (cGeneral.employeId.ToString() != "")
                    {
                        cEmployees em = new cEmployees();
                        bool result = em.employeChangePassword(Convert.ToInt32(cGeneral.employeId), txtNewPassword1.Text);
                        if (result)
                        {
                            MessageBox.Show("Password Changed Succesfully");
                            txtANewPassword1.Clear();
                            txtNewPassword1.Clear();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Passwords are not same.");
                }
            }
            else
            {
                MessageBox.Show("Please fill the password area.");
            }
        }

        private void lvEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvEmployees.SelectedItems.Count > 0)
            {
                btnDelete.Enabled = true;
                txtEmpId.Text = lvEmployees.SelectedItems[0].SubItems[0].Text;
                
                cbJob.SelectedIndex = Convert.ToInt32(lvEmployees.SelectedItems[0].SubItems[1].Text) - 1;
                txtName.Text = lvEmployees.SelectedItems[0].SubItems[3].Text;
                txtSurname.Text = lvEmployees.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                btnDelete.Enabled = false;

            }

        }
    }
}
