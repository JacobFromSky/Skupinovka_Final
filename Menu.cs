using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace I4_Janečka_Dinh_Skupinovka
{
    public partial class Menu : Form
    {
        public static string connectionString;
        SqlConnection connectionCommand;
        List<Fotbalista> listFotbalistu = new List<Fotbalista>();
        List<Fotbalista> listFiltrovanychFotbalistu;
        Fotbalista fotbalista;
        int index = -1;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Obnoveni();
        }

        private void Obnoveni()
        {
            lboxPolozky.SelectedIndex = -1;
            listFotbalistu.Clear();
            lboxPolozky.Items.Clear();
            try
            {
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\janeja\Downloads\I4_Janečka_Dinh_Skupinovka_Final\I4_Janečka_Dinh_Skupinovka\JJ_TD_Fotbalisti.mdf;Integrated Security=True;Connect Timeout=30";
                connectionCommand = new SqlConnection(connectionString);
                string selectionStringFotbalista = "SELECT * FROM [Fotbalista]";
                SqlCommand selectionCommand = new SqlCommand(selectionStringFotbalista, connectionCommand);
                connectionCommand.Open();
                SqlDataReader readCommand = selectionCommand.ExecuteReader();
                while (readCommand.Read())
                {
                    listFotbalistu.Add(fotbalista = new Fotbalista((int)readCommand["Id"], (string)readCommand["Jmeno"], (string)readCommand["Prijmeni"], (DateTime)readCommand["DatumNarozeni"], (int)readCommand[4], (int)readCommand[5], (int)readCommand[6], (bool)readCommand[7], (int)readCommand[8], (int)readCommand[9], (int)readCommand[10], (int)readCommand[11], (int)readCommand[12], (bool)readCommand[13], (bool)readCommand[14]));
                    lboxPolozky.Items.Add(readCommand["Jmeno"] + " " + readCommand["Prijmeni"]);
                }
                connectionCommand.Close();
            }
            catch{ MessageBox.Show("Chyba!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Blokace(List<Fotbalista> list) // Vypisuje informace o zvolené položce, pokud položka není vybrána tak vypisuje bez informací, povoluje a zakazuje tlačítka na smazání a editaci
        {
            if (index == -1)
            {
                btUpravit.Enabled = false;
                btSmazat.Enabled = false;
                lbDatumNarozeni.Text = "Datum narození: ?";
                lbZemeNarozeni.Text = "Země narození: ?";
                lbVyska.Text = "Výška(cm): ?";
                lbVaha.Text = "Váha(kg): ?";
                lbZemeKlubu.Text = "Země klubu: ?";
                lbLigaKlubu.Text = "Liga klubu: ?";
                lbKlub.Text = "Klub: ?";
                lbPozice.Text = "Pozice: ?";
                lbCisloDresu.Text = "Číslo dresu: ?";
                lbNoha.Text = "Pravá/levá noha: ?";
                lbZlatyMic.Text = "Zlatý míč: ?";
                lbZlataKopacka.Text = "Zlatá kopačka: ?";
            }
            else
            {
                btUpravit.Enabled = true;
                btSmazat.Enabled = true;
                lbDatumNarozeni.Text = "Datum narození: " + list[index].ZiskatDatumNarozeni(list[index].datumNarozeni);
                lbZemeNarozeni.Text = "Země narození: " + list[index].ConvertIndexToData(list[index].zemeNarozeniIndex, "ZemeID");
                lbVyska.Text = "Výška(cm): " + list[index].vyska;
                lbVaha.Text = "Váha(kg): " + list[index].vaha;
                lbZemeKlubu.Text = "Země klubu: " + list[index].ConvertIndexToData(list[index].zemeKlubuIndex, "ZemeID");
                lbLigaKlubu.Text = "Liga klubu: " + list[index].ConvertIndexToData(list[index].ligaKlubuIndex, "LigaID");
                lbKlub.Text = "Klub: " + list[index].ConvertIndexToData(list[index].klubIndex, "KlubID");
                lbPozice.Text = "Pozice: " + list[index].ConvertIndexToData(list[index].poziceIndex, "PoziceID");
                lbCisloDresu.Text = "Číslo dresu: " + list[index].cisloDresu;
                lbNoha.Text = "Pravá / levá noha: " + list[index].ZiskatNoha(list[index].pravaNoha);
                lbZlatyMic.Text = "Zlatý míč: " + list[index].ZiskatZlatyMic(list[index].zlatyMic);
                lbZlataKopacka.Text = "Zlaté kopačky: " + list[index].ZiskatZlataKopacka(list[index].zlataKopacka);
            }
        }

        private void lboxPolozky_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lboxPolozky.SelectedIndex;
            Blokace(listFotbalistu);
        }

        private void btNovaPolozka_Click(object sender, EventArgs e)
        {
            NovaPolozka novaPolozka = new NovaPolozka();
            novaPolozka.ShowDialog();
            Obnoveni();
            Blokace(listFotbalistu);
        }

        private void btSmazat_Click(object sender, EventArgs e)
        {
            try
            {
                string Prikaz = "DELETE FROM [Fotbalista]  WHERE Id = " + listFotbalistu[index].id;
                connectionCommand.Open();
                SqlCommand prikaz = new SqlCommand(Prikaz, connectionCommand);
                prikaz.ExecuteNonQuery();
                connectionCommand.Close();
            }
            catch{ MessageBox.Show("Chyba!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Obnoveni();
            Blokace(listFotbalistu);
        }

        private void btKonec_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btUpravit_Click(object sender, EventArgs e)
        {
            Editace Editace = new Editace(listFotbalistu[index].id, listFotbalistu[index].vaha, 
                listFotbalistu[index].poziceIndex, listFotbalistu[index].cisloDresu, listFotbalistu[index].zemeKlubuIndex, 
                listFotbalistu[index].ligaKlubuIndex, listFotbalistu[index].klubIndex, listFotbalistu[index].zlatyMic, listFotbalistu[index].zlataKopacka);
            Editace.ShowDialog();
            Obnoveni();
            Blokace(listFotbalistu);
        }

        public static void ComboBoxy(string nazevTabulky, ComboBox cmb)
        {
            try
            {
                string Prikaz = "SELECT * FROM" + " [" + nazevTabulky + "]"; ;
                SqlConnection connectionCommand = new SqlConnection(connectionString);
                connectionCommand.Open();
                SqlCommand prikaz = new SqlCommand(Prikaz, connectionCommand);
                SqlDataReader zaznamy = prikaz.ExecuteReader();
                while (zaznamy.Read())
                {
                    cmb.Items.Add(zaznamy[1].ToString());
                }
                connectionCommand.Close();
            }
            catch { MessageBox.Show("Chyba!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cbFiltrace_CheckedChanged(object sender, EventArgs e)
        {
            lboxPolozky.SelectedIndex = -1;
            lboxFiltr.SelectedIndex = -1;
            Blokace(listFotbalistu);
            if (cbFiltrace.Checked) 
            {
                ZakazAPovoleniOblastiPolozky(false, true);
                ComboBoxy("KlubID", cmbFiltraceKlub);
                ComboBoxy("LigaID", cmbFiltraceLigaKlubu);
                ComboBoxy("ZemeID", cmbFiltraceZemeNarozeni); 
                ComboBoxy("PoziceID", cmbFiltrPozice);
                for (int i = 0; i < listFotbalistu.Count; i++)
                {
                    lboxFiltr.Items.Add(listFotbalistu[i].jmeno + " " + listFotbalistu[i].prijmeni);
                }
                listFiltrovanychFotbalistu = new List<Fotbalista>(listFotbalistu);
            } 
            else 
            {
                ZakazAPovoleniOblastiPolozky(true,false);
                lboxFiltr.Items.Clear();
                ResetHodnotUFiltru();
                cmbFiltraceKlub.Items.Clear();
                cmbFiltraceLigaKlubu.Items.Clear();
                cmbFiltraceZemeNarozeni.Items.Clear();
                cmbFiltrPozice.Items.Clear();
            }
        }

        private void ZakazAPovoleniOblastiPolozky(bool zakazOblastiPolozky, bool zakazOblastiFiltr) 
        {
            gboxFiltrace.Enabled = zakazOblastiFiltr;
            lboxFiltr.Enabled = zakazOblastiFiltr;
            btNovaPolozka.Enabled = zakazOblastiPolozky;
            btUlozit.Enabled = zakazOblastiPolozky;
            lboxPolozky.Enabled = zakazOblastiPolozky;
        }

        private void ResetHodnotUFiltru()
        {
            listFiltrovanychFotbalistu = new List<Fotbalista>(listFotbalistu);
            lboxFiltr.Items.Clear();
            cmbFiltrPozice.SelectedIndex = -1;
            cmbFiltraceZemeNarozeni.SelectedIndex = -1;
            cmbFiltraceLigaKlubu.SelectedIndex = -1;
            cmbFiltraceKlub.SelectedIndex = -1;
            cbFiltrNoha.Checked = false;
            cbFiltrZlataKopacka.Checked = false;
            cbFiltrZlatyMic.Checked = false;
            rbFiltrLeva.Checked = false;
            rbFiltrPrava.Checked = false;
            cbOceneni.Checked = false;
            numMaxVaha.Value = numMaxVaha.Maximum;
            numMaxVyska.Value = numMaxVyska.Maximum;
            numMinVaha.Value = numMinVaha.Minimum;
            numMinVyska.Value = numMinVyska.Minimum;
            for (int i = 0; i < listFiltrovanychFotbalistu.Count; i++)
            {
                lboxFiltr.Items.Add(listFiltrovanychFotbalistu[i].jmeno + " " + listFiltrovanychFotbalistu[i].prijmeni);
            }
            Blokace(listFotbalistu);
        }

        private void btPouzit_Click(object sender, EventArgs e)
        {
            listFiltrovanychFotbalistu = new List<Fotbalista>(listFotbalistu);
            for (int i = 0; i < listFotbalistu.Count; i++)
            {
                if (cmbFiltrPozice.SelectedIndex == -1)
                {

                }
                else if (cmbFiltrPozice.SelectedIndex != listFotbalistu[i].poziceIndex - 1)
                {
                    listFiltrovanychFotbalistu.Remove(listFotbalistu[i]);
                }

                if (cmbFiltraceZemeNarozeni.SelectedIndex == -1)
                {

                }
                else if (cmbFiltraceZemeNarozeni.SelectedIndex != listFotbalistu[i].zemeNarozeniIndex - 1)
                {
                    listFiltrovanychFotbalistu.Remove(listFotbalistu[i]);
                }

                if (cmbFiltraceLigaKlubu.SelectedIndex == -1)
                {

                }
                else if (cmbFiltraceLigaKlubu.SelectedIndex != listFotbalistu[i].ligaKlubuIndex - 1)
                {
                    listFiltrovanychFotbalistu.Remove(listFotbalistu[i]);
                }

                if (cmbFiltraceKlub.SelectedIndex == -1)
                {

                }
                else if (cmbFiltraceKlub.SelectedIndex != listFotbalistu[i].klubIndex - 3)
                {
                    listFiltrovanychFotbalistu.Remove(listFotbalistu[i]);
                }

                if (numMinVyska.Value > listFotbalistu[i].vyska || numMaxVyska.Value < listFotbalistu[i].vyska)
                {
                    listFiltrovanychFotbalistu.Remove(listFotbalistu[i]);
                }

                if (numMinVaha.Value > listFotbalistu[i].vaha || numMaxVaha.Value < listFotbalistu[i].vaha)
                {
                    listFiltrovanychFotbalistu.Remove(listFotbalistu[i]);
                }

                if (cbFiltrNoha.Checked == true)
                {
                    if(rbFiltrPrava.Checked && listFotbalistu[i].pravaNoha == false)
                        listFiltrovanychFotbalistu.Remove(listFotbalistu[i]);
                    else if (rbFiltrLeva.Checked && listFotbalistu[i].pravaNoha == true)
                        listFiltrovanychFotbalistu.Remove(listFotbalistu[i]);
                }

                if (cbOceneni.Checked == true)
                {
                    if(cbFiltrZlatyMic.Checked && listFotbalistu[i].zlatyMic == false)
                        listFiltrovanychFotbalistu.Remove(listFotbalistu[i]);
                    else if (cbFiltrZlataKopacka.Checked && listFotbalistu[i].zlataKopacka == false)
                        listFiltrovanychFotbalistu.Remove(listFotbalistu[i]);
                }
            }

            lboxFiltr.Items.Clear();

            if (listFiltrovanychFotbalistu.Count == 0)
            {
                MessageBox.Show("Žádná položka neodpovídá danému filtru!", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            for (int i = 0; i < listFiltrovanychFotbalistu.Count; i++)
            {
                lboxFiltr.Items.Add(listFiltrovanychFotbalistu[i].jmeno + " " + listFiltrovanychFotbalistu[i].prijmeni);
            }

            index = -1;
            Blokace(listFiltrovanychFotbalistu);
        }

        private void btResetovat_Click(object sender, EventArgs e)
        {
            ResetHodnotUFiltru();
        }

        private void numerikyChybaChange(object sender, EventArgs e) // hlídá, aby minimální výška nebyla větší hodnota jak maximální výška
        {
            if (numMinVyska.Value > numMaxVyska.Value)
            {
                MessageBox.Show("Minimální výška nemůže být větší jak maximální výška!", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numMinVyska.Value = numMinVyska.Minimum;
                numMaxVyska.Value = numMaxVyska.Maximum;
            }

            if (numMinVaha.Value > numMaxVaha.Value)
            {
                MessageBox.Show("Minimální váha nemůže být větší jak maximální výška!", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numMinVaha.Value = numMinVaha.Minimum;
                numMaxVaha.Value = numMaxVaha.Maximum;
            }
        }

        private void cbFiltrNoha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFiltrNoha.Checked == true)
            {
                rbFiltrLeva.Enabled = true;
                rbFiltrPrava.Enabled = true;
            }
            else
            {
                rbFiltrLeva.Enabled = false;
                rbFiltrPrava.Enabled = false;
                rbFiltrLeva.Checked = false;
                rbFiltrPrava.Checked = false;
            }
        }

        private void cbOceneni_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOceneni.Checked == true)
            {
                cbFiltrZlataKopacka.Enabled = true;
                cbFiltrZlatyMic.Enabled = true;
            }
            else
            {
                cbFiltrZlataKopacka.Enabled = false;
                cbFiltrZlatyMic.Enabled = false;
                cbFiltrZlataKopacka.Checked = false;
                cbFiltrZlatyMic.Checked = false;
            }
        }

        private void lboxFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lboxFiltr.SelectedIndex;
            Blokace(listFiltrovanychFotbalistu);
        }

        private void TlacitkaUlozeni(bool zakaz)
        {
            lboxPolozky.Enabled = zakaz;
            cbFiltrace.Enabled = zakaz;

            btSmazat.Enabled = zakaz;
            btUpravit.Enabled = zakaz;
            btNovaPolozka.Enabled = zakaz;
            btUlozit.Enabled = zakaz;
            btKonec.Enabled = zakaz;
        }

        private void btUlozit_Click(object sender, EventArgs e)
        {
            lboxPolozky.SelectedIndex = -1;
            Blokace(listFotbalistu);
            TlacitkaUlozeni(false);
            gboxUlozit.Visible = true;
        }

        private void btPotvrditUlozeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter souborZapis = new StreamWriter(sfd.FileName, false, Encoding.UTF8);
                    souborZapis.WriteLine(Ulozeni());
                    souborZapis.Close();
                }
            }
            catch
            {
                MessageBox.Show("Chyba!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TlacitkaUlozeni(true);
            gboxUlozit.Visible = false;
        }

        private string Ulozeni()
        {
            string zahlavi = null;
            string zapis = null;

            for (int i = 0; i < listFotbalistu.Count; i++)
            {
                if (cbJmeno.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Jméno;";

                    zapis += listFotbalistu[i].jmeno + ";";
                }

                if (cbPrijmeni.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Přijmení;";

                    zapis += listFotbalistu[i].prijmeni + ";";
                }

                if (cbDatumNarozeni.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Datum narození;";

                    zapis += listFotbalistu[i].ZiskatDatumNarozeni(listFotbalistu[i].datumNarozeni) + ";";
                }

                if (cbZemeNarozeni.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Země narození;";

                    zapis += listFotbalistu[i].ConvertIndexToData(listFotbalistu[i].zemeNarozeniIndex, "ZemeID") + ";";
                }

                if (cbVyska.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Výška;";

                    zapis += listFotbalistu[i].vyska + ";";
                }

                if (cbVaha.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Váha;";

                    zapis += listFotbalistu[i].vaha + ";";
                }

                if (cbNoha.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Pravá noha;";

                    zapis += listFotbalistu[i].pravaNoha + ";";
                }

                if (cbPozice.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Pozice;";

                    zapis += listFotbalistu[i].ConvertIndexToData(listFotbalistu[i].poziceIndex, "PoziceID") + ";";
                }

                if (cbZemeKlubu.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Země klubu;";

                    zapis += listFotbalistu[i].ConvertIndexToData(listFotbalistu[i].zemeKlubuIndex, "ZemeID") + ";";
                }

                if (cbLigaKlubu.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Liga klubu;";

                    zapis += listFotbalistu[i].ConvertIndexToData(listFotbalistu[i].ligaKlubuIndex, "LigaID") + ";";
                }

                if (cbKlub.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Klub;";

                    zapis += listFotbalistu[i].ConvertIndexToData(listFotbalistu[i].klubIndex, "KlubID") + ";";
                }

                if (cbCisloDresu.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Číslo dresu;";

                    zapis += listFotbalistu[i].cisloDresu + ";";
                }

                if (cbZlatyMic.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Zlatý míč;";

                    zapis += listFotbalistu[i].zlatyMic.ToString() + ";";
                }

                if (cbZlataKopacka.Checked != false)
                {
                    if (i == 0)
                        zahlavi += "Zlatá kopačka;";

                    zapis += listFotbalistu[i].zlataKopacka.ToString() + ";";
                }
                if (i == 0)
                    zahlavi += Environment.NewLine;

                zapis += Environment.NewLine;
            }
            return zahlavi + zapis;
        }


        private void btZrušit_Click(object sender, EventArgs e)
        {
            TlacitkaUlozeni(true);
            gboxUlozit.Visible = false;
        }
    }
}
