using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace IT3A1_WinForm
{
    internal class MyConfig
    {
        //Create object activeUser
        public static User activeUser;

        //Create logger object
        public static Logger logger = LogManager.GetCurrentClassLogger();

        //Create connection to DB
        public static OleDbConnection AccCon = new
            OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Application.StartupPath +
            "myDB.accdb;Jet OLEDB:Database Password=adm@123;");

        //Create SQL Server Connenction
        public static SqlConnection SqlCon = new SqlConnection(
            "Data Source=localhost;" +
            "Initial Catalog=IT3A1;" +
            "User ID=it3a1_usr;Password=adm@1235;" +
            "TrustServerCertificate=True;");

        //Method for validating email address
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
    public enum Sex { Male, Female };
    public enum Shift { Morning, Afternoon, Evening };
    public enum Address { Phnom_Penh, Province };
    //Creating enum UserRoles for user which include SysAdmin, Admin and User.
    public enum UserRoles { SuperAdmin, Admin, User };
}
