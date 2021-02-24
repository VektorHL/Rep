
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Insert : Form

    {

        private SqlConnection sqlConnection = null;

        public Insert(SqlConnection connection)
        {
            InitializeComponent();
            sqlConnection = connection;
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Insert_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.database1DataSet.Place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Trainer". При необходимости она может быть перемещена или удалена.
            this.trainerTableAdapter.Fill(this.database1DataSet.Trainer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Training". При необходимости она может быть перемещена или удалена.
            this.trainingTableAdapter.Fill(this.database1DataSet.Training);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand insertFitnessCommand = new SqlCommand("INSERT INTO [Fitness] (date, time, train, trainer, max, fact, place)VALUES(@date,@time, @train, @trainer, @max, @fact, @place)", sqlConnection);
            insertFitnessCommand.Parameters.AddWithValue("date",Convert.ToDateTime(dateTimePicker1.Text));
            insertFitnessCommand.Parameters.AddWithValue("time", Convert.ToDateTime(dateTimePicker2.Text));
            insertFitnessCommand.Parameters.AddWithValue("train", comboBox1.Text);
            insertFitnessCommand.Parameters.AddWithValue("trainer", comboBox2.Text);
            insertFitnessCommand.Parameters.AddWithValue("max", numericUpDown1.Text);
            insertFitnessCommand.Parameters.AddWithValue("fact", numericUpDown2.Text);
            insertFitnessCommand.Parameters.AddWithValue("place", comboBox3.Text);

            try
            {
                await insertFitnessCommand.ExecuteNonQueryAsync();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

