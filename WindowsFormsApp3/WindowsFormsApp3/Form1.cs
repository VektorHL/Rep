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
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert(sqlConnection);
            insert.Show();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
          

            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");

             await sqlConnection.OpenAsync();
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Дата");
            listView1.Columns.Add("Время");
            listView1.Columns.Add("Тренировка");
            listView1.Columns.Add("Тренер");
            listView1.Columns.Add("Max");
            listView1.Columns.Add("Запись");
            listView1.Columns.Add("Место");
            await LoadFitnessAsync();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }
        private async Task LoadFitnessAsync()
        {
            SqlDataReader sqlReader = null;
            SqlCommand getFitnessCommand = new SqlCommand("SELECT * FROM [Fitness] ORDER BY DATE,TIME",sqlConnection);
            try
            {
                sqlReader = await getFitnessCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[] {
                        Convert.ToString(sqlReader["id"]),
                        Convert.ToString(sqlReader["date"]),
                         Convert.ToString(sqlReader["time"]),
                        Convert.ToString(sqlReader["train"]),
                        Convert.ToString(sqlReader["trainer"]),
                        Convert.ToString(sqlReader["max"]),
                        Convert.ToString(sqlReader["fact"]),
                        Convert.ToString(sqlReader["place"]),
                        

                    });


                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader !=null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }

        }

        private  async void toolStripButton5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            await LoadFitnessAsync();
        }

        private  async void toolStripButton3_Click(object sender, EventArgs e)
        {
            Selectcs select = new Selectcs(sqlConnection);
            select.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                Update update = new Update(sqlConnection, Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                update.Show();
            }
            else
            {
                MessageBox.Show("Выделите строку!","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

           
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This program made by Mary Shilkina and Ilya Burakov", "О программе",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
