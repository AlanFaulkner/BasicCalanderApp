using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BasicCalanderApp
{
    public partial class ExisintgAppointment : Form
    {
        private string AppointmentID;

        public ExisintgAppointment(string Date, string Start, string End, string Title, string Location)
        {
            InitializeComponent();
            this.Date.Text = Date;
            this.MeetingTitle.Text = Title;
            this.MeetingLocation.Text = Location;

            var StartTimes = Time(TimeSpan.Parse("00:00:00"), 30);
            foreach (var time in StartTimes)
            {
                StartTime.Items.Add(time);
            }
            StartTime.Text = Start;

            var EndTimes = Time(TimeSpan.Parse(End), 30);
            foreach (var time in EndTimes)
            {
                EndTime.Items.Add(time);
            }
            EndTime.Text = End;
            UpdateButton.Enabled = false;
            GetAppointmentID();
        }

        private void GetAppointmentID()
        {
            using (SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SchedualConnectionString))
            {
                // Open connection to database
                try
                {
                    myConnection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                using (SqlCommand CMD = new SqlCommand("Select ID from AppointmentSchedual WHERE Date = @Date and StartTime = @Time", myConnection))
                {
                    CMD.Parameters.Add(new SqlParameter("Date", Date.Text));
                    CMD.Parameters.Add(new SqlParameter("Time", StartTime.Text));

                    using (SqlDataReader Result = CMD.ExecuteReader())
                    {
                        while (Result.Read())
                        {
                            AppointmentID = Result[0].ToString();
                        }
                    }
                }
            }
        }

        private List<TimeSpan> Time(TimeSpan Start, int Incriment)
        {
            var times = new List<TimeSpan>();
            double interval = Incriment;

            DateTime Starting = new DateTime(2017, 1, 1, 0, 0, 0);
            DateTime Ending = new DateTime(2017, 1, 1, 23, 30, 0);
            Starting += Start + new TimeSpan(0, 30, 0);

            for (var ts = Starting; ts <= Ending; ts = ts.AddMinutes(interval))
            {
                times.Add(ts.TimeOfDay);
            }

            return times;
        }

        private void StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            var times = Time(TimeSpan.Parse(StartTime.Text), 30);

            EndTime.Items.Clear();
            foreach (var time in times)
            {
                EndTime.Items.Add(time);
            }
            EndTime.Enabled = true;
            EndTime.SelectedIndex = 0;
        }

        private void DataChanged(object sender, EventArgs e)
        {
            UpdateButton.Enabled = true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SchedualConnectionString))
            {
                // Open connection to database
                try
                {
                    myConnection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                using (SqlCommand CMD = new SqlCommand("UPDATE AppointmentSchedual SET Date = @Date, StartTime = @Start, EndTime = @End, Title = @Title, Location = @Location WHERE ID = @ID", myConnection))
                {
                    CMD.Parameters.Add(new SqlParameter("Date", Convert.ToDateTime(Date.Text).ToShortDateString()));
                    CMD.Parameters.Add(new SqlParameter("Start", TimeSpan.Parse(StartTime.Text)));
                    CMD.Parameters.Add(new SqlParameter("End", TimeSpan.Parse(EndTime.Text)));
                    CMD.Parameters.Add(new SqlParameter("Title", MeetingTitle.Text));
                    CMD.Parameters.Add(new SqlParameter("Location", MeetingLocation.Text));
                    CMD.Parameters.Add(new SqlParameter("ID", AppointmentID));

                    try
                    {
                        CMD.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection myConnection = new SqlConnection(Properties.Settings.Default.SchedualConnectionString))
            {
                // Open connection to database
                try
                {
                    myConnection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                using (SqlCommand CMD = new SqlCommand("Delete FROM AppointmentSchedual WHERE ID = @ID", myConnection))
                {
                    CMD.Parameters.Add(new SqlParameter("ID", AppointmentID));

                    try
                    {
                        CMD.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            this.Close();
        }
    }
}