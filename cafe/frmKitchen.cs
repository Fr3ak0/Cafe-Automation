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
    public partial class frmKitchen : Form
    {
        public frmKitchen()
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

        private void frmKitchen_Load(object sender, EventArgs e)
        {

            cProductTypes AnaCategory = new cProductTypes();
            AnaCategory.getProductTypes(cbCategory);
            cbCategory.Items.Insert(0,"All Categories");
            cbCategory.SelectedIndex= 0;
            label1.Visible = false;
            txtSearch.Visible = false;
            cProducts p= new cProducts();
            p.listProducts(lvGıdaListesi);
        }
        private void Clearr()
        {
            txtProductName.Clear();
            txtProductPrice.Clear();
            txtCategoryId.Clear();
            txtCategoryName.Clear();
            txtDesc.Clear();
            txtProductPrice.Text = string.Format("{0:##0.00}", 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rAddProduct.Checked)
            {
                if (txtProductName.Text.Trim()==""||txtProductPrice.Text.Trim()==""||cbCategory.SelectedItem.ToString()== "All Categories")
                {
                    MessageBox.Show("Please Choose Product Name and Category","Warning,Infos Empty", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    cProducts p= new cProducts();
                    p.Price1= Convert.ToDecimal(txtProductPrice.Text);
                    p.ProductName1 = txtProductName.Text;
                    p.Desc1 = "added";
                    p.CategoryId1 = producttypeNo;
                    int sonuc=p.addProduct(p);
                    if (sonuc!=0)
                    {
                        MessageBox.Show("Product added Succesfully");
                        Restart();
                        Clearr();
                    }
                }
            }
            else
            {
                if (txtCategoryName.Text.Trim()=="")
                {
                    MessageBox.Show("Please Enter Category Name", "Warning,Infos Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else 
                { 
                    cProductTypes pt= new cProductTypes();
                    pt.CategoryName1= txtCategoryName.Text;
                    pt.Description1=txtDesc.Text;
                    int result =pt.addCategory(pt);
                    if (result!=0)
                    {
                        MessageBox.Show("Category added Succesfully");
                        Restart();
                        Clearr();
                    }
                }
            }
        }
        int producttypeNo = 0;
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cProducts p = new cProducts();
            if (cbCategory.SelectedItem.ToString()== "All Categories")
            {
                p.listProducts(lvGıdaListesi);
            }
            else
            {
                cProductTypes pt= (cProductTypes)cbCategory.SelectedItem;
                producttypeNo = pt.ProductTypeNo1;
                p.listProductsByProductId(lvGıdaListesi,producttypeNo);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (rAddProduct.Checked)
            {
                if (txtProductName.Text.Trim() == "" || txtProductPrice.Text.Trim() == "" || cbCategory.SelectedItem.ToString() == "All Categories")
                {
                    MessageBox.Show("Please Choose Product Name and Category", "Warning,Infos Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cProducts p = new cProducts();
                    p.Price1 = Convert.ToDecimal(txtProductPrice.Text);
                    p.ProductName1 = txtProductName.Text;
                    p.CategoryId1=producttypeNo;
                    p.Desc1 = "Updated";
                    p.ProductId1=Convert.ToInt32(txtProductId.Text);
                    
                    int sonuc = p.updateProducts(p);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Product updated Succesfully");
                        Restart();
                        if (rAddCategory.Checked)
                        {
                            cbCategory_SelectedIndexChanged(sender, e);
                        }
                        Clearr();
                    }
                }
            }
            else
            {
                if (txtCategoryId.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Category Name", "Warning,Infos Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    cProductTypes pt = new cProductTypes();
                    pt.CategoryName1 = txtCategoryName.Text;
                    pt.Description1 = txtDesc.Text;
                    pt.CategoryId1 = Convert.ToInt32 (txtCategoryId.Text);
                    int sonuc = pt.updateProductscCat(pt);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("Category updated Succesfully");
                        if (rAddProduct.Checked)
                        {
                            cbCategory_SelectedIndexChanged(sender, e);
                        }
                        Restart();
                        Clearr();
                    }
                }
            }
        }

        private void lvGıdaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGıdaListesi.SelectedItems.Count>0)
            {
                txtProductName.Text = lvGıdaListesi.SelectedItems[0].SubItems[3].Text;
                txtProductPrice.Text = lvGıdaListesi.SelectedItems[0].SubItems[4].Text;
                txtProductId.Text = lvGıdaListesi.SelectedItems[0].SubItems[0].Text;


            }
        }

        private void rAddProduct_CheckedChanged(object sender, EventArgs e)
        {
            lvGıdaListesi.Visible = true;
            panelProducts.Visible = true;
            if (rAddCategory.Checked)
            {
                lvGıdaListesi.Visible = false;
                panelProducts.Visible = false;
            }
            Restart() ;
        }

        private void rAddCategory_CheckedChanged(object sender, EventArgs e)
        {
            lvCategories.Visible = true;
            panelAddCategory.Visible = true;
            if (rAddProduct.Checked)
            {
                lvCategories.Visible = false;
                panelAddCategory.Visible = false;
            }
            Restart();
        }

        private void lvCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCategories.SelectedItems.Count > 0)
            {
                txtCategoryName.Text = lvCategories.SelectedItems[0].SubItems[1].Text;
                txtDesc.Text = lvCategories.SelectedItems[0].SubItems[2].Text;
                txtCategoryId.Text = lvCategories.SelectedItems[0].SubItems[0].Text;


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rAddProduct.Checked)
            {
                if(lvGıdaListesi.SelectedItems.Count > 0) { 
                    if (MessageBox.Show("Are you sure deleting this product", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cProducts p = new cProducts();
                    
                    
                        p.ProductId1 = Convert.ToInt32(txtProductId.Text);
                    
                        int sonuc = p.deleteProducts(p,1);
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Product deleted Succesfully");
                            
                            cbCategory_SelectedIndexChanged(sender, e);
                            Restart();
                            Clearr();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Choose Product");
                }

            }
            else
            {
                if (lvCategories.SelectedItems.Count>0)
                {

                
                    if (MessageBox.Show("Are you sure deleting this product", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cProductTypes pt = new cProductTypes();
                        int sonuc = pt.deleteProductscCat(Convert.ToInt32(txtCategoryId.Text));
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Product deleted Succesfully");
                            cProducts p = new cProducts();
                            p.ProductId1=Convert.ToInt32(txtCategoryId.Text);
                            p.deleteProducts(p, 0);
                            Restart();
                            Clearr();
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtSearch.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rAddProduct.Checked)
            {
                cProducts p = new cProducts();
                p.listProductsByProductName(lvGıdaListesi,txtSearch.Text);
            }
            else
            {
                cProductTypes pt = new cProductTypes();
                pt.getProductTypes(lvCategories,txtSearch.Text);
            }

        }
        private void Restart()
        {
            cProductTypes pt = new cProductTypes();
            pt.getProductTypes(cbCategory);
            cbCategory.Items.Insert(0, "All Categories");
            cbCategory.SelectedIndex = 0;
            pt.getProductTypes(lvCategories);
            cProducts p = new cProducts();
            p.listProducts(lvGıdaListesi);
        }
    }
}
