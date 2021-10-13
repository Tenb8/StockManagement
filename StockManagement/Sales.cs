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

namespace StockManagement
{
    public partial class Sales : Sample2

    {
        public Sales()
        {
            InitializeComponent();
        }
        retrieval re = new retrieval();
      float GROSS=0 ;
       
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool check; string[] prPro = new string[5];
        private void barecodeTxt_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6 && e.RowIndex>=0)
                {
                    grossTxt.Text = "";
                    CashBTxt.Text = "";
                    CashRecTxt.Text = "";
                    disTxt.Text = "";

                    float grandTot, tot;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int quan = 0;
                    if (quan == 0)
                    {quan = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                      grandTot = Convert.ToSingle(grossLabel.Text);
                 grandTot = grandTot + Convert.ToSingle(row.Cells["totalGv"].Value.ToString())+Convert.ToSingle(prPro[4]);
                  //   grandTot = Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());

                        grossLabel.Text = grandTot.ToString();
                        dataGridView1.Rows.Remove(row);
                    }
                    else if (quan > 1)
                    {
                        quan--;
                        gross = Convert.ToSingle(grossLabel.Text);
                        dis = Convert.ToSingle(row.Cells["disGV"].Value.ToString())+
                            Convert.ToSingle(prPro[4]);//-Convert.ToSingle(prPro[4]);
                        tot = Convert.ToSingle(row.Cells["quantityGV"].Value.ToString()) * 
                            Convert.ToSingle(row.Cells["pupGV"].Value.ToString())*dis ;
                      
  row.Cells["totalGv"].Value = tot;
                        row.Cells["quantityGV"].Value = quan;
                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            GROSS += Convert.ToSingle(item.Cells["totalGv"].Value.ToString());
                        }
                        grossLabel.Text = GROSS.ToString();
                         GROSS = 0;
                    }
                }
            }
        }
        private void Sales_Load(object sender, EventArgs e)
        {
            barcodeTxt.Focus();
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void chekoutBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                float gross = 0, dis=0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // gross = Convert.ToSingle(grossLabel.Text);
                    dis += Convert.ToSingle(row.Cells["disGV"].Value.ToString());
                    gross += Convert.ToSingle(row.Cells["totalGv"].Value.ToString());
                }
                // grossTxt.Text = Math.Round(gross, 0).ToString();
                grossTxt.Text = gross.ToString();

                disTxt.Text = dis.ToString();
            }
        }

        private void amountgiveTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountgiveTxt_Validating(object sender, CancelEventArgs e)
        {
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        float dis, gross, cal;
        Insertion i = new Insertion();
        private void payBtn_Click(object sender, EventArgs e)
        {
            if (CashBTxt.Text != "" && CashRecTxt.Text != "" && grossTxt.Text != "" && payementCB.SelectedIndex != -1 && disTxt.Text != "")
            {
                //  n is used to go to next line
   DialogResult dr = MessageBox.Show("Are you sure you want to  submit curent sale? \t Total Amount: " 
                                           + grossTxt.Text," \t Total Amount: " 
                                           + CashRecTxt.Text+"\t Total Given: " 
                                           + CashBTxt.Text , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (dr == DialogResult.Yes)
                {
                    i.insertSales(dataGridView1, "proIDGV", "quantityGV", retrieval.user_ID, 
                    DateTime.Now, Convert.ToSingle(grossTxt.Text),
                    Convert.ToSingle(disTxt.Text), Convert.ToSingle(CashBTxt.Text),
                    Convert.ToSingle(CashRecTxt.Text), 
                    payementCB.SelectedIndex.ToString(),"pupGV");//
                    MainClass.enable_reset(groupBox2);
                    dataGridView1.Rows.Clear();
                    grossLabel.Text = "0.00";
                    SalesReports sr = new SalesReports();
                    sr.Show();
                }
            }
        }

        private void totaldiscTxt_Validating_1(object sender, CancelEventArgs e)
        {

        }

        private void barecodeTxt_Validating_1(object sender, CancelEventArgs e)
        {

        }

        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTxt.Text != "")
            {
                grossTxt.Text = "";
                CashBTxt.Text = "";
                CashRecTxt.Text = "";


                int quanCount = 0, StockQuan = 0, nCount = 0;
                prPro = re.getProductsBybarecode(barcodeTxt.Text);
                // stock check
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (prPro[0] == row.Cells["proIDGV"].Value.ToString())
                        {
                                 quanCount = quanCount + Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                        }

                }

                             StockQuan = Convert.ToInt32(re.getProductQuantity(Convert.ToInt64(prPro[0])));

                             nCount = StockQuan - quanCount;
                 if (nCount <= 0)
                   {
                              MainClass.ShowMSG("Stock for this product is finished", "Error", "Error");
                   }
                else
                   {
                        if (dataGridView1.RowCount == 0)
                        {
                        //      dataGridView1.Rows.Add(Convert.ToInt32(prPro[0]), prPro[1], 1, Convert.ToSingle(prPro[3]), 0, Convert.ToSingle(prPro[3]));
                        dataGridView1.Rows.Add(Convert.ToInt32(prPro[0]),
                        prPro[1], 1, Convert.ToSingle(prPro[3]),
                        Convert.ToSingle(prPro[4]), Convert.ToSingle(prPro[5]));

                          }
                          else
                          {
                        foreach (DataGridViewRow row in dataGridView1.Rows)

                        {
                            //quantity count agar product majjod hai tou us ki quantity add kari jau
                            if (row.Cells["proIDGV"].Value.ToString() == prPro[0])
                            {
                                check = true;
                                break;

                            }
                            else
                            {
                                check = false;

                            }
                        }
                        if (check == true)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["proIDGV"].Value.ToString() == prPro[0])
                                {
                                    float disc = 0;
                                    row.Cells["quantityGV"].Value = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) + 1;
                                    if (row.Cells["disGV"].Value.ToString() != null)
                                    {
                                        disc +=  Convert.ToSingle(row.Cells["disGV"].Value.ToString());
                                        row.Cells["disGV"].Value.ToString();
                                    }
                                    float tot =   Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) 
                                                * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString())
                                                - Convert.ToSingle(row.Cells["disGV"].Value.ToString());
                                                row.Cells["totalGv"].Value = tot;
                                }

                            }
                        }
                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(prPro[0]), prPro[1],
                                1, Convert.ToSingle(prPro[3]), Convert.ToSingle(prPro[4]),
                                Convert.ToSingle(prPro[3]));
                          //dataGridView1.Rows.Add(Convert.ToInt32(prPro[0]), prPro[1], 1, Convert.ToSingle(prPro[2]), Convert.ToSingle(prPro[3]),0, Convert.ToSingle(prPro[4]));

                        }
                    }
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {


                        GROSS += Convert.ToSingle(item.Cells["totalGv"].Value.ToString());
                    }
                    //Math is a class
                    grossLabel.Text = Math.Round(GROSS, 0).ToString();
                    GROSS = 0;
                    barcodeTxt.Focus();
                    barcodeTxt.Text = "";
                }

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CashRecTxt_TextChanged(object sender, EventArgs e)
        {
            if (CashRecTxt.Text != "")
            {
                if (!rg.Match(CashRecTxt.Text).Success)
                {
                    CashRecTxt.Text = "";
                    CashRecTxt.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(CashRecTxt.Text);
                    float amountReturn = amountGiven - Convert.ToSingle(grossLabel.Text);
                    CashBTxt.Text = Math.Round(amountReturn, 0).ToString();

                }
            }
            else
            {
                CashBTxt.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CashRecTxt_Validating(object sender, CancelEventArgs e)
        {
            if (CashRecTxt.Text != "" && grossLabel.Text != "")
            {
                if (!(Convert.ToSingle(grossLabel.Text) <= Convert.ToSingle(CashRecTxt.Text)))
                {
                    CashRecTxt.Text = "";
                    CashBTxt.Text = "";
                    CashRecTxt.Focus();
                }
            }
        }

        private void disTxt_Validating(object sender, CancelEventArgs e)
        {
            if (disTxt.Text != "")
            {
                dis = Convert.ToSingle(disTxt.Text);
                gross = Convert.ToSingle(grossLabel.Text);
                cal = gross - (gross * dis / 100);
                grossTxt.Text = "";
                CashRecTxt.Text = "";
                CashBTxt.Text = "";


            }

            grossLabel.Text = Math.Round(cal, 0).ToString();
        }



    }

}
    

