using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace cafe
{
    internal class cProductTypes
    {
        cGeneral gnl = new cGeneral();
        #region fields
        private string CategoryName;
        private int ProductTypeNo;
        private int CategoryId;
        private string Description;
        #endregion

        #region properties
        public string CategoryName1 { get => CategoryName; set => CategoryName = value; }
        public int ProductTypeNo1 { get => ProductTypeNo; set => ProductTypeNo = value; }
        public int CategoryId1 { get => CategoryId; set => CategoryId = value; }
        public string Description1 { get => Description; set => Description = value; } 
        #endregion

        public void getByProductTypes(ListView Types,Button btn)
        {
            Types.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select PRODUCTNAME,PRICE,Products.ID From Categories Inner Join Products on Categories.ID=Products.CATEGORYID Where Products.CATEGORYID=@CATEGORYID and Products.SITUATION=0", con);
            string aa = btn.Name;
            int lenght=aa.Length;
            cmd.Parameters.Add("@CATEGORYID", SqlDbType.Int).Value = aa.Substring(lenght - 1, 1);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr=cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Types.Items.Add(dr["PRODUCTNAME"].ToString());
                Types.Items[i].SubItems.Add(dr["PRICE"].ToString());
                Types.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close(); 
        }
        public void getByProductSearch(ListView Types, int txt)
        {
            Types.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From Products where ID=@Id", con);
            
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = txt;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Types.Items.Add(dr["PRODUCTNAME"].ToString());
                Types.Items[i].SubItems.Add(dr["PRICE"].ToString());
                Types.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void getProductTypes(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Categories where SITUATION=0", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    cProductTypes pt = new cProductTypes();
                    pt.ProductTypeNo1 = Convert.ToInt32(dr["ID"]);
                    pt.CategoryName1 = Convert.ToString(dr["CATEGORYNAME"]);
                    pt.Description1 = Convert.ToString(dr["DESCRIPTION"]);
                    cb.Items.Add(pt);
                    
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
        public void getProductTypes(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Categories where SITUATION=0  ", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["CATEGORYNAME"].ToString());
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
        //arama
        public void getProductTypes(ListView lv,string search)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Categories where SITUATION=0 and CATEGORYNAME like '%'+ @search + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@search",SqlDbType.VarChar).Value = search;
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["CATEGORYNAME"].ToString());
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
        public int addCategory(cProductTypes pt)
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert into Categories (CATEGORYNAME,DESCRIPTION) values (@CATEGORYNAME,@DESCRIPTION)", con);
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd.Parameters.Add("@CATEGORYNAME", SqlDbType.VarChar).Value = pt.CategoryName;
                cmd.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar).Value = pt.Description1;
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
        public int updateProductscCat(cProductTypes pt)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Categories set CATEGORYNAME=@CATEGORYNAME,DESCRIPTION=@DESC where ID=@CATID", con);

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                cmd.Parameters.Add("CATEGORYNAME", SqlDbType.VarChar).Value = pt.CategoryName1;
                cmd.Parameters.Add("DESC", SqlDbType.VarChar).Value = pt.Description1;
                cmd.Parameters.Add("CATID", SqlDbType.Int).Value = pt.CategoryId1;
                
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
        public int deleteProductscCat(int id)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Categories set SITUATION=1 where ID=@CATID", con);

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();
                
                cmd.Parameters.Add("CATID", SqlDbType.Int).Value = id;

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
        public override string ToString()
        {
            return CategoryName1;
        }

    }
}
