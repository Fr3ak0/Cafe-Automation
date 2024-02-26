using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe
{
   
    internal class cPayment
    {
        cGeneral gnl = new cGeneral();
        #region fields
        private int PaymentId;
        private int AdditionId;
        private decimal Subtotal;
        private decimal KdvPrice;
        private decimal Total;
        private DateTime date;
        #endregion
        #region Properties
        public int PaymentId1 { get => PaymentId; set => PaymentId = value; }
        public int AdditionId1 { get => AdditionId; set => AdditionId = value; }
        public decimal Subtotal1 { get => Subtotal; set => Subtotal = value; }
        public decimal KdvPrice1 { get => KdvPrice; set => KdvPrice = value; }
        public decimal Total1 { get => Total; set => Total = value; }
        public DateTime Date { get => date; set => date = value; } 
        #endregion

        public bool billClose(cPayment bill)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Payments(ADDITIONID,SUBTOTAL,KDVTUTARI,TOTAL) values (@ADDITIONID,@SUBTOTAL,@KDVTUTARI,@TOTAL)", con);
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd.Parameters.Add("ADDITIONID", SqlDbType.Int).Value = bill.AdditionId1;
                cmd.Parameters.Add("SUBTOTAL", SqlDbType.Decimal).Value = bill.Subtotal1;
                cmd.Parameters.Add("KDVTUTARI", SqlDbType.Decimal).Value = bill.KdvPrice1;
                cmd.Parameters.Add("TOTAL", SqlDbType.Decimal).Value = bill.Total1;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
            return result;
        }
    }
}
