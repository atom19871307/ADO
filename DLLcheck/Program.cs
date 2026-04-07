using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

using DBtools;
namespace DLLcheck
{
	internal class Program
	{

		static void Main(string[] args)
		{
			// Подключение к базе данных "Movies".
			// Создаем объект connector, используя строку подключения из App.config для базы Movies_PV_522.
			// Movies բազայի միացումը
			Connector connector = new Connector(ConfigurationManager.ConnectionStrings["Movies_PV_522"].ConnectionString);
			
			// Выбираем все данные из таблицы "Directors" базы Movies.
			connector.Select("*", "Directors");

			// Подключение к базе данных "Academy".
			// Создаем второй объект connectorAcademy для работы с базой PV_522_Import.
			// Academy բազայի միացումը
			Connector connectorAcademy = new Connector(ConfigurationManager.ConnectionStrings["PV_522_Import"].ConnectionString);

			// Выбираем все данные из таблицы "Disciplines" базы Academy.
			connectorAcademy.Select("*", "Disciplines");

			// Обновление данных (Update).
			// Вызываем метод Update для таблицы "Groups". 
			// Устанавливаем новое имя группы 'PV_522' для записи с ID = 1.
			// ՀԻՄԱ ԿԱՆՉՈՒՄ ԵՆՔ UPDATE-Ը (բոլորը մեկ Main-ի ներսում)
			connectorAcademy.Update("Groups", "group_name = N'PV_522_Imp'", 1);
			Console.WriteLine("Проверяем базу......");
			// Выводим сообщение в консоль о том, что операция прошла успешно.
			Console.WriteLine("Данные успешно обновлены:");

			Console.ReadKey(); // Որպեսզի կոնսոլը անմիջապես չփակվի
		}

	}
}
