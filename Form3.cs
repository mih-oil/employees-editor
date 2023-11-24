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
    public partial class Form3 : Form
    {
        private static int OFFSETVALUE = 0;
        private static string employeeId = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGreedVievFiller(OFFSETVALUE);
        }

        private void nextEmployeesButton_Click(object sender, EventArgs e)
        {
            OFFSETVALUE += 10;
            dataGreedVievFiller(OFFSETVALUE);
        }

        private void previousEmployeesButton_Click(object sender, EventArgs e)
        {
            OFFSETVALUE -= 10;
            dataGreedVievFiller(OFFSETVALUE);
        }

        private void dataGreedVievFiller(int OFFSETVALUE)
        {
            NpgsqlConnection npgsqlConnection = createConnection();

            npgsqlConnection.Open();

            string commandText = "SELECT employee_id, employees.employee_name, employees.age, positions.position_id, positions.position_name, positions.position_salary FROM employees INNER JOIN positions on employees.position_id = positions.position_id LIMIT 10 OFFSET " + OFFSETVALUE;

            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(commandText, npgsqlConnection);

            DataSet dataSet = new DataSet();

            npgsqlDataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

            closeConnection(npgsqlConnection);

            if (dataGridView1.RowCount < 10)
            {
                nextEmployeesButton.Enabled = false;
            }
            else
            {
                nextEmployeesButton.Enabled = true;
            }

            if (OFFSETVALUE == 0)
            {
                previousEmployeesButton.Enabled = false;
            }
            else
            {
                previousEmployeesButton.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                newEmployeeName.Text = dataGridView1.Rows[e.RowIndex].Cells["employee_name"].Value.ToString();

                newEmployeeAge.Text = dataGridView1.Rows[e.RowIndex].Cells["age"].Value.ToString();

                positionTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["position_id"].Value.ToString();

                employeeId = dataGridView1.Rows[e.RowIndex].Cells["employee_id"].Value.ToString();
            }
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection npgsqlConnection = createConnection();

            npgsqlConnection.Open();

            var commandText = "UPDATE employees SET employee_name = @employee_name, age = @age, position_id = @position_id WHERE employee_id = @employee_id";

            var cmd = new NpgsqlCommand(commandText, npgsqlConnection);

                cmd.Parameters.AddWithValue("employee_name", newEmployeeName.Text);

                cmd.Parameters.AddWithValue("age", int.Parse(newEmployeeAge.Text));

                cmd.Parameters.AddWithValue("position_id", int.Parse(positionTextBox.Text));

                cmd.Parameters.AddWithValue("employee_id", int.Parse(employeeId));

            cmd.ExecuteNonQuery();

            closeConnection(npgsqlConnection);
        }

        private void deliteUserButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection npgsqlConnection = createConnection();

            npgsqlConnection.Open();

            var commandText = "DELETE FROM employees WHERE employee_id = @id";

            var cmd = new NpgsqlCommand(commandText, npgsqlConnection);

            cmd.Parameters.AddWithValue("id", int.Parse(employeeId));

            cmd.ExecuteNonQuery();

            closeConnection(npgsqlConnection);
        }
    }
}
