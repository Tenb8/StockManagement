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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

       private void label2_Click(object sender, EventArgs e)
       {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            { usernameErrorLabel.Visible = true; }
            else { usernameErrorLabel.Visible = false; }
            if (passwordTxt.Text == "")
            { passwordErrorLabel.Visible = true; }
            else { passwordErrorLabel.Visible = false; }

            if (usernameErrorLabel.Visible || passwordErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields are ", "stop", "Error");// error is the type of msg

            }
            else
            {
                if (usernameTxt.Text != "" && passwordTxt.Text != "")
                {

                    if (retrieval.getUserDetail(usernameTxt.Text, passwordTxt.Text))
                    {
                        HomeScreen sc = new HomeScreen();
                        MainClass.showWindow(sc, this, MDI.ActiveForm);

                    }

                }
            }
        }
        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            { usernameErrorLabel.Visible = true; }
            else { usernameErrorLabel.Visible = false; }

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "")
            { passwordErrorLabel.Visible = true; }
            else { passwordErrorLabel.Visible = false; }

        }
    }
}
