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

namespace car_rental_1
{
    public partial class CarRegistration : Form
    {
        public CarRegistration()
        {
            InitializeComponent();
        }

        private void comboBoxAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MyConString = "datasource=localhost;port=3306;username=root;password=;database=car_rent";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command;
            MySqlDataReader mdr;

            connection.Open();

            string selectQuery = "SELECT * FROM carregistration WHERE RegNumber = '" + textBoxRegiNo.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                MessageBox.Show("User already registered!");
            }
            else {
                string query = "INSERT INTO  carregistration(RegNumber,Make,Model,Available) VALUES('" + textBoxRegiNo.Text + "','" + textBoxMake.Text + "','" + textBoxModel.Text + "','" + comboBoxAvailable.Text + "')";
                MySqlConnection databaseConnection = new MySqlConnection(MyConString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                 try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    GetStudentRecord();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Car Successfully Registered!");
            }

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void GetStudentRecord() {
            string MyConString = "datasource=localhost;port=3306;username=root;password=;database=car_rent";
            MySqlConnection refresh_connection = new MySqlConnection(MyConString);
            string refreshQuery = "SELECT * FROM carregistration";
            MySqlCommand commandDatabase = new MySqlCommand(refreshQuery, refresh_connection);
            DataTable dtable = new DataTable();
            refresh_connection.Open();


            MySqlDataReader mdr3 = commandDatabase.ExecuteReader();


            dtable.Load(mdr3);
            refresh_connection.Close();
            dataGridView1.DataSource = dtable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main main_obj = new Main();
            this.Hide();
            main_obj.ShowDialog();
            this.Close();
        }
    }
}
