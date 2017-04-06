namespace BasicCalanderApp
{
    partial class Appointment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.MeetingTitle = new System.Windows.Forms.TextBox();
            this.MeetingLocation = new System.Windows.Forms.TextBox();
            this.StartTime = new System.Windows.Forms.ComboBox();
            this.EndTime = new System.Windows.Forms.ComboBox();
            this.Occurance = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Occurance";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(98, 226);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MeetingTitle
            // 
            this.MeetingTitle.Location = new System.Drawing.Point(98, 46);
            this.MeetingTitle.Name = "MeetingTitle";
            this.MeetingTitle.Size = new System.Drawing.Size(174, 20);
            this.MeetingTitle.TabIndex = 7;
            // 
            // MeetingLocation
            // 
            this.MeetingLocation.Location = new System.Drawing.Point(98, 72);
            this.MeetingLocation.Name = "MeetingLocation";
            this.MeetingLocation.Size = new System.Drawing.Size(174, 20);
            this.MeetingLocation.TabIndex = 8;
            // 
            // StartTime
            // 
            this.StartTime.FormattingEnabled = true;
            this.StartTime.Location = new System.Drawing.Point(151, 116);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(121, 21);
            this.StartTime.TabIndex = 10;
            this.StartTime.SelectedIndexChanged += new System.EventHandler(this.StartTime_SelectedIndexChanged);
            // 
            // EndTime
            // 
            this.EndTime.Enabled = false;
            this.EndTime.FormattingEnabled = true;
            this.EndTime.Location = new System.Drawing.Point(151, 143);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(121, 21);
            this.EndTime.TabIndex = 11;
            // 
            // Occurance
            // 
            this.Occurance.FormattingEnabled = true;
            this.Occurance.Items.AddRange(new object[] {
            "One-Off",
            "Daily",
            "Weekly",
            "Bi-Weekly",
            "Monthly"});
            this.Occurance.Location = new System.Drawing.Point(151, 171);
            this.Occurance.Name = "Occurance";
            this.Occurance.Size = new System.Drawing.Size(121, 21);
            this.Occurance.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Occurance);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.MeetingLocation);
            this.Controls.Add(this.MeetingTitle);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox MeetingTitle;
        private System.Windows.Forms.TextBox MeetingLocation;
        private System.Windows.Forms.ComboBox StartTime;
        private System.Windows.Forms.ComboBox EndTime;
        private System.Windows.Forms.ComboBox Occurance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}