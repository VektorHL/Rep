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
	public partial class TimeTible : Form
	{
		public TimeTible()
		{
			InitializeComponent();
			LoadDataTeining();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void LoadDataTeining()
		{

			string connectString;

			connectString = "server=localhost; port=3306; username=root; password=root; database=fitness_center";

			MySqlConnection mySqlConnection = new MySqlConnection(connectString);
			
			mySqlConnection.Open();

			string query = "SELECT `id`, `discipline`, `start`, `finish`, `trainer`, DAYname(start) FROM `group_training`";
			



			MySqlCommand command = new MySqlCommand(query, mySqlConnection);

			MySqlDataReader reader = command.ExecuteReader();

			List<string[]> data = new List<string[]>();

			while (reader.Read())
			{
				data.Add(new string[6]);

				data[data.Count - 1][0] = reader[0].ToString();
				data[data.Count - 1][1] = reader[1].ToString();
				data[data.Count - 1][2] = reader[2].ToString();
				data[data.Count - 1][3] = reader[3].ToString();
				data[data.Count - 1][4] = reader[4].ToString();
				data[data.Count - 1][5] = reader[5].ToString();
			}
			reader.Close();
			mySqlConnection.Close();


			foreach (string[] s in data)
			{
				dataGridView1.Rows.Add(s);
			}


		}

		private void disciplineSearchServise_Click(object sender, EventArgs e)
		{
			disciplineSearch();
		}


		private void disciplineSearch()
		{
			dataGridView1.Rows.Clear();//Очищает таблицу

			string connectString;

			connectString = "server=localhost; port=3306; username=root; password=root; database=fitness_center";

			MySqlConnection mySqlConnection = new MySqlConnection(connectString);

			mySqlConnection.Open();

			string disciplineSearchName = disciplineSearchField.Text;

			string query = "SELECT `id`, `discipline`, `start`, `finish`, `trainer`, DAYname(start) FROM `group_training` WHERE discipline = '" + disciplineSearchName + "' ORDER BY id";

			
			MySqlCommand command = new MySqlCommand(query, mySqlConnection);

			MySqlDataReader reader = command.ExecuteReader();

			List<string[]> data = new List<string[]>();

			while (reader.Read())
			{
				data.Add(new string[6]);

				data[data.Count - 1][0] = reader[0].ToString();
				data[data.Count - 1][1] = reader[1].ToString();
				data[data.Count - 1][2] = reader[2].ToString();
				data[data.Count - 1][3] = reader[3].ToString();
				data[data.Count - 1][4] = reader[4].ToString();
				data[data.Count - 1][5] = reader[5].ToString();
			}
			reader.Close();
			mySqlConnection.Close();


			foreach (string[] s in data)
			{
				dataGridView1.Rows.Add(s);
			}

		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm mainForm = new MainForm();//Переход на гоавную
			mainForm.Show();
		}
	}
}
