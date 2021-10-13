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
    public partial class Stock : Sample2
    {
        public Stock()
        {
            
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            base.addBtn.Enabled = false;
            base.editBtn.Enabled = false;
            base.saveBtn.Enabled = false;
            base.deleteBtn.Enabled = false;

        }
        public override void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            MainClass.showWindow(hs, this, MDI.ActiveForm);

        }

       
        retrieval re = new retrieval();
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            re.showStocksDetail(dataGridView1, proIDGV, proGV, barecodeGV, bpGV,spGV, expiryGV, catGV, quantityGV, finalGV, statusGV);
        }
    }
}
