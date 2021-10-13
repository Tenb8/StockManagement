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
    class retrieval
    {


        /// Affichage des utilisateur
        public void showUsers (DataGridView gv, DataGridViewColumn userIDGV, 
            DataGridViewColumn nameGV, DataGridViewColumn userNameGV, DataGridViewColumn passGV,
            DataGridViewColumn emailGV, DataGridViewColumn phoneGV, DataGridViewColumn statusG,string data=null)
        { 
            try
            {
                System.Data.SqlClient.SqlCommand comd;
                if (data == null)
                {
comd = new SqlCommand("st_getUsersDataUsers", MainClass.connect);
                }
                else { comd = new SqlCommand("st_getUsersDataUsersLIKE", MainClass.connect);
                    comd.Parameters.AddWithValue("@data", data);
                }
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
              userIDGV.DataPropertyName =dt.Columns["ID"].ToString();
                nameGV.DataPropertyName =dt.Columns["Name"].ToString();
               userNameGV.DataPropertyName =dt.Columns["Username"].ToString();
               passGV.DataPropertyName =dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName =dt.Columns["Phone"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
             statusG.DataPropertyName =dt.Columns["Status"].ToString();

              //  comd.ExecuteNonQuery();
               //MainClass.connect.Open();
                gv.DataSource = dt;
            }
            catch (Exception)
            {

                
            }
            
        }

        /// Affchage  de categories
        public void showCategories(DataGridView gv, DataGridViewColumn catIdGV ,DataGridViewColumn catnameGV,
       
                    DataGridViewColumn catstatusG)
        {
            try
            {
                System.Data.SqlClient.SqlCommand comd= new SqlCommand("st_getCategoriesData", MainClass.connect);
                
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                catIdGV.DataPropertyName = dt.Columns["ID"].ToString();
                catnameGV.DataPropertyName = dt.Columns["Category"].ToString();
                catstatusG.DataPropertyName = dt.Columns["status"].ToString();

                //      comd.ExecuteNonQuery();
                //    MainClass.connect.Open();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.ShowMSG(ex.Message, "Erorr", "Error");
            }

        }




        /// Affchage des list de categories
        public void getCategoriesList(string proc,ComboBox cb,string displayMenbers,string valueMenbers) {

            try
            {
             //  cb.Items.Clear();
                cb.DataSource = null;
             // cb.Items.Insert(0, "Select Categories....");
                
                SqlCommand sd = new SqlCommand(proc,MainClass.connect);
                sd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(sd);

                DataTable dt = new DataTable();

                da.Fill(dt);
               
                DataRow rt = dt.NewRow();
                rt.ItemArray = new object []
                    { 0,"Select...." }; //A coriger pour ke on estb plusieurs elements
                dt.Rows.InsertAt(rt, 0);
                cb.DataSource = dt;
                cb.DisplayMember =displayMenbers  ;
                cb.ValueMember =valueMenbers  ;
                
            }
            catch(Exception ex )
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }


        private string[]  productsData= new string[6];

        public string[] getProductsBybarecode(string barecode)
        {
            try
            {


                SqlCommand sd = new SqlCommand("st_getProductByBareCode", MainClass.connect);
                sd.CommandType = CommandType.StoredProcedure;
                sd.Parameters.AddWithValue("@barecode", barecode);
                MainClass.connect.Open();
                SqlDataReader da = sd.ExecuteReader();
                if (da.HasRows)
                {
                    while (da.Read())
                    {
                        productsData[0] = da[0].ToString();//product id
                        productsData[1] = da[1].ToString();//product
                        productsData[2] = da[2].ToString();//barcode
                       productsData[3] = da[3].ToString();//selling price
                        productData[4] = da[4].ToString();
                        productData[5] = da[5].ToString();

                    }
                }
                else
                {
                     
                   Array.Clear(productsData, 0, productsData.Length);
                
                }
            
                MainClass.connect.Close();
            }
            catch (Exception)
            {
                MainClass.connect.Close();
             //   throw;
            }
            return productsData;
        }


        private string[] productData = new string[3];

        public string[] getProductsBybarecode1(string barecode)
        {

            try
            {


                SqlCommand sd = new SqlCommand("st_getProductByBareCode1", MainClass.connect);
                sd.CommandType = CommandType.StoredProcedure;
                sd.Parameters.AddWithValue("@barecode", barecode);
                MainClass.connect.Open();
                SqlDataReader da = sd.ExecuteReader();
                if (da.HasRows)
                {
                    while (da.Read())
                    {
                        productData[0] = da[0].ToString();//product id
                        productData[1] = da[1].ToString();//product
                        productData[2] = da[2].ToString();//barcode
                      //  productData[3] = da[3].ToString();//selling price
                    }
                }
                else
                {
                    MainClass.ShowMSG("", "Error", "Error");
                }
                MainClass.connect.Close();
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");

            }
            return productData;
        }

        /// Affchage des produitssssss (vendredi 22 mai)
        /// 
        public void showProducts(DataGridView gv, DataGridViewColumn proIdGV, DataGridViewColumn pronameGV,

                   DataGridViewColumn expiryGV, DataGridViewColumn priceGV, DataGridViewColumn barecodeGV, DataGridViewColumn catIDGV)
        {
            try
            {
                System.Data.SqlClient.SqlCommand comd = new SqlCommand("st_getDataProducts", MainClass.connect);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                 
                proIdGV.DataPropertyName = dt.Columns["Product ID"].ToString();
               pronameGV.DataPropertyName = dt.Columns["Product Name"].ToString();
           priceGV .DataPropertyName = dt.Columns["Category"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                // catGV  .DataPropertyName = dt.Columns["Price"].ToString();
               
              barecodeGV.DataPropertyName = dt.Columns["BareCode"].ToString();
            
               catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();

                //      comd.ExecuteNonQuery();
                //    MainClass.connect.Open();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.ShowMSG(ex.Message, "Erorr", "Error");
            }

        }

        public static int user_ID {
            get;
            private set;
        }
        public static string EMP_name
        {
            get;
            private set;
        }
      private static  bool cheickLogin;
        private static string pass_word = null,  user_name=null;

        public static bool getUserDetail(string username, string password)
        {
            try
            {
                
                SqlCommand com = new SqlCommand("st_getUserDetails", MainClass.connect);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@user", username);
                com.Parameters.AddWithValue("@pass", password);

                MainClass.connect.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    cheickLogin = true;
                    while (dr.Read())
                    {
                        user_ID = Convert.ToInt32( dr["ID"].ToString());
                        EMP_name =  dr["Name"].ToString();
                    user_name = dr["Username"].ToString();
                      pass_word  = dr["Password"].ToString();
                    }
                   // HomeScreen sc = new HomeScreen();
                   // MainClass.showWindow(sc, this, MDI.ActiveForm);
                }
                else
                {
                    cheickLogin = false;
                    if (username != null && password != null)
                    {
                        if (user_name != username && pass_word==password)
                        {
                            MainClass.ShowMSG("Invalid username", "Error", "Error");
                        }
                        else if(user_name == username && pass_word != password)
                        {

                            MainClass.ShowMSG("Invalid password", "Error", "Error");

                        }
                       else if(user_name != username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid username and Invalid password", "Error", "Error");
                        }
                    }
                }
              
                MainClass.connect.Close();

 
    }
            catch (Exception)
            {

                MainClass.ShowMSG("Unable to login..", "Error", "Error");
              MainClass.connect.Close();
            }

            return cheickLogin;
        }

        public void showSupplier(DataGridView gv, DataGridViewColumn suplierIDGV, DataGridViewColumn companyGV, DataGridViewColumn contactpersonGV, DataGridViewColumn countryGV,
            DataGridViewColumn cityGV, DataGridViewColumn adressGV, DataGridViewColumn emailGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn statusGV)
        {
            try
            {
                System.Data.SqlClient.SqlCommand comd = new SqlCommand("st_getSupplieData", MainClass.connect);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                suplierIDGV.DataPropertyName = dt.Columns["Suplier ID"].ToString();
                companyGV.DataPropertyName = dt.Columns["Company Name"].ToString();
                contactpersonGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
                countryGV.DataPropertyName = dt.Columns["Country"].ToString();
                cityGV.DataPropertyName = dt.Columns["City"].ToString();
                adressGV.DataPropertyName = dt.Columns["Adress"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone2"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                //      comd.ExecuteNonQuery();
                //    MainClass.connect.Open();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.ShowMSG(ex.Message, "Erorr", "Error");
            }

        }

        public void showCustomer(DataGridView gv, DataGridViewColumn customerIDGV, DataGridViewColumn companyGV, DataGridViewColumn contactpersonGV, DataGridViewColumn countryGV,
     DataGridViewColumn cityGV, DataGridViewColumn adressGV, DataGridViewColumn emailGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn statusGV)
        {
            try
            {
                System.Data.SqlClient.SqlCommand comd = new SqlCommand("st_getCustomerData", MainClass.connect);
                comd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(comd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                customerIDGV.DataPropertyName = dt.Columns["Customer ID"].ToString();
                companyGV.DataPropertyName = dt.Columns["Company Name"].ToString();
                contactpersonGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
                countryGV.DataPropertyName = dt.Columns["Country"].ToString();
                cityGV.DataPropertyName = dt.Columns["City"].ToString();
                adressGV.DataPropertyName = dt.Columns["Adress"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone2"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                //      comd.ExecuteNonQuery();
                //    MainClass.connect.Open();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.ShowMSG(ex.Message, "Erorr", "Error");
            }

        }



        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
                // cb.Items.Clear();
                cb.DataSource = null;
                // cb.Items.Insert ( 0, "Select...." );

                SqlCommand cmd = new SqlCommand(proc, MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "select...." };
                dt.Rows.InsertAt(dr, 0);



                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;


            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        //SHOWPURCHASEINVOICEDETAILS
        public void showpurchaseInvoiceDetails(Int64 pid, DataGridView gv, DataGridViewColumn mPIDGV, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn quantityGV, DataGridViewColumn pupGV, DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
              mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                proIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Name of Product"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                pupGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();   
                totGV.DataPropertyName = dt.Columns["Total Price"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        //GETPRDUCT QUANTITY

        public object getProductQuantityWithoutConnection(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proId", proID);
                productStockCount = cmd.ExecuteScalar();


            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return productStockCount;
        }

        private object productStockCount = 0;
        public object getProductQuantity(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proId", proID);
                MainClass.connect.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.connect.Close();

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return productStockCount;
        }


        public void showStocksDetail(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proGV, 
            DataGridViewColumn barcodeGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn expiryGV, DataGridViewColumn catGV, 
            DataGridViewColumn quanGV, DataGridViewColumn finalGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getAllStocks", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barecode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
             
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                quanGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                finalGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
             


                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        //Product which respect to category
        public void showproductsWRTCategories(int catID, DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn buyingPriceGV
            ,DataGridViewColumn spGV, DataGridViewColumn disGV, DataGridViewColumn proMarGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsMRTCategory", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cat_ID", catID);
                //dataadaplter class is responsible to excute the query
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                buyingPriceGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
               disGV.DataPropertyName = dt.Columns["Discount"].ToString();
              proMarGV.DataPropertyName = dt.Columns["Profit Percentage"].ToString();


                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        private bool checkProductPExist;
        public bool checkProductPriceExist(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkProductsPriceExit", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.connect.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkProductPExist = true;
                }
                else
                {
                    checkProductPExist = false;
                }
                MainClass.connect.Close();
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return checkProductPExist;
        }
        ReportDocument rd;
        public void showReport( CrystalReportViewer crv, string proc, string param1, object val1)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd = new ReportDocument();
                //it is a class for crystal report
                //it is a property jdr bi Application ki exe save hogi whan se path utha k le aya ga
                rd.Load(Application.StartupPath + "\\Report\\Sale Receipt.rpt");
                rd.SetDataSource(dt);//\\Reports\\Sale Receipt.rpt
                crv.ReportSource = rd;
                crv.RefreshReport();

            }
            catch (Exception ex)
            {
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }

        }

    }
}
