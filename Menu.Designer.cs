namespace I4_Janečka_Dinh_Skupinovka
{
    partial class Menu
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbOceneni = new System.Windows.Forms.CheckBox();
            this.rbFiltrLeva = new System.Windows.Forms.RadioButton();
            this.rbFiltrPrava = new System.Windows.Forms.RadioButton();
            this.lbFiltrKlub = new System.Windows.Forms.Label();
            this.cmbFiltraceKlub = new System.Windows.Forms.ComboBox();
            this.cmbFiltraceLigaKlubu = new System.Windows.Forms.ComboBox();
            this.lbFiltrLigaKlubu = new System.Windows.Forms.Label();
            this.cmbFiltraceZemeNarozeni = new System.Windows.Forms.ComboBox();
            this.lbFiltrZemeNarozeni = new System.Windows.Forms.Label();
            this.lbFiltrMaxVyska = new System.Windows.Forms.Label();
            this.lbFiltrMaxVaha = new System.Windows.Forms.Label();
            this.numMaxVaha = new System.Windows.Forms.NumericUpDown();
            this.numMaxVyska = new System.Windows.Forms.NumericUpDown();
            this.lbFiltrMinVaha = new System.Windows.Forms.Label();
            this.lbFiltrMinVyska = new System.Windows.Forms.Label();
            this.numMinVaha = new System.Windows.Forms.NumericUpDown();
            this.cbFiltrZlataKopacka = new System.Windows.Forms.CheckBox();
            this.cbFiltrZlatyMic = new System.Windows.Forms.CheckBox();
            this.lbFiltrPozice = new System.Windows.Forms.Label();
            this.cbFiltrNoha = new System.Windows.Forms.CheckBox();
            this.numMinVyska = new System.Windows.Forms.NumericUpDown();
            this.btResetovat = new System.Windows.Forms.Button();
            this.btPouzit = new System.Windows.Forms.Button();
            this.lbZlataKopacka = new System.Windows.Forms.Label();
            this.lbZlatyMic = new System.Windows.Forms.Label();
            this.lbNoha = new System.Windows.Forms.Label();
            this.lbCisloDresu = new System.Windows.Forms.Label();
            this.lbPozice = new System.Windows.Forms.Label();
            this.lbKlub = new System.Windows.Forms.Label();
            this.lbLigaKlubu = new System.Windows.Forms.Label();
            this.lbZemeKlubu = new System.Windows.Forms.Label();
            this.lbVaha = new System.Windows.Forms.Label();
            this.lbVyska = new System.Windows.Forms.Label();
            this.lbZemeNarozeni = new System.Windows.Forms.Label();
            this.lbDatumNarozeni = new System.Windows.Forms.Label();
            this.cmbFiltrPozice = new System.Windows.Forms.ComboBox();
            this.cbFiltrace = new System.Windows.Forms.CheckBox();
            this.btUlozit = new System.Windows.Forms.Button();
            this.btNovaPolozka = new System.Windows.Forms.Button();
            this.btUpravit = new System.Windows.Forms.Button();
            this.btSmazat = new System.Windows.Forms.Button();
            this.lboxFiltr = new System.Windows.Forms.ListBox();
            this.lboxPolozky = new System.Windows.Forms.ListBox();
            this.btKonec = new System.Windows.Forms.Button();
            this.gboxFiltrace = new System.Windows.Forms.GroupBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btZrušit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cbZlataKopacka = new System.Windows.Forms.CheckBox();
            this.cbZlatyMic = new System.Windows.Forms.CheckBox();
            this.btPotvrditUlozeni = new System.Windows.Forms.Button();
            this.lbUlozit = new System.Windows.Forms.Label();
            this.cbNoha = new System.Windows.Forms.CheckBox();
            this.cbVaha = new System.Windows.Forms.CheckBox();
            this.cbCisloDresu = new System.Windows.Forms.CheckBox();
            this.cbVyska = new System.Windows.Forms.CheckBox();
            this.cbPozice = new System.Windows.Forms.CheckBox();
            this.cbZemeNarozeni = new System.Windows.Forms.CheckBox();
            this.cbKlub = new System.Windows.Forms.CheckBox();
            this.cbDatumNarozeni = new System.Windows.Forms.CheckBox();
            this.cbLigaKlubu = new System.Windows.Forms.CheckBox();
            this.cbPrijmeni = new System.Windows.Forms.CheckBox();
            this.cbZemeKlubu = new System.Windows.Forms.CheckBox();
            this.cbJmeno = new System.Windows.Forms.CheckBox();
            this.gboxUlozit = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVaha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVyska)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinVaha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinVyska)).BeginInit();
            this.gboxFiltrace.SuspendLayout();
            this.gboxUlozit.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOceneni
            // 
            this.cbOceneni.AutoSize = true;
            this.cbOceneni.Location = new System.Drawing.Point(240, 83);
            this.cbOceneni.Name = "cbOceneni";
            this.cbOceneni.Size = new System.Drawing.Size(82, 22);
            this.cbOceneni.TabIndex = 105;
            this.cbOceneni.Text = "Ocenění";
            this.cbOceneni.UseVisualStyleBackColor = true;
            this.cbOceneni.CheckedChanged += new System.EventHandler(this.cbOceneni_CheckedChanged);
            // 
            // rbFiltrLeva
            // 
            this.rbFiltrLeva.AutoSize = true;
            this.rbFiltrLeva.Enabled = false;
            this.rbFiltrLeva.Location = new System.Drawing.Point(331, 54);
            this.rbFiltrLeva.Name = "rbFiltrLeva";
            this.rbFiltrLeva.Size = new System.Drawing.Size(57, 22);
            this.rbFiltrLeva.TabIndex = 104;
            this.rbFiltrLeva.TabStop = true;
            this.rbFiltrLeva.Text = "Levá";
            this.rbFiltrLeva.UseVisualStyleBackColor = true;
            // 
            // rbFiltrPrava
            // 
            this.rbFiltrPrava.AutoSize = true;
            this.rbFiltrPrava.Enabled = false;
            this.rbFiltrPrava.Location = new System.Drawing.Point(240, 54);
            this.rbFiltrPrava.Name = "rbFiltrPrava";
            this.rbFiltrPrava.Size = new System.Drawing.Size(64, 22);
            this.rbFiltrPrava.TabIndex = 103;
            this.rbFiltrPrava.TabStop = true;
            this.rbFiltrPrava.Text = "Pravá";
            this.rbFiltrPrava.UseVisualStyleBackColor = true;
            // 
            // lbFiltrKlub
            // 
            this.lbFiltrKlub.AutoSize = true;
            this.lbFiltrKlub.Location = new System.Drawing.Point(6, 115);
            this.lbFiltrKlub.Name = "lbFiltrKlub";
            this.lbFiltrKlub.Size = new System.Drawing.Size(41, 18);
            this.lbFiltrKlub.TabIndex = 102;
            this.lbFiltrKlub.Text = "Klub:";
            // 
            // cmbFiltraceKlub
            // 
            this.cmbFiltraceKlub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltraceKlub.FormattingEnabled = true;
            this.cmbFiltraceKlub.Location = new System.Drawing.Point(122, 112);
            this.cmbFiltraceKlub.Name = "cmbFiltraceKlub";
            this.cmbFiltraceKlub.Size = new System.Drawing.Size(112, 26);
            this.cmbFiltraceKlub.TabIndex = 101;
            // 
            // cmbFiltraceLigaKlubu
            // 
            this.cmbFiltraceLigaKlubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltraceLigaKlubu.FormattingEnabled = true;
            this.cmbFiltraceLigaKlubu.Location = new System.Drawing.Point(122, 81);
            this.cmbFiltraceLigaKlubu.Name = "cmbFiltraceLigaKlubu";
            this.cmbFiltraceLigaKlubu.Size = new System.Drawing.Size(112, 26);
            this.cmbFiltraceLigaKlubu.TabIndex = 100;
            // 
            // lbFiltrLigaKlubu
            // 
            this.lbFiltrLigaKlubu.AutoSize = true;
            this.lbFiltrLigaKlubu.Location = new System.Drawing.Point(6, 83);
            this.lbFiltrLigaKlubu.Name = "lbFiltrLigaKlubu";
            this.lbFiltrLigaKlubu.Size = new System.Drawing.Size(78, 18);
            this.lbFiltrLigaKlubu.TabIndex = 99;
            this.lbFiltrLigaKlubu.Text = "Liga klubu:";
            // 
            // cmbFiltraceZemeNarozeni
            // 
            this.cmbFiltraceZemeNarozeni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltraceZemeNarozeni.FormattingEnabled = true;
            this.cmbFiltraceZemeNarozeni.Location = new System.Drawing.Point(121, 49);
            this.cmbFiltraceZemeNarozeni.Name = "cmbFiltraceZemeNarozeni";
            this.cmbFiltraceZemeNarozeni.Size = new System.Drawing.Size(112, 26);
            this.cmbFiltraceZemeNarozeni.TabIndex = 98;
            // 
            // lbFiltrZemeNarozeni
            // 
            this.lbFiltrZemeNarozeni.AutoSize = true;
            this.lbFiltrZemeNarozeni.Location = new System.Drawing.Point(6, 52);
            this.lbFiltrZemeNarozeni.Name = "lbFiltrZemeNarozeni";
            this.lbFiltrZemeNarozeni.Size = new System.Drawing.Size(111, 18);
            this.lbFiltrZemeNarozeni.TabIndex = 97;
            this.lbFiltrZemeNarozeni.Text = "Země narození:";
            // 
            // lbFiltrMaxVyska
            // 
            this.lbFiltrMaxVyska.AutoSize = true;
            this.lbFiltrMaxVyska.Location = new System.Drawing.Point(237, 147);
            this.lbFiltrMaxVyska.Name = "lbFiltrMaxVyska";
            this.lbFiltrMaxVyska.Size = new System.Drawing.Size(86, 18);
            this.lbFiltrMaxVyska.TabIndex = 96;
            this.lbFiltrMaxVyska.Text = "Max. výška:";
            // 
            // lbFiltrMaxVaha
            // 
            this.lbFiltrMaxVaha.AutoSize = true;
            this.lbFiltrMaxVaha.Location = new System.Drawing.Point(237, 176);
            this.lbFiltrMaxVaha.Name = "lbFiltrMaxVaha";
            this.lbFiltrMaxVaha.Size = new System.Drawing.Size(79, 18);
            this.lbFiltrMaxVaha.TabIndex = 95;
            this.lbFiltrMaxVaha.Text = "Max. váha:";
            // 
            // numMaxVaha
            // 
            this.numMaxVaha.Location = new System.Drawing.Point(344, 174);
            this.numMaxVaha.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numMaxVaha.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMaxVaha.Name = "numMaxVaha";
            this.numMaxVaha.Size = new System.Drawing.Size(103, 24);
            this.numMaxVaha.TabIndex = 94;
            this.numMaxVaha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMaxVaha.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numMaxVaha.ValueChanged += new System.EventHandler(this.numerikyChybaChange);
            // 
            // numMaxVyska
            // 
            this.numMaxVyska.Location = new System.Drawing.Point(344, 144);
            this.numMaxVyska.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.numMaxVyska.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numMaxVyska.Name = "numMaxVyska";
            this.numMaxVyska.Size = new System.Drawing.Size(103, 24);
            this.numMaxVyska.TabIndex = 93;
            this.numMaxVyska.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMaxVyska.Value = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.numMaxVyska.ValueChanged += new System.EventHandler(this.numerikyChybaChange);
            // 
            // lbFiltrMinVaha
            // 
            this.lbFiltrMinVaha.AutoSize = true;
            this.lbFiltrMinVaha.Location = new System.Drawing.Point(6, 176);
            this.lbFiltrMinVaha.Name = "lbFiltrMinVaha";
            this.lbFiltrMinVaha.Size = new System.Drawing.Size(75, 18);
            this.lbFiltrMinVaha.TabIndex = 92;
            this.lbFiltrMinVaha.Text = "Min. váha:";
            // 
            // lbFiltrMinVyska
            // 
            this.lbFiltrMinVyska.AutoSize = true;
            this.lbFiltrMinVyska.Location = new System.Drawing.Point(6, 147);
            this.lbFiltrMinVyska.Name = "lbFiltrMinVyska";
            this.lbFiltrMinVyska.Size = new System.Drawing.Size(82, 18);
            this.lbFiltrMinVyska.TabIndex = 91;
            this.lbFiltrMinVyska.Text = "Min. výška:";
            // 
            // numMinVaha
            // 
            this.numMinVaha.Location = new System.Drawing.Point(122, 174);
            this.numMinVaha.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numMinVaha.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMinVaha.Name = "numMinVaha";
            this.numMinVaha.Size = new System.Drawing.Size(112, 24);
            this.numMinVaha.TabIndex = 90;
            this.numMinVaha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMinVaha.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMinVaha.ValueChanged += new System.EventHandler(this.numerikyChybaChange);
            // 
            // cbFiltrZlataKopacka
            // 
            this.cbFiltrZlataKopacka.AutoSize = true;
            this.cbFiltrZlataKopacka.Enabled = false;
            this.cbFiltrZlataKopacka.Location = new System.Drawing.Point(331, 114);
            this.cbFiltrZlataKopacka.Name = "cbFiltrZlataKopacka";
            this.cbFiltrZlataKopacka.Size = new System.Drawing.Size(120, 22);
            this.cbFiltrZlataKopacka.TabIndex = 89;
            this.cbFiltrZlataKopacka.Text = "Zlatá kopačka";
            this.cbFiltrZlataKopacka.UseVisualStyleBackColor = true;
            // 
            // cbFiltrZlatyMic
            // 
            this.cbFiltrZlatyMic.AutoSize = true;
            this.cbFiltrZlatyMic.Enabled = false;
            this.cbFiltrZlatyMic.Location = new System.Drawing.Point(240, 114);
            this.cbFiltrZlatyMic.Name = "cbFiltrZlatyMic";
            this.cbFiltrZlatyMic.Size = new System.Drawing.Size(86, 22);
            this.cbFiltrZlatyMic.TabIndex = 88;
            this.cbFiltrZlatyMic.Text = "Zlatý míč";
            this.cbFiltrZlatyMic.UseVisualStyleBackColor = true;
            // 
            // lbFiltrPozice
            // 
            this.lbFiltrPozice.AutoSize = true;
            this.lbFiltrPozice.Location = new System.Drawing.Point(6, 20);
            this.lbFiltrPozice.Name = "lbFiltrPozice";
            this.lbFiltrPozice.Size = new System.Drawing.Size(58, 18);
            this.lbFiltrPozice.TabIndex = 87;
            this.lbFiltrPozice.Text = "Pozice:";
            // 
            // cbFiltrNoha
            // 
            this.cbFiltrNoha.AutoSize = true;
            this.cbFiltrNoha.Location = new System.Drawing.Point(240, 19);
            this.cbFiltrNoha.Name = "cbFiltrNoha";
            this.cbFiltrNoha.Size = new System.Drawing.Size(144, 22);
            this.cbFiltrNoha.TabIndex = 86;
            this.cbFiltrNoha.Text = "Preferovaná noha";
            this.cbFiltrNoha.UseVisualStyleBackColor = true;
            this.cbFiltrNoha.CheckedChanged += new System.EventHandler(this.cbFiltrNoha_CheckedChanged);
            // 
            // numMinVyska
            // 
            this.numMinVyska.Location = new System.Drawing.Point(122, 144);
            this.numMinVyska.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.numMinVyska.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numMinVyska.Name = "numMinVyska";
            this.numMinVyska.Size = new System.Drawing.Size(112, 24);
            this.numMinVyska.TabIndex = 85;
            this.numMinVyska.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMinVyska.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numMinVyska.ValueChanged += new System.EventHandler(this.numerikyChybaChange);
            // 
            // btResetovat
            // 
            this.btResetovat.Location = new System.Drawing.Point(240, 204);
            this.btResetovat.Name = "btResetovat";
            this.btResetovat.Size = new System.Drawing.Size(207, 62);
            this.btResetovat.TabIndex = 83;
            this.btResetovat.Text = "Resetovat";
            this.btResetovat.UseVisualStyleBackColor = true;
            this.btResetovat.Click += new System.EventHandler(this.btResetovat_Click);
            // 
            // btPouzit
            // 
            this.btPouzit.Location = new System.Drawing.Point(9, 204);
            this.btPouzit.Name = "btPouzit";
            this.btPouzit.Size = new System.Drawing.Size(224, 62);
            this.btPouzit.TabIndex = 82;
            this.btPouzit.Text = "Použít";
            this.btPouzit.UseVisualStyleBackColor = true;
            this.btPouzit.Click += new System.EventHandler(this.btPouzit_Click);
            // 
            // lbZlataKopacka
            // 
            this.lbZlataKopacka.AutoSize = true;
            this.lbZlataKopacka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZlataKopacka.Location = new System.Drawing.Point(714, 219);
            this.lbZlataKopacka.Name = "lbZlataKopacka";
            this.lbZlataKopacka.Size = new System.Drawing.Size(126, 20);
            this.lbZlataKopacka.TabIndex = 77;
            this.lbZlataKopacka.Text = "Zlatá kopačka: ?";
            // 
            // lbZlatyMic
            // 
            this.lbZlatyMic.AutoSize = true;
            this.lbZlatyMic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZlatyMic.Location = new System.Drawing.Point(714, 194);
            this.lbZlatyMic.Name = "lbZlatyMic";
            this.lbZlatyMic.Size = new System.Drawing.Size(88, 20);
            this.lbZlatyMic.TabIndex = 76;
            this.lbZlatyMic.Text = "Zlatý míč: ?";
            // 
            // lbNoha
            // 
            this.lbNoha.AutoSize = true;
            this.lbNoha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNoha.Location = new System.Drawing.Point(396, 194);
            this.lbNoha.Name = "lbNoha";
            this.lbNoha.Size = new System.Drawing.Size(138, 20);
            this.lbNoha.TabIndex = 75;
            this.lbNoha.Text = "Pravá/levá noha: ?";
            // 
            // lbCisloDresu
            // 
            this.lbCisloDresu.AutoSize = true;
            this.lbCisloDresu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCisloDresu.Location = new System.Drawing.Point(714, 169);
            this.lbCisloDresu.Name = "lbCisloDresu";
            this.lbCisloDresu.Size = new System.Drawing.Size(104, 20);
            this.lbCisloDresu.TabIndex = 74;
            this.lbCisloDresu.Text = "Číslo dresu: ?";
            // 
            // lbPozice
            // 
            this.lbPozice.AutoSize = true;
            this.lbPozice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPozice.Location = new System.Drawing.Point(396, 219);
            this.lbPozice.Name = "lbPozice";
            this.lbPozice.Size = new System.Drawing.Size(73, 20);
            this.lbPozice.TabIndex = 73;
            this.lbPozice.Text = "Pozice: ?";
            // 
            // lbKlub
            // 
            this.lbKlub.AutoSize = true;
            this.lbKlub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKlub.Location = new System.Drawing.Point(714, 144);
            this.lbKlub.Name = "lbKlub";
            this.lbKlub.Size = new System.Drawing.Size(57, 20);
            this.lbKlub.TabIndex = 72;
            this.lbKlub.Text = "Klub: ?";
            // 
            // lbLigaKlubu
            // 
            this.lbLigaKlubu.AutoSize = true;
            this.lbLigaKlubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLigaKlubu.Location = new System.Drawing.Point(714, 119);
            this.lbLigaKlubu.Name = "lbLigaKlubu";
            this.lbLigaKlubu.Size = new System.Drawing.Size(98, 20);
            this.lbLigaKlubu.TabIndex = 71;
            this.lbLigaKlubu.Text = "Liga klubu: ?";
            // 
            // lbZemeKlubu
            // 
            this.lbZemeKlubu.AutoSize = true;
            this.lbZemeKlubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZemeKlubu.Location = new System.Drawing.Point(714, 94);
            this.lbZemeKlubu.Name = "lbZemeKlubu";
            this.lbZemeKlubu.Size = new System.Drawing.Size(109, 20);
            this.lbZemeKlubu.TabIndex = 70;
            this.lbZemeKlubu.Text = "Země klubu: ?";
            // 
            // lbVaha
            // 
            this.lbVaha.AutoSize = true;
            this.lbVaha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbVaha.Location = new System.Drawing.Point(396, 169);
            this.lbVaha.Name = "lbVaha";
            this.lbVaha.Size = new System.Drawing.Size(91, 20);
            this.lbVaha.TabIndex = 69;
            this.lbVaha.Text = "Váha(kg): ?";
            // 
            // lbVyska
            // 
            this.lbVyska.AutoSize = true;
            this.lbVyska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbVyska.Location = new System.Drawing.Point(396, 144);
            this.lbVyska.Name = "lbVyska";
            this.lbVyska.Size = new System.Drawing.Size(100, 20);
            this.lbVyska.TabIndex = 68;
            this.lbVyska.Text = "Výška(cm): ?";
            // 
            // lbZemeNarozeni
            // 
            this.lbZemeNarozeni.AutoSize = true;
            this.lbZemeNarozeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZemeNarozeni.Location = new System.Drawing.Point(396, 119);
            this.lbZemeNarozeni.Name = "lbZemeNarozeni";
            this.lbZemeNarozeni.Size = new System.Drawing.Size(132, 20);
            this.lbZemeNarozeni.TabIndex = 67;
            this.lbZemeNarozeni.Text = "Země narození: ?";
            // 
            // lbDatumNarozeni
            // 
            this.lbDatumNarozeni.AutoSize = true;
            this.lbDatumNarozeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDatumNarozeni.Location = new System.Drawing.Point(396, 94);
            this.lbDatumNarozeni.Name = "lbDatumNarozeni";
            this.lbDatumNarozeni.Size = new System.Drawing.Size(139, 20);
            this.lbDatumNarozeni.TabIndex = 66;
            this.lbDatumNarozeni.Text = "Datum narození: ?";
            // 
            // cmbFiltrPozice
            // 
            this.cmbFiltrPozice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrPozice.FormattingEnabled = true;
            this.cmbFiltrPozice.Location = new System.Drawing.Point(122, 17);
            this.cmbFiltrPozice.Name = "cmbFiltrPozice";
            this.cmbFiltrPozice.Size = new System.Drawing.Size(112, 26);
            this.cmbFiltrPozice.TabIndex = 65;
            // 
            // cbFiltrace
            // 
            this.cbFiltrace.AutoSize = true;
            this.cbFiltrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFiltrace.Location = new System.Drawing.Point(400, 281);
            this.cbFiltrace.Name = "cbFiltrace";
            this.cbFiltrace.Size = new System.Drawing.Size(199, 59);
            this.cbFiltrace.TabIndex = 64;
            this.cbFiltrace.Text = "Filtrace";
            this.cbFiltrace.UseVisualStyleBackColor = true;
            this.cbFiltrace.CheckedChanged += new System.EventHandler(this.cbFiltrace_CheckedChanged);
            // 
            // btUlozit
            // 
            this.btUlozit.Location = new System.Drawing.Point(204, 449);
            this.btUlozit.Name = "btUlozit";
            this.btUlozit.Size = new System.Drawing.Size(186, 80);
            this.btUlozit.TabIndex = 63;
            this.btUlozit.Text = "Uložit";
            this.btUlozit.UseVisualStyleBackColor = true;
            this.btUlozit.Click += new System.EventHandler(this.btUlozit_Click);
            // 
            // btNovaPolozka
            // 
            this.btNovaPolozka.Location = new System.Drawing.Point(12, 449);
            this.btNovaPolozka.Name = "btNovaPolozka";
            this.btNovaPolozka.Size = new System.Drawing.Size(186, 80);
            this.btNovaPolozka.TabIndex = 62;
            this.btNovaPolozka.Text = "Nová položka";
            this.btNovaPolozka.UseVisualStyleBackColor = true;
            this.btNovaPolozka.Click += new System.EventHandler(this.btNovaPolozka_Click);
            // 
            // btUpravit
            // 
            this.btUpravit.Enabled = false;
            this.btUpravit.Location = new System.Drawing.Point(204, 353);
            this.btUpravit.Name = "btUpravit";
            this.btUpravit.Size = new System.Drawing.Size(186, 90);
            this.btUpravit.TabIndex = 61;
            this.btUpravit.Text = "Upravit";
            this.btUpravit.UseVisualStyleBackColor = true;
            this.btUpravit.Click += new System.EventHandler(this.btUpravit_Click);
            // 
            // btSmazat
            // 
            this.btSmazat.Enabled = false;
            this.btSmazat.Location = new System.Drawing.Point(12, 353);
            this.btSmazat.Name = "btSmazat";
            this.btSmazat.Size = new System.Drawing.Size(186, 90);
            this.btSmazat.TabIndex = 60;
            this.btSmazat.Text = "Smazat";
            this.btSmazat.UseVisualStyleBackColor = true;
            this.btSmazat.Click += new System.EventHandler(this.btSmazat_Click);
            // 
            // lboxFiltr
            // 
            this.lboxFiltr.Enabled = false;
            this.lboxFiltr.FormattingEnabled = true;
            this.lboxFiltr.ItemHeight = 18;
            this.lboxFiltr.Location = new System.Drawing.Point(1028, 12);
            this.lboxFiltr.Name = "lboxFiltr";
            this.lboxFiltr.Size = new System.Drawing.Size(442, 328);
            this.lboxFiltr.TabIndex = 59;
            this.lboxFiltr.SelectedIndexChanged += new System.EventHandler(this.lboxFiltr_SelectedIndexChanged);
            // 
            // lboxPolozky
            // 
            this.lboxPolozky.FormattingEnabled = true;
            this.lboxPolozky.ItemHeight = 18;
            this.lboxPolozky.Location = new System.Drawing.Point(12, 12);
            this.lboxPolozky.Name = "lboxPolozky";
            this.lboxPolozky.Size = new System.Drawing.Size(378, 328);
            this.lboxPolozky.TabIndex = 58;
            this.lboxPolozky.SelectedIndexChanged += new System.EventHandler(this.lboxPolozky_SelectedIndexChanged);
            // 
            // btKonec
            // 
            this.btKonec.Location = new System.Drawing.Point(12, 535);
            this.btKonec.Name = "btKonec";
            this.btKonec.Size = new System.Drawing.Size(378, 80);
            this.btKonec.TabIndex = 107;
            this.btKonec.Text = "Ukončit Aplikaci";
            this.btKonec.UseVisualStyleBackColor = true;
            this.btKonec.Click += new System.EventHandler(this.btKonec_Click);
            // 
            // gboxFiltrace
            // 
            this.gboxFiltrace.Controls.Add(this.lbFiltrPozice);
            this.gboxFiltrace.Controls.Add(this.cmbFiltrPozice);
            this.gboxFiltrace.Controls.Add(this.btPouzit);
            this.gboxFiltrace.Controls.Add(this.cbOceneni);
            this.gboxFiltrace.Controls.Add(this.btResetovat);
            this.gboxFiltrace.Controls.Add(this.rbFiltrLeva);
            this.gboxFiltrace.Controls.Add(this.rbFiltrPrava);
            this.gboxFiltrace.Controls.Add(this.numMinVyska);
            this.gboxFiltrace.Controls.Add(this.lbFiltrKlub);
            this.gboxFiltrace.Controls.Add(this.cbFiltrNoha);
            this.gboxFiltrace.Controls.Add(this.cmbFiltraceKlub);
            this.gboxFiltrace.Controls.Add(this.cbFiltrZlatyMic);
            this.gboxFiltrace.Controls.Add(this.cmbFiltraceLigaKlubu);
            this.gboxFiltrace.Controls.Add(this.cbFiltrZlataKopacka);
            this.gboxFiltrace.Controls.Add(this.lbFiltrLigaKlubu);
            this.gboxFiltrace.Controls.Add(this.numMinVaha);
            this.gboxFiltrace.Controls.Add(this.cmbFiltraceZemeNarozeni);
            this.gboxFiltrace.Controls.Add(this.lbFiltrMinVyska);
            this.gboxFiltrace.Controls.Add(this.lbFiltrZemeNarozeni);
            this.gboxFiltrace.Controls.Add(this.lbFiltrMinVaha);
            this.gboxFiltrace.Controls.Add(this.lbFiltrMaxVyska);
            this.gboxFiltrace.Controls.Add(this.numMaxVyska);
            this.gboxFiltrace.Controls.Add(this.lbFiltrMaxVaha);
            this.gboxFiltrace.Controls.Add(this.numMaxVaha);
            this.gboxFiltrace.Enabled = false;
            this.gboxFiltrace.Location = new System.Drawing.Point(1019, 353);
            this.gboxFiltrace.Name = "gboxFiltrace";
            this.gboxFiltrace.Size = new System.Drawing.Size(453, 280);
            this.gboxFiltrace.TabIndex = 108;
            this.gboxFiltrace.TabStop = false;
            // 
            // sfd
            // 
            this.sfd.Filter = "(.csv)|*.csv";
            // 
            // btZrušit
            // 
            this.btZrušit.Location = new System.Drawing.Point(278, 198);
            this.btZrušit.Name = "btZrušit";
            this.btZrušit.Size = new System.Drawing.Size(268, 51);
            this.btZrušit.TabIndex = 125;
            this.btZrušit.Text = "Zrušit";
            this.btZrušit.UseVisualStyleBackColor = true;
            this.btZrušit.Click += new System.EventHandler(this.btZrušit_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "(.csv)|*.csv";
            // 
            // cbZlataKopacka
            // 
            this.cbZlataKopacka.AutoSize = true;
            this.cbZlataKopacka.Location = new System.Drawing.Point(216, 147);
            this.cbZlataKopacka.Name = "cbZlataKopacka";
            this.cbZlataKopacka.Size = new System.Drawing.Size(120, 22);
            this.cbZlataKopacka.TabIndex = 124;
            this.cbZlataKopacka.Text = "Zlatá kopačka";
            this.cbZlataKopacka.UseVisualStyleBackColor = true;
            // 
            // cbZlatyMic
            // 
            this.cbZlatyMic.AutoSize = true;
            this.cbZlatyMic.Location = new System.Drawing.Point(356, 147);
            this.cbZlatyMic.Name = "cbZlatyMic";
            this.cbZlatyMic.Size = new System.Drawing.Size(86, 22);
            this.cbZlatyMic.TabIndex = 123;
            this.cbZlatyMic.Text = "Zlatý míč";
            this.cbZlatyMic.UseVisualStyleBackColor = true;
            // 
            // btPotvrditUlozeni
            // 
            this.btPotvrditUlozeni.Location = new System.Drawing.Point(4, 198);
            this.btPotvrditUlozeni.Name = "btPotvrditUlozeni";
            this.btPotvrditUlozeni.Size = new System.Drawing.Size(268, 51);
            this.btPotvrditUlozeni.TabIndex = 122;
            this.btPotvrditUlozeni.Text = "Uložit";
            this.btPotvrditUlozeni.UseVisualStyleBackColor = true;
            this.btPotvrditUlozeni.Click += new System.EventHandler(this.btPotvrditUlozeni_Click);
            // 
            // lbUlozit
            // 
            this.lbUlozit.AutoSize = true;
            this.lbUlozit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUlozit.Location = new System.Drawing.Point(125, 20);
            this.lbUlozit.Name = "lbUlozit";
            this.lbUlozit.Size = new System.Drawing.Size(315, 42);
            this.lbUlozit.TabIndex = 121;
            this.lbUlozit.Text = "Co chcete uložit ?";
            // 
            // cbNoha
            // 
            this.cbNoha.AutoSize = true;
            this.cbNoha.Location = new System.Drawing.Point(496, 111);
            this.cbNoha.Name = "cbNoha";
            this.cbNoha.Size = new System.Drawing.Size(63, 22);
            this.cbNoha.TabIndex = 120;
            this.cbNoha.Text = "Noha";
            this.cbNoha.UseVisualStyleBackColor = true;
            // 
            // cbVaha
            // 
            this.cbVaha.AutoSize = true;
            this.cbVaha.Location = new System.Drawing.Point(6, 111);
            this.cbVaha.Name = "cbVaha";
            this.cbVaha.Size = new System.Drawing.Size(60, 22);
            this.cbVaha.TabIndex = 119;
            this.cbVaha.Text = "Váha";
            this.cbVaha.UseVisualStyleBackColor = true;
            // 
            // cbCisloDresu
            // 
            this.cbCisloDresu.AutoSize = true;
            this.cbCisloDresu.Location = new System.Drawing.Point(97, 147);
            this.cbCisloDresu.Name = "cbCisloDresu";
            this.cbCisloDresu.Size = new System.Drawing.Size(102, 22);
            this.cbCisloDresu.TabIndex = 118;
            this.cbCisloDresu.Text = "Číslo dresu";
            this.cbCisloDresu.UseVisualStyleBackColor = true;
            // 
            // cbVyska
            // 
            this.cbVyska.AutoSize = true;
            this.cbVyska.Location = new System.Drawing.Point(496, 71);
            this.cbVyska.Name = "cbVyska";
            this.cbVyska.Size = new System.Drawing.Size(67, 22);
            this.cbVyska.TabIndex = 117;
            this.cbVyska.Text = "Výška";
            this.cbVyska.UseVisualStyleBackColor = true;
            // 
            // cbPozice
            // 
            this.cbPozice.AutoSize = true;
            this.cbPozice.Location = new System.Drawing.Point(6, 145);
            this.cbPozice.Name = "cbPozice";
            this.cbPozice.Size = new System.Drawing.Size(73, 22);
            this.cbPozice.TabIndex = 116;
            this.cbPozice.Text = "Pozice";
            this.cbPozice.UseVisualStyleBackColor = true;
            // 
            // cbZemeNarozeni
            // 
            this.cbZemeNarozeni.AutoSize = true;
            this.cbZemeNarozeni.Location = new System.Drawing.Point(356, 71);
            this.cbZemeNarozeni.Name = "cbZemeNarozeni";
            this.cbZemeNarozeni.Size = new System.Drawing.Size(126, 22);
            this.cbZemeNarozeni.TabIndex = 115;
            this.cbZemeNarozeni.Text = "Země narození";
            this.cbZemeNarozeni.UseVisualStyleBackColor = true;
            // 
            // cbKlub
            // 
            this.cbKlub.AutoSize = true;
            this.cbKlub.Location = new System.Drawing.Point(356, 111);
            this.cbKlub.Name = "cbKlub";
            this.cbKlub.Size = new System.Drawing.Size(56, 22);
            this.cbKlub.TabIndex = 114;
            this.cbKlub.Text = "Klub";
            this.cbKlub.UseVisualStyleBackColor = true;
            // 
            // cbDatumNarozeni
            // 
            this.cbDatumNarozeni.AutoSize = true;
            this.cbDatumNarozeni.Location = new System.Drawing.Point(216, 71);
            this.cbDatumNarozeni.Name = "cbDatumNarozeni";
            this.cbDatumNarozeni.Size = new System.Drawing.Size(132, 22);
            this.cbDatumNarozeni.TabIndex = 113;
            this.cbDatumNarozeni.Text = "Datum narození";
            this.cbDatumNarozeni.UseVisualStyleBackColor = true;
            // 
            // cbLigaKlubu
            // 
            this.cbLigaKlubu.AutoSize = true;
            this.cbLigaKlubu.Location = new System.Drawing.Point(216, 111);
            this.cbLigaKlubu.Name = "cbLigaKlubu";
            this.cbLigaKlubu.Size = new System.Drawing.Size(93, 22);
            this.cbLigaKlubu.TabIndex = 112;
            this.cbLigaKlubu.Text = "Liga klubu";
            this.cbLigaKlubu.UseVisualStyleBackColor = true;
            // 
            // cbPrijmeni
            // 
            this.cbPrijmeni.AutoSize = true;
            this.cbPrijmeni.Location = new System.Drawing.Point(97, 71);
            this.cbPrijmeni.Name = "cbPrijmeni";
            this.cbPrijmeni.Size = new System.Drawing.Size(80, 22);
            this.cbPrijmeni.TabIndex = 111;
            this.cbPrijmeni.Text = "Příjmení";
            this.cbPrijmeni.UseVisualStyleBackColor = true;
            // 
            // cbZemeKlubu
            // 
            this.cbZemeKlubu.AutoSize = true;
            this.cbZemeKlubu.Location = new System.Drawing.Point(97, 111);
            this.cbZemeKlubu.Name = "cbZemeKlubu";
            this.cbZemeKlubu.Size = new System.Drawing.Size(104, 22);
            this.cbZemeKlubu.TabIndex = 110;
            this.cbZemeKlubu.Text = "Země klubu";
            this.cbZemeKlubu.UseVisualStyleBackColor = true;
            // 
            // cbJmeno
            // 
            this.cbJmeno.AutoSize = true;
            this.cbJmeno.Location = new System.Drawing.Point(6, 71);
            this.cbJmeno.Name = "cbJmeno";
            this.cbJmeno.Size = new System.Drawing.Size(73, 22);
            this.cbJmeno.TabIndex = 109;
            this.cbJmeno.Text = "Jméno";
            this.cbJmeno.UseVisualStyleBackColor = true;
            // 
            // gboxUlozit
            // 
            this.gboxUlozit.Controls.Add(this.lbUlozit);
            this.gboxUlozit.Controls.Add(this.btZrušit);
            this.gboxUlozit.Controls.Add(this.cbJmeno);
            this.gboxUlozit.Controls.Add(this.cbZlataKopacka);
            this.gboxUlozit.Controls.Add(this.cbZemeKlubu);
            this.gboxUlozit.Controls.Add(this.cbZlatyMic);
            this.gboxUlozit.Controls.Add(this.cbPrijmeni);
            this.gboxUlozit.Controls.Add(this.btPotvrditUlozeni);
            this.gboxUlozit.Controls.Add(this.cbLigaKlubu);
            this.gboxUlozit.Controls.Add(this.cbDatumNarozeni);
            this.gboxUlozit.Controls.Add(this.cbNoha);
            this.gboxUlozit.Controls.Add(this.cbKlub);
            this.gboxUlozit.Controls.Add(this.cbVaha);
            this.gboxUlozit.Controls.Add(this.cbZemeNarozeni);
            this.gboxUlozit.Controls.Add(this.cbCisloDresu);
            this.gboxUlozit.Controls.Add(this.cbPozice);
            this.gboxUlozit.Controls.Add(this.cbVyska);
            this.gboxUlozit.Location = new System.Drawing.Point(400, 353);
            this.gboxUlozit.Name = "gboxUlozit";
            this.gboxUlozit.Size = new System.Drawing.Size(601, 262);
            this.gboxUlozit.TabIndex = 126;
            this.gboxUlozit.TabStop = false;
            this.gboxUlozit.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 645);
            this.ControlBox = false;
            this.Controls.Add(this.gboxUlozit);
            this.Controls.Add(this.gboxFiltrace);
            this.Controls.Add(this.btKonec);
            this.Controls.Add(this.lbZlataKopacka);
            this.Controls.Add(this.lbZlatyMic);
            this.Controls.Add(this.lbNoha);
            this.Controls.Add(this.lbCisloDresu);
            this.Controls.Add(this.lbPozice);
            this.Controls.Add(this.lbKlub);
            this.Controls.Add(this.lbLigaKlubu);
            this.Controls.Add(this.lbZemeKlubu);
            this.Controls.Add(this.lbVaha);
            this.Controls.Add(this.lbVyska);
            this.Controls.Add(this.lbZemeNarozeni);
            this.Controls.Add(this.lbDatumNarozeni);
            this.Controls.Add(this.cbFiltrace);
            this.Controls.Add(this.btUlozit);
            this.Controls.Add(this.btNovaPolozka);
            this.Controls.Add(this.btUpravit);
            this.Controls.Add(this.btSmazat);
            this.Controls.Add(this.lboxFiltr);
            this.Controls.Add(this.lboxPolozky);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Databáze fotbalistů";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVaha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVyska)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinVaha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinVyska)).EndInit();
            this.gboxFiltrace.ResumeLayout(false);
            this.gboxFiltrace.PerformLayout();
            this.gboxUlozit.ResumeLayout(false);
            this.gboxUlozit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbOceneni;
        private System.Windows.Forms.RadioButton rbFiltrLeva;
        private System.Windows.Forms.RadioButton rbFiltrPrava;
        private System.Windows.Forms.Label lbFiltrKlub;
        private System.Windows.Forms.ComboBox cmbFiltraceKlub;
        private System.Windows.Forms.ComboBox cmbFiltraceLigaKlubu;
        private System.Windows.Forms.Label lbFiltrLigaKlubu;
        private System.Windows.Forms.ComboBox cmbFiltraceZemeNarozeni;
        private System.Windows.Forms.Label lbFiltrZemeNarozeni;
        private System.Windows.Forms.Label lbFiltrMaxVyska;
        private System.Windows.Forms.Label lbFiltrMaxVaha;
        private System.Windows.Forms.NumericUpDown numMaxVaha;
        private System.Windows.Forms.NumericUpDown numMaxVyska;
        private System.Windows.Forms.Label lbFiltrMinVaha;
        private System.Windows.Forms.Label lbFiltrMinVyska;
        private System.Windows.Forms.NumericUpDown numMinVaha;
        private System.Windows.Forms.CheckBox cbFiltrZlataKopacka;
        private System.Windows.Forms.CheckBox cbFiltrZlatyMic;
        private System.Windows.Forms.Label lbFiltrPozice;
        private System.Windows.Forms.CheckBox cbFiltrNoha;
        private System.Windows.Forms.NumericUpDown numMinVyska;
        private System.Windows.Forms.Button btResetovat;
        private System.Windows.Forms.Button btPouzit;
        private System.Windows.Forms.Label lbZlataKopacka;
        private System.Windows.Forms.Label lbZlatyMic;
        private System.Windows.Forms.Label lbNoha;
        private System.Windows.Forms.Label lbCisloDresu;
        private System.Windows.Forms.Label lbPozice;
        private System.Windows.Forms.Label lbKlub;
        private System.Windows.Forms.Label lbLigaKlubu;
        private System.Windows.Forms.Label lbZemeKlubu;
        private System.Windows.Forms.Label lbVaha;
        private System.Windows.Forms.Label lbVyska;
        private System.Windows.Forms.Label lbZemeNarozeni;
        private System.Windows.Forms.Label lbDatumNarozeni;
        private System.Windows.Forms.ComboBox cmbFiltrPozice;
        private System.Windows.Forms.CheckBox cbFiltrace;
        private System.Windows.Forms.Button btUlozit;
        private System.Windows.Forms.Button btNovaPolozka;
        private System.Windows.Forms.Button btUpravit;
        private System.Windows.Forms.Button btSmazat;
        private System.Windows.Forms.ListBox lboxFiltr;
        private System.Windows.Forms.ListBox lboxPolozky;
        private System.Windows.Forms.Button btKonec;
        private System.Windows.Forms.GroupBox gboxFiltrace;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btZrušit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox cbZlataKopacka;
        private System.Windows.Forms.CheckBox cbZlatyMic;
        private System.Windows.Forms.Button btPotvrditUlozeni;
        private System.Windows.Forms.Label lbUlozit;
        private System.Windows.Forms.CheckBox cbNoha;
        private System.Windows.Forms.CheckBox cbVaha;
        private System.Windows.Forms.CheckBox cbCisloDresu;
        private System.Windows.Forms.CheckBox cbVyska;
        private System.Windows.Forms.CheckBox cbPozice;
        private System.Windows.Forms.CheckBox cbZemeNarozeni;
        private System.Windows.Forms.CheckBox cbKlub;
        private System.Windows.Forms.CheckBox cbDatumNarozeni;
        private System.Windows.Forms.CheckBox cbLigaKlubu;
        private System.Windows.Forms.CheckBox cbPrijmeni;
        private System.Windows.Forms.CheckBox cbZemeKlubu;
        private System.Windows.Forms.CheckBox cbJmeno;
        private System.Windows.Forms.GroupBox gboxUlozit;
    }
}

