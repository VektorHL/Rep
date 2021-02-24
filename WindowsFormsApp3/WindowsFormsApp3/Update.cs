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
    public partial class Update : Form
    {
        private SqlConnection sqlConnection = null;

        private int id;
        public Update(SqlConnection connection, int id)
        {
            InitializeComponent();
            sqlConnection = connection;
            this.id = id;
        }

        private async void Update_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.database1DataSet.Place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Trainer". При необходимости она может быть перемещена или удалена.
            this.trainerTableAdapter.Fill(this.database1DataSet.Trainer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Training". При необходимости она может быть перемещена или удалена.
            this.trainingTableAdapter.Fill(this.database1DataSet.Training);
            SqlCommand getFitnessInfoCommand = new SqlCommand("SELECT [date],[time],[train],[trainer],[fact],[place] FROM [Fitness] WHERE [id]=@id", sqlConnection);
            getFitnessInfoCommand.Parameters.AddWithValue("id", id);
            SqlDataReader sqlReader = null;
            try
            {
                sqlReader = await getFitnessInfoCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    dateTimePicker1.Text = Convert.ToString(sqlReader["date"]);
                    dateTimePicker2.Text = Convert.ToString(sqlReader["time"]);
                    comboBox1.Text= Convert.ToString(sqlReader["train"]);
                    comboBox2.Text = Convert.ToString(sqlReader["trainer"]);
                    numericUpDown1.Text = Convert.ToString(sqlReader["fact"]);
                    comboBox3.Text= Convert.ToString(sqlReader["place"]);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                    sqlReader.Close();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SqlCommand updateFitnessCommand = new SqlCommand("UPDATE [Fitness] SET [date]=@date ,[time]=@time,[train]=@train,[trainer]=@trainer,[fact]=@fact,[place]=@place WHERE [id]=@id",sqlConnection);
            updateFitnessCommand.Parameters.AddWithValue("id", id);
            updateFitnessCommand.Parameters.AddWithValue("date", Convert.ToDateTime(dateTimePicker1.Text));
            updateFitnessCommand.Parameters.AddWithValue("time", Convert.ToDateTime(dateTimePicker2.Text));
            updateFitnessCommand.Parameters.AddWithValue("train", comboBox1.Text);
            updateFitnessCommand.Parameters.AddWithValue("trainer", comboBox2.Text);
            updateFitnessCommand.Parameters.AddWithValue("fact", numericUpDown1.Text);
            updateFitnessCommand.Parameters.AddWithValue("place", comboBox3.Text);
            try
            {
                await updateFitnessCommand.ExecuteNonQueryAsync();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
