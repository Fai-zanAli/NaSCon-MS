using NasCon_proj.Controllers;
using NasCon_proj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasCon_proj.Views
{
    public partial class AdministratorView : Form
    {
        private AdminController adminController;

        public AdministratorView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.adminController = new AdminController(); // Initialize the AdminController


            dataGridView1.Columns.Add("EventID", "Event ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("CategoryID", "Category ID");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Time", "Time");
            dataGridView1.Columns.Add("Venue", "Venue");
            dataGridView1.Columns.Add("RegistrationPrice", "Registration Price");
            dataGridView1.Columns.Add("EventType", "Event Type");
            dataGridView1.Columns.Add("Capacity", "Capacity");
        }


        private void LoadEvents()
        {
            // Clear existing rows
            dataGridView1.Rows.Clear();

            var events = adminController.GetEvents();

            foreach (var evt in events)
            {
                dataGridView1.Rows.Add(
                    evt.EventID,
                    evt.Name,
                    evt.CategoryID,
                    evt.Date,
                    evt.Time,
                    evt.Venue,
                    evt.RegistrationPrice,
                    evt.EventType,
                    evt.Capacity
                );
            }
        }




        private void Administrator_Load(object sender, EventArgs e)
        {
            LoadEvents();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void signout_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Hide();
        }
    }
}
