using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class Setting :Sample
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string s;
           string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (isCB.Checked)
            {
                if (serverTxt.Text != "" && databaseTxt.Text != "")
                {
   s = "Data Source=" + serverTxt.Text + ";Initial Catalog= " + databaseTxt.Text + ";Integrated Security=true;MultipleActiveResultSets=true; ";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dl = MessageBox.Show("Setting Saved..", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dl == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else { MessageBox.Show("Please give data complete to continue..."); }
            }
            else
            {
                if (serverTxt.Text != "" && databaseTxt.Text != "" && userIdTxt.Text != "" && passwordTxt.Text != "")
                {
                    s = "Data Source=" + serverTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";User ID=" + userIdTxt.Text + ";Password=" + passwordTxt.Text+";MultipleActiveResultSets = true;   ";
                    File.WriteAllText(path + "\\ connect", s);
                    DialogResult dl = MessageBox.Show("Setting Saved..", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dl == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give data complete to continue...");

                }
            }
            
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userIdTxt.Enabled = false;
                passwordTxt.Enabled = false;
                userIdTxt.Text = "";
                passwordTxt.Text = "";


            }
            else
            {
                userIdTxt.Enabled = true;
                passwordTxt.Enabled =true;

            }
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void databaseTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
