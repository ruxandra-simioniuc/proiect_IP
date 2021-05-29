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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WelcomeContent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(657, 99);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(166, 55);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "NUME";
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
            this.WelcomeContent.Controls.Add(this.buttonReservation);
            this.WelcomeContent.Controls.Add(this.buttonLogout);
            this.WelcomeContent.Controls.Add(this.labelName);
            this.WelcomeContent.Controls.Add(this.label_welcome);
            this.WelcomeContent.Location = new System.Drawing.Point(3, 1);
            this.WelcomeContent.Name = "WelcomeContent";
            this.WelcomeContent.Size = new System.Drawing.Size(1352, 896);
            this.WelcomeContent.TabIndex = 5;
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
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel WelcomeContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
