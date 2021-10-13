using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockManagement
{
    public partial class Users : Sample2
    {
        short stat;
        int userID;
        int edit=0;//cedci indik denregistrer   et 1 rafraichir
        public Users()
        {
            InitializeComponent();
        }
        retrieval re = new retrieval();
        private void Users_Load(object sender, EventArgs e)
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
            if (nameTxt.Text == "")
            {
                nameErrorLabel.Visible = true;
            }
            else {
                nameErrorLabel.Visible = false;
            }
            if (usernameTxt.Text == "") {
                usernameErrorLabel.Visible = true;
            }
            else { usernameErrorLabel.Visible = false; }
            if (passTxt.Text == "")
            { passErrorLabel.Visible = true; }else { passErrorLabel.Visible = false; }
            if (phoneTxt.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false;  }
            if (emailTxt.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if(statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if (nameErrorLabel.Visible|| usernameErrorLabel.Visible || passErrorLabel.Visible || emailErrorLabel.Visible || phoneErrorLabel.Visible|| statusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields are ", "stop", "Error");// error is the type of msg
            }
            else
            {    
                if (statusDD.SelectedIndex==0)
                    {
                        stat = 1;

                    }
                    else if (statusDD.SelectedIndex == 1){
                        stat = 0;
                    }
                if (edit == 0)// code for save operation
                {
                 
                    Insertion inser = new Insertion();
                  
                    inser.insertUser(nameTxt.Text, usernameTxt.Text, passTxt.Text, emailTxt.Text, phoneTxt.Text,stat);
                    re.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV,EmailGV,  statusGV);
                    MainClass.disabl_reset(leftPanel);

                }
                else if (edit == 1)// code for update operation
                {

                    DialogResult dr = MessageBox.Show("Are you sure to update record", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) {
                        Updation u = new Updation();
                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updateUsers(userID, nameTxt.Text, usernameTxt.Text, passTxt.Text, emailTxt.Text, phoneTxt.Text,stat);
                    re.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, statusGV);
                    MainClass.disabl_reset(leftPanel);
}
                
                }
            }
        }


        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete record", "Questio...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion dele = new Deletion();
                    dele.deleteUsers(userID, "st_deleteUsers", "@id");
                    re.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, statusGV);//Efface et fait une mise a jour 

                }

            }
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
           if(SearchTxt.Text != "")
            {
                re.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, statusGV,SearchTxt.Text);
            }
            else { re.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, statusGV); }
        }



        public override void viewBtn_Click(object sender, EventArgs e)
        {
            re.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, statusGV);
        }
        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID =Convert.ToInt32( ( row.Cells["userIDGV"].Value.ToString()));
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt. Text = row.Cells["UserNameGV"].Value.ToString();
                passTxt.Text  = row.Cells["PassGV"].Value.ToString();
                emailTxt.Text   = row.Cells["EmailGV"].Value.ToString();
                phoneTxt.Text= row.Cells["PhoneGV"].Value.ToString();
                statusDD.Text = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }
    }
}
