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
	public partial class CardRegistrationForm : Form
	{
		public CardRegistrationForm()
		{
			InitializeComponent();
		}



		//Закрытие программы
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

		//Перемещение окна
		Point lastPoint;

		private void topPanel_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void topPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void card_VIP_check_CheckedChanged(object sender, EventArgs e)
		{
			if (card_VIP_check.Checked)
			{
				cardPrice.Text = "22500" + " рублей";

			}
			else
			{
				cardPrice.Text = "15000 рублей";
			}

		}



		private void buttonRegistr_Click(object sender, EventArgs e)
		{


			//if (isUserExist())
			//	return;

			string card_type;
			string access_gum;
			string access_swimming;
			Int32 Price;

			if (card_VIP_check.Checked)
			{
				cardPrice.Text = "22500 рублей";
				card_type = "vip";
				access_gum = "yes";
				access_swimming = "yes";
				Price = 22500;
			}
			else
			{
				cardPrice.Text = "15000 рублей";
				card_type = "normal";
				access_gum = "yes";
				access_swimming = "no";
				Price = 15000;
			}



			DataTable table = new DataTable();

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			MySqlDataAdapter adapter2 = new MySqlDataAdapter();

			DB db = new DB();



			MySqlCommand check = new MySqlCommand("SELECT phone FROM `customer` WHERE customer.phone= @phone ", db.getConnection());
			check.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customerPhoneField.Text;



			//commandUp.Parameters.Add("@phone1", MySqlDbType.VarChar).Value = customerPhoneField.Text;


			adapter.SelectCommand = check;
			adapter.Fill(table);



			db.openConnection();


			if (table.Rows.Count > 0)
			{

		
				MySqlCommand command = new MySqlCommand("INSERT INTO `card`(`phone`, `price`, `card_type`, `validity`, `access_gum`, `access_swimming`) VALUES(@phone , @price ,@card_type ,CURDATE(), @access_gum, @access_swimming); UPDATE `card` SET `validity`= DATE_ADD(`validity`, INTERVAL 1 year) WHERE card.phone=@phone;    ", db.getConnection());
				command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customerPhoneField.Text;
				command.Parameters.Add("@price", MySqlDbType.Int32).Value = Price;
				command.Parameters.Add("@card_type", MySqlDbType.VarChar).Value = card_type;
				command.Parameters.Add("@access_gum", MySqlDbType.VarChar).Value = access_gum;
				command.Parameters.Add("@access_swimming", MySqlDbType.VarChar).Value = access_swimming;
				adapter2.SelectCommand = command;

				

				if (command.ExecuteNonQuery() == 2)
				{
					
					MessageBox.Show("Карта зарегистрированна");
					curCard();
				}
				else
				{
					
					MessageBox.Show("Что то пошло не так");
				}
			}
			else
			{
				MessageBox.Show("Карта не была привязана, проверьте правильность написания номера");
			}


		



			db.closeConnection();

		


		}





		/*	private bool phoneChek() // Реализовал уже реализованное, зачем??? Не знаю.
				{

				DB db = new DB();

				DataTable table = new DataTable();

				MySqlDataAdapter adapter = new MySqlDataAdapter();

				MySqlCommand check = new MySqlCommand("SELECT phone FROM `customer` WHERE customer.phone= @phone ", db.getConnection());
				check.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customerPhoneField.Text;


				adapter.SelectCommand = check;
				adapter.Fill(table);


				if (table.Rows.Count > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}*/

		private bool curCard()
		{

			string a;

			MySqlDataAdapter adapter = new MySqlDataAdapter();

			DB db = new DB();


			MySqlCommand commandCust = new MySqlCommand(" UPDATE `customer` SET `currentСard`= (SELECT card.id FROM card WHERE card.phone = @phone111) WHERE customer.phone=@phone111 ", db.getConnection());
			commandCust.Parameters.Add("@phone111", MySqlDbType.VarChar).Value = customerPhoneField.Text;



			adapter.SelectCommand = commandCust;



			db.openConnection();
			if (commandCust.ExecuteNonQuery() ==1)
			{

				MessageBox.Show("Функция выполнилась");
			}
			else
			{

				MessageBox.Show("Функция сломалась");
			}

			db.closeConnection();
			return true;
		}

	}
}
