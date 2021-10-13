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
    public partial class ProductPrice : Sample2
    {
       // int edit=0;
       Int64 proID;
        retrieval re = new retrieval();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public ProductPrice()
        { 
            InitializeComponent();
            re.getCategoriesList("st_getCategoriesList", catDDD, "Category", "ID");
        }
     
        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {
         
        }


        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }
        Updation u = new Updation();

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (catDDD.SelectedIndex != -1 && catDDD.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if ((bool)row.Cells["selectGV"].FormattedValue == true)
                    {
                        check++;
                        float disc, profitMar, sp, bp;
                        //turnury operator
                        disc = row.Cells["disGv"].Value == null ? 0 : Convert.ToSingle(row.Cells["disGv"].Value.ToString());
                        profitMar = row.Cells["profitMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString());
                        bp = Convert.ToSingle(row.Cells["buyingpriceGV"].Value.ToString());

                        if (disc == 0 && profitMar == 0)
                        {
                            sp = bp;
                        }
                        else
                        {
                            sp = Convert.ToSingle(row.Cells["finalpriceGV"].Value.ToString());
                        }

                       u.updateProductPrice(Convert.ToInt64(row.Cells["proIDGV"].Value.ToString()), bp, sp, disc, profitMar);
                      

                    }
                }
                if (check > 0)
                {
                    MainClass.ShowMSG("Product Pricing updated Successfully", "Success", "Success");
                    check = 0;
                }
                else
                {
                    MainClass.ShowMSG("Please check the box to save", "Error", "Error");
                    check = 0;
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

        }


        private void catCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catDDD.SelectedIndex != -1 && catDDD.SelectedIndex != 0)
            {
                re.showproductsWRTCategories(Convert.ToInt32(catDDD.SelectedValue.ToString()), dataGridView1,
                    proIDGV, proGV,buyingpriceGV,finalpriceGV,disGv,profitMarginGV);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["profitMarginGV"].Value != null && rg.Match(row.Cells["profitMarginGV"].Value.ToString()).Success)
                {

                    float buyingprice = Convert.ToSingle(row.Cells["buyingpriceGV"].Value.ToString());
                    float profitmargin = Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString()) / 100;
                    float amounttoIncrease = profitmargin * buyingprice;
                    float discountPer;

                    float finalSellingPrice = buyingprice + amounttoIncrease;

                    if (row.Cells["disGv"].Value != null && rg.Match(row.Cells["disGv"].Value.ToString()).Success)
                    {
                        discountPer = finalSellingPrice * (Convert.ToSingle(row.Cells["disGv"].Value.ToString()) / 100);
                    }
                    else
                    {
                        discountPer = 0;
                    }
                    row.Cells["finalpriceGV"].Value = finalSellingPrice - discountPer;
                }
                else
                {
                    row.Cells["finalpriceGV"].Value = null;
                    row.Cells["profitMarginGV"].Value = null;
                    row.Cells["disGv"].Value = null;
                }
            }
        }

        private void ProductPrice_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }
    }
}
