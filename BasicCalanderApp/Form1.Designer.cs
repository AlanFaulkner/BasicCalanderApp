namespace BasicCalanderApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.AppointmentGridView = new System.Windows.Forms.DataGridView();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentSchedualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSchedualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calander Application Ver 1.0";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 73);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // AppointmentGridView
            // 
            this.AppointmentGridView.AllowUserToAddRows = false;
            this.AppointmentGridView.AllowUserToDeleteRows = false;
            this.AppointmentGridView.AutoGenerateColumns = false;
            this.AppointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartTime,
            this.EndTime,
            this.titleDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.AppointmentGridView.DataSource = this.appointmentSchedualBindingSource;
            this.AppointmentGridView.Location = new System.Drawing.Point(258, 73);
            this.AppointmentGridView.Name = "AppointmentGridView";
            this.AppointmentGridView.ReadOnly = true;
            this.AppointmentGridView.Size = new System.Drawing.Size(299, 162);
            this.AppointmentGridView.TabIndex = 2;
            this.AppointmentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentGridView_CellContentClick);
            // 
            // StartTime
            // 
            this.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 80;
            // 
            // EndTime
            // 
            this.EndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 77;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 52;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 73;
            // 
            // appointmentSchedualBindingSource
            // 
            this.appointmentSchedualBindingSource.DataMember = "AppointmentSchedual";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(258, 250);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "New";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 294);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AppointmentGridView);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSchedualBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView AppointmentGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.BindingSource appointmentSchedualBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
    }
}

