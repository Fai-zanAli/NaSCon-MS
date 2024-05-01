using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NasCon_proj.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace NasCon_proj.Controllers
{
    public class AdminController
    {
        private MySqlConnection connection;

        public AdminController()
        {
            connection = DatabaseHelper.GetConnection();
        }

        public List<Event> GetEvents()
        {
            List<Event> events = new List<Event>();
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                string query = @"SELECT EventID, Name, CategoryID, Date, Time, Venue, RegistrationPrice, EventType, Capacity
                                 FROM Events";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Event evt = new Event
                        {
                            EventID = reader.GetInt32("EventID"),
                            Name = reader.GetString("Name"),
                            CategoryID = reader.GetInt32("CategoryID"),
                            Date = reader.GetDateTime("Date"),
                            Time = reader.GetTimeSpan("Time"),
                            Venue = reader.GetString("Venue"),
                            RegistrationPrice = reader.GetDecimal("RegistrationPrice"),
                            EventType = reader.GetBoolean("EventType"),
                            Capacity = reader.GetInt32("Capacity")
                        };
                        events.Add(evt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return events;
        }

    

    }
}
