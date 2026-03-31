using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

//ADO.NET
//ADO - ActiveX Data Objects
// .NET
//System.Date.SqlClient

namespace ADO
{
	class Program
	{
		private const string movies_PV_522_connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_522;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

		private static T_SQL movies_PV_522 = new T_SQL(new SqlConnection(movies_PV_522_connection_string));
		static void Main(string[] args)
		{
			Console.WriteLine(movies_PV_522_connection_string);


			string cmd = "SELECT * FROM Directors";
			movies_PV_522.Select(cmd);
			Console.WriteLine($"Колличество записей: {movies_PV_522.Scalar("SELECT COUNT(*) FROM Directors")}");
			movies_PV_522.Select
				(
				"SELECT " + "title , date = release_date , first_name , last_name " +"FROM Movies , Directors " +"WHERE director_id = director"
				);
		}

	}
	public class T_SQL
	{
		private SqlConnection connection;

		public T_SQL(SqlConnection _connection) { connection = _connection; }
		public T_SQL(ref SqlConnection _connection) { connection = _connection; }
		public void Select(string cmd, int interval = 11)
		{
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			string[][] output = new string[1][];
			output[0] = new string[reader.FieldCount];

			for (int i = 0; i < reader.FieldCount; i++)
				output[0][i] = $"[ {reader.GetName(i)} ]";
			/*
			for (int i = 0; i < reader.FieldCount; i++)
				Console.Write($"[ {reader.GetName(i)} ]\t");
			Console.WriteLine();
			*/
			while (reader.Read())
			{
				output = output.Append(new string[reader.FieldCount]).ToArray();
				for (int i = 0; i < reader.FieldCount; i++)
					output[output.Length - 1][i] = reader[i].ToString();
				/*
				string output_line = "";
				for(int i = 0; i < reader.FieldCount; ++i) 
					output_line += reader[i].ToString() + '\t';
				Console.WriteLine(output_line);
				*/
				//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
				//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}\t{reader.FieldCount}");
			}
			reader.Close();
			connection.Close();

			for (int i = 0; i < output[0].Length; ++i)
			{
				int max_size_str = 0;
				for (int j = 0; j < output.Length; ++j)
					if (max_size_str < output[j][i].Length) max_size_str = output[j][i].Length;

				for (int j = 0; j < output.Length; ++j)
					output[j][i] += new string(' ', max_size_str - output[j][i].Length + interval);
			}
			for (int i = 0; i < output[0].Length; ++i)
				Console.Write(output[0][i]);
			Console.WriteLine($"\n{new string('-', output[0].Sum(str => str.Length))}");

			for (int i = 1; i < output.Length; ++i)
			{
				foreach (string line in output[i])
					Console.Write(line);
				Console.WriteLine();
			}
		}
		//static void Select(string fields, stringo tables, string conditon = "")
			//string cmd = $"SELECT {fields} FROM {tables}";
		public object Scalar(string cmd)
		{
			object value = null;
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			value = command.ExecuteScalar();
			connection.Close();
			return value;
		}

	}
}