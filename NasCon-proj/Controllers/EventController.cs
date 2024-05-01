using NasCon_proj.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace NasCon_proj.Controllers
{
    public class EventController
    {
        private MySqlConnection connection;

        public EventController()
        {
            connection = DatabaseHelper.GetConnection();
        }

        public List<Event> GetEvents(string categoryName)
        {
            List<Event> events = new List<Event>();
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = @"SELECT 
                                    Events.EventID, 
                                    Events.Name, 
                                    Events.CategoryID, 
                                    Events.Date, 
                                    Events.Time, 
                                    Events.Venue, 
                                    Events.RegistrationPrice, 
                                    Events.EventType, 
                                    Events.Capacity,
                                    EventCategories.CategoryName, 
                                    EventCategories.Description 
                                FROM 
                                    Events 
                                INNER JOIN 
                                    EventCategories ON Events.CategoryID = EventCategories.CategoryID";

                if (!string.IsNullOrEmpty(categoryName) && categoryName != "All")
                {
                    query += " WHERE EventCategories.CategoryName = @CategoryName";
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (!string.IsNullOrEmpty(categoryName) && categoryName != "All")
                {
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                }

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    events.Add(new Event
                    {
                        EventID = Convert.ToInt32(row["EventID"]),
                        Name = row["Name"].ToString(),
                        CategoryID = Convert.ToInt32(row["CategoryID"]),
                        Date = Convert.ToDateTime(row["Date"]),
                        Time = TimeSpan.Parse(row["Time"].ToString()),
                        Venue = row["Venue"].ToString(),
                        RegistrationPrice = Convert.ToDecimal(row["RegistrationPrice"]),
                        EventType = Convert.ToBoolean(row["EventType"]),
                        Capacity = Convert.ToInt32(row["Capacity"]),
                        CategoryName = row["CategoryName"].ToString(),
                        Description = row["Description"].ToString()
                    });
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

        public List<EventCategory> GetEventCategories()
        {
            List<EventCategory> categories = new List<EventCategory>();
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = "SELECT CategoryID, CategoryName, Description FROM EventCategories";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    categories.Add(new EventCategory
                    {
                        CategoryID = Convert.ToInt32(row["CategoryID"]),
                        CategoryName = row["CategoryName"].ToString(),
                        Description = row["Description"].ToString()
                    });
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
            return categories;
        }

        public Event GetEventByName(string eventName)
        {
            Event selectedEvent = null;
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = "SELECT * FROM Events WHERE Name = @EventName";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EventName", eventName);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        selectedEvent = new Event
                        {
                            EventID = Convert.ToInt32(reader["EventID"]),
                            Name = reader["Name"].ToString(),
                            CategoryID = Convert.ToInt32(reader["CategoryID"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            Time = TimeSpan.Parse(reader["Time"].ToString()),
                            Venue = reader["Venue"].ToString(),
                            RegistrationPrice = Convert.ToDecimal(reader["RegistrationPrice"]),
                            EventType = Convert.ToBoolean(reader["EventType"]),
                            Capacity = Convert.ToInt32(reader["Capacity"]),
                        };
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
            return selectedEvent;
        }

        public bool RegisterForEvent(int userID, int eventID, int? teamID, string registrationType)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = @"INSERT INTO Registrations (UserID, EventID, TeamID, RegistrationType, RegistrationDate) 
                                 VALUES (@UserID, @EventID, @TeamID, @RegistrationType, @RegistrationDate)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@EventID", eventID);
                cmd.Parameters.AddWithValue("@TeamID", (object)teamID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RegistrationType", registrationType);
                cmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Event> GetBookedEventsByUserID(int userID)
        {
            List<Event> bookedEvents = new List<Event>();
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                // Query to retrieve booked events for the given userID
                string query = @"SELECT Events.EventID, Events.Name, Events.Date, Events.Time, Events.Venue, Events.RegistrationPrice, EventCategories.CategoryName, EventCategories.Description
                                 FROM Events
                                 INNER JOIN Registrations ON Events.EventID = Registrations.EventID
                                 INNER JOIN EventCategories ON Events.CategoryID = EventCategories.CategoryID
                                 WHERE Registrations.UserID = @UserID";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", userID);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    bookedEvents.Add(new Event
                    {
                        EventID = Convert.ToInt32(row["EventID"]),
                        Name = row["Name"].ToString(),
                        Date = Convert.ToDateTime(row["Date"]),
                        Time = TimeSpan.Parse(row["Time"].ToString()),
                        Venue = row["Venue"].ToString(),
                        RegistrationPrice = Convert.ToDecimal(row["RegistrationPrice"]),
                        CategoryName = row["CategoryName"].ToString(),
                        Description = row["Description"].ToString()
                    });
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
            return bookedEvents;
        }


        public List<FoodDeal> GetFoodDeals()
        {
            List<FoodDeal> foodDeals = new List<FoodDeal>();
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                // Query to retrieve available food deals
                string query = "SELECT * FROM FoodDeals";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    foodDeals.Add(new FoodDeal
                    {
                        DealID = Convert.ToInt32(row["DealID"]),
                        DealName = row["DealName"].ToString(),
                        Price = Convert.ToDecimal(row["Price"]),
                        Description = row["Description"].ToString()
                    });
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
            return foodDeals;
        }
    }


}
