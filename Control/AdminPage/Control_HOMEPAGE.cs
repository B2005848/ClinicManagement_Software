using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_gr.Layout.AdminPage
{
    public partial class Control_HOMEPAGE : UserControl
    {
        public Control_HOMEPAGE()
        {
            InitializeComponent();
            getQuantityPatients();

        }


        //function get quantity of Patients
        private void getQuantityPatients()
        {
            if (DatabaseManager.OpenConnection())
            {
                String quantity = DatabaseManager.GetQuantity_patient();
                patient_quantity_value.Text = quantity;

            }
            else
            {
                MessageBox.Show("Error occurred while getting quantity of patients.");
            }
        }


        //go to interface list patients
        private void item_patien_home_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
