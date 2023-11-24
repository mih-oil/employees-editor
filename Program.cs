using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }

        internal static NpgsqlConnection createConnection()
        {
            String connectionString = "Server=ella.db.elephantsql.com; Port=5432; Database=pzbyanyp; UserId=pzbyanyp; Password=XxDxdbgeVGvT2lHkXQ44vQEBCw-TO2ps";

            return new NpgsqlConnection(connectionString);
        }

        internal static void closeConnection(NpgsqlConnection connection)
        {
            connection.Close();
        }
    }
}
