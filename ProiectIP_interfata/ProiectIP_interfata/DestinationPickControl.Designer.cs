namespace ProiectIP_interfata
{
    partial class DestinationPickControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_destination = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_findFlight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar_flightTime = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_destination
            // 
            this.comboBox_destination.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_destination.FormattingEnabled = true;
            this.comboBox_destination.Location = new System.Drawing.Point(143, 365);
            this.comboBox_destination.Name = "comboBox_destination";
            this.comboBox_destination.Size = new System.Drawing.Size(356, 54);
            this.comboBox_destination.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destinatie";
            // 
            // button_findFlight
            // 
            this.button_findFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_findFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_findFlight.Location = new System.Drawing.Point(523, 674);
            this.button_findFlight.Name = "button_findFlight";
            this.button_findFlight.Size = new System.Drawing.Size(340, 77);
            this.button_findFlight.TabIndex = 8;
            this.button_findFlight.Text = "Cauta zbor";
            this.button_findFlight.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1002, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar_flightTime
            // 
            this.monthCalendar_flightTime.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar_flightTime.Location = new System.Drawing.Point(823, 244);
            this.monthCalendar_flightTime.Name = "monthCalendar_flightTime";
            this.monthCalendar_flightTime.TabIndex = 12;
            this.monthCalendar_flightTime.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_flightTime_DateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(937, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 46);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data";
            // 
            // DestinationPickControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar_flightTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_findFlight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_destination);
            this.Name = "DestinationPickControl";
            this.Size = new System.Drawing.Size(1363, 890);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_destination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_findFlight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar_flightTime;
        private System.Windows.Forms.Label label6;
    }
}
