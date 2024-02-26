using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    internal class cProducts
    {
        cGeneral gnl = new cGeneral();
        #region fields
        private int ProductId;
        private int CategoryId;
        private string ProductName;
        private decimal Price;
        private string Desc;
        #endregion
        #region Properties
        public int ProductId1 { get => ProductId; set => ProductId = value; }
        public int CategoryId1 { get => CategoryId; set => CategoryId = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public decimal Price1 { get => Price; set => Price = value; }
        public string Desc1 { get => Desc; set => Desc = value; }
        #endregion
        public void listProductsByProductName(ListView lv, string search)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE SITUATION = 0 AND PRODUCTNAME LIKE '%' + @search + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@search", SqlDbType.VarChar).Value = search;
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd.ExecuteReader();
                int sayac = 0;
                
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["CATEGORYID"].ToString());
                    lv.Items[sayac].SubItems.Add("All Categories");
                    lv.Items[sayac].SubItems.Add(dr["PRODUCTNAME"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["PRICE"].ToString()));
                    
                    
                    sayac++;
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
        }
        public int addProduct(cProducts p)
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert into Products (PRODUCTNAME,CATEGORYID,DESCRIPTION,PRICE) values (@NAME,@CATEGORYID,@DESCRIPTION,@PRICE)", con);
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd.Parameters.Add("@NAME", SqlDbType.VarChar).Value = p.ProductName1;
                cmd.Parameters.Add("@CATEGORYID", SqlDbType.Int).Value = p.CategoryId1;
                cmd.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar).Value = p.Desc1;
                cmd.Parameters.Add("@PRICE", SqlDbType.Money).Value = p.Price1;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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
            return sonuc;
        }
        public void listProducts(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Products.*,CATEGORYNAME from Products Inner Join Categories on Categories.ID=Products.CATEGORYID where Products.SITUATION=0  ", con);
            SqlDataReader dr = null;
            
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["CATEGORYID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["CATEGORYNAME"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["PRODUCTNAME"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["PRICE"].ToString()));
                    lv.Items[sayac].SubItems.Add(dr["DESCRIPTION"].ToString());
                    
                    sayac++;
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
        }
        public int updateProducts(cProducts p)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Products set PRODUCTNAME=@PRODUCTNAME,DESCRIPTION=@DESCRIPTION,CATEGORYID=@CATEGORYID,PRICE=@PRICE where ID=@productId", con);
            
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                
                cmd.Parameters.Add("@PRODUCTNAME", SqlDbType.VarChar).Value = p.ProductName1;
                cmd.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar).Value = p.Desc1;
                cmd.Parameters.Add("@CATEGORYID", SqlDbType.Int).Value = p.CategoryId1;
                cmd.Parameters.Add("@PRICE", SqlDbType.Money).Value = p.Price1;
                cmd.Parameters.Add("@productId", SqlDbType.Int).Value = p.ProductId1;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally { con.Dispose();  con.Close(); }

            
            return sonuc;
        }
        public int deleteProducts(cProducts p,int kat)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            string sql = "Update Products set SITUATION=1 where ";
            if(kat== 0)
            {
                sql += "CATEGORYID=@productId";
            }
            else
            {
                sql += "ID=@productId";
            }
            SqlCommand cmd = new SqlCommand(sql,con);
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd.Parameters.Add("productId", SqlDbType.Int).Value = p.ProductId1;
                
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally { con.Dispose(); con.Close(); }


            return sonuc;
        }
        public void listProductsByProductId(ListView lv, int productId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Products.*,CATEGORYNAME from Products Inner Join Categories on Categories.ID=Products.CATEGORYID where Products.SITUATION=0 and Products.CATEGORYID=@productId ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("productId", SqlDbType.Int).Value = productId;
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["CATEGORYID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["CATEGORYNAME"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["PRODUCTNAME"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["PRICE"].ToString()));
                    sayac++;
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


        }
    }
}
