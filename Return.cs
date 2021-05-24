using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace car_rental_1
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MyConString = "datasource=localhost;port=3306;username=root;password=;database=car_rent";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command;
            MySqlDataReader mdr;

            connection.Open();

            string selectQuery = "SELECT * FROM return_car WHERE CarID = '" + textBoxCarID.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                MessageBox.Show("Return already done!");
            }
            else
            {
                string query = "INSERT INTO  return_car(CarID,Customer_ID,Date,Days_Elapsed,Fine) VALUES('" + textBoxCarID.Text + "','" + textBoxCustID.Text + "','" + textBoxDate.Text + "','" + textBoxDaysElapsed.Text + "','" + textBoxFine.Text + "')";
             
                MySqlConnection databaseConnection = new MySqlConnection(MyConString);
              
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    
                    GetReturnRecords();
                    MessageBox.Show("Return already registered!");

                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }
                
            }

            connection.Close();
        }

        private void GetReturnRecords()
        {
            string MyConString = "datasource=localhost;port=3306;username=root;password=;database=car_rent";
            MySqlConnection refresh_connection = new MySqlConnection(MyConString);
            string refreshQuery = "SELECT * FROM return_car";
            MySqlCommand commandDatabase = new MySqlCommand(refreshQuery, refresh_connection);
            DataTable dtable = new DataTable();
            refresh_connection.Open();


            MySqlDataReader mdr3 = commandDatabase.ExecuteReader();


            dtable.Load(mdr3);
            refresh_connection.Close();
            dataGridView1.DataSource = dtable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetReturnRecords();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main_obj = new Main();
            this.Hide();
            main_obj.ShowDialog();
            this.Close();
        }
    }
}
