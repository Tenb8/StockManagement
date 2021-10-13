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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            MainClass.showWindow(us, this, MDI.ActiveForm);

            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void catBtn_Click(object sender, EventArgs e)
        {
           Categories cat = new Categories();
            MainClass.showWindow(cat, this, MDI.ActiveForm);
        }

        private void proDD_Click(object sender, EventArgs e)
        {
           product pro = new product();
            MainClass.showWindow(pro, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI ob = new MDI();
         ob.logOutToolStripMenuItem.Enabled = false;
            userLabel.Text ="Доброе пожаловать!:"+"\n\t"+ retrieval.EMP_name;
        }

        private void suplierBtn_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            MainClass.showWindow(sup, this, MDI.ActiveForm);
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {

            PurchaseInvoice pur = new PurchaseInvoice();
            MainClass.showWindow(pur, this, MDI.ActiveForm);
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Customers pur = new Customers();
            MainClass.showWindow(pur, this, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stock sto = new Stock();
            MainClass.showWindow(sto, this, MDI.ActiveForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.showWindow(s, this, MDI.ActiveForm);

        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            ProductPrice pp = new ProductPrice();
            MainClass.showWindow(pp, this, MDI.ActiveForm);
        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
