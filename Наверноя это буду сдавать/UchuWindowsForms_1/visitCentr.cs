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
	public partial class visitCentr : Form
	{
		public visitCentr()
		{
			InitializeComponent();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Application.Exit();

		}

		private void closeButton_MouseEnter(object sender, EventArgs e)
		{
			closeButton.ForeColor = Color.Green;
		}

		private void closeButton_MouseLeave(object sender, EventArgs e)
		{
			closeButton.ForeColor = Color.White;
		}

		private void buttonVisit_Click(object sender, EventArgs e)
		{

			//DataTable table = new DataTable();
			//MySqlDataAdapter adapter = new MySqlDataAdapter();
			DB db = new DB();


			if (isCurrentOut())//Может человек уже в центру, и хочет выйти
			{
				

			}
			else// Если он всё таки не в центре
			{
				MySqlCommand commandVisit = new MySqlCommand("INSERT INTO `visit`(`in_centr`, `out_centr`, `card_id`) VALUES (CURRENT_TIMESTAMP(), '1999-12-30' , @curdId  )", db.getConnection());

				commandVisit.Parameters.Add("@curdId", MySqlDbType.VarChar).Value = cardIdField.Text;
				db.openConnection();


				if (commandVisit.ExecuteNonQuery() == 1)
				{

					MessageBox.Show("Гость вошёл в центр ");

				}
				else
				{

					MessageBox.Show("Что то пошло не так в окне визита");
				}

				db.closeConnection();
			}



		}


		private bool isCurrentOut()
			{
			DB db = new DB();
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();


			//Должна проверять, входил ли уже этот человек в центр.
			MySqlCommand commandVisitOutCheck = new MySqlCommand("SELECT `out_centr`  FROM `visit` WHERE `card_id` = @curdId AND `out_centr` ='1999-12-30 00:00:00' ", db.getConnection());

			commandVisitOutCheck.Parameters.Add("@curdId", MySqlDbType.VarChar).Value = cardIdField.Text;

			adapter.SelectCommand = commandVisitOutCheck;//Проверяем, в центре ли гость
			adapter.Fill(table);

			

			db.openConnection();
			if (table.Rows.Count >0 )
			{

				MySqlCommand commandVisitOut = new MySqlCommand("UPDATE `visit` SET `out_centr`=CURRENT_TIMESTAMP() WHERE `card_id` = @curdId ", db.getConnection());
				commandVisitOut.Parameters.Add("@curdId", MySqlDbType.VarChar).Value = cardIdField.Text;

				

				if (commandVisitOut.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Гость покинул центр");

				}
				else
				{
					MessageBox.Show("Гость покинул центр!!!");//Если гость не в первый раз
				}



				db.closeConnection();
				return true;
			}
			else
			{

				//MessageBox.Show("Гость еще не в цетре ");//Это для проверки
				db.closeConnection();
				return false;
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
