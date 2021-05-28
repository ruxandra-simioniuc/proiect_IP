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
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.buttonFindFlight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendarFlightTime = new System.Windows.Forms.MonthCalendar();
            this.labelData = new System.Windows.Forms.Label();
            this.ContentDestinationPick = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.ContentDestinationPick.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(531, 246);
            this.comboBoxDestination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(239, 39);
            this.comboBoxDestination.TabIndex = 1;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.Location = new System.Drawing.Point(581, 206);
            this.labelDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(136, 31);
            this.labelDestination.TabIndex = 5;
            this.labelDestination.Text = "Destinație";
            // 
            // buttonFindFlight
            // 
            this.buttonFindFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFindFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindFlight.Location = new System.Drawing.Point(347, 430);
            this.buttonFindFlight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFindFlight.Name = "buttonFindFlight";
            this.buttonFindFlight.Size = new System.Drawing.Size(227, 50);
            this.buttonFindFlight.TabIndex = 8;
            this.buttonFindFlight.Text = "Caută zbor";
            this.buttonFindFlight.UseVisualStyleBackColor = false;
            this.buttonFindFlight.Click += new System.EventHandler(this.buttonFindFlight_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(5, 5);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // monthCalendarFlightTime
            // 
            this.monthCalendarFlightTime.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendarFlightTime.Location = new System.Drawing.Point(91, 172);
            this.monthCalendarFlightTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.monthCalendarFlightTime.Name = "monthCalendarFlightTime";
            this.monthCalendarFlightTime.TabIndex = 12;
            this.monthCalendarFlightTime.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarFlightTime_DateChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(167, 136);
            this.labelData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(72, 31);
            this.labelData.TabIndex = 13;
            this.labelData.Text = "Data";
            // 
            // ContentDestinationPick
            // 
            this.ContentDestinationPick.Controls.Add(this.labelInfo);
            this.ContentDestinationPick.Controls.Add(this.labelData);
            this.ContentDestinationPick.Controls.Add(this.monthCalendarFlightTime);
            this.ContentDestinationPick.Controls.Add(this.button1);
            this.ContentDestinationPick.Controls.Add(this.buttonFindFlight);
            this.ContentDestinationPick.Controls.Add(this.labelDestination);
            this.ContentDestinationPick.Controls.Add(this.comboBoxDestination);
            this.ContentDestinationPick.Location = new System.Drawing.Point(0, 0);
            this.ContentDestinationPick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContentDestinationPick.Name = "ContentDestinationPick";
            this.ContentDestinationPick.Size = new System.Drawing.Size(909, 578);
            this.ContentDestinationPick.TabIndex = 14;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(218, 52);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(463, 31);
            this.labelInfo.TabIndex = 14;
            this.labelInfo.Text = "Alegeți data călătoriei, apoi destinația";
            // 
            // DestinationPickControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentDestinationPick);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DestinationPickControl";
            this.Size = new System.Drawing.Size(909, 578);
            this.ContentDestinationPick.ResumeLayout(false);
            this.ContentDestinationPick.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Button buttonFindFlight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendarFlightTime;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel ContentDestinationPick;
        private System.Windows.Forms.Label labelInfo;
    }
}
