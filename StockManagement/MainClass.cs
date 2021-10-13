using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace StockManagement
{
    class MainClass
    {
        //private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

   //   private static string s = File.ReadAllText(path+"\\connect");
        //private static string s = File.ReadAllText(path );

        public static SqlConnection connect = new SqlConnection("Data Source =AFFIYYA\\SQLEXPRESS;Initial catalog=imsDB;Integrated Security=True"); 

        public static DialogResult ShowMSG(string msg, string hesding, string type)
        {
            if (type == "Succes")
            {
                return MessageBox.Show(msg, hesding, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg,hesding, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void showWindow(Form openWin, Form closeWin,Form MDIWin)
        {
            closeWin.Close();
          openWin.MdiParent = MDIWin; 
            //A revoir ici 
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();

        }
        public static void showWindow(Form openWin, Form MDIWin)
        {
            
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();

        }
        public static void disabl_reset(Panel pe)
        {
            foreach (Control c in pe.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;
                    ch.Enabled = false;
                    ch.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                  
                    dtp.Value = DateTime.Now;
                }
            }

        }
        public static void disable (Panel pe)
        {
            foreach (Control c in pe.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                     
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                   
                }
                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;
                    ch.Enabled = false;
                   
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                  
                }
            }

        }
        public static void enable_reset(Panel pe)
        {
            foreach (Control c in pe.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true   ;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;
                    ch.Enabled = true;
                    ch.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;                 
                    dtp.Value = DateTime.Now;
                }
            }

        }
        public static void enable(Panel pe)
        {
            foreach (Control c in pe.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                  
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                  
                }
                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;
                    ch.Enabled = true;
                  
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                   
                     
                }
            }

        }
        public static void enable_reset(GroupBox pe)
        {
            foreach (Control c in pe.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox ch = (CheckBox)c;
                    ch.Enabled = true;
                    ch.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
            }

        }
    }
}
