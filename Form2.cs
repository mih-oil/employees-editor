using System;
using Npgsql;
using System.Windows.Forms;
using static WindowsFormsApp23.Program;

namespace WindowsFormsApp23
{
    public partial class Form2 : Form
    {
        private static Tuple<string, int>[] tuples = new Tuple<string, int>[100];
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NpgsqlConnection npgsqlConnection = createConnection();

            npgsqlConnection.Open();

            string commandText = "SELECT position_name, position_id FROM positions";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(commandText, npgsqlConnection);

            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

            int counter = 0;

            while (npgsqlDataReader.Read())
            {
                positionsComboBox.Items.Add(npgsqlDataReader.GetString(0));

                tuples[counter] = new Tuple<string, int>(npgsqlDataReader.GetString(0), (int)npgsqlDataReader.GetInt64(1));

                counter++;
            }

            closeConnection(npgsqlConnection);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void newEmployeeAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void addingNewEmployeeButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection npgsqlConnection = createConnection();

            npgsqlConnection.Open();

            string commandText = "INSERT INTO employees (employee_name, age, position_id) VALUES (@employee_name, @age, @position_id)";

            var cmd = new NpgsqlCommand(commandText, npgsqlConnection);

            cmd.Parameters.AddWithValue("employee_name", newEmployeeName.Text);

            try
            {
                cmd.Parameters.AddWithValue("age", int.Parse(newEmployeeAge.Text));
            }
            catch (FormatException)
            {
                closeConnection(npgsqlConnection);
                return;
            }

            cmd.Parameters.AddWithValue("position_id", findPositionId((string)positionsComboBox.SelectedItem));

            cmd.ExecuteNonQuery();

            closeConnection(npgsqlConnection);

            this.Close();
        }

        private int findPositionId(string positionName)
        {
            int counter = 0;

            if (String.IsNullOrEmpty(positionName))
            {
                return tuples[counter].Item2;
            } else
            {
                while (tuples[counter].Item1 != positionName)
                {
                    counter++;
                }

                return tuples[counter].Item2;
            }
        }
    }
}
