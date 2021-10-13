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
    public partial class Customers : Sample2
    {
        int edit = 0;
        short stat;
        Int64 cust_ID;
        public Customers()
        {
            InitializeComponent();
        }
        retrieval re = new retrieval();
        private void Customers_Load(object sender, EventArgs e)
        {
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
            if (customercompTxt.Text == "") { companycosErrorLabel.Visible = true; } else { companycosErrorLabel.Visible = false; }
            if (percostTxt.Text == "") { conctacosErrorLabel.Visible = true; } else { conctacosErrorLabel.Visible = false; }
            if (countrycosTxt.Text == "") { payscosErrorLabel.Visible = true; } else { payscosErrorLabel.Visible = false; }
            if (adrescosTxt.Text == "") { adresscosErrorLabel.Visible = true; } else { adresscosErrorLabel.Visible = false; }
            if (vilcosTxt.Text == "") { villecosErrorLabel.Visible = true; } else { villecosErrorLabel.Visible = false; }
            if (firstphoncosTxt.Text == "") { phone1cosErrorLabel.Visible = true; } else { phone1cosErrorLabel.Visible = false; }
            //  if (seconphoneTxt.Text == "") { phone2errorLabel.Visible = true; } else { phone2errorLabel.Visible = false; }
            if (emailcosTxt.Text == "") { emailcosErrorLabel.Visible = true; } else { emailcosErrorLabel.Visible = false; }
            if (statuscustomerCB.SelectedIndex == -1) { statuscosErrorLabel.Visible = true; } else { statuscosErrorLabel.Visible = false; }
            if (companycosErrorLabel.Visible || conctacosErrorLabel.Visible || payscosErrorLabel.Visible || villecosErrorLabel.Visible || adresscosErrorLabel.Visible || emailcosErrorLabel.Visible ||
                 phone1cosErrorLabel.Visible || statuscosErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields are ", "stop", "Error");// error is the type of msg
            }
            else
            {
                if (statuscustomerCB.SelectedIndex == 0)
                {
                    stat = 1;

                }
                else if (statuscustomerCB.SelectedIndex == 1)
                {
                    stat = 0;
                }

                if (edit == 0)// code for save operation
                {

                    Insertion inser = new Insertion();
                    if (seconphonecosTxt.Text == "")
                    {
                        inser.insertCustomer(customercompTxt.Text, percostTxt.Text, countrycosTxt.Text, vilcosTxt.Text, adrescosTxt.Text, emailcosTxt.Text, firstphoncosTxt.Text, stat, null);

                    }
                    else
                    {
                        inser.insertCustomer(customercompTxt.Text, percostTxt.Text, countrycosTxt.Text, vilcosTxt.Text, adrescosTxt.Text, emailcosTxt.Text, firstphoncosTxt.Text, stat, seconphonecosTxt.Text);
                        re.showCustomer(dataGridView2, costumerIDGV, companycosGV, contactpersoncosGV, countrycosGV, citycosGV, adresscosGV, emailcosGV, phone1cosGV, phone2cosGV, statuscosGV);
                        MainClass.disabl_reset(leftPanel);

                    }
                }
                else if (edit == 1)// code for update operation
                {
                    Updation u = new Updation();

                    DialogResult dr = MessageBox.Show("Are you sure to update record", "Questio...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        if (statuscustomerCB.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statuscustomerCB.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        if (seconphonecosTxt.Text == "")
                        {
                            u.updateCustomer(cust_ID, customercompTxt.Text, percostTxt.Text, countrycosTxt.Text, vilcosTxt.Text, adrescosTxt.Text, emailcosTxt.Text, firstphoncosTxt.Text, stat, null);

                        }
                        else
                        {
                            u.updateCustomer(cust_ID, customercompTxt.Text, percostTxt.Text, countrycosTxt.Text, vilcosTxt.Text, adrescosTxt.Text, emailcosTxt.Text, firstphoncosTxt.Text, stat, seconphonecosTxt.Text);
                        }
                        //  u.updateSupplier(sup_ID, supcompaTxt.Text, percontTxt.Text, countryTxt.Text, vilTxt.Text, adresTxt.Text, emailTxt.Text, firstphonTxt.Text, stat, seconphoneTxt.Text);
                        re.showCustomer(dataGridView2, costumerIDGV, companycosGV, contactpersoncosGV, countrycosGV, citycosGV, adresscosGV, emailcosGV, phone1cosGV, phone2cosGV, statuscosGV);
                        MainClass.disabl_reset(leftPanel);
                    }

                }
            }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                Deletion dele = new Deletion();
                DialogResult dr = MessageBox.Show("Are you sure to Delete record", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    dele.deleteUsers(cust_ID, "st_deleteCustomer", "@id");
                    re.showCustomer(dataGridView2, costumerIDGV, companycosGV, contactpersoncosGV, countrycosGV, citycosGV, adresscosGV, emailcosGV, phone1cosGV, phone2cosGV, statuscosGV);

                }

            }

        }
        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxt.Text != "")
            {
                re.showSupplier(dataGridView2, costumerIDGV, companycosGV, contactpersoncosGV, countrycosGV, citycosGV, adresscosGV, emailcosGV, phone1cosGV, phone2cosGV, statuscosGV);
            }
            else
            {
                re.showSupplier(dataGridView2, costumerIDGV, companycosGV, contactpersoncosGV, countrycosGV, citycosGV, adresscosGV, emailcosGV, phone1cosGV, phone2cosGV, statuscosGV);
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

            
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            re.showCustomer(dataGridView2, costumerIDGV, companycosGV, contactpersoncosGV, countrycosGV, citycosGV, adresscosGV, emailcosGV, phone1cosGV, phone2cosGV, statuscosGV);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
               cust_ID = Convert.ToInt32((row.Cells["costumerIDGV"].Value.ToString()));
                customercompTxt.Text = row.Cells["companycosGV"].Value.ToString();
                percostTxt.Text = row.Cells["contactpersoncosGV"].Value.ToString();
                countrycosTxt.Text = row.Cells["countrycosGV"].Value.ToString();
                vilcosTxt.Text = row.Cells["citycosGV"].Value.ToString();
                adrescosTxt.Text = row.Cells["adresscosGV"].Value.ToString();
                emailcosTxt.Text = row.Cells["emailcosGV"].Value.ToString();
                firstphoncosTxt.Text = row.Cells["phone1cosGV"].Value.ToString();
                seconphonecosTxt.Text = row.Cells["phone2cosGV"].Value.ToString();
                statuscustomerCB.Text = row.Cells["statuscosGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
