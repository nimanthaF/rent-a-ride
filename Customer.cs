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
    public partial class Customer : Form
    {
        public Customer()
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

            string selectQuery = "SELECT * FROM customer WHERE CustomerID = '" + textBoxID.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                MessageBox.Show("User already registered!");
            }
            else
            {
                string query = "INSERT INTO  customer(CustomerID,Name,Address,Mobile) VALUES('" + textBoxID.Text + "','" + textBoxName.Text + "','" + textBoxAddress.Text + "','" + textBoxMobile.Text + "')";
                MySqlConnection databaseConnection = new MySqlConnection(MyConString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    GetCustomerRecords();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Customer Successfully Registered!");
            }

            connection.Close();
        }


        private void GetCustomerRecords()
        {
            string MyConString = "datasource=localhost;port=3306;username=root;password=;database=car_rent";
            MySqlConnection refresh_connection = new MySqlConnection(MyConString);
            string refreshQuery = "SELECT * FROM customer";
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
            GetCustomerRecords();
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
