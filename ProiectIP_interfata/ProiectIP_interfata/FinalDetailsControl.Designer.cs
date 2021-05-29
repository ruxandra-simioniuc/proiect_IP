namespace ProiectIP_interfata
{
    partial class FinalDetailsControl
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
            this.label_greeting = new System.Windows.Forms.Label();
            this.labelNumberSeats = new System.Windows.Forms.Label();
            this.labelFlightDate = new System.Windows.Forms.Label();
            this.labelFinalPrice = new System.Windows.Forms.Label();
            this.labelFinalSelectedSeats = new System.Windows.Forms.Label();
            this.labelFinalSelectedDate = new System.Windows.Forms.Label();
            this.labelFinalSelectedPrice = new System.Windows.Forms.Label();
            this.button_finalReservation = new System.Windows.Forms.Button();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelFinalDestination = new System.Windows.Forms.Label();
            this.ContentFinalDetails = new System.Windows.Forms.Panel();
            this.ContentFinalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_greeting
            // 
            this.label_greeting.AutoSize = true;
            this.label_greeting.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_greeting.Location = new System.Drawing.Point(39, 68);
            this.label_greeting.Name = "label_greeting";
            this.label_greeting.Size = new System.Drawing.Size(1244, 44);
            this.label_greeting.TabIndex = 0;
            this.label_greeting.Text = "Mulțumim că ne-ați ales pentru selectarea zoborului dumneavostră!";
            // 
            // labelNumberSeats
            // 
            this.labelNumberSeats.AutoSize = true;
            this.labelNumberSeats.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberSeats.Location = new System.Drawing.Point(248, 292);
            this.labelNumberSeats.Name = "labelNumberSeats";
            this.labelNumberSeats.Size = new System.Drawing.Size(441, 44);
            this.labelNumberSeats.TabIndex = 1;
            this.labelNumberSeats.Text = "Număr locuri selectate:";
            // 
            // labelFlightDate
            // 
            this.labelFlightDate.AutoSize = true;
            this.labelFlightDate.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlightDate.Location = new System.Drawing.Point(412, 380);
            this.labelFlightDate.Name = "labelFlightDate";
            this.labelFlightDate.Size = new System.Drawing.Size(277, 44);
            this.labelFlightDate.TabIndex = 2;
            this.labelFlightDate.Text = "Data zborului:";
            // 
            // labelFinalPrice
            // 
            this.labelFinalPrice.AutoSize = true;
            this.labelFinalPrice.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalPrice.Location = new System.Drawing.Point(492, 463);
            this.labelFinalPrice.Name = "labelFinalPrice";
            this.labelFinalPrice.Size = new System.Drawing.Size(197, 44);
            this.labelFinalPrice.TabIndex = 3;
            this.labelFinalPrice.Text = "Preț final:";
            // 
            // labelFinalSelectedSeats
            // 
            this.labelFinalSelectedSeats.AutoSize = true;
            this.labelFinalSelectedSeats.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalSelectedSeats.Location = new System.Drawing.Point(694, 292);
            this.labelFinalSelectedSeats.Name = "labelFinalSelectedSeats";
            this.labelFinalSelectedSeats.Size = new System.Drawing.Size(113, 44);
            this.labelFinalSelectedSeats.TabIndex = 4;
            this.labelFinalSelectedSeats.Text = "toate";
            // 
            // labelFinalSelectedDate
            // 
            this.labelFinalSelectedDate.AutoSize = true;
            this.labelFinalSelectedDate.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalSelectedDate.Location = new System.Drawing.Point(694, 380);
            this.labelFinalSelectedDate.Name = "labelFinalSelectedDate";
            this.labelFinalSelectedDate.Size = new System.Drawing.Size(100, 44);
            this.labelFinalSelectedDate.TabIndex = 5;
            this.labelFinalSelectedDate.Text = "data";
            // 
            // labelFinalSelectedPrice
            // 
            this.labelFinalSelectedPrice.AutoSize = true;
            this.labelFinalSelectedPrice.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalSelectedPrice.Location = new System.Drawing.Point(694, 463);
            this.labelFinalSelectedPrice.Name = "labelFinalSelectedPrice";
            this.labelFinalSelectedPrice.Size = new System.Drawing.Size(101, 44);
            this.labelFinalSelectedPrice.TabIndex = 6;
            this.labelFinalSelectedPrice.Text = "mult";
            // 
            // button_finalReservation
            // 
            this.button_finalReservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_finalReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_finalReservation.Location = new System.Drawing.Point(506, 655);
            this.button_finalReservation.Name = "button_finalReservation";
            this.button_finalReservation.Size = new System.Drawing.Size(268, 94);
            this.button_finalReservation.TabIndex = 7;
            this.button_finalReservation.Text = "Finalizează rezervarea";
            this.button_finalReservation.UseVisualStyleBackColor = false;
            this.button_finalReservation.Click += new System.EventHandler(this.buttonFinalReservation_Click);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.Location = new System.Drawing.Point(472, 537);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(217, 44);
            this.labelDestination.TabIndex = 8;
            this.labelDestination.Text = "Destinația:";
            // 
            // labelFinalDestination
            // 
            this.labelFinalDestination.AutoSize = true;
            this.labelFinalDestination.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalDestination.Location = new System.Drawing.Point(694, 537);
            this.labelFinalDestination.Name = "labelFinalDestination";
            this.labelFinalDestination.Size = new System.Drawing.Size(155, 44);
            this.labelFinalDestination.TabIndex = 9;
            this.labelFinalDestination.Text = "oriunde";
            // 
            // ContentFinalDetails
            // 
            this.ContentFinalDetails.Controls.Add(this.labelFinalDestination);
            this.ContentFinalDetails.Controls.Add(this.labelDestination);
            this.ContentFinalDetails.Controls.Add(this.button_finalReservation);
            this.ContentFinalDetails.Controls.Add(this.labelFinalSelectedPrice);
            this.ContentFinalDetails.Controls.Add(this.labelFinalSelectedDate);
            this.ContentFinalDetails.Controls.Add(this.labelFinalSelectedSeats);
            this.ContentFinalDetails.Controls.Add(this.labelFinalPrice);
            this.ContentFinalDetails.Controls.Add(this.labelFlightDate);
            this.ContentFinalDetails.Controls.Add(this.labelNumberSeats);
            this.ContentFinalDetails.Controls.Add(this.label_greeting);
            this.ContentFinalDetails.Location = new System.Drawing.Point(0, 0);
            this.ContentFinalDetails.Name = "ContentFinalDetails";
            this.ContentFinalDetails.Size = new System.Drawing.Size(1359, 895);
            this.ContentFinalDetails.TabIndex = 10;
            // 
            // FinalDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentFinalDetails);
            this.Name = "FinalDetailsControl";
            this.Size = new System.Drawing.Size(1360, 895);
            this.ContentFinalDetails.ResumeLayout(false);
            this.ContentFinalDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_greeting;
        private System.Windows.Forms.Label labelNumberSeats;
        private System.Windows.Forms.Label labelFlightDate;
        private System.Windows.Forms.Label labelFinalPrice;
        private System.Windows.Forms.Label labelFinalSelectedSeats;
        private System.Windows.Forms.Label labelFinalSelectedDate;
        private System.Windows.Forms.Label labelFinalSelectedPrice;
        private System.Windows.Forms.Button button_finalReservation;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelFinalDestination;
        private System.Windows.Forms.Panel ContentFinalDetails;
    }
}
