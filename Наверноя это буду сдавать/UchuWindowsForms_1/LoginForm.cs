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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();

			this.passField.AutoSize = false;
			this.passField.Size = new Size(this.passField.Size.Width, 64);
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


		Point lastPoint;


		private void mainPanel_MouseDown(object sender, MouseEventArgs e)
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



		private void ButtonLogin_Click(object sender, EventArgs e)
		{
			string loginUser = loginField.Text;
			string passUser = passField.Text;

			DB db = new DB();

			DataTable table = new DataTable();

			MySqlDataAdapter adapter = new MySqlDataAdapter();


			//MySqlCommand COMMAND = new MySqlCommand("SELECT * FROM `employee` WHERE `login` = loginUser AND  `pass` = passUser ");
			MySqlCommand command = new MySqlCommand("SELECT * FROM `employee` WHERE `login` = @uL AND  `pass` = @uP ", db.getConnection());

			//command.Parameters.Add("@uL", MySqlDbType.Text).Value = loginUser; //Для постгресса
			//command.Parameters.Add("@uP", MySqlDbType.Text).Value = passUser;  //Для постгресса

			command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser; //Для MAMP
		    command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;  //Для MAMP


			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (table.Rows.Count  > 0)
			{
				this.Hide();
				MainForm mainForm = new MainForm();//Переход на главную форму
				mainForm.Show();

			}
			else
			{
				MessageBox.Show("Работника с таким логином или паролем не существует");
			}

		}

		private void loginField_TextChanged(object sender, EventArgs e)
		{

		}






	}
}
