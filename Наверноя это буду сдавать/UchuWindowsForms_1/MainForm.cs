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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		//Закрыти программы
		private void closeButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//Перемещение верхней панели
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


		//Кнопки
		private void buttonCustomerRegistration_Click(object sender, EventArgs e)
		{
			this.Hide();
			RegistrForm registrForm = new RegistrForm();
			registrForm.Show();
		}

		private void buttonCardRegistration_Click(object sender, EventArgs e)
		{
			this.Hide();
			CardRegistrationForm cardRegistration = new CardRegistrationForm();
			cardRegistration.Show();
		}

		private void buttonVisit_Click(object sender, EventArgs e)
		{
			this.Hide();
			visitCentr visitCentr1 = new visitCentr();
			visitCentr1.Show();
		}

		private void buttonServiseCatalog_Click(object sender, EventArgs e)
		{
			this.Hide();
			serviseCatalog serviseCatalog1 = new serviseCatalog();
			serviseCatalog1.Show();
		}

		private void buttonUseServise_Click(object sender, EventArgs e)
		{
			this.Hide();
			useServise useServise1 = new useServise();
			useServise1.Show();
		}

		private void buttonTimeTible_Click(object sender, EventArgs e)
		{
			this.Hide();
			TimeTible timeTible = new TimeTible();
			timeTible.Show();

		}
	}
}
