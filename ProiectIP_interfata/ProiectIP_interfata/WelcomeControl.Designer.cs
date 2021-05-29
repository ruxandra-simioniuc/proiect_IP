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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.WelcomeContent = new System.Windows.Forms.Panel();
            this.labelWelcomeText2 = new System.Windows.Forms.Label();
            this.labelWelcomeText1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.WelcomeContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(484, 101);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(297, 55);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Bine ai venit!";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(50, 711);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(187, 90);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReservation.Location = new System.Drawing.Point(981, 711);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(288, 90);
            this.buttonReservation.TabIndex = 3;
            this.buttonReservation.Text = "Rezervă un zbor";
            this.buttonReservation.UseVisualStyleBackColor = false;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ProiectIP_interfata.Properties.Resources.airplane128;
            this.pictureBoxLogo.Location = new System.Drawing.Point(510, 260);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(205, 222);
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // WelcomeContent
            // 
            this.WelcomeContent.Controls.Add(this.labelWelcomeText2);
            this.WelcomeContent.Controls.Add(this.labelWelcomeText1);
            this.WelcomeContent.Controls.Add(this.pictureBoxLogo);
            this.WelcomeContent.Controls.Add(this.buttonReservation);
            this.WelcomeContent.Controls.Add(this.buttonLogout);
            this.WelcomeContent.Controls.Add(this.label_welcome);
            this.WelcomeContent.Location = new System.Drawing.Point(3, 1);
            this.WelcomeContent.Name = "WelcomeContent";
            this.WelcomeContent.Size = new System.Drawing.Size(1352, 896);
            this.WelcomeContent.TabIndex = 5;
            // 
            // labelWelcomeText2
            // 
            this.labelWelcomeText2.AutoSize = true;
            this.labelWelcomeText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeText2.Location = new System.Drawing.Point(395, 580);
            this.labelWelcomeText2.Name = "labelWelcomeText2";
            this.labelWelcomeText2.Size = new System.Drawing.Size(484, 55);
            this.labelWelcomeText2.TabIndex = 6;
            this.labelWelcomeText2.Text = "selecta zborul din Iași";
            // 
            // labelWelcomeText1
            // 
            this.labelWelcomeText1.AutoSize = true;
            this.labelWelcomeText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeText1.Location = new System.Drawing.Point(215, 510);
            this.labelWelcomeText1.Name = "labelWelcomeText1";
            this.labelWelcomeText1.Size = new System.Drawing.Size(855, 55);
            this.labelWelcomeText1.TabIndex = 5;
            this.labelWelcomeText1.Text = "Apasă pe \'Rezervă un zbor\' pentru a-ți ";
            // 
            // WelcomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WelcomeContent);
            this.Name = "WelcomeControl";
            this.Size = new System.Drawing.Size(1356, 898);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.WelcomeContent.ResumeLayout(false);
            this.WelcomeContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel WelcomeContent;
        private System.Windows.Forms.Label labelWelcomeText1;
        private System.Windows.Forms.Label labelWelcomeText2;
    }
}
