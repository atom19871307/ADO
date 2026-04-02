
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

//ADO.NET
//ADO - ActiveX Data Objects
//.NET
//System.Data
//System.Data.SqlClient

namespace PV_522_ADO
{
	class Program
	{
		static void Main(string[] args)
		{
			//string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_522;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			string connection_string = ConfigurationManager.ConnectionStrings["Movies"].ConnectionString;
			Connector connector = new Connector(connection_string);

			connector.Select("SELECT * FROM Directors");
			connector.Select("title,first_name,last_name", "Movies,Directors", "director=director_id");
			//connector.Insert("Directors", "first_name, last_name",  "'Christopher', 'Nolar'");

			//--------------------------------------------------------------------------
			// Добавляем нового режиссера
			connector.Select("SELECT * FROM Directors");
			//connector.Insert("Directors", "director_id, first_name, last_name", "7, 'Steven', 'Spielberg'");
			//connector.Insert("Directors", "director_id, first_name, last_name", "8, 'Christopher', 'Nolan'");
			//connector.Insert("Directors", "director_id, first_name, last_name", "9, 'Quentin', 'Tarantino'");
			//connector.Insert("Directors", "director_id, first_name, last_name", "10, 'Martin', 'Scorsese'");
			// Давайте распечатаем их все, чтобы проверить
			//------------------------------------------------------------------------
			//Console.WriteLine(connection_string);
			//connection = new SqlConnection(connection_string);

			//string cmd = "SELECT last_name,first_name FROM Directors";
			//Select(cmd);

			//Console.WriteLine($"Количество записей: {Scalar("SELECT COUNT(*) FROM Directors")}");
			//Select("title, release_date, last_name, first_name", "Movies,Directors", "director=director_id");
			/*Select("SELECT title,release_date,first_name,last_name FROM Movies,Directors WHERE director=director_id");*/

		}
	}
}
