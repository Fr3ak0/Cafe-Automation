using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace cafe
{
    internal class cEmployees
    {
        cGeneral gnl = new cGeneral();
        #region Fields
        private int EmployeId;
        private int JobId;
        private string EmployeName;
        private string EmployeSurname;
        private string EmployePassword;
        private string EmployeUsername;
        private bool situation;
        #endregion
        #region Properties
        public int EmployeId1 { get => EmployeId; set => EmployeId = value; }
        public int JobId1 { get => JobId; set => JobId = value; }
        public string EmployeName1 { get => EmployeName; set => EmployeName = value; }
        public string EmployeSurname1 { get => EmployeSurname; set => EmployeSurname = value; }
        public string EmployePassword1 { get => EmployePassword; set => EmployePassword = value; }
        public string EmployeUsername1 { get => EmployeUsername; set => EmployeUsername = value; }
        public bool Situation { get => situation; set => situation = value; } 
        #endregion

        public bool employeEntryControl (string password,int UserId)
        {
            bool result =false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Employees where ID=@Id and PASSWORD=@password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State==ConnectionState.Closed) con.Open();
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            return result;
        }
        public void employeGetbyInformation(ComboBox cb)
        {
            cb.Items.Clear();
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Employees where SITUATION=0", con);
       
            if (con.State == ConnectionState.Closed) con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cEmployees emp = new cEmployees();
                emp.EmployeId = Convert.ToInt32(dr["ID"]);
                emp.JobId = Convert.ToInt32(dr["JOBID"]);
                emp.EmployeName = Convert.ToString(dr["NAME"]);
                emp.EmployeSurname = Convert.ToString(dr["SURNAME"]);
                emp.EmployePassword = Convert.ToString(dr["PASSWORD"]);
                emp.EmployeUsername = Convert.ToString(dr["USERNAME"]);
                emp.situation = Convert.ToBoolean(dr["SITUATION"]);
                cb.Items.Add(emp);
            }
            dr.Close();
            con.Close();
        }
        public override string ToString() 
        {
            string giris = EmployeName + " " + EmployeSurname;
            return giris;
        }
        public void getEmployeInformationsLV(ListView lv)
        {
            lv.Items.Clear();
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Employees.*,EmployeJobs.JOB from Employees Inner join EmployeJobs on EmployeJobs.ID=Employees.JOBID where Employees.SITUATION=0", con);

            if (con.State == ConnectionState.Closed) con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["JOBID"].ToString());
                lv.Items[i].SubItems.Add(dr["JOB"].ToString());
                lv.Items[i].SubItems.Add(dr["NAME"].ToString());
                lv.Items[i].SubItems.Add(dr["SURNAME"].ToString());
                lv.Items[i].SubItems.Add(dr["USERNAME"].ToString());
                i++;
            }
            dr.Close();
            con.Close();


        }
        public void getEmployeInformationsFromIDLV(ListView lv, int empId)
        {
            lv.Items.Clear();
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Employees.*,EmployeJobs.JOB from Employees Inner join " +
                "EmployeJobs on EmployeJobs.ID=Employees.JOBID where Employees.SITUATION=0 and Employees.ID=@empId", con);
            cmd.Parameters.Add("empId", SqlDbType.Int).Value = empId;

            if (con.State == ConnectionState.Closed) con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["JOBID"].ToString());
                lv.Items[i].SubItems.Add(dr["JOB"].ToString());
                lv.Items[i].SubItems.Add(dr["NAME"].ToString());
                lv.Items[i].SubItems.Add(dr["SURNAME"].ToString());
                lv.Items[i].SubItems.Add(dr["USERNAME"].ToString());
                i++;
            }
            dr.Close();
            con.Close();


        }
        public string getEmployeName(int empId)
        {
            string result = "";

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select NAME + SURNAME from Employees where Employees.SITUATION=0 and Employees.ID=@empId", con);
            cmd.Parameters.Add("empId", SqlDbType.Int).Value = empId;


            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                result = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            con.Close();
            return result;

        }
        public bool employeChangePassword(int employeId, string pass)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Employees set PASSWORD=@pass where ID=@empId", con);
            cmd.Parameters.Add("empId", SqlDbType.Int).Value = employeId;
            cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = pass;

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            con.Close();
            return result;
        }
        public bool employeAdd(cEmployees em)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert into Employees (NAME,SURNAME,JOBID,PASSWORD) values (@NAME,@SURNAME,@JOBID,@PASSWORD)", con);
            cmd.Parameters.Add("@NAME", SqlDbType.VarChar).Value = em.EmployeName1;
            cmd.Parameters.Add("@SURNAME", SqlDbType.VarChar).Value = em.EmployeSurname1;
            cmd.Parameters.Add("@JOBID", SqlDbType.Int).Value = em.JobId1;
            
            cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = em.EmployePassword1;
            

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            con.Close();
            return result;
        }
        public bool employeUpdate(cEmployees em, int empId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Employees set NAME=@NAME,SURNAME=@SURNAME,JOBID=@JOBID,PASSWORD=@PASSWORD where ID=@empId", con);
            cmd.Parameters.Add("empId", SqlDbType.Int).Value = empId;
            cmd.Parameters.Add("NAME", SqlDbType.VarChar).Value = em.EmployeName1;
            cmd.Parameters.Add("SURNAME", SqlDbType.VarChar).Value = em.EmployeSurname1;
            cmd.Parameters.Add("JOBID", SqlDbType.VarChar).Value = em.JobId1;
            cmd.Parameters.Add("PASSWORD", SqlDbType.Int).Value = em.EmployePassword1;
            

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            con.Close();
            return result;
        }
        public bool employeDelete(int empId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Employees set SITUATION=1 where ID=@empId", con);
            cmd.Parameters.Add("empId", SqlDbType.Int).Value = empId;

           

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            con.Close();
            return result;
        }
    }
}
