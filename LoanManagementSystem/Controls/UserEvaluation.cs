using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagementSystem.Controls
{
    public partial class UserEvaluation : UserControl
    {
        public UserEvaluation()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Add columns to the DataGridView: Name and Action
            dataGridView1.Columns.Clear(); // Clear existing columns, if any

            // Add the Name column
            dataGridView1.Columns.Add("Name", "Name");

            // Add the Action column with a button
            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn();
            actionColumn.Name = "Action";
            actionColumn.Text = "View";
            actionColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(actionColumn);

            // Optionally, you can set the properties for DataGridView here, e.g., AllowUserToAddRows
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadData()
        {
            // Example data to populate the DataGridView
            var users = new List<string>
            {
                "John Doe",
                "Jane Smith",
                "Michael Johnson"
            };

            foreach (var user in users)
            {
                // Add a new row for each user
                dataGridView1.Rows.Add(user);
            }
        }

        // Handle the button click event for the "View" button
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked column is the "Action" button column
            if (e.ColumnIndex == dataGridView1.Columns["Action"].Index && e.RowIndex >= 0)
            {
                // Get the name of the selected user from the first column (Name)
                string selectedUserName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();

                // Perform the action, for example, show a message box
                MessageBox.Show($"View details for {selectedUserName}");

                // You can add additional logic to handle "View" actions here
                // For instance, you might open a new form or navigate to a detail view.
            }
        }

        private void UserEvaluation_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data into the DataGridView
            dataGridView1.CellContentClick += dataGridView1_CellContentClick; // Register event for button clicks
        }
    }
}
