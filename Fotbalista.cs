using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace I4_Janečka_Dinh_Skupinovka
{
    class Fotbalista
    {
        public string jmeno, prijmeni;
        public DateTime datumNarozeni;
        public int zemeNarozeniIndex, vyska, vaha, poziceIndex, zemeKlubuIndex, ligaKlubuIndex, klubIndex, cisloDresu, id;
        public bool pravaNoha, zlatyMic, zlataKopacka;

        public Fotbalista(int Id,string Jmeno, string Prijmeni, DateTime Datumnarozeni, int ZemeNarozeni, int Vyska, int Vaha, bool Pravanoha, int Pozice, int ZemeKlubu, int LigaKlubu, int Klub, int CisloDresu, bool Zlatymic, bool Zlatakopacka)
        {
            id = Id;
            jmeno = Jmeno;
            prijmeni = Prijmeni;
            datumNarozeni = Datumnarozeni;
            zemeNarozeniIndex = ZemeNarozeni;
            vyska = Vyska;
            vaha = Vaha;
            pravaNoha = Pravanoha;
            poziceIndex = Pozice;
            zemeKlubuIndex = ZemeKlubu;
            ligaKlubuIndex = LigaKlubu;
            klubIndex = Klub;
            cisloDresu = CisloDresu;
            zlatyMic = Zlatymic;
            zlataKopacka = Zlatakopacka;
        }

        public string ConvertIndexToData(int index, string nazevTabulky)
        {
            string vysledek = "";
            try
            {
                string connectionString = Menu.connectionString;
                SqlConnection connectionCommand = new SqlConnection(connectionString);
                string selectionString = "SELECT * FROM" + " [" + nazevTabulky + "]";
                SqlCommand selectionCommand = new SqlCommand(selectionString, connectionCommand);
                connectionCommand.Open();
                SqlDataReader readCommand = selectionCommand.ExecuteReader();
                while (readCommand.Read())
                {
                    if (index == Convert.ToInt32(readCommand[0]))
                    {
                        vysledek = readCommand[1].ToString();
                    }
                }
            }
            catch { MessageBox.Show("Chyba!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return vysledek;
        }

        public string ZiskatDatumNarozeni(DateTime datumnarozeni)
        {
            string vysledek = "";

            vysledek = Convert.ToString(datumnarozeni.Day + "." + datumnarozeni.Month + "." + datumnarozeni.Year);

            return vysledek;

        }

        public string ZiskatNoha(bool noha)
        {
            string vysledek = "";

            if (noha)
                vysledek = "Pravá";
            else
                vysledek = "Levá";
                return vysledek;
        }
        public string ZiskatZlatyMic(bool zlatymic)
        {
            string vysledek = "";

            if (zlatymic)
                vysledek = "Ano";
            else
                vysledek = "Ne";
            return vysledek;
        }
        public string ZiskatZlataKopacka(bool zlatakopacka)
        {
            string vysledek = "";

            if (zlatakopacka)
                vysledek = "Ano";
            else
                vysledek = "Ne";
            return vysledek;
        }
    }
}
