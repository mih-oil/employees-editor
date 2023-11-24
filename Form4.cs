using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp23.Program;

namespace WindowsFormsApp23
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void addNewPositionButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection npgsqlConnection = createConnection();

            npgsqlConnection.Open();

            string commandText = "INSERT INTO positions (position_name, position_salary) VALUES (@position_name, @position_salary)";

            var cmd = new NpgsqlCommand(commandText, npgsqlConnection);

            cmd.Parameters.AddWithValue("position_name", positionTextBox.Text);

            try
            {
                cmd.Parameters.AddWithValue("position_salary", int.Parse(salaryTextBox.Text));
            }
            catch (FormatException)
            {
                closeConnection(npgsqlConnection);
                return;
            }
            

            cmd.ExecuteNonQuery();

            closeConnection(npgsqlConnection);

            this.Close();
        }
    }
}
