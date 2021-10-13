using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    class Updation
    {
        public void updateProductPrice(Int64 proID, float bp, float sp, float dis, float profitPer)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProductPrice", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", bp);
                cmd.Parameters.AddWithValue("@sp", sp);
                cmd.Parameters.AddWithValue("@discount", dis);
                cmd.Parameters.AddWithValue("@profPer", profitPer);
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

        public void updateProductPriceWRTPI(Int64 proID, float bp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProductPrice1", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", bp);

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
        public void updateUsers( int id, string name, string username, string password, string email, string phone, Int16 status)
        {
            try
            {
                System.Data.SqlClient.SqlCommand command = new SqlCommand("st_updateUsers", MainClass.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username ", username);
                command.Parameters.AddWithValue("@pwd ", password);
                command.Parameters.AddWithValue("@phone ", phone);
                command.Parameters.AddWithValue("@email  ", email);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@id  ",id );
                MainClass.connect.Open();
                command.ExecuteNonQuery();
                MainClass.connect.Close();
                MainClass.ShowMSG(name + "update to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
        }
        public void updateCategories(int id, string name, Int16 status)
        {
            try
            {
                System.Data.SqlClient.SqlCommand command = new SqlCommand("st_updateCategories", MainClass.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name ", name);
                command.Parameters.AddWithValue("@id ", id);
                command.Parameters.AddWithValue("@isActive", status);
                MainClass.connect.Open();
                command.ExecuteNonQuery();
                MainClass.connect.Close();
                MainClass.ShowMSG(name + "update to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
        }

        public void updateProducts(Int64 proID, string product, string barecode, int catId, DateTime? expiry = null )
        {
            try
            {
                System.Data.SqlClient.SqlCommand command = new SqlCommand("st_updateProducts", MainClass.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name ", product);
                command.Parameters.AddWithValue("@barecode", barecode);
              //  command.Parameters.AddWithValue("@price", price);
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
                command.Parameters.AddWithValue("@pro_ID", proID);


                MainClass.connect.Open();
                command.ExecuteNonQuery();
                MainClass.connect.Close();
                MainClass.ShowMSG(product + "Updated to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
        }

        // обновить поставщики
        public void updateSupplier( Int64 supplierID, string company, string personcontac, string pays, string ville, string adress,string email, string phone1 ,Int16 status ,string phone2=null)
        {
            try
            {
                System.Data.SqlClient.SqlCommand command = new SqlCommand("st_updateSupplier", MainClass.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@company ", company);
                command.Parameters.AddWithValue("@contactperson", personcontac);
                command.Parameters.AddWithValue("@country", pays);
                command.Parameters.AddWithValue("@city", ville);
                command.Parameters.AddWithValue("@adress ", adress);
                command.Parameters.AddWithValue("@emailsuplier", email);
                command.Parameters.AddWithValue("@phone1", phone1); 
                                   command.Parameters.AddWithValue("@phone2", phone2);
  command.Parameters.AddWithValue("@status", status);
               // if (phone2 == null)
              // {
              //    command.Parameters.AddWithValue("@phone2", DBNull.Value);
               // }
               // else
              // {
              //     
              // }
              command.Parameters.AddWithValue("@id", supplierID); 
                      
                MainClass.connect.Open();
                command.ExecuteNonQuery();
                MainClass.connect.Close();
                MainClass.ShowMSG(company + "  Update to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
        }

        public void updateCustomer(Int64 customerID, string company, string personcontac, string pays, string ville, string adress, string email, string phone1, Int16 status, string phone2 = null)
        {
            try
            {
                System.Data.SqlClient.SqlCommand command = new SqlCommand("st_updateCustomer", MainClass.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@company ", company);
                command.Parameters.AddWithValue("@contactperson", personcontac);
                command.Parameters.AddWithValue("@country", pays);
                command.Parameters.AddWithValue("@city", ville);
                command.Parameters.AddWithValue("@adress ", adress);
                command.Parameters.AddWithValue("@emailcustomer", email);
                command.Parameters.AddWithValue("@phone1", phone1);
                command.Parameters.AddWithValue("@phone2", phone2);
                command.Parameters.AddWithValue("@status", status);
                // if (phone2 == null)
                // {
                //    command.Parameters.AddWithValue("@phone2", DBNull.Value);
                // }
                // else
                // {
                //     
                // }
                command.Parameters.AddWithValue("@id", customerID);

                MainClass.connect.Open();
                command.ExecuteNonQuery();
                MainClass.connect.Close();
                MainClass.ShowMSG(company + "  Update to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
        }





        public void updateStock(Int64 proID, int quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.connect);
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

        public void updateStockWhtitoutConnection(Int64 proID, int quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proId", proID);
                cmd.Parameters.AddWithValue("@proquan", quan);
           
                cmd.ExecuteNonQuery();
             
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
