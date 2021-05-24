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
    public partial class Calculation : Form
    {
        public Calculation()
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

            string selectQuery = "SELECT * FROM calculation WHERE ID = '" + textBoxID.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                MessageBox.Show("Payment already done!");
            }
            else
            {
                int quantity = int.Parse(textBoxQuantity.Text);
                int price = int.Parse(textBoxPrice.Text);

                int total = quantity * price;
                int payment;

                if (comboBoxDiscount.SelectedIndex == 1)
                {
                    payment= total-((total * 5) / 100);
                }
                else
                {
                    payment = total;
                }

                string query = "INSERT INTO  calculation(ID,Name,Quantity,Price,Total,Discount,Payment) VALUES('" + textBoxID.Text + "','" + textBoxName.Text + "','" + textBoxQuantity.Text + "','" + textBoxPrice.Text + "','"+total+"','" + comboBoxDiscount.Text + "','"+payment+"')";
                MySqlConnection databaseConnection = new MySqlConnection(MyConString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    GetCalculations();
                    MessageBox.Show("Payment Successfully done!");
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }
                
            }

            connection.Close();
        }

        private void GetCalculations()
        {
            string MyConString = "datasource=localhost;port=3306;username=root;password=;database=car_rent";
            MySqlConnection refresh_connection = new MySqlConnection(MyConString);
            string refreshQuery = "SELECT * FROM calculation";
            MySqlCommand commandDatabase = new MySqlCommand(refreshQuery, refresh_connection);
            DataTable dtable = new DataTable();
            refresh_connection.Open();


            MySqlDataReader mdr3 = commandDatabase.ExecuteReader();


            dtable.Load(mdr3);
            refresh_connection.Close();
            dataGridView1.DataSource = dtable;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxQuantity.Clear();
            textBoxPrice.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main_obj = new Main();
            this.Hide();
            main_obj.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form_obj = new Form1();
            this.Hide();
            form_obj.ShowDialog();
            this.Close();
        }
    }
}
