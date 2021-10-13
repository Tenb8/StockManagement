using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace StockManagement
{
    class Insertion
    { 
        public void insertUser (string name, string username,string password,string email, string phone,Int16 status)
        {
            try
            {
                System.Data.SqlClient.SqlCommand command = new SqlCommand("st_insertUsers", MainClass.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name ",name);
                command.Parameters.AddWithValue("@username ",username);
                command.Parameters.AddWithValue("@pwd",password);
                command.Parameters.AddWithValue("@phone ",phone);
                command.Parameters.AddWithValue("@email ",email);
                command.Parameters.AddWithValue("@status", status); 
                MainClass.connect.Open();
                command.ExecuteNonQuery();
                MainClass.connect.Close();
                MainClass.ShowMSG(name +"added to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
        }
        public void insertCategories(string name,Int16 status)
        {
            try
            {
                System.Data.SqlClient.SqlCommand command = new SqlCommand("st_insertCategories", MainClass.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name ", name);
                command.Parameters.AddWithValue("@isActive", status);
                MainClass.connect.Open();
                command.ExecuteNonQuery();
                MainClass.connect.Close();
                MainClass.ShowMSG(name + "added to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
        }

        public void insertProducts(string product, string barecode,int catId, DateTime ? expiry= null)
        {
            try
            {
                System.Data.SqlClient.SqlCommand command = new SqlCommand("st_insertProducts", MainClass.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name ", product);
                command.Parameters.AddWithValue("@barecode", barecode);
               // command.Parameters.AddWithValue("@price", price);
                //command.Parameters.AddWithValue("@expiry", expiry);
               
                if (expiry == null)
               {
                   command.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
               else
               {
                    command.Parameters.AddWithValue("@expiry", expiry);
               }
                command.Parameters.AddWithValue("@cat_ID", catId);
                MainClass.connect.Open();
                command.ExecuteNonQuery();
                MainClass.connect.Close();
                MainClass.ShowMSG(product + " added to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
        }

        public void insertSupplier( string company,string personcontac, string pays,string ville,string adress,string email,string phone1,Int16 status,string phone2=null)
        {
            try
            {
                System.Data.SqlClient.SqlCommand command = new SqlCommand("st_insertSupplier", MainClass.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@company", company);
                command.Parameters.AddWithValue("@contactperson", personcontac);
                command.Parameters.AddWithValue("@country", pays);
                command.Parameters.AddWithValue("@city", ville);
                command.Parameters.AddWithValue("@adress", adress);
                command.Parameters.AddWithValue("@emailsuplier", email);
                command.Parameters.AddWithValue("@phone1", phone1);
            //  command.Parameters.AddWithValue("@phone2", phone2);
            //    command.Parameters.AddWithValue("@status", status);
              

                  if (phone2 == null)
               {
                  command.Parameters.AddWithValue("@phone2", DBNull.Value);
               }
               else
              {
                   command.Parameters.AddWithValue("@phone2", phone2);
                }
                // command.Parameters.AddWithValue("@cat_ID", catId);
                command.Parameters.AddWithValue("@status", status);
                MainClass.connect.Open();
                command.ExecuteNonQuery();
                MainClass.connect.Close();
                MainClass.ShowMSG(company + " added to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
        }


        public void insertCustomer(string company, string personcontac, string pays, string ville, string adress, string email, string phone1, Int16 status, string phone2 = null)
        {
            try
            {
                System.Data.SqlClient.SqlCommand command = new SqlCommand("st_insertCustomers", MainClass.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@company", company);
                command.Parameters.AddWithValue("@contactperson", personcontac);
                command.Parameters.AddWithValue("@country", pays);
                command.Parameters.AddWithValue("@city", ville);
                command.Parameters.AddWithValue("@adress", adress);
                command.Parameters.AddWithValue("@emailcustomer", email);
                command.Parameters.AddWithValue("@phone1", phone1);
                //  command.Parameters.AddWithValue("@phone2", phone2);
                //    command.Parameters.AddWithValue("@status", status);


                if (phone2 == null)
                {
                    command.Parameters.AddWithValue("@phone2", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@phone2", phone2);
                }
                // command.Parameters.AddWithValue("@cat_ID", catId);
                command.Parameters.AddWithValue("@status", status);
                MainClass.connect.Open();
                command.ExecuteNonQuery();
                MainClass.connect.Close();
                MainClass.ShowMSG(company + " added to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
        }



        private Int64 purchaseInvoiceID;

        public Int64 insertPurchaseInvoice(DateTime date , int doneBy,int suppId)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    System.Data.SqlClient.SqlCommand command = new SqlCommand("st_insertPurchaseInvoice", MainClass.connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@date ", date);
                    command.Parameters.AddWithValue("@doneBy", doneBy);
                    command.Parameters.AddWithValue("@supplier_Id", suppId);
                    MainClass.connect.Open();
                    command.ExecuteNonQuery();
                    command.CommandText = "st_LastpurchaseId";
                    command.Parameters.Clear();
                    purchaseInvoiceID = Convert.ToInt64(command.ExecuteScalar());
                    MainClass.connect.Close();
                    sc.Complete();
                } 
                ///  MainClass.ShowMSG(name + "added to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
            return purchaseInvoiceID;
        }

        int pidCount;

        public int insertPurchaseInvoiceDetails(Int64 purID, Int64 proID, int quan, float tPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoicedtails", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseId", purID);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quantity", quan);
                cmd.Parameters.AddWithValue("@totalprice", tPrice);
                MainClass.connect.Open();
                pidCount = cmd.ExecuteNonQuery();
                MainClass.connect.Close();

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return pidCount;
        }


        public void insertStock(Int64 proID, int quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proId", proID);
                cmd.Parameters.AddWithValue("@proquan", quan);
                MainClass.connect.Open();
                cmd.ExecuteNonQuery();
                MainClass.connect.Close();

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }

        }
        public void insertdeleteditems(Int64 pid, Int64 proid, int quan, int userid, DateTime date)
        {
            //it is use to catch logical error
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertDeletedItemsPI", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi", pid);
                cmd.Parameters.AddWithValue("@usrID", userid);
                cmd.Parameters.AddWithValue("@proID", proid);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@date", date);

                MainClass.connect.Open();
                cmd.ExecuteNonQuery();
                MainClass.connect.Close();

            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void insertProductPrice(Int64 proID, float buyingamount)
        {
            //it is use to catch logical error
            try
            {


                SqlCommand cmd = new SqlCommand("st_insertProductsPrice", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", buyingamount);
              

                MainClass.connect.Open();
                cmd.ExecuteNonQuery();
                MainClass.connect.Close();
              //  cmd.CommandText = "st_LastpurchaseId";
           //     cmd.Parameters.Clear();



            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        //Insertion des vantes
        int salCount = 0;
        Int64 salesID;
        retrieval r = new retrieval();
        Updation u = new Updation();

        public void insertSales(DataGridView gv, string proIDGV, string proQuanGV, int doneBy, DateTime dt, float tAmount, float Discount, 
            float cashRec, float cashBack,  string payType, string pupGV)//
        {
            try
            {using( TransactionScope sc=new TransactionScope()) 
                {
                    SqlCommand cmd = new SqlCommand("st_insertSales", MainClass.connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@done",doneBy);
                    cmd.Parameters.AddWithValue("@date",dt);
                    cmd.Parameters.AddWithValue("@totamnt",tAmount);
                    cmd.Parameters.AddWithValue("@totdis",Discount);
                    cmd.Parameters.AddWithValue("@given",cashRec);
                    cmd.Parameters.AddWithValue("@return",cashBack);
                    cmd.Parameters.AddWithValue("@pay",payType);
                  //  if (payType =="Cash")
                  //  {
                  //cmd.Parameters.AddWithValue("@pay", 0);
                  //  }
                  //  else if (payType =="Debit Card")
                  //  {
                  //      Convert.ToString(cmd.Parameters.AddWithValue("@pay", 1));
                  //  }
                  //  else if (payType =="Credit Card")
                  //  {
                  //      Convert.ToString(cmd.Parameters.AddWithValue("@pay", 2));
                  //  }

                    MainClass.connect.Open();
                    salCount = cmd.ExecuteNonQuery();
                    //sales ko count kaa rahe hai
                    if (salCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSalesID", MainClass.connect);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //ExecuteScalar is se ik(1) hi value uth kar ati hai
                        salesID = Convert.ToInt64(cmd2.ExecuteScalar());


                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("st_insertSalesDetails", MainClass.connect);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@salID", salesID);
                            cmd3.Parameters.AddWithValue("@proID", Convert.ToInt64(row.Cells[proIDGV].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[proQuanGV].Value.ToString()));
                    cmd3.Parameters.AddWithValue("@sellinPrice", Convert.ToSingle(row.Cells[pupGV].Value.ToString()));
                            cmd3.ExecuteNonQuery();
    int stockOfProduct = Convert.ToInt32(r.getProductQuantityWithoutConnection(Convert.ToInt64(row.Cells[proIDGV].Value.ToString())));
                            int currentQuantityProduct = Convert.ToInt32(row.Cells[proQuanGV].Value.ToString());
      int finalProductQuan = stockOfProduct - currentQuantityProduct;

           u.updateStockWhtitoutConnection(Convert.ToInt64(row.Cells[proIDGV].Value.ToString()), finalProductQuan);
                        }

                    }
                    MainClass.connect.Close();
                    MainClass.ShowMSG("Sales Successful", "Success", "Success");
                    sc.Complete();
                }


            }
            //exception handlini
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }

        }


    }
}
