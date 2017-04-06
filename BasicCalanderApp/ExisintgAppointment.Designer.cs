namespace BasicCalanderApp
{
    partial class ExisintgAppointment
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
            this.label7 = new System.Windows.Forms.Label();
            this.MeetingLocation = new System.Windows.Forms.TextBox();
            this.MeetingTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EndTime = new System.Windows.Forms.ComboBox();
            this.StartTime = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date";
            // 
            // MeetingLocation
            // 
            this.MeetingLocation.Location = new System.Drawing.Point(98, 87);
            this.MeetingLocation.Name = "MeetingLocation";
            this.MeetingLocation.Size = new System.Drawing.Size(174, 20);
            this.MeetingLocation.TabIndex = 20;
            this.MeetingLocation.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // MeetingTitle
            // 
            this.MeetingTitle.Location = new System.Drawing.Point(98, 61);
            this.MeetingTitle.Name = "MeetingTitle";
            this.MeetingTitle.Size = new System.Drawing.Size(174, 20);
            this.MeetingTitle.TabIndex = 19;
            this.MeetingTitle.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "End Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Title";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Location = new System.Drawing.Point(34, 226);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 23;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(162, 226);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EndTime
            // 
            this.EndTime.FormattingEnabled = true;
            this.EndTime.Location = new System.Drawing.Point(151, 154);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(121, 21);
            this.EndTime.TabIndex = 27;
            this.EndTime.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // StartTime
            // 
            this.StartTime.FormattingEnabled = true;
            this.StartTime.Location = new System.Drawing.Point(151, 127);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(121, 21);
            this.StartTime.TabIndex = 26;
            this.StartTime.SelectedIndexChanged += new System.EventHandler(this.StartTime_SelectedIndexChanged);
            this.StartTime.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(98, 28);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(100, 20);
            this.Date.TabIndex = 30;
            this.Date.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // ExisintgAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MeetingLocation);
            this.Controls.Add(this.MeetingTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ExisintgAppointment";
            this.Text = "ExisintgAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MeetingLocation;
        private System.Windows.Forms.TextBox MeetingTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox EndTime;
        private System.Windows.Forms.ComboBox StartTime;
        private System.Windows.Forms.TextBox Date;
    }
}