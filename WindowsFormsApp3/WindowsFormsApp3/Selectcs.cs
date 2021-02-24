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
    public partial class Selectcs : Form
    {
        private SqlConnection sqlConnection = null;

   
        public Selectcs(SqlConnection connection)
        {
            InitializeComponent();
            sqlConnection = connection;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Selectcs_Load(object sender, EventArgs e)
        {
         
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
          
            listView1.Columns.Add("Тренер");
            listView1.Columns.Add("Телефон");
            await LoadTrainerAsync();
        }
        private async Task LoadTrainerAsync()
        {
            SqlDataReader sqlReader = null;
            SqlCommand getTrainerCommand = new SqlCommand("SELECT name,tel FROM [Trainer]", sqlConnection);
            try
            {
                sqlReader = await getTrainerCommand.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[] {
                        Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["tel"]),
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
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }

        }

        private void Selectcs_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
