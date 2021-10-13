using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;


namespace StockManagement
{
    public partial class PurchaseInvoiceDetails : Sample2
    { retrieval re = new retrieval();
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }
       

        private void datepickerpurchaseIn_ValueChanged(object sender, EventArgs e)
        {
            re.getListWithTwoParameters("st_getPurchaseInvoiceList", purchaseInDD, "Company", "ID", "@month",
                datepickerpurchaseIn.Value.Month, "@year", datepickerpurchaseIn.Value.Year);

        }
        public  override void backBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice hs = new PurchaseInvoice();
         MainClass.showWindow(hs, this, MDI.ActiveForm);

        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            re.getListWithTwoParameters("st_getPurchaseInvoiceList", purchaseInDD, "Company", "ID", "@month", datepickerpurchaseIn.Value.Month, "@year", datepickerpurchaseIn.Value.Year);

        }

        private void purchaseInDD_SelectedIndexChanged(object sender, EventArgs e)
        {

         if (purchaseInDD.SelectedIndex != -1 && purchaseInDD.SelectedIndex!=0)
           {
               re.showpurchaseInvoiceDetails(Convert.ToInt64(purchaseInDD.SelectedValue.ToString()), dataGridView1,mpiDGV, proIDGV, proGV, quantityGV, pupGV, totalGv);

            }float t = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                t += Convert.ToSingle(row.Cells["totalGv"].Value.ToString());
            }grossLabel.Text = t.ToString();
        }
        Insertion i = new Insertion();
        Updation u = new Updation();Deletion de = new Deletion();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int q;
            if (e.RowIndex!=-1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure " + row.Cells["proGV"].Value.ToString() + "from purchase ?\nt\t\tWARNING\nDeLETION OF PRODUCT WILL EFFETC STOCK ", "QUESTION...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            i.insertdeleteditems(Convert.ToInt64(purchaseInDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()),
                         Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), retrieval.user_ID, DateTime.Now);
                            object ob = re.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                            if (ob != null)
                            {

                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                                u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                                float tot = Convert.ToSingle(grossLabel.Text) - Convert.ToSingle(row.Cells["totalGv"]);
                                de.deleteUsers(Convert.ToInt64( row.Cells["mpiDGV"].Value.ToString()), "st_deleteProductfromPID", "@mPID");
                                dataGridView1.Rows.Remove(row);
                            }
                            sc.Complete();
                        }
                          
                  
                    
                }
                }
            }
        }
    }
}
