using System;
using System.Collections;
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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTables frm = new frmTables();
            this.Close();
            frm.Show();
        }

        //Calculator
        void process(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn1":
                    txtCount.Text += (1).ToString();
                    break;
                case "btn2":
                    txtCount.Text += (2).ToString();
                    break;
                case "btn3":
                    txtCount.Text += (3).ToString();
                    break;
                case "btn4":
                    txtCount.Text += (4).ToString();
                    break;
                case "btn5":
                    txtCount.Text += (5).ToString();
                    break;
                case "btn6":
                    txtCount.Text += (6).ToString();
                    break;
                case "btn7":
                    txtCount.Text += (7).ToString();
                    break;
                case "btn8":
                    txtCount.Text += (8).ToString();
                    break;
                case "btn9":
                    txtCount.Text += (9).ToString();
                    break;
                case "btn0":
                    txtCount.Text += (0).ToString();
                    break;
                default:
                    MessageBox.Show("Enter a Number");
                    break;
            }

        }
        int tableId = 0; int AdditionId = 0;
        private void frmOrder_Load(object sender, EventArgs e)
        {
            lblTableNo.Text = cGeneral.buttonValue;
            cTables tb = new cTables();
            tableId = tb.TableGetbyNumber(cGeneral.buttonName);
            if(tb.TableGetbyState(tableId,2)==true)
            {
                cAddition ad = new cAddition();
                AdditionId = ad.getByAddition(tableId);
                cOrder or = new cOrder();
                or.getByOrder(lvOrders, AdditionId);
            }



            btn1.Click += new EventHandler(process);
            btn2.Click += new EventHandler(process);
            btn3.Click += new EventHandler(process);
            btn4.Click += new EventHandler(process);
            btn5.Click += new EventHandler(process);
            btn6.Click += new EventHandler(process);
            btn7.Click += new EventHandler(process);
            btn8.Click += new EventHandler(process);
            btn9.Click += new EventHandler(process);
            btn0.Click += new EventHandler(process);

        }
        cProductTypes productTypes = new cProductTypes();
        private void btnMainDish1_Click(object sender, EventArgs e)
        {
            
            productTypes.getByProductTypes(lvMenu, btnMainDish1);
        }

        private void btnDrinks2_Click(object sender, EventArgs e)
        {
            productTypes.getByProductTypes(lvMenu, btnDrinks2);
        }

        private void btnSweets3_Click(object sender, EventArgs e)
        {
            productTypes.getByProductTypes(lvMenu, btnSweets3);
        }

        private void btnSalads4_Click(object sender, EventArgs e)
        {
            productTypes.getByProductTypes(lvMenu, btnSalads4);
        }

        private void btnFastFood5_Click(object sender, EventArgs e)
        {
            productTypes.getByProductTypes(lvMenu, btnFastFood5);
        }

        private void btnSoup6_Click(object sender, EventArgs e)
        {
            productTypes.getByProductTypes(lvMenu, btnSoup6);
        }

        private void btnPasta7_Click(object sender, EventArgs e)
        {
            productTypes.getByProductTypes(lvMenu, btnPasta7);
        }

        private void btnAraSıcak8_Click(object sender, EventArgs e)
        {
            productTypes.getByProductTypes(lvMenu, btnAraSıcak8);
        }
        int sayac = 0; int sayac2 = 0;
        private void lvMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtCount.Text == "")
            {
                txtCount.Text = "1";
            }
            if (lvMenu.Items.Count > 0)
            {
                sayac = lvOrders.Items.Count;
                lvOrders.Items.Add(lvMenu.SelectedItems[0].Text);
                lvOrders.Items[sayac].SubItems.Add(txtCount.Text);
                lvOrders.Items[sayac].SubItems.Add((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(txtCount.Text)).ToString());
                lvOrders.Items[sayac].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvOrders.Items[sayac].SubItems.Add("0");
                sayac2 = lvNewAdded.Items.Count;
                lvOrders.Items[sayac].SubItems.Add(sayac2.ToString());
                
                lvNewAdded.Items.Add(AdditionId.ToString());
                lvNewAdded.Items[sayac2].SubItems.Add(lvMenu.SelectedItems[0].SubItems[2].Text);
                lvNewAdded.Items[sayac2].SubItems.Add(txtCount.Text);
                lvNewAdded.Items[sayac2].SubItems.Add(tableId.ToString());
                lvNewAdded.Items[sayac2].SubItems.Add(sayac2.ToString());
                sayac2++;
                txtCount.Text = "";
            }
        }
        ArrayList deleted = new ArrayList();
        private void btnOrder_Click(object sender, EventArgs e)
        {
            cTables tb = new cTables();
            frmTables frm = new frmTables();
            cAddition ad = new cAddition();
            cOrder od = new cOrder();
            bool sonuc = false;
            if (tb.TableGetbyState(tableId,1)==true)
            {
                ad.ServiceTypeNo1 = 1;
                
                ad.EmployeId1 = 1;
                ad.TableId1 = tableId;
                ad.Date = DateTime.Now;
                sonuc = ad.setByAdditionNew(ad);
                tb.setChangeTableState(cGeneral.buttonName, 2);

                if (lvOrders.Items.Count > 0)
                {
                    for (int i = 0; i < lvOrders.Items.Count; i++)
                    {
                        od.TableId1 = tableId;
                        od.ProductId1 = Convert.ToInt32(lvOrders.Items[i].SubItems[3].Text);
                        od.AdditionId1 = ad.getByAddition(tableId);
                        od.Count1 = Convert.ToInt32(lvOrders.Items[i].SubItems[1].Text);
                        od.setSaveOrder(od);
                    }
                    this.Close();
                    frm.Show();
                }
            }
            else if (tb.TableGetbyState(tableId,2)==true)
            {
                if(lvNewAdded.Items.Count > 0)
                {
                    for (int i = 0; i < lvNewAdded.Items.Count; i++)
                    {
                        od.TableId1 = tableId;
                        od.ProductId1 = Convert.ToInt32(lvNewAdded.Items[i].SubItems[3].Text);
                        od.AdditionId1 = ad.getByAddition(tableId) ;
                        od.Count1 = Convert.ToInt32(lvNewAdded.Items[i].SubItems[2].Text);
                        od.setSaveOrder(od);
                    }
                    cGeneral.AdditionId= ad.getByAddition(tableId).ToString();
                }
                if (deleted.Count>0)
                {
                    foreach (string item in deleted)
                    {
                        od.setDeleteOrder(Convert.ToInt32(item));
                    }
                }
                this.Close();
                frm.Show();
            }
        }

        private void lvOrders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lvOrders.Items.Count > 0)
            {
                if (lvOrders.SelectedItems[0].SubItems[4].Text != "0")
                {
                    cOrder od = new cOrder();
                    od.setDeleteOrder(Convert.ToInt32(lvOrders.SelectedItems[0].SubItems[4].Text));
                }
                else
                {
                    for (int i = 0; i < lvNewAdded.Items.Count; i++)
                    {
                        if (lvNewAdded.Items[i].SubItems[4].Text == lvOrders.SelectedItems[0].SubItems[5].Text)
                        {
                            lvNewAdded.Items.RemoveAt(i);
                        }
                    }
                }
                lvOrders.Items.RemoveAt(lvOrders.SelectedItems[0].Index);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "";
            }
            else
            {
                cProductTypes pt = new cProductTypes();
                pt.getByProductSearch(lvMenu, Convert.ToInt32(txtSearch.Text));
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cGeneral.ServiceTypeNo = 1;
            cGeneral.AdditionId = AdditionId.ToString();
            frmBill frm = new frmBill();
            this.Close();
            frm.Show();
        }

        
    }
}
