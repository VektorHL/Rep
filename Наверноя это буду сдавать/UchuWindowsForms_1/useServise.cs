﻿using MySql.Data.MySqlClient;
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
	public partial class useServise : Form
	{
		public useServise()
		{
			InitializeComponent();
			LoadFullData();
		}
		private void LoadFullData()
		{

			string connectString;

			connectString = "server=localhost; port=3306; username=root; password=root; database=fitness_center";

			MySqlConnection mySqlConnection = new MySqlConnection(connectString);

			mySqlConnection.Open();
			
			string query = "SELECT `id`, `name`, `used`, `can be used`, `idCardCustomer` FROM `active_services` GROUP BY  active_services.id";

			MySqlCommand command = new MySqlCommand(query, mySqlConnection);

			MySqlDataReader reader = command.ExecuteReader();

			List<string[]> data = new List<string[]>();

			while (reader.Read())
			{
				data.Add(new string[5]);

				data[data.Count - 1][0] = reader[0].ToString();
				data[data.Count - 1][1] = reader[1].ToString();
				data[data.Count - 1][2] = reader[2].ToString();
				data[data.Count - 1][3] = reader[3].ToString();
				data[data.Count - 1][4] = reader[4].ToString();
			}
			reader.Close();
			mySqlConnection.Close();


			foreach (string[] s in data)
			{
				dataGridView1.Rows.Add(s);
			}


		}

		private void useServisebutton_Click(object sender, EventArgs e)
		{
			useServiseButFunction();//Всё выполнение в функции
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

		private void buttonSearch_Click(object sender, EventArgs e)
		{

			dataGridView1.Rows.Clear();//Очищает таблицу

			string connectString;

			connectString = "server=localhost; port=3306; username=root; password=root; database=fitness_center";

			MySqlConnection mySqlConnection = new MySqlConnection(connectString);

			string idCardCudtomer = cardIdField.Text;

			mySqlConnection.Open();

			string query = "SELECT `id`, `name`, `used`, `can be used`, `idCardCustomer` FROM `active_services`  WHERE idCardCustomer = " + idCardCudtomer +  " GROUP BY  active_services.id";

			MySqlCommand command = new MySqlCommand(query, mySqlConnection);

			MySqlDataReader reader = command.ExecuteReader();

			List<string[]> data = new List<string[]>();

			while (reader.Read())
			{
				data.Add(new string[5]);

				data[data.Count - 1][0] = reader[0].ToString();
				data[data.Count - 1][1] = reader[1].ToString();
				data[data.Count - 1][2] = reader[2].ToString();
				data[data.Count - 1][3] = reader[3].ToString();
				data[data.Count - 1][4] = reader[4].ToString();
			}
			reader.Close();
			mySqlConnection.Close();


			foreach (string[] s in data)
			{
				dataGridView1.Rows.Add(s);
			}

			if (data.Count == 0)
			{
				MessageBox.Show("Карты с таким номером не найдено");
			}


		}

		private void useServiseButFunction()
		{

			string connectString;

			connectString = "server=localhost; port=3306; username=root; password=root; database=fitness_center";

			MySqlConnection mySqlConnection = new MySqlConnection(connectString);

			mySqlConnection.Open();


			string idCardCudtomer = cardIdFieldBotm.Text;
			string idServis = servisIdFieldBotm.Text;
			string query = "UPDATE `active_services` SET `used`= `used`+1 WHERE idCardCustomer=" + idCardCudtomer + " AND  id ="+ idServis;

			MySqlCommand command = new MySqlCommand(query, mySqlConnection);


			if (command.ExecuteNonQuery() == 1 )
			{
				MessageBox.Show("Услуга успешно списана");
				return;
			}
			else
			{
				MessageBox.Show("Услуга не списана, проверьте правильность заполнения номера карты и услуги");
				return;
			}

		}



	}
}
