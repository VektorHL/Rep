using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchuWindowsForms_1
{
	public partial class serviseCatalog : Form
	{
		public serviseCatalog()
		{
			InitializeComponent();

			LoadData();
		}


		private void LoadData()
		{

			//DB db = new DB();

			string connectString;


			connectString = "server=localhost; port=3306; username=root; password=root; database=fitness_center";

			MySqlConnection mySqlConnection = new MySqlConnection(connectString);


			mySqlConnection.Open();


			string query = "SELECT * FROM `serviceсatalog` ORDER BY id";


			MySqlCommand command = new MySqlCommand(query, mySqlConnection);

			MySqlDataReader reader = command.ExecuteReader();

			List<string[]> data = new List<string[]>();

			while (reader.Read())
			{
				data.Add(new string[3]);

				data[data.Count - 1][0] = reader[0].ToString();
				data[data.Count - 1][1] = reader[1].ToString();
				data[data.Count - 1][2] = reader[2].ToString();

			}
			reader.Close();
			mySqlConnection.Close();


			foreach (string[] s in data)
			{
				dataGridView1.Rows.Add(s);
			}


		}







		private void closeButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm mainForm = new MainForm();//Переход на гоавную
			mainForm.Show();
		}

		private void buttonAddServise_Click(object sender, EventArgs e)
		{

			if (cardIdField.Text == "")
			{
				MessageBox.Show("Введите номер карты");
				return;
			}
			if (surviseIdField.Text == "")
			{
				MessageBox.Show("Выберите услугу из списка");
				return;
			}
			if (canUsedField.Text == "")
			{
				MessageBox.Show("Вседите колл-во приобретаемых услуг");
				return;
			}

			if (chekCardId() == true)//Проверка существования карты
			{
				return;
			}




			DB db = new DB();

			MySqlCommand command = new MySqlCommand(" INSERT INTO `active_services`(`name`, `used`, `can be used`, `idCardCustomer`) VALUES (@name, '0', @maxuse, @idCardCustomer)  ", db.getConnection());

			command.Parameters.Add("@name", MySqlDbType.VarChar).Value = getServName();
			command.Parameters.Add("@maxuse", MySqlDbType.VarChar).Value = canUsedField.Text;
			command.Parameters.Add("@idCardCustomer", MySqlDbType.VarChar).Value = cardIdField.Text;



			db.openConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				MessageBox.Show("Услуги преобретены");
			}
			else
			{
				MessageBox.Show("Услуги не внесены в базу");
			}


			db.closeConnection();


		}











		private bool chekCardId()
		{
			string connectString;

			connectString = "server=localhost; port=3306; username=root; password=root; database=fitness_center";

			MySqlConnection mySqlConnection = new MySqlConnection(connectString);

			mySqlConnection.Open();


			string query = "SELECT `serviceName` FROM `serviceсatalog` WHERE id ="+ cardIdField.Text;

			MySqlCommand command = new MySqlCommand(query, mySqlConnection);

			MySqlDataReader reader = command.ExecuteReader();

			List<string[]> data = new List<string[]>();

			while (reader.Read())
			{
				data.Add(new string[1]);

				data[data.Count - 1][0] = reader[0].ToString();

			}
			reader.Close();
			mySqlConnection.Close();

			if (data.Count >0)
			{
				MessageBox.Show("Эта карта не найдена");
				
				return true;// То есть такая карта найдена
			}
			else
			{
				//MessageBox.Show("Такая карта есть");
				return false;// То есть такой карты не нашли
			}

		}

		private string getServName()//Берёт имя услуги по id
		{

			string connectString;

			connectString = "server=localhost; port=3306; username=root; password=root; database=fitness_center";

			MySqlConnection mySqlConnection = new MySqlConnection(connectString);

			mySqlConnection.Open();


			string query = "SELECT  `serviceName` FROM `serviceсatalog` WHERE  id = " + surviseIdField.Text;

			MySqlCommand command = new MySqlCommand(query, mySqlConnection);

			MySqlDataReader reader = command.ExecuteReader();
			reader.Read();//Заставляет ридер читать
			string servisName = reader[0].ToString();//Переносит данные из ридера
			
			reader.Close();
			mySqlConnection.Close();

			return servisName;
		}

	}
}
