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
    internal class cOrder
    {
        cGeneral gnl = new cGeneral();
        #region fields
        private int Id;
        private int AdditionId;
        private int ProductId;
        private int Count;
        private int TableId;
        private bool Situation;
        #endregion
        #region properties
        public int Id1 { get => Id; set => Id = value; }
        public int AdditionId1 { get => AdditionId; set => AdditionId = value; }
        public int ProductId1 { get => ProductId; set => ProductId = value; }
        public int Count1 { get => Count; set => Count = value; }
        public int TableId1 { get => TableId; set => TableId = value; } 
        #endregion
        public void getByOrder(ListView lv,int AdditionId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select PRODUCTNAME,PRICE,Sales.ID,PRODUCTID,Sales.COUNT From Sales Inner Join products on Sales.PRODUCTID=Products.ID Where ADDITIONID=@AdditionId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdditionId",SqlDbType.Int).Value=AdditionId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["PRODUCTNAME"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["COUNT"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["PRODUCTID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["PRICE"]) * Convert.ToDecimal(dr["COUNT"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally 
            {   
                dr.Close();
                con.Dispose();
                con.Close();
                
            }
        }
        public bool setSaveOrder(cOrder Infos)
        {
            bool sonuc=false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Sales(ADDITIONID,PRODUCTID,COUNT,TABLEID) values(@AdditionNo,@ProductId,@Count,@tableId)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdditionNo",SqlDbType.Int).Value=Infos.AdditionId1;
                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = Infos.ProductId1;
                cmd.Parameters.Add("@Count", SqlDbType.Int).Value = Infos.Count1;
                cmd.Parameters.Add("@tableId", SqlDbType.Int).Value = Infos.TableId1;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
            return sonuc;
        }
        public void setDeleteOrder(int salesId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Delete From Sales Where ID=@SalesID", con);
            cmd.Parameters.Add("@SalesID",SqlDbType.Int).Value= salesId;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
    }
}
