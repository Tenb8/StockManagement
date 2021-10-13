using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StockManagement
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
         
          string  path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    if (File.Exists(path+"\\connect")) {
                Setting set = new Setting();
             MainClass.showWindow(set, this);
              
            }
            else
            {  
                Login log = new Login();
                MainClass.showWindow(log, this);
            }
           
        

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Setting set = new Setting();
            MainClass.showWindow(set, this);

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            MainClass.showWindow(log, this);
            MDI ob = new MDI();
           ob.logOutToolStripMenuItem.Enabled =true;
        }
    }
}
