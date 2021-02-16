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
	public partial class RegistrForm : Form
	{
		public RegistrForm()
		{
			InitializeComponent();

		
			customerNameField.Text = "Введите Имя";
			customerNameField.ForeColor = Color.Gray;
			customerSurnameField.Text = "Введите Фамилию";
			customerSurnameField.ForeColor = Color.Gray;
			customerPhoneField.Text = "Введите телефон";
			customerPhoneField.ForeColor = Color.Gray;


		}

		//Блок выключения программы
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




		//Блок перемещения окна
		Point lastPoint;
	
		private void topPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void topPanel_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void mainPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void mainPanel_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		//Блок имени


		private void customerNameField_MouseEnter(object sender, EventArgs e)
		{
			if (customerNameField.Text == "Введите Имя")
			{
				customerNameField.Text = "";
				customerNameField.ForeColor = Color.Black;

			}
		}

		private void customerNameField_MouseLeave(object sender, EventArgs e)
		{
			if (customerNameField.Text == "")
				customerNameField.Text = "Введите Имя";
			customerNameField.ForeColor = Color.Gray;
		}


		//Блок Фамилии

		private void customerSurnameField_MouseEnter(object sender, EventArgs e)
		{
			if (customerSurnameField.Text == "Введите Фамилию")
				customerSurnameField.Text = "";
			customerSurnameField.ForeColor = Color.Black;

			
		}

		private void customerSurnameField_MouseLeave(object sender, EventArgs e)
		{
			if (customerSurnameField.Text == "")
			{
				customerSurnameField.Text = "Введите Фамилию";
				customerSurnameField.ForeColor = Color.Gray;
			}
		}


		//Блок для телефона


		private void customerPhoneField_MouseEnter(object sender, EventArgs e)
		{
			if (customerPhoneField.Text == "Введите телефон")
			{
				customerPhoneField.Text = "";
				customerPhoneField.ForeColor = Color.Black;

			}
		}

		private void customerPhoneField_MouseLeave(object sender, EventArgs e)
		{
			if (customerPhoneField.Text == "")
				customerPhoneField.Text = "Введите телефон";
			customerPhoneField.ForeColor = Color.Gray;
		}


		//Блок действий кнопок
		private void buttonRegistr_Click(object sender, EventArgs e)
		{

			if (customerNameField.Text == "Имя")
			{
				MessageBox.Show("Введите имя");
				return;
			}
			if (customerSurnameField.Text == "Фамилия")
			{
				MessageBox.Show("Введите Фамилию");
				return;
			}
			if (customerPhoneField.Text == "Введите телефон")
			{
				MessageBox.Show("Введите телефон");
				return;
			}

			

			if (isUserExist())
				return;

			DB db = new DB();
			//MySqlCommand command = new MySqlCommand("INSERT INTO `employe` ( `login`, `pass`, `name`, `surname`) VALUES(@login, @pass, @name, @surname)", db.getConnection());


			MySqlCommand command = new MySqlCommand("INSERT INTO `customer`( `name`, `surname`, `phone`, `registrationDate`, `currentСard`) VALUES(@name, @surname, @phone, CURDATE(), 0)", db.getConnection());

			
			command.Parameters.Add("@name", MySqlDbType.VarChar).Value = customerNameField.Text  ;
			command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = customerSurnameField.Text;
			command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customerPhoneField.Text;
		



			db.openConnection();

			if (command.ExecuteNonQuery()==1)
			{
				MessageBox.Show("Пользователь был зарегистрирован");
			}
			else
			{
				MessageBox.Show("Пользователь не был зарегистрирован");
			}


			db.closeConnection();
		}


		public Boolean isUserExist()
		{

			DB db = new DB();

			DataTable table = new DataTable();

			MySqlDataAdapter adapter = new MySqlDataAdapter();


			MySqlCommand command = new MySqlCommand("SELECT * FROM `customer` WHERE `phone` = @cP ", db.getConnection());

	
			command.Parameters.Add("@cP", MySqlDbType.VarChar).Value = customerPhoneField.Text; //Для MAMP
		

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (table.Rows.Count > 0)
			{
				MessageBox.Show("Этот человек уже зарегистрирован");
				return true;
			}
			else
			{
				return false;
			}
		}

		private void mainPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void back_MouseEnter(object sender, EventArgs e)
		{
			closeButton.ForeColor = Color.Gray;
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm mainForm = new MainForm();//Переход на гоавную
			mainForm.Show();
		}

		
	}
}
