using System;
using System.Data;
using System.Windows.Forms;

namespace project_gr.Layout.AdminPage
{
    public partial class Control_PRESCRIPTION : UserControl
    {
        public Control_PRESCRIPTION()
        {
            InitializeComponent();

            LoadMedicinesData();
        }

        private void LoadMedicinesData()
        {
            try
            {
                DataTable medicinesTable = DatabaseManager.GetAllMedicines();

                if (medicinesTable != null)
                {
                    dataGrid.DataSource = medicinesTable;

                    dataGrid.Columns["No"].HeaderText = "No.";
                    dataGrid.Columns["medicine_id"].HeaderText = "Mã thuốc";
                    dataGrid.Columns["name"].HeaderText = "Tên thuốc";
                    dataGrid.Columns["description"].HeaderText = "Mô tả";
                    dataGrid.Columns["quantity"].HeaderText = "Số lượng";
                    dataGrid.Columns["drug_type_id"].HeaderText = "Loại thuốc";
                    dataGrid.Columns["price_per_unit"].HeaderText = "Đơn giá";
                    dataGrid.Columns["package_quantity"].HeaderText = "Số lượng/gói";
                }
                else
                {
                    MessageBox.Show("Failed to load medicines data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicines data: " + ex.Message);
            }
        }
    }
}
