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
    public partial class Categories :Sample2
    { short stat;
        int catID;
        int edit = 0;
        retrieval re = new retrieval();
        public Categories()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       
      
        private void Categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
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
             if (catNameTxt.Text == "")
            {
               catNameErrorLabel.Visible = true;
            }
            else {
                catNameErrorLabel.Visible = false;
            }
            if(activeDD.SelectedIndex == -1) { isactErrorLabel.Visible = true; } else { isactErrorLabel.Visible = false; }
            if (isactErrorLabel.Visible||catNameErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields are ", "stop", "Error");// error is the type of msg
            }
            else
            {    
                if (activeDD.SelectedIndex==0)
                    {
                        stat = 1;

                    }
                    else if (activeDD.SelectedIndex == 1){
                        stat = 0;
                    }
                if (edit == 0)// code for save operation
                {
                 
                    Insertion inser = new Insertion();
                  
                    inser.insertCategories(catNameTxt.Text,stat);
                    re.showCategories(dataGridView1, catIDGV, nameCatGV, statusCatGV);
                    MainClass.disabl_reset(leftPanel);

                }
                else if (edit == 1)// code for update operation
                {

                    DialogResult dr = MessageBox.Show("Are you sure to update record", "Questio...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) {
                        Updation u = new Updation();
                        if (activeDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (activeDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }

                        u.updateCategories(catID, catNameTxt.Text, stat);
                        re.showCategories(dataGridView1, catIDGV, nameCatGV, statusCatGV);
                    MainClass.disabl_reset(leftPanel);
}
                
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure to update record", "Questio...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion dele = new Deletion();
                    dele.deleteUsers(catID, "st_deleteCategories", "@id");
                    re.showCategories(dataGridView1, catIDGV, nameCatGV, statusCatGV);

                }

            }

        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxt.Text != "")
            {
                re.showCategories(dataGridView1, catIDGV, nameCatGV, statusCatGV);
            }
            else { re.showCategories(dataGridView1, catIDGV, nameCatGV, statusCatGV); }

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            re.showCategories(dataGridView1, catIDGV, nameCatGV, statusCatGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                catNameTxt.Text = row.Cells["nameCatGV"].Value.ToString();
               
             activeDD.SelectedItem= row.Cells["statusCatGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
