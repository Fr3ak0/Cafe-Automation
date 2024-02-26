using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace cafe
{

    internal class cAddition
    {
        cGeneral gnl = new cGeneral();
        #region fields
        private int ID;
        private int ServiceTypeNo;
        private int EmployeId;
        private int TableId;
        private DateTime date;
        private bool Situation;
        #endregion
        #region Properties
        public int TableId1 { get => TableId2; set => TableId2 = value; }
        public int ServiceTypeNo1 { get => ServiceTypeNo; set => ServiceTypeNo = value; }
        public int EmployeId1 { get => EmployeId; set => EmployeId = value; }
        public int TableId2 { get => TableId; set => TableId = value; }
        public DateTime Date { get => date; set => date = value; }
        public bool Situation1 { get => Situation; set => Situation = value; } 
        #endregion

        public int getByAddition(int TableId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID From Addition Where TABLEID=@TableId Order by ID desc", con);
            cmd.Parameters.Add("@TableId",SqlDbType.Int).Value = TableId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                TableId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                
            }
            finally { con.Close(); }
            return TableId;
        }
        public bool setByAdditionNew(cAddition Infos)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Addition(SERVICETYPENO,DATE,EMPLOYEID,TABLEID,SITUATION) values(@ServiceTypeNo,@Date,@EmployeId,@TableId,@Situation)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServiceTypeNo",SqlDbType.Int).Value=Infos.ServiceTypeNo1;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = Infos.Date;
                cmd.Parameters.Add("@EmployeId", SqlDbType.Int).Value = Infos.EmployeId1;
                cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = Infos.TableId1;
                cmd.Parameters.Add("@Situation", SqlDbType.Bit).Value = 0;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());



            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                
            }
            finally 
            { 
                con.Dispose();
                con.Close(); 
            }
            return sonuc;
        }
        public void additionClose(int additionId,int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Addition set SITUATION =@situation Where ID=@additionId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("additionId",SqlDbType.Int).Value=additionId;
                cmd.Parameters.Add("situation", SqlDbType.Int).Value = state;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally 
            { 
                con.Dispose();
                con.Close();
            }
            
        }
    }
}
