using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UchuWindowsForms_1
{
	class DB
	{
		//MySqlConnection connection = new MySqlConnection("server=localhost; port=5432; username=admin; password=12345; database=fitness_center"); //Для Постгресс
		MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=fitness_center");// Для MAMP


		public void openConnection()
		{
			if (connection.State == System.Data.ConnectionState.Closed)
			{
				connection.Open();
			}
		}

		public void closeConnection()
		{
			if (connection.State == System.Data.ConnectionState.Open)
			{
				connection.Close();
			}
		}


		public MySqlConnection getConnection()
		{
			return connection;
		}
	}
}
