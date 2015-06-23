namespace rent_a_car
{
    partial class glavnaFormaAdmin
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
            this.components = new System.ComponentModel.Container();
            this.msGlavnaForma = new System.Windows.Forms.MenuStrip();
            this.automobiliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviAutomobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisAutomobilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisKlijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKreirajRacun = new System.Windows.Forms.Button();
            this.btnKreirajPosudba = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bazaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new rent_a_car.bazaDataSet();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.posudbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msGlavnaForma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // msGlavnaForma
            // 
            this.msGlavnaForma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automobiliToolStripMenuItem,
            this.klijentiToolStripMenuItem,
            this.zaposleniciToolStripMenuItem,
            this.posudbeToolStripMenuItem,
            this.računiToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.msGlavnaForma.Location = new System.Drawing.Point(0, 0);
            this.msGlavnaForma.Name = "msGlavnaForma";
            this.msGlavnaForma.Size = new System.Drawing.Size(1048, 24);
            this.msGlavnaForma.TabIndex = 0;
            this.msGlavnaForma.Text = "Glavna Forma";
            // 
            // automobiliToolStripMenuItem
            // 
            this.automobiliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNoviAutomobilToolStripMenuItem,
            this.popisAutomobilaToolStripMenuItem});
            this.automobiliToolStripMenuItem.Name = "automobiliToolStripMenuItem";
            this.automobiliToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.automobiliToolStripMenuItem.Text = "Automobili";
            // 
            // dodajNoviAutomobilToolStripMenuItem
            // 
            this.dodajNoviAutomobilToolStripMenuItem.Name = "dodajNoviAutomobilToolStripMenuItem";
            this.dodajNoviAutomobilToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.dodajNoviAutomobilToolStripMenuItem.Text = "Dodaj novi automobil";
            this.dodajNoviAutomobilToolStripMenuItem.Click += new System.EventHandler(this.dodajNoviAutomobilToolStripMenuItem_Click);
            // 
            // popisAutomobilaToolStripMenuItem
            // 
            this.popisAutomobilaToolStripMenuItem.Name = "popisAutomobilaToolStripMenuItem";
            this.popisAutomobilaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.popisAutomobilaToolStripMenuItem.Text = "Popis automobila";
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovogKlijentaToolStripMenuItem,
            this.popisKlijenataToolStripMenuItem});
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            // 
            // dodajNovogKlijentaToolStripMenuItem
            // 
            this.dodajNovogKlijentaToolStripMenuItem.Name = "dodajNovogKlijentaToolStripMenuItem";
            this.dodajNovogKlijentaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.dodajNovogKlijentaToolStripMenuItem.Text = "Dodaj novog klijenta";
            this.dodajNovogKlijentaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovogKlijentaToolStripMenuItem_Click);
            // 
            // popisKlijenataToolStripMenuItem
            // 
            this.popisKlijenataToolStripMenuItem.Name = "popisKlijenataToolStripMenuItem";
            this.popisKlijenataToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.popisKlijenataToolStripMenuItem.Text = "Popis klijenata";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovogZaposlenikaToolStripMenuItem,
            this.popisZaposlenikaToolStripMenuItem});
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // dodajNovogZaposlenikaToolStripMenuItem
            // 
            this.dodajNovogZaposlenikaToolStripMenuItem.Name = "dodajNovogZaposlenikaToolStripMenuItem";
            this.dodajNovogZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.dodajNovogZaposlenikaToolStripMenuItem.Text = "Dodaj novog zaposlenika";
            this.dodajNovogZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovogZaposlenikaToolStripMenuItem_Click);
            // 
            // popisZaposlenikaToolStripMenuItem
            // 
            this.popisZaposlenikaToolStripMenuItem.Name = "popisZaposlenikaToolStripMenuItem";
            this.popisZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.popisZaposlenikaToolStripMenuItem.Text = "Popis zaposlenika";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // btnKreirajRacun
            // 
            this.btnKreirajRacun.Location = new System.Drawing.Point(57, 201);
            this.btnKreirajRacun.Name = "btnKreirajRacun";
            this.btnKreirajRacun.Size = new System.Drawing.Size(170, 80);
            this.btnKreirajRacun.TabIndex = 1;
            this.btnKreirajRacun.Text = "Kreiraj racun";
            this.btnKreirajRacun.UseVisualStyleBackColor = true;
            this.btnKreirajRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // btnKreirajPosudba
            // 
            this.btnKreirajPosudba.Location = new System.Drawing.Point(57, 81);
            this.btnKreirajPosudba.Name = "btnKreirajPosudba";
            this.btnKreirajPosudba.Size = new System.Drawing.Size(170, 80);
            this.btnKreirajPosudba.TabIndex = 2;
            this.btnKreirajPosudba.Text = "Kreiraj posudbu";
            this.btnKreirajPosudba.UseVisualStyleBackColor = true;
            this.btnKreirajPosudba.Click += new System.EventHandler(this.btnPosudba_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 319);
            this.dataGridView1.TabIndex = 3;
            // 
            // bazaDataSetBindingSource
            // 
            this.bazaDataSetBindingSource.DataSource = this.bazaDataSet;
            this.bazaDataSetBindingSource.Position = 0;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "bazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUredi
            // 
            this.btnUredi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUredi.Location = new System.Drawing.Point(282, 422);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(110, 40);
            this.btnUredi.TabIndex = 4;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIzbrisi.Location = new System.Drawing.Point(430, 422);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(110, 40);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.Text = "Izbrisi";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            // 
            // posudbeToolStripMenuItem
            // 
            this.posudbeToolStripMenuItem.Name = "posudbeToolStripMenuItem";
            this.posudbeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.posudbeToolStripMenuItem.Text = "Posudbe";
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.računiToolStripMenuItem.Text = "Računi";
            // 
            // glavnaFormaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rent_a_car.Properties.Resources.main_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 517);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKreirajPosudba);
            this.Controls.Add(this.btnKreirajRacun);
            this.Controls.Add(this.msGlavnaForma);
            this.MainMenuStrip = this.msGlavnaForma;
            this.Name = "glavnaFormaAdmin";
            this.Text = "Rent-A-Car aplikacija";
            this.msGlavnaForma.ResumeLayout(false);
            this.msGlavnaForma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msGlavnaForma;
        private System.Windows.Forms.ToolStripMenuItem automobiliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.Button btnKreirajRacun;
        private System.Windows.Forms.Button btnKreirajPosudba;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviAutomobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisAutomobilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisKlijenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.BindingSource bazaDataSetBindingSource;
        private bazaDataSet bazaDataSet;
        private System.Windows.Forms.ToolStripMenuItem posudbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
    }
}