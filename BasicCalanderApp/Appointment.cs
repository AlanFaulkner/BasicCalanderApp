using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BasicCalanderApp
{
    public partial class Appointment : Form
    {
        public Appointment(string SelectedDate)
        {
            InitializeComponent();
            label1.Text = SelectedDate;

            var times = Time(TimeSpan.Parse("00:00:00"), 30);

            foreach (var time in times)
            {
                StartTime.Items.Add(time);
            }

            Occurance.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (Occurance.Text)
            {
                case ("One-Off"):
                    InsertAppointment(label1.Text);
                    break;

                case ("Daily"):
                    for (int Day = 0; Day < 364; Day++)
                    {
                        InsertAppointment(DateTime.Parse(label1.Text).AddDays(Day).ToShortDateString());
                    }
                    break;

                case ("Weekly"):
                    for (int Week = 0; Week < 52; Week++)
                    {
                        InsertAppointment(DateTime.Parse(label1.Text).AddDays(7 * Week).ToShortDateString());
                    }
                    break;

                case ("Bi-Weekly"):
                    for (int Week = 0; Week < 26; Week++)
                    {
                        InsertAppointment(DateTime.Parse(label1.Text).AddDays(14 * Week).ToShortDateString());
                    }
                    break;

                case ("Monthly"):
                    for (int Month = 0; Month < 12; Month++)
                    {
                        InsertAppointment(DateTime.Parse(label1.Text).AddMonths(Month).ToShortDateString());
                    }
                    break;
            }

            this.Close();
        }

        private void InsertAppointment(string Date)
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

                using (SqlCommand CMD = new SqlCommand("INSERT INTO AppointmentSchedual(Date, StartTime, EndTime, Title, Location) VALUES (@Date, @StartTime, @EndTime, @Title, @Location)", myConnection))
                {
                    // Add parameters
                    CMD.Parameters.Add(new SqlParameter("Date", Date));
                    CMD.Parameters.Add(new SqlParameter("StartTime", TimeSpan.Parse(StartTime.Text)));
                    CMD.Parameters.Add(new SqlParameter("EndTime", TimeSpan.Parse(EndTime.Text)));
                    CMD.Parameters.Add(new SqlParameter("Title", MeetingTitle.Text));
                    CMD.Parameters.Add(new SqlParameter("Location", MeetingLocation.Text));

                    // Executute command
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
    }
}