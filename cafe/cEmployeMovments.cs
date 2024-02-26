using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace cafe
{
    internal class cEmployeMovments
    {
        cGeneral gnl = new cGeneral();
        #region field
        private int MovmentId;
        private int EmployeId;
        private string Process;
        private DateTime Date;
        private bool situation;
        #endregion
        #region Properties
        public bool Situation { get => situation; set => situation = value; }
        public int EmployeId1 { get => EmployeId; set => EmployeId = value; }
        public string Process1 { get => Process; set => Process = value; }
        public DateTime Date1 { get => Date; set => Date = value; }
        public int MovmentId1 { get => MovmentId; set => MovmentId = value; } 
        #endregion


        public bool PersonalActionSave(cEmployeMovments em)
        {
            bool result = false; 
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into EmployeMovments(EMPLOYEID,PROCESS,DATE)Values(@empId,@pro,@dt)", con);

            try
            {
                if (con.State ==ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.Add("@empId", SqlDbType.Int).Value = em.EmployeId;
                    cmd.Parameters.Add("@pro", SqlDbType.VarChar).Value = em.Process;
                    cmd.Parameters.Add("@dt", SqlDbType.DateTime).Value = em.Date;
                    result = Convert.ToBoolean(cmd.ExecuteNonQuery());
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;
        }
    }
}
