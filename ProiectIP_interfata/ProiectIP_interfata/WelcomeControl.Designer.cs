namespace ProiectIP_interfata
{
    partial class WelcomeControl
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
            this.label_welcome = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_reservation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WelcomeContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.WelcomeContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(364, 99);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(297, 55);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Bine ai venit,";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(657, 99);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(166, 55);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "NUME";
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.Location = new System.Drawing.Point(50, 711);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(187, 90);
            this.button_logout.TabIndex = 2;
            this.button_logout.Text = "Log out";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // button_reservation
            // 
            this.button_reservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reservation.Location = new System.Drawing.Point(981, 711);
            this.button_reservation.Name = "button_reservation";
            this.button_reservation.Size = new System.Drawing.Size(288, 90);
            this.button_reservation.TabIndex = 3;
            this.button_reservation.Text = "Rezervă un zbor";
            this.button_reservation.UseVisualStyleBackColor = false;
            this.button_reservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProiectIP_interfata.Properties.Resources.airplane128;
            this.pictureBox1.Location = new System.Drawing.Point(510, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 222);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeContent
            // 
            this.WelcomeContent.Controls.Add(this.label2);
            this.WelcomeContent.Controls.Add(this.label1);
            this.WelcomeContent.Controls.Add(this.pictureBox1);
            this.WelcomeContent.Controls.Add(this.button_reservation);
            this.WelcomeContent.Controls.Add(this.button_logout);
            this.WelcomeContent.Controls.Add(this.label_name);
            this.WelcomeContent.Controls.Add(this.label_welcome);
            this.WelcomeContent.Location = new System.Drawing.Point(3, 1);
            this.WelcomeContent.Name = "WelcomeContent";
            this.WelcomeContent.Size = new System.Drawing.Size(1352, 896);
            this.WelcomeContent.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Apasă pe \'Rezervă un zbor\' pentru a-ți ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "selecta zborul din Iași";
            // 
            // WelcomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WelcomeContent);
            this.Name = "WelcomeControl";
            this.Size = new System.Drawing.Size(1356, 898);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.WelcomeContent.ResumeLayout(false);
            this.WelcomeContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_reservation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel WelcomeContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
