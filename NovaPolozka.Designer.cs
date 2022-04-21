namespace I4_Janečka_Dinh_Skupinovka
{
    partial class NovaPolozka
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
            this.numVyska = new System.Windows.Forms.NumericUpDown();
            this.numVaha = new System.Windows.Forms.NumericUpDown();
            this.lbNoha = new System.Windows.Forms.Label();
            this.rbLevak = new System.Windows.Forms.RadioButton();
            this.cmbPozice = new System.Windows.Forms.ComboBox();
            this.rbPravak = new System.Windows.Forms.RadioButton();
            this.numCisloDresu = new System.Windows.Forms.NumericUpDown();
            this.cbZlataKopacka = new System.Windows.Forms.CheckBox();
            this.cbZlatyMic = new System.Windows.Forms.CheckBox();
            this.tbPrijmeni = new System.Windows.Forms.TextBox();
            this.tbJmeno = new System.Windows.Forms.TextBox();
            this.lbPrijmeni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCisloDresu = new System.Windows.Forms.Label();
            this.lbPozice = new System.Windows.Forms.Label();
            this.lbKlub = new System.Windows.Forms.Label();
            this.lbLigaKlubu = new System.Windows.Forms.Label();
            this.lbZemeKlubu = new System.Windows.Forms.Label();
            this.lbVaha = new System.Windows.Forms.Label();
            this.lbVyska = new System.Windows.Forms.Label();
            this.lbZemeNarozeni = new System.Windows.Forms.Label();
            this.lbDatumNarozeni = new System.Windows.Forms.Label();
            this.btPridat = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.dtpDatumNarozeni = new System.Windows.Forms.DateTimePicker();
            this.cmbZemeNarozeni = new System.Windows.Forms.ComboBox();
            this.cmbZemeKlubu = new System.Windows.Forms.ComboBox();
            this.cmbKlub = new System.Windows.Forms.ComboBox();
            this.cmbLigaKlubu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numVyska)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVaha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCisloDresu)).BeginInit();
            this.SuspendLayout();
            // 
            // numVyska
            // 
            this.numVyska.Location = new System.Drawing.Point(154, 102);
            this.numVyska.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.numVyska.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numVyska.Name = "numVyska";
            this.numVyska.Size = new System.Drawing.Size(197, 24);
            this.numVyska.TabIndex = 88;
            this.numVyska.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numVyska.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // numVaha
            // 
            this.numVaha.Location = new System.Drawing.Point(154, 132);
            this.numVaha.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numVaha.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numVaha.Name = "numVaha";
            this.numVaha.Size = new System.Drawing.Size(197, 24);
            this.numVaha.TabIndex = 87;
            this.numVaha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numVaha.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbNoha
            // 
            this.lbNoha.AutoSize = true;
            this.lbNoha.Location = new System.Drawing.Point(29, 163);
            this.lbNoha.Name = "lbNoha";
            this.lbNoha.Size = new System.Drawing.Size(44, 18);
            this.lbNoha.TabIndex = 86;
            this.lbNoha.Text = "Noha";
            // 
            // rbLevak
            // 
            this.rbLevak.AutoSize = true;
            this.rbLevak.Location = new System.Drawing.Point(246, 162);
            this.rbLevak.Name = "rbLevak";
            this.rbLevak.Size = new System.Drawing.Size(57, 22);
            this.rbLevak.TabIndex = 84;
            this.rbLevak.TabStop = true;
            this.rbLevak.Text = "Levá";
            this.rbLevak.UseVisualStyleBackColor = true;
            this.rbLevak.CheckedChanged += new System.EventHandler(this.rbPravak_CheckedChanged);
            // 
            // cmbPozice
            // 
            this.cmbPozice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozice.FormattingEnabled = true;
            this.cmbPozice.Location = new System.Drawing.Point(154, 190);
            this.cmbPozice.Name = "cmbPozice";
            this.cmbPozice.Size = new System.Drawing.Size(197, 26);
            this.cmbPozice.TabIndex = 85;
            // 
            // rbPravak
            // 
            this.rbPravak.AutoSize = true;
            this.rbPravak.Location = new System.Drawing.Point(154, 162);
            this.rbPravak.Name = "rbPravak";
            this.rbPravak.Size = new System.Drawing.Size(64, 22);
            this.rbPravak.TabIndex = 83;
            this.rbPravak.TabStop = true;
            this.rbPravak.Text = "Pravá";
            this.rbPravak.UseVisualStyleBackColor = true;
            this.rbPravak.CheckedChanged += new System.EventHandler(this.rbPravak_CheckedChanged);
            // 
            // numCisloDresu
            // 
            this.numCisloDresu.Location = new System.Drawing.Point(516, 132);
            this.numCisloDresu.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numCisloDresu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCisloDresu.Name = "numCisloDresu";
            this.numCisloDresu.Size = new System.Drawing.Size(150, 24);
            this.numCisloDresu.TabIndex = 82;
            this.numCisloDresu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCisloDresu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbZlataKopacka
            // 
            this.cbZlataKopacka.AutoSize = true;
            this.cbZlataKopacka.Location = new System.Drawing.Point(516, 163);
            this.cbZlataKopacka.Name = "cbZlataKopacka";
            this.cbZlataKopacka.Size = new System.Drawing.Size(120, 22);
            this.cbZlataKopacka.TabIndex = 81;
            this.cbZlataKopacka.Text = "Zlatá kopačka";
            this.cbZlataKopacka.UseVisualStyleBackColor = true;
            // 
            // cbZlatyMic
            // 
            this.cbZlatyMic.AutoSize = true;
            this.cbZlatyMic.Location = new System.Drawing.Point(404, 162);
            this.cbZlatyMic.Name = "cbZlatyMic";
            this.cbZlatyMic.Size = new System.Drawing.Size(86, 22);
            this.cbZlatyMic.TabIndex = 80;
            this.cbZlatyMic.Text = "Zlatý míč";
            this.cbZlatyMic.UseVisualStyleBackColor = true;
            // 
            // tbPrijmeni
            // 
            this.tbPrijmeni.Location = new System.Drawing.Point(516, 9);
            this.tbPrijmeni.Name = "tbPrijmeni";
            this.tbPrijmeni.Size = new System.Drawing.Size(150, 24);
            this.tbPrijmeni.TabIndex = 79;
            this.tbPrijmeni.TextChanged += new System.EventHandler(this.NovaPolozka_TextChanged);
            // 
            // tbJmeno
            // 
            this.tbJmeno.Location = new System.Drawing.Point(153, 12);
            this.tbJmeno.Name = "tbJmeno";
            this.tbJmeno.Size = new System.Drawing.Size(198, 24);
            this.tbJmeno.TabIndex = 78;
            this.tbJmeno.TextChanged += new System.EventHandler(this.NovaPolozka_TextChanged);
            // 
            // lbPrijmeni
            // 
            this.lbPrijmeni.AutoSize = true;
            this.lbPrijmeni.Location = new System.Drawing.Point(401, 12);
            this.lbPrijmeni.Name = "lbPrijmeni";
            this.lbPrijmeni.Size = new System.Drawing.Size(65, 18);
            this.lbPrijmeni.TabIndex = 77;
            this.lbPrijmeni.Text = "Příjmení:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 76;
            this.label1.Text = "Jméno:";
            // 
            // lbCisloDresu
            // 
            this.lbCisloDresu.AutoSize = true;
            this.lbCisloDresu.Location = new System.Drawing.Point(401, 134);
            this.lbCisloDresu.Name = "lbCisloDresu";
            this.lbCisloDresu.Size = new System.Drawing.Size(87, 18);
            this.lbCisloDresu.TabIndex = 70;
            this.lbCisloDresu.Text = "Číslo dresu:";
            // 
            // lbPozice
            // 
            this.lbPozice.AutoSize = true;
            this.lbPozice.Location = new System.Drawing.Point(29, 193);
            this.lbPozice.Name = "lbPozice";
            this.lbPozice.Size = new System.Drawing.Size(58, 18);
            this.lbPozice.TabIndex = 69;
            this.lbPozice.Text = "Pozice:";
            // 
            // lbKlub
            // 
            this.lbKlub.AutoSize = true;
            this.lbKlub.Location = new System.Drawing.Point(401, 102);
            this.lbKlub.Name = "lbKlub";
            this.lbKlub.Size = new System.Drawing.Size(41, 18);
            this.lbKlub.TabIndex = 68;
            this.lbKlub.Text = "Klub:";
            // 
            // lbLigaKlubu
            // 
            this.lbLigaKlubu.AutoSize = true;
            this.lbLigaKlubu.Location = new System.Drawing.Point(401, 72);
            this.lbLigaKlubu.Name = "lbLigaKlubu";
            this.lbLigaKlubu.Size = new System.Drawing.Size(78, 18);
            this.lbLigaKlubu.TabIndex = 67;
            this.lbLigaKlubu.Text = "Liga klubu:";
            // 
            // lbZemeKlubu
            // 
            this.lbZemeKlubu.AutoSize = true;
            this.lbZemeKlubu.Location = new System.Drawing.Point(401, 42);
            this.lbZemeKlubu.Name = "lbZemeKlubu";
            this.lbZemeKlubu.Size = new System.Drawing.Size(89, 18);
            this.lbZemeKlubu.TabIndex = 66;
            this.lbZemeKlubu.Text = "Země klubu:";
            // 
            // lbVaha
            // 
            this.lbVaha.AutoSize = true;
            this.lbVaha.Location = new System.Drawing.Point(29, 134);
            this.lbVaha.Name = "lbVaha";
            this.lbVaha.Size = new System.Drawing.Size(71, 18);
            this.lbVaha.TabIndex = 65;
            this.lbVaha.Text = "Váha(kg):";
            // 
            // lbVyska
            // 
            this.lbVyska.AutoSize = true;
            this.lbVyska.Location = new System.Drawing.Point(29, 104);
            this.lbVyska.Name = "lbVyska";
            this.lbVyska.Size = new System.Drawing.Size(83, 18);
            this.lbVyska.TabIndex = 64;
            this.lbVyska.Text = "Výška(cm):";
            // 
            // lbZemeNarozeni
            // 
            this.lbZemeNarozeni.AutoSize = true;
            this.lbZemeNarozeni.Location = new System.Drawing.Point(29, 75);
            this.lbZemeNarozeni.Name = "lbZemeNarozeni";
            this.lbZemeNarozeni.Size = new System.Drawing.Size(111, 18);
            this.lbZemeNarozeni.TabIndex = 63;
            this.lbZemeNarozeni.Text = "Země narození:";
            // 
            // lbDatumNarozeni
            // 
            this.lbDatumNarozeni.AutoSize = true;
            this.lbDatumNarozeni.Location = new System.Drawing.Point(29, 47);
            this.lbDatumNarozeni.Name = "lbDatumNarozeni";
            this.lbDatumNarozeni.Size = new System.Drawing.Size(117, 18);
            this.lbDatumNarozeni.TabIndex = 62;
            this.lbDatumNarozeni.Text = "Datum narození:";
            // 
            // btPridat
            // 
            this.btPridat.Enabled = false;
            this.btPridat.Location = new System.Drawing.Point(32, 222);
            this.btPridat.Name = "btPridat";
            this.btPridat.Size = new System.Drawing.Size(634, 50);
            this.btPridat.TabIndex = 61;
            this.btPridat.Text = "Přidat";
            this.btPridat.UseVisualStyleBackColor = true;
            this.btPridat.Click += new System.EventHandler(this.btPridat_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(32, 274);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(634, 50);
            this.btExit.TabIndex = 89;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dtpDatumNarozeni
            // 
            this.dtpDatumNarozeni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumNarozeni.Location = new System.Drawing.Point(152, 42);
            this.dtpDatumNarozeni.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpDatumNarozeni.Name = "dtpDatumNarozeni";
            this.dtpDatumNarozeni.Size = new System.Drawing.Size(199, 24);
            this.dtpDatumNarozeni.TabIndex = 90;
            // 
            // cmbZemeNarozeni
            // 
            this.cmbZemeNarozeni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZemeNarozeni.FormattingEnabled = true;
            this.cmbZemeNarozeni.Location = new System.Drawing.Point(152, 72);
            this.cmbZemeNarozeni.Name = "cmbZemeNarozeni";
            this.cmbZemeNarozeni.Size = new System.Drawing.Size(199, 26);
            this.cmbZemeNarozeni.TabIndex = 91;
            // 
            // cmbZemeKlubu
            // 
            this.cmbZemeKlubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZemeKlubu.FormattingEnabled = true;
            this.cmbZemeKlubu.Location = new System.Drawing.Point(516, 39);
            this.cmbZemeKlubu.Name = "cmbZemeKlubu";
            this.cmbZemeKlubu.Size = new System.Drawing.Size(150, 26);
            this.cmbZemeKlubu.TabIndex = 92;
            // 
            // cmbKlub
            // 
            this.cmbKlub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlub.FormattingEnabled = true;
            this.cmbKlub.Location = new System.Drawing.Point(516, 101);
            this.cmbKlub.Name = "cmbKlub";
            this.cmbKlub.Size = new System.Drawing.Size(150, 26);
            this.cmbKlub.TabIndex = 93;
            // 
            // cmbLigaKlubu
            // 
            this.cmbLigaKlubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLigaKlubu.FormattingEnabled = true;
            this.cmbLigaKlubu.Location = new System.Drawing.Point(516, 69);
            this.cmbLigaKlubu.Name = "cmbLigaKlubu";
            this.cmbLigaKlubu.Size = new System.Drawing.Size(150, 26);
            this.cmbLigaKlubu.TabIndex = 94;
            // 
            // NovaPolozka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 336);
            this.ControlBox = false;
            this.Controls.Add(this.cmbLigaKlubu);
            this.Controls.Add(this.cmbKlub);
            this.Controls.Add(this.cmbZemeKlubu);
            this.Controls.Add(this.cmbZemeNarozeni);
            this.Controls.Add(this.dtpDatumNarozeni);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.numVyska);
            this.Controls.Add(this.numVaha);
            this.Controls.Add(this.lbNoha);
            this.Controls.Add(this.rbLevak);
            this.Controls.Add(this.cmbPozice);
            this.Controls.Add(this.rbPravak);
            this.Controls.Add(this.numCisloDresu);
            this.Controls.Add(this.cbZlataKopacka);
            this.Controls.Add(this.cbZlatyMic);
            this.Controls.Add(this.tbPrijmeni);
            this.Controls.Add(this.tbJmeno);
            this.Controls.Add(this.lbPrijmeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCisloDresu);
            this.Controls.Add(this.lbPozice);
            this.Controls.Add(this.lbKlub);
            this.Controls.Add(this.lbLigaKlubu);
            this.Controls.Add(this.lbZemeKlubu);
            this.Controls.Add(this.lbVaha);
            this.Controls.Add(this.lbVyska);
            this.Controls.Add(this.lbZemeNarozeni);
            this.Controls.Add(this.lbDatumNarozeni);
            this.Controls.Add(this.btPridat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NovaPolozka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nová Položka";
            this.Load += new System.EventHandler(this.NovaPolozka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numVyska)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVaha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCisloDresu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numVyska;
        private System.Windows.Forms.NumericUpDown numVaha;
        private System.Windows.Forms.Label lbNoha;
        private System.Windows.Forms.RadioButton rbLevak;
        private System.Windows.Forms.ComboBox cmbPozice;
        private System.Windows.Forms.RadioButton rbPravak;
        private System.Windows.Forms.NumericUpDown numCisloDresu;
        private System.Windows.Forms.CheckBox cbZlataKopacka;
        private System.Windows.Forms.CheckBox cbZlatyMic;
        private System.Windows.Forms.TextBox tbPrijmeni;
        private System.Windows.Forms.TextBox tbJmeno;
        private System.Windows.Forms.Label lbPrijmeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCisloDresu;
        private System.Windows.Forms.Label lbPozice;
        private System.Windows.Forms.Label lbKlub;
        private System.Windows.Forms.Label lbLigaKlubu;
        private System.Windows.Forms.Label lbZemeKlubu;
        private System.Windows.Forms.Label lbVaha;
        private System.Windows.Forms.Label lbVyska;
        private System.Windows.Forms.Label lbZemeNarozeni;
        private System.Windows.Forms.Label lbDatumNarozeni;
        private System.Windows.Forms.Button btPridat;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DateTimePicker dtpDatumNarozeni;
        private System.Windows.Forms.ComboBox cmbZemeNarozeni;
        private System.Windows.Forms.ComboBox cmbZemeKlubu;
        private System.Windows.Forms.ComboBox cmbKlub;
        private System.Windows.Forms.ComboBox cmbLigaKlubu;
    }
}