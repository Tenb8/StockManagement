using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class SalesReports :Sample
    {
        public SalesReports()
        {
            InitializeComponent();
        }

        private void SalesReports_Load(object sender, EventArgs e)
        {
            retrieval r = new retrieval();
          r.showReport(crystalReportViewer1, "st_getSalesReceipt", "@user", retrieval.user_ID);
        }
    }
}
