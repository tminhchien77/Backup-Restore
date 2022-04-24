using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backup_restore
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=DESKTOP-R6465LG;Initial Catalog=BANVE_SANBONG;Integrated Security=True";
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String password = "";
        public static String database = "";
        public static String mlogin = "";

        public static string defaultPath = "D:/Program Files/MSSQL/backup";

        public static int ConnectServer()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connstr = "Data Source=" + Program.servername + " ;Initial Catalog=" +
                   Program.database + ";User ID=" +
                   Program.username + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối với SERVER.\n Bạn xem lại username và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return -1;
            }

        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            try
            {
                da.Fill(dt);
                return dt;

            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }


        }
        public static int execNonQuery(String str, String msg = "")
        {
            SqlCommand sqlCommand = new SqlCommand(str, Program.conn);
            sqlCommand.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlCommand.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    if (ex.Message.Contains("Error converting data type varchar to int"))
                        MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                    else MessageBox.Show(ex.Message);
                }
                conn.Close();
                return -1;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Application.Run(new FormMain());*/
            Application.Run(new FormLogin());
        }
    }
}
