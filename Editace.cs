using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace I4_Janečka_Dinh_Skupinovka
{
    public partial class Editace : Form
    {
        int vaha, pozice, cisloDresu, zemeKlubu, ligaKlubu, klub, id;
        bool zlatyMic, zlataKopacka;
        public Editace(int Id,int Vaha, int Pozice, int CisloDresu, int  ZemeKlubu, int LigaKlubu, int Klub, bool ZlatyMic, bool ZlataKopacka)
        {
            InitializeComponent();
            id = Id;
            vaha = Vaha;
            pozice = Pozice;
            cisloDresu = CisloDresu;
            zemeKlubu = ZemeKlubu;
            ligaKlubu = LigaKlubu;
            klub = Klub;
            zlatyMic = ZlatyMic;
            zlataKopacka = ZlataKopacka;
        }

        private void Editace_Load(object sender, EventArgs e)
        {
            numVaha.Value = vaha;
            numCisloDresu.Value = cisloDresu;
            cbZlatyMic.Checked = zlatyMic;
            cbZlataKopacka.Checked = zlataKopacka;
            I4_Janečka_Dinh_Skupinovka.Menu.ComboBoxy("PoziceID", cmbPozice);
            I4_Janečka_Dinh_Skupinovka.Menu.ComboBoxy("KlubID", cmbKlub);
            I4_Janečka_Dinh_Skupinovka.Menu.ComboBoxy("LigaID", cmbLigaKlubu);
            I4_Janečka_Dinh_Skupinovka.Menu.ComboBoxy("ZemeID", cmbZemeKlubu);
            cmbPozice.SelectedIndex = pozice - 1;
            cmbKlub.SelectedIndex = klub - 3;
            cmbLigaKlubu.SelectedIndex = ligaKlubu - 1;
            cmbZemeKlubu.SelectedIndex = zemeKlubu - 1;
        }

        private void btUlozit_Click(object sender, EventArgs e)
        {
            try
            {
                string Prikaz = "UPDATE Fotbalista SET Vaha = " + numVaha.Value + ", CisloDresu = " + numCisloDresu.Value + ", Pozice = " + (cmbPozice.SelectedIndex + 1) +
                ", ZemeKlubu = " + (cmbZemeKlubu.SelectedIndex + 1) + ", LigaKlubu = " + (cmbLigaKlubu.SelectedIndex + 1) + ", Klub = " + (cmbKlub.SelectedIndex + 3) +
                ", ZlatyMic = " + MicAKopacka(cbZlatyMic) + ", ZlataKopacka = " + MicAKopacka(cbZlataKopacka) +
                "Where Id = " + id;
                SqlConnection connectionCommand = new SqlConnection(I4_Janečka_Dinh_Skupinovka.Menu.connectionString);
                connectionCommand.Open();
                SqlCommand prikaz = new SqlCommand(Prikaz, connectionCommand);
                prikaz.ExecuteNonQuery();
                connectionCommand.Close();
            }
            catch { MessageBox.Show("Chyba!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            this.Close();
        }

        private int MicAKopacka (CheckBox cb)
        {
            if (cb.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
