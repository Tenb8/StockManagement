using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
namespace StockManagement
{
    public partial class PurchaseInvoice :Sample2
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }
      int prodId; float gt,tot;
        retrieval re = new retrieval();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            re.getCategoriesList("st_getSupplierList", purchasDD, "Company", "ID");
            //  MainClass.disabl_reset(leftPanel);

        }
       
        private  void barecodeTxt_TextChanged(object sender, EventArgs e)
        {
          if (barecodeTxt.Text != "")
            {
                prPro = re.getProductsBybarecode(barecodeTxt.Text);
                prodId = Convert.ToInt32(prPro[0]);
                prodTxt.Text = prPro[1];
               priceTxt.Text = prPro[2];
               string barco = prPro[2];
              prodTxt.Enabled = false;


             if (barco != null)
              {
                priceTxt  .Focus();
               }



            }
           else
          {
              prodId = 0;
            prodTxt.Text = "";
        priceTxt.Text = "";
               Array.Clear(prPro, 0, prPro.Length);
           }


        }

        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }
        int CO;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Int64 purchaseInvoiceID;
                Insertion i = new Insertion();
                Updation u = new Updation();
                //transaction is use jab tak ap ka sara code successfull ni chal jata excecute ni hota or agar ik code ni chalta tou dusre ko bi roll back kar deta hai jo successfull chala ho 
                //transaction rokti hai invalid operations ko
                using (TransactionScope sc = new TransactionScope())
                {
                    purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, retrieval.user_ID, Convert.ToInt32(purchasDD.SelectedValue));

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                      CO += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()),
                          Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["totalGv"].Value.ToString()));

                    if (re.checkProductPriceExist(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString())))
                       {
                            u.updateProductPriceWRTPI(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                        }
                        else
                       {
                        i.insertProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                       }

                    //   for stocks
                        int q;
                        object ob = re.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                        if (ob != null)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                            u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                        }
                        else
                        {
                            i.insertStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                        }

                    }
                    if (CO > 0)
                    {
                        MainClass.ShowMSG("Purchase Invoice Created SuccessFully", "Success", "Success");
                        PurchaseInvoiceDetails sr = new PurchaseInvoiceDetails();
                        sr.Show();
                    }
                    else
                    {
                        MainClass.ShowMSG("Unable to create Purchase Invoice", "Error", "Error");
                    }

                    sc.Complete();

                }

            }

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails pur = new PurchaseInvoiceDetails();
            MainClass.showWindow(pur, this, MDI.ActiveForm);
        }




        string[] prPro = new string[5];
        private void barecodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (barecodeTxt.Text != "")
            {
                prPro = re.getProductsBybarecode1(barecodeTxt.Text);
                prodId = Convert.ToInt32(prPro[0]);
                prodTxt.Text = prPro[1];    
                string barco = prPro[2];
                prodTxt.Enabled = false;


                if (barco != null)
                {
                    priceTxt.Focus();
                }



            }
            else
            {
                prodId = 0;
                prodTxt.Text = "";
                priceTxt.Text = "";
                Array.Clear(prPro, 0, prPro.Length);
            }

        }


        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {
            if (quantityTxt.Text != "")
            {

                if (rg.Match(quantityTxt.Text).Success)
                {
                    float quan, price;
                    quan = Convert.ToSingle(quantityTxt.Text);
                    price = Convert.ToSingle(priceTxt.Text);
                    tot = quan * price;
                 totaLabel.Text = tot.ToString("##########.##");
                }
                else
                {
                    quantityTxt.SelectAll();
                }
            }
            else
            {
               totaLabel.Text = "0.00";

            }
        }

        private void totaLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["totalGv"].Value.ToString());
                    grossLabel.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);


                }
            }
        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {
            if (priceTxt.Text != "")
            {
                if (!rg.Match(priceTxt.Text).Success)
                {
                    priceTxt.Text = "";
                    priceTxt.Focus();
                }
            }
        }

        private void addcardBtn_Click(object sender, EventArgs e)
        {
            if (purchasDD.SelectedIndex == -1) {suplierErrorLabel.Visible = true; } else { suplierErrorLabel.Visible = false; }
            if (barecodeTxt.Text == "") { barecodeErrorLabel.Visible = true; } else { barecodeErrorLabel.Visible = false; }
            if (quantityTxt.Text == "") { qutityErrorLabel.Visible = true; } else { qutityErrorLabel.Visible = false; }
            if (suplierErrorLabel.Visible || barecodeErrorLabel.Visible || qutityErrorLabel.Visible)
            {
                MainClass.ShowMSG("Feild with * are mandatory", "Stop", "Error");//error is a type of message
            }

            else
            {

                dataGridView1.Rows.Add(prodId, prodTxt.Text,quantityTxt.Text, priceTxt.Text,  totaLabel.Text);
              
            gt += Convert.ToSingle(totaLabel.Text);
                grossLabel.Text = gt.ToString();
                prodId = 0;
                prodTxt.Text = "";
                priceTxt.Text = "";   
                barecodeTxt.Text = "";
                totaLabel.Text = "0.00";
                quantityTxt.Text = "";  
                Array.Clear(prPro, 0, prPro.Length);


            }
        }

    }
    }
