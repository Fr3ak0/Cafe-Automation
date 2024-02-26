using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    internal class cEmployeJob
    {
        cGeneral gnl = new cGeneral();
        #region fields
        private int EmployeJobId;
        private string tanim;
        #endregion

        #region properties
        public string Tanim { get => tanim; set => tanim = value; }
        public int EmployeJobId1 { get => EmployeJobId; set => EmployeJobId = value; } 
        #endregion

        public void getEmployeJob(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from EmployeJobs", con);
            SqlDataReader dr = null; 

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cEmployeJob ej = new cEmployeJob();
                    ej.EmployeJobId1 = Convert.ToInt32(dr["ID"].ToString());
                    ej.Tanim = dr["JOB"].ToString();
                    cb.Items.Add(ej);
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            dr.Close();
            con.Close();
        }
        public string tanimEmployeJob(int emp)
        {
            string result = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select JOB from EmployeJobs where ID=@empId", con);
            cmd.Parameters.Add("empId",SqlDbType.Int).Value = emp;

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
        public override string ToString()
        {
            return tanim;
        }
        

    }
}
