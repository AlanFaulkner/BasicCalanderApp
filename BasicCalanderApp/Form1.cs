using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BasicCalanderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Appointment newAppointment = new Appointment(monthCalendar.SelectionRange.Start.ToShortDateString());
            newAppointment.FormClosing += new FormClosingEventHandler(this.newAppointmentClosing);
            newAppointment.Show();
        }

        private void newAppointmentClosing(object sender, FormClosingEventArgs e)
        {
            UpdateAppointmentSchedual();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateAppointmentSchedual();
        }

        private void UpdateAppointmentSchedual()
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

                using (SqlCommand CMD = new SqlCommand("SELECT * FROM AppointmentSchedual WHERE Date = @Date ORDER BY StartTime", myConnection))
                {
                    CMD.Parameters.Add(new SqlParameter("Date", monthCalendar.SelectionRange.Start.ToShortDateString()));
                    DataTable dt = new DataTable();
                    SqlDataAdapter Results = new SqlDataAdapter(CMD);
                    Results.Fill(dt);
                    AppointmentGridView.DataSource = dt;
                }
            }
        }

        private void AppointmentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Date = monthCalendar.SelectionRange.Start.ToShortDateString();
            string StartTime = AppointmentGridView.Rows[AppointmentGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            string EndTime = AppointmentGridView.Rows[AppointmentGridView.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
            string Title = AppointmentGridView.Rows[AppointmentGridView.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
            string Location = AppointmentGridView.Rows[AppointmentGridView.SelectedCells[0].RowIndex].Cells[3].Value.ToString();

            ExisintgAppointment Appointment = new ExisintgAppointment(Date, StartTime, EndTime, Title, Location);
            Appointment.FormClosing += new FormClosingEventHandler(this.newAppointmentClosing);
            Appointment.Show();
        }
                
    }
}