using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace cafe
{
    internal class cTables
    {
        #region field
        private int tableId;
        private int capasite;
        private int servicetype;
        private int situation;
        private bool confrimation;
        #endregion
        #region properties
        public int TableId { get => tableId; set => tableId = value; }
        public int Capasite { get => capasite; set => capasite = value; }
        public int Servicetype { get => servicetype; set => servicetype = value; }
        public int Situation { get => situation; set => situation = value; }
        public bool Confrimation { get => confrimation; set => confrimation = value; } 
        #endregion
        cGeneral gnl = new cGeneral();
        public string SessionSum(int state,string tableId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select DATE,TABLEID From Addition Right Join Tables on Addition.TABLEID=Tables.ID Where Tables.SITUATION=@situation and Addition.SITUATION=0 and Tables.ID=@tableId",con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@situation",SqlDbType.Int).Value =state;
            cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = Convert.ToInt32(tableId);
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["DATE"]).ToString();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }
        public int TableGetbyNumber(string TableValue)
        {
            string aa = TableValue;
            int lenght= aa.Length;
            if (lenght > 9)
            {
                return Convert.ToInt32(aa.Substring(lenght - 2, 2));
            }
            else
            {
                return Convert.ToInt32(aa.Substring(lenght - 1, 1));
            }
            
        }
        public bool TableGetbyState(int ButtonName,int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select SITUATION From Tables Where ID=@TableId and SITUATION=@state", con);
            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@state",SqlDbType.Int).Value=state;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose( );
                con.Close();
            }
            return result;
        }
        public void setChangeTableState(string ButtonName,int state)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Tables Set SITUATION=@Situation where ID=@TableNo", con);
            
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string aa = ButtonName;
            int lenght = aa.Length;
            string tableNo = Regex.Match(ButtonName, @"\d+").Value;

            cmd.Parameters.Add("@Situation",SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@TableNo",SqlDbType.Int).Value=tableNo;
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
    }
}
