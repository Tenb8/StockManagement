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
    public partial class Supplier : Sample2
    {
        int edit = 0;
        short stat ;
        Int64 sup_ID;
        public Supplier()
        {
            InitializeComponent();
        }

        retrieval re = new retrieval();
        private void Supplier_Load(object sender, EventArgs e)
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
            if (supcompaTxt.Text == "") { companyErrorLabel.Visible = true; } else { companyErrorLabel.Visible = false; }
            if (percontTxt.Text == "") { conctaErrorLabel.Visible = true; } else { conctaErrorLabel.Visible = false; }
            if (countryTxt.Text == "") { paysErrorLabel.Visible = true; } else { paysErrorLabel.Visible = false; }
            if (adresTxt.Text == "") { adressErrorLabel.Visible = true; } else { adressErrorLabel.Visible = false; }
            if (vilTxt.Text == "") { villeErrorLabel.Visible = true; } else { villeErrorLabel.Visible = false; }
            if (firstphonTxt.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
            //  if (seconphoneTxt.Text == "") { phone2errorLabel.Visible = true; } else { phone2errorLabel.Visible = false; }
            if (emailTxt.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if (statussupplierCB.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if (companyErrorLabel.Visible || conctaErrorLabel.Visible || paysErrorLabel.Visible|| villeErrorLabel.Visible|| adressErrorLabel.Visible || emailErrorLabel.Visible ||
                 phone1ErrorLabel.Visible   || statusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields are ", "stop", "Error");// error is the type of msg
            }
            else
            {
                if (statussupplierCB.SelectedIndex == 0)
                {
                    stat = 1;

                }
                else if (statussupplierCB.SelectedIndex == 1)
                {
                    stat = 0;
                }

                if (edit == 0)// code for save operation
                {

                    Insertion inser = new Insertion();
                    if (seconphoneTxt.Text == "")
                    {
                        inser.insertSupplier(supcompaTxt.Text, percontTxt.Text, countryTxt.Text, vilTxt.Text, adresTxt.Text, emailTxt.Text, firstphonTxt.Text, stat, null);

                    }
                    else
                    {
                        inser.insertSupplier(supcompaTxt.Text, percontTxt.Text, countryTxt.Text, vilTxt.Text, adresTxt.Text, emailTxt.Text, firstphonTxt.Text, stat, seconphoneTxt.Text);
                        re.showSupplier(dataGridView2, suplierIDGV, companyGV, contactpersonGV, countryGV, cityGV, adressGV, emailGV, phone1GV, phone2GV, statusGV);
                        MainClass.disabl_reset(leftPanel);

                    }
                }
                else if (edit == 1)// code for update operation
                {Updation u = new Updation();

                    DialogResult dr = MessageBox.Show("Are you sure to update record", "Questio...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        
                        if (statussupplierCB.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statussupplierCB.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        if (seconphoneTxt.Text == "") { 
                            u.updateSupplier(sup_ID, supcompaTxt.Text, percontTxt.Text, countryTxt.Text, vilTxt.Text, adresTxt.Text, emailTxt.Text, firstphonTxt.Text, stat, null);

                    }
                    else
                    {
                        u.updateSupplier(sup_ID, supcompaTxt.Text, percontTxt.Text, countryTxt.Text, vilTxt.Text, adresTxt.Text, emailTxt.Text, firstphonTxt.Text, stat, seconphoneTxt.Text);
                    }
                  //  u.updateSupplier(sup_ID, supcompaTxt.Text, percontTxt.Text, countryTxt.Text, vilTxt.Text, adresTxt.Text, emailTxt.Text, firstphonTxt.Text, stat, seconphoneTxt.Text);
                        re.showSupplier(dataGridView2, suplierIDGV, companyGV, contactpersonGV, countryGV, cityGV, adressGV, emailGV, phone1GV, phone2GV, statusGV);
                        MainClass.disabl_reset(leftPanel);
                    }

                }
                }
            }
        
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            { Deletion dele = new Deletion();
                DialogResult dr = MessageBox.Show("Are you sure to Delete record", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                   
                    dele.deleteUsers(sup_ID, "st_deleteSupplier","@id");
                    re.showSupplier(dataGridView2, suplierIDGV, companyGV, contactpersonGV, countryGV, cityGV, adressGV, emailGV, phone1GV, phone2GV, statusGV);

                }

            }

        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxt.Text != "")
            {
                re.showSupplier(dataGridView2, suplierIDGV, companyGV, contactpersonGV, countryGV, cityGV, adressGV, emailGV, phone1GV, phone2GV, statusGV);
            }
            else
            {
                re.showSupplier(dataGridView2, suplierIDGV, companyGV, contactpersonGV, countryGV, cityGV, adressGV, emailGV, phone1GV, phone2GV, statusGV);
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            re.showSupplier(dataGridView2,suplierIDGV, companyGV, contactpersonGV, countryGV, cityGV, adressGV, emailGV, phone1GV, phone2GV, statusGV);

        }

        private void SearchTxt_Click(object sender, EventArgs e)
        {

        }

      //  private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
      //  {
             
      //  }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                sup_ID = Convert.ToInt32((row.Cells["suplierIDGV"].Value.ToString()));
                supcompaTxt.Text = row.Cells["companyGV"].Value.ToString();
                percontTxt.Text = row.Cells["contactpersonGV"].Value.ToString();
                countryTxt.Text = row.Cells["countryGV"].Value.ToString();
                vilTxt.Text = row.Cells["cityGV"].Value.ToString();
                adresTxt.Text = row.Cells["adressGV"].Value.ToString();
                emailTxt.Text = row.Cells["emailGV"].Value.ToString();
                firstphonTxt.Text = row.Cells["phone1GV"].Value.ToString();
                seconphoneTxt.Text = row.Cells["phone2GV"].Value.ToString();
               statussupplierCB.Text = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }

        }
    }
}

