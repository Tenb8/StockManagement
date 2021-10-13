using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    class Deletion
    {
        public void deleteUsers(Object id, string proc,string param)
        {
            try
            {
                System.Data.SqlClient.SqlCommand command = new SqlCommand(proc, MainClass.connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(param,id);
                
                MainClass.connect.Open();
                command.ExecuteNonQuery();
                MainClass.connect.Close();
                MainClass.ShowMSG( "Data delete to the system successfully ", "success..", "success");
            }
            catch (Exception ex)
            {
                MainClass.connect.Close();
                MainClass.ShowMSG(ex.Message, "Error..", "Error");
            }
        }
    }
}
