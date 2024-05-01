using MySql.Data.MySqlClient;
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
    public partial class ParticipantView : Form
    {
        private EventController eventController;
        private int userID; // Add a field to store the userID

        public ParticipantView(int userID)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            InitializeDatabaseConnection();
            PopulateCategoriesComboBox(); // Call method to populate categories ComboBox
            PopulateEventComboBox(); // Call method to populate events ComboBox
            DisplayEventDetails(); // Display all events initially
            this.userID = userID;
        }

        private void InitializeDatabaseConnection()
        {
            eventController = new EventController();
        }

        private void DisplayEventDetails()
        {
            string selectedCategory = categories1.SelectedItem?.ToString();
            List<Event> events = eventController.GetEvents(selectedCategory);
            dataGridView1.DataSource = events;
        }

        private void PopulateCategoriesComboBox()
        {
            List<EventCategory> categories = eventController.GetEventCategories();
            categories1.Items.Add("All");
            foreach (EventCategory category in categories)
            {
                categories1.Items.Add(category.CategoryName);
            }
            categories1.SelectedIndex = 0;
        }
        private void PopulateEventComboBox()
        {
            List<Event> events = eventController.GetEvents(null); // Get all events
            foreach (Event evnt in events)
            {
                registereventbox1.Items.Add(evnt.Name);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void categories1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEventDetails();
        }

        private void ParticipantView_Load(object sender, EventArgs e)
        {

        }

        private void registerevent1_Click(object sender, EventArgs e)
        {
            string selectedEventName = registereventbox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedEventName))
            {
                MessageBox.Show("Please select an event to register.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EventController eventController = new EventController();
            Event selectedEvent = eventController.GetEventByName(selectedEventName);
            if (selectedEvent == null)
            {
                MessageBox.Show("Failed to retrieve event details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = eventController.RegisterForEvent(userID, selectedEvent.EventID, null, "Individual");

            if (success)
            {
                MessageBox.Show($"Successfully registered for event: {selectedEvent.Name}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to register for event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookedEventsView bookedEvents = new BookedEventsView(userID);
            bookedEvents.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FoodDealsView fooddeals = new FoodDealsView();
            fooddeals.Show();
            this.Hide();
        }

        private void registereventbox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signout1_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Hide();
        }
    }
}
