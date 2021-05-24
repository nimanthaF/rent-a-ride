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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void carRegButton_Click(object sender, EventArgs e)
        {
            CarRegistration reg_obj = new CarRegistration();
            this.Hide();
            reg_obj.ShowDialog();
            this.Close();
        }

        private void calculationButton_Click(object sender, EventArgs e)
        {
            Calculation cal_obj = new Calculation();
            this.Hide();
            cal_obj.ShowDialog();
            this.Close();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            Customer cutom_obj = new Customer();
            this.Hide();
            cutom_obj.ShowDialog();
            this.Close();
        }

        private void rentalButton_Click(object sender, EventArgs e)
        {
            Rental rent_obj = new Rental();
            this.Hide();
            rent_obj.ShowDialog();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.ShowDialog();
            this.Close();
        }

        private void returncarButton_Click(object sender, EventArgs e)
        {
            Return return_obj = new Return();
            this.Hide();
            return_obj.ShowDialog();
            this.Close();
        }
    }
}
