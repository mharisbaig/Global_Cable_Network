using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Global_Cable_Network
{
    static class Program
    {
      // static public string connectionString ="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Mohammad\\Documents\\Visual Studio 2010\\Projects\\Global_Cable_Network\\Global_Cable_Network\\bin\\Debug\\GCN_Database.accdb";
     static public string connectionString ="Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + Application.StartupPath +"\\GCN_Database.accdb";
        
      //  string cs = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Data\School.mdf;Integrated Security=True";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new frmMain());
           
        }
    }
}
