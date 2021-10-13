using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class product : Sample2
    {
        int edit=0;
        Int64 prodID;       
        public product()
        {
            InitializeComponent();
        }
        retrieval re = new retrieval();

        private void product_Load(object sender, EventArgs e)
        {  re.getCategoriesList("st_getCategoriesList", catCB, "Category", "ID");
            MainClass.disabl_reset(leftPanel);
         
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (productTxt.Text == "")
            {
                proErrorLabel.Visible = true;
            }
            else
            {
                proErrorLabel.Visible = false;
            }
            if (barecodeTxt.Text == "")
            {
               barErrorLabel.Visible = true;
            }
            else { barErrorLabel.Visible = false; }
         //if (expiryPicker.Value.Date < DateTime.Now.Date)
           // { expiryErrorLabel.Visible = true; expiryErrorLabel.Text = "La date invalide "; }
            //else { expiryErrorLabel.Visible = false; }
            if (expiryPicker.Value.Date == DateTime.Now.Date|| expiryPicker.Value.Date < DateTime.Now.Date|| expiryPicker.Value.Date > DateTime.Now.Date) { expiryErrorLabel.Visible = false; }
           // if (priceTxt.Text == "") {priceErrorLabel.Visible = true; } else { priceErrorLabel.Visible = false; }
            if (catCB.SelectedIndex == -1|| catCB.SelectedIndex == 0) { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }

            if (  barErrorLabel.Visible || expiryErrorLabel.Visible || proErrorLabel.Visible || catErrorLabel.Visible )
            {
                MainClass.ShowMSG("Fields are ", "stop", "Error");// error is the type of msg
            }
            else
            {
               
                if (edit == 0)// code for save operation
                {
                   
                    Insertion inser = new Insertion();
 if (expiryPicker.Value == DateTime.Now) {
                   
                        inser.insertProducts(productTxt.Text,barecodeTxt.Text,Convert.ToInt32(catCB.SelectedValue),null);
                    }

                    else { inser.insertProducts(productTxt.Text, barecodeTxt.Text, Convert.ToInt32(catCB.SelectedValue), expiryPicker.Value); }
                    re.showProducts(dataGridView1, proIDGV, proGV, barecodeGV,expiryGV,catGV, catIDGV);
                    MainClass.disabl_reset(leftPanel);

                } 
                else if (edit == 1)// code for update operation
                {

                    DialogResult dr = MessageBox.Show("Are you sure to update record", "Questio...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (expiryPicker.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProducts(prodID, productTxt.Text, barecodeTxt.Text, Convert.ToInt32(catCB.SelectedValue));
                        }
                        else {   u.updateProducts(prodID, productTxt.Text, barecodeTxt.Text,  Convert.ToInt32(catCB.SelectedValue),expiryPicker.Value);
}
                        re.showProducts(dataGridView1, proIDGV, proGV ,barecodeGV,expiryGV,catGV,  catIDGV);

                        MainClass.disabl_reset(leftPanel);
                    }

                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure to Delete this record", "Questio...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion dele = new Deletion();
                    dele.deleteUsers(prodID, "st_deleteProducts", "@pro_ID");
                    re.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barecodeGV, catIDGV);//Efface et fait une mise a jour 

                }

            }

        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxt.Text != "")
            {
                re.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barecodeGV, catIDGV);///per
            }
            else
            {
                re.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barecodeGV, catIDGV);
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            re.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barecodeGV, catIDGV);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex!=-1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
             prodID = Convert.ToInt32((row.Cells["proIDGV"].Value.ToString()));
               productTxt.Text = row.Cells["proGV"].Value.ToString();
                barecodeTxt.Text = row.Cells["barecodeGV"].Value.ToString();
            //    priceTxt.Text = row.Cells["priceGV"].Value.ToString();
                //  

                if (row.Cells["expiryGV"].FormattedValue.ToString() == "")
                {
                    expiryPicker.Value = DateTime.Now;
                }else { expiryPicker.Value= Convert.ToDateTime( row.Cells["expiryGV"].Value.ToString());}

                catCB.SelectedValue = row.Cells["catIDGV"].Value.ToString();
              
                MainClass.disable(leftPanel);

            }
        }

        private void barecodeTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
