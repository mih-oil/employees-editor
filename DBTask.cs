using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp23.Program;

namespace WindowsFormsApp23
{
    internal class DBTask
    {
        //выборка всех сотрудников
        public void task1()
        {
            NpgsqlConnection npgsqlConnection = createConnection();

            npgsqlConnection.Open();

            string commandText = "SELECT * FROM employees";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(commandText, npgsqlConnection);

            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

            while(npgsqlDataReader.Read())
            {
                Console.WriteLine(npgsqlDataReader[0].ToString());
            }

            closeConnection(npgsqlConnection);
        }

        //выборка сотрудников с зп выше 10000
        public void task2()
        {
            NpgsqlConnection npgsqlConnection = createConnection();

            npgsqlConnection.Open();

            string commandText = "SELECT employee_id, employees.employee_name, employees.age, positions.position_id, positions.position_name, positions.position_salary FROM employees INNER JOIN positions on employees.position_id = positions.position_id WHERE positions.position_salary > 10000";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(commandText, npgsqlConnection);

            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

            while (npgsqlDataReader.Read())
            {
                Console.WriteLine(npgsqlDataReader[0].ToString());
            }

            closeConnection(npgsqlConnection);
        }

        //удаление всех сотрудников старше 70
        public void task3()
        {
            NpgsqlConnection npgsqlConnection = createConnection();

            npgsqlConnection.Open();

            string commandText = "DELETE FROM employees WHERE age > 70";

            var cmd = new NpgsqlCommand(commandText, npgsqlConnection);

            cmd.ExecuteNonQuery();

            closeConnection(npgsqlConnection);
        }

        //обновить зп до 15000  тем сотрудникам, у которых она меньше
        public void task4()
        {
            NpgsqlConnection npgsqlConnection = createConnection();

            npgsqlConnection.Open();

            string commandText = "UPDATE positions SET position_salary = 15000 WHERE position_salary < 15000";

            var cmd = new NpgsqlCommand(commandText, npgsqlConnection);

            cmd.ExecuteNonQuery();

            closeConnection(npgsqlConnection);
        }
    }
}
