namespace rent_a_car
{
    partial class LogIn
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
            this.lblKorisnicko = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnLogiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKorisnicko
            // 
            this.lblKorisnicko.AutoSize = true;
            this.lblKorisnicko.Location = new System.Drawing.Point(122, 315);
            this.lblKorisnicko.Name = "lblKorisnicko";
            this.lblKorisnicko.Size = new System.Drawing.Size(81, 13);
            this.lblKorisnicko.TabIndex = 0;
            this.lblKorisnicko.Text = "Korisnicko ime: ";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(153, 355);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(50, 13);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka: ";
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(236, 307);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnicko.TabIndex = 2;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(236, 355);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtLozinka.TabIndex = 3;
            // 
            // btnLogiraj
            // 
            this.btnLogiraj.Location = new System.Drawing.Point(125, 406);
            this.btnLogiraj.Name = "btnLogiraj";
            this.btnLogiraj.Size = new System.Drawing.Size(211, 23);
            this.btnLogiraj.TabIndex = 4;
            this.btnLogiraj.Text = "Logiraj se";
            this.btnLogiraj.UseVisualStyleBackColor = true;
            this.btnLogiraj.Click += new System.EventHandler(this.btnLogiraj_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rent_a_car.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnLogiraj);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnicko);
            this.Name = "LogIn";
            this.Text = "Logiraj se!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnicko;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnLogiraj;
    }
}

