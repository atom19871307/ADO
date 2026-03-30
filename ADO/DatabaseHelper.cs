using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Threading.Tasks;

// Библиотека для работы с SQL Server// Գրադարան SQL Server-ի հետ աշխատելու համար
using System.Data.SqlClient;
namespace ADO
{
	public class DatabaseHelper
	{
		// Объект подключения к базе данных // Կապի օբյեկտ բազայի հետ
		private SqlConnection connection;

		// Конструктор, принимающий строку подключения
		// Կոնստրուկտոր, որը ստանում է կապի տողը
		public DatabaseHelper(string connectionString)
		{
			//  Создаем новое подключение //Ստեղծում ենք նոր կապ 
			connection = new SqlConnection(connectionString);
		}
		// Метод для выбора данных  //
		// Մեթոդ տվյալներ ընտրելու համար
		public void Select(string cmd)
		{
			// Создаем SQL команду  // Ստեղծում ենք SQL հրամանը
			SqlCommand command = new SqlCommand(cmd, connection);
			// Открываем соединение  // Բացում ենք կապը
			connection.Open();
			//Выполняем запрос и получаем данные  // Կատարում ենք հարցումը և ստանում տվյալները
			SqlDataReader reader = command.ExecuteReader();
			// Печатаем названия колонок  // Տպում ենք սյունակների անունները
			for (int i = 0; i < reader.FieldCount; i++)
				Console.Write($"{reader.GetName(i)}\t");

			Console.WriteLine(); // Նոր տողի համար
								 // Читаем данные построчно
			while (reader.Read())
			{
				// Տպում ենք առաջին 3 սյունակները / Печатаем первые 3 колонки
				Console.WriteLine($"{reader[0]}\t\t{reader[1]}\t\t{reader[2]}");
			}
			reader.Close();
			connection.Close();
		}
		// Метод для получения одного значения// Մեթոդ մեկ արժեք ստանալու համար (օր.՝ Count) 
		public object Scalar(string cmd)
		{
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			// Получаем только первое значение первого столбца // Ստանում ենք միայն առաջին սյունակի առաջին տողը 
			object value = command.ExecuteScalar();
			connection.Close();  // Закрываем соединение
			return value;       // Возвращаем значение
		}
	}
}
