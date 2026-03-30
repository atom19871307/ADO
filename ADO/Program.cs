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
	internal class Program
	{
		static SqlConnection connection;
		static void Main(string[] args)
		{
			// Строка подключения к серверу и БД// Կապի տողը, որը նշում է սերվերը և բազայի անունը 
			string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_522;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			// Создаем объект класса DatabaseHelper
			// Ստեղծում ենք մեր նոր դասի օբյեկտը // Ստեղծում ենք DatabaseHelper-ի օբյեկտը 
			DatabaseHelper db = new DatabaseHelper(connection_string);

			 // Вызываем метод Select для директоров// Կանչում ենք Select մեթոդը ռեժիսորների համար	// Կանչում ենք մեթոդները օբյեկտի միջոցով
			db.Select("SELECT * FROM Directors");
			// Вызываем Scalar для подсчета количества// Կանչում ենք Scalar մեթոդը քանակը հաշվելու համար 
			Console.WriteLine($"Количество записей: {db.Scalar("SELECT COUNT(*) FROM Directors")}");

		}
	
	}
}
