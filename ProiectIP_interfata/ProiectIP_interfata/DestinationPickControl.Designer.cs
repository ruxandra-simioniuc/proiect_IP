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
            this.comboBox_origin = new System.Windows.Forms.ComboBox();
            this.comboBox_destination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_findFlight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar_flightTime = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_origin
            // 
            this.comboBox_origin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox_origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_origin.FormattingEnabled = true;
            this.comboBox_origin.Location = new System.Drawing.Point(193, 99);
            this.comboBox_origin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_origin.Name = "comboBox_origin";
            this.comboBox_origin.Size = new System.Drawing.Size(317, 46);
            this.comboBox_origin.TabIndex = 0;
            // 
            // comboBox_destination
            // 
            this.comboBox_destination.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_destination.FormattingEnabled = true;
            this.comboBox_destination.Location = new System.Drawing.Point(686, 99);
            this.comboBox_destination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_destination.Name = "comboBox_destination";
            this.comboBox_destination.Size = new System.Drawing.Size(317, 46);
            this.comboBox_destination.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plecare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(679, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destinatie";
            // 
            // button_findFlight
            // 
            this.button_findFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_findFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_findFlight.Location = new System.Drawing.Point(465, 539);
            this.button_findFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_findFlight.Name = "button_findFlight";
            this.button_findFlight.Size = new System.Drawing.Size(302, 62);
            this.button_findFlight.TabIndex = 8;
            this.button_findFlight.Text = "Cauta zbor";
            this.button_findFlight.UseVisualStyleBackColor = false;
            this.button_findFlight.Click += new System.EventHandler(this.button_findFlight_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(891, 453);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(7, 6);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar_flightTime
            // 
            this.monthCalendar_flightTime.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar_flightTime.Location = new System.Drawing.Point(465, 257);
            this.monthCalendar_flightTime.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar_flightTime.Name = "monthCalendar_flightTime";
            this.monthCalendar_flightTime.TabIndex = 12;
            this.monthCalendar_flightTime.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_flightTime_DateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(566, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data";
            // 
            // DestinationPickControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar_flightTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_findFlight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_destination);
            this.Controls.Add(this.comboBox_origin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DestinationPickControl";
            this.Size = new System.Drawing.Size(1212, 712);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_origin;
        private System.Windows.Forms.ComboBox comboBox_destination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_findFlight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar_flightTime;
        private System.Windows.Forms.Label label6;
    }
}
