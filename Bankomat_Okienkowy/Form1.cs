using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat_Okienkowy
{
    public partial class f_Bankomat : Form
    {
        string err_string;
        bool tab2_access = false;
        bool tab3_access = false;
        int? DGLPN, GGLPN;
        float[,] tl_nominaly = {{ 10, 200 }, { 10, 100 }, { 10, 50 }, { 10, 20 }, { 10, 10 }, { 10, 5 }, { 10, 2 }, { 10, 1 }, { 10, 0.5f }};
        float[,] tl_nominalyPLN = { { 10, 200 }, { 10, 100 }, { 10, 50 }, { 10, 20 }, { 10, 10 }, { 10, 5 }, { 10, 2 }, { 10, 1 }, { 10, 0.5f } };
        float[,] tl_nominalyEUR = { { 10, 200 }, { 10, 100 }, { 10, 50 }, { 10, 20 }, { 10, 10 }, { 10, 5 }, { 10, 2 }, { 10, 1 }, { 10, 0.5f } };
        float[,] tl_nominalyUSD = { { 10, 200 }, { 10, 100 }, { 10, 50 }, { 10, 20 }, { 10, 10 }, { 10, 5 }, { 10, 2 }, { 10, 1 }, { 10, 0.5f } };
        string[] typyNominalow;
        string[] typyNominalowPLN = { "Banknot", "Banknot", "Banknot", "Banknot", "Banknot", "Moneta", "Moneta", "Moneta", "Moneta" };
        string[] typyNominalowEUR = { "Banknot", "Banknot", "Banknot", "Banknot", "Banknot", "Banknot", "Moneta", "Moneta", "Moneta" };
        string[] typyNominalowUSD = { "Banknot", "Banknot", "Banknot", "Banknot", "Banknot", "Banknot", "Banknot", "Banknot", "Moneta" };

        public f_Bankomat()
        {

            InitializeComponent();

        }

        private void tab_nominaly_Click(object sender, EventArgs e)
        {
            //if (tab2_access == false) tabControl1.SelectedTab = tab_konfiguracja;
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            float tl_ResztaDoWyplaty, tl_KwotaDoWyplaty = 0;
            int tl_Index = 0;
            int table_index = 0;

            //przypisanie odpowiedniej tablicy nominalów w zależności od wybranej waluty

            switch (cmb_waluta.Text)
            {
                case "PLN":
                    //if (rdb_PrzedzialWybierany.Checked == true) tl_nominaly = tl_nominalyPLN;
                    typyNominalow = typyNominalowPLN;
                    break;
                case "EUR":
                    //if (rdb_PrzedzialWybierany.Checked == true) tl_nominaly = tl_nominalyEUR;
                    typyNominalow = typyNominalowEUR;
                    break;
                case "USD":
                   // if (rdb_PrzedzialWybierany.Checked == true) tl_nominaly = tl_nominalyUSD;
                    typyNominalow = typyNominalowUSD;
                    break;
            }


            try
                {
                    float.Parse(txt_kwota.Text); //sprawdzanie czy wpisana kwota jest prawidłowa
                }
            catch (Exception)
                {
                    MessageBox.Show("Wprowadzona kwota jest błędna. Wprowadź ponownie.", "Wystąpił błąd");
                }

            if (float.TryParse(txt_kwota.Text, out tl_KwotaDoWyplaty))
            { 
                //sprawdzanie czy jest wystarczająca ilość pieniędzy w bankomacie
                tl_KwotaDoWyplaty = float.Parse(txt_kwota.Text);
                tl_ResztaDoWyplaty = float.Parse(txt_kwota.Text);
                tl_Index = 0;
                //pętla do przeliczenia wypłaty
                while (tl_ResztaDoWyplaty > 0 && tl_Index < tl_nominaly.GetLength(0))
                {//wyznaczanie liczby nominałów o wartości Nominały[Index]
                    float tl_LiczbaNominalow;
                    tl_LiczbaNominalow = (int)(tl_ResztaDoWyplaty / tl_nominaly[tl_Index, 1]);//obliczanie ile banknotów wypłacić

                    //sprawdzanie czy mamy wystarczającą ilość banknotów o danym nominale w bankomacie
                    if (tl_LiczbaNominalow > tl_nominaly[tl_Index, 0])
                    {
                        tl_LiczbaNominalow = tl_nominaly[tl_Index, 0]; //wypłacamy tyle ile mamy
                    }
                    tl_ResztaDoWyplaty = tl_ResztaDoWyplaty - (tl_LiczbaNominalow * tl_nominaly[tl_Index, 1]);//zmniejszanie kwoty do wypłacenia
                    tl_Index++;
                }

                if (tl_ResztaDoWyplaty > 0) //jeśli > 0 tzn że została kwota  do wypłacenia ale bankomat nie ma już gotówki
                {
                    MessageBox.Show("Bankomat nie ma tyle gotówki. Wprowadź mniejszą kwotę.", "Wystąpił Błąd");
                }

                else //kod uruchamiany jeśli bankomat ma wystarczającą ilość pieniędzy (ta sama pętla jeszcze raz)
                {
                    tl_ResztaDoWyplaty = tl_KwotaDoWyplaty; //resetowanie wartości
                    tl_Index = 0; //resetowanie licznika
                    lblPodsumowanie.Text = "Wypłacanie kwoty "+ cmb_waluta.Text + " " + txt_kwota.Text + ":";

                    while ((tl_ResztaDoWyplaty > 0) && (tl_Index < tl_nominaly.GetLength(0)))
                    {//wyznaczanie liczby nominałów o wartości Nominały[Index]
                        float tl_LiczbaNominalow;
                        tl_LiczbaNominalow = (int)(tl_ResztaDoWyplaty / tl_nominaly[tl_Index, 1]);//obliczanie ile banknotów wypłacić

                        //sprawdzanie czy mamy wystarczającą ilość banknotów o danym nominale w bankomacie
                        if (tl_LiczbaNominalow > tl_nominaly[tl_Index, 0])
                        {
                            tl_LiczbaNominalow = tl_nominaly[tl_Index, 0]; //wypłacamy tylko taką ilość jaką mamy w bankomacie
                        }

                        //wypisanie wypłaty na ostatniej zakładce
                        if (tl_LiczbaNominalow > 0) //&& (tl_Index < tl_nominaly.GetLength(0)))
                        {
                            //zmienna table_index została wprowadzona osobno w odróżnieniu od tl_Index ze względu na to że
                            //nie każde przekręcenie pętli jest wyświetlane w tablicy na 3ciej zakładce
                            //wyświetlane są tylko rekordy gdzie tl_Nominaly > 0
                            dgv_ListaWyplaty.Rows.Add();
                            dgv_ListaWyplaty.Rows[table_index].Cells[0].Value = tl_LiczbaNominalow;
                            dgv_ListaWyplaty.Rows[table_index].Cells[1].Value = tl_nominaly[tl_Index, 1];
                            dgv_ListaWyplaty.Rows[table_index].Cells[2].Value = typyNominalow[tl_Index]; //wpisywanie waluty
                            //if (tl_nominaly[tl_Index, 1] < 10) dgv_ListaWyplaty.Rows[table_index].Cells[2].Value = "Moneta";//stary kod do waluty
                            //else dgv_ListaWyplaty.Rows[table_index].Cells[2].Value = "Banknot";                             //stary kod do waluty
                            dgv_ListaWyplaty.Rows[table_index].Cells[3].Value = cmb_waluta.Text;
                            table_index++;
                        }

                            //pomniejszanie kwoty i liczby nominałów do wypłaty
                            tl_ResztaDoWyplaty = tl_ResztaDoWyplaty - (tl_LiczbaNominalow * tl_nominaly[tl_Index, 1]);//zmniejszanie kwoty
                            tl_nominaly[tl_Index, 0] = tl_nominaly[tl_Index, 0] - tl_LiczbaNominalow;//zmniejszanie liczby nominałów
                            tl_Index++;
                        }
                    

                    tab3_access = true;
                    tab2_access = false;
                    tabControl1.SelectedTab = tab_wyplata;
                }
            }
        }

        private void btn_NextTab1_Click(object sender, EventArgs e) //kliknięcie przycisku DALEJ na pierwszej zakładce
        {
            err_string = "";    
            //sprawdzanie czy waluta jest wybrana
                if (cmb_waluta.Text == "...")
                {
                    err_string = "Nie wybrałeś waluty!";
                    error_provider.SetError(cmb_waluta, "Wybierz walutę!");
                }

                //sprawdzanie czy wybór przedziału jest kliknięty
                if (rdb_DomyslnyPrzedzial.Checked == false && rdb_PrzedzialWybierany.Checked == false)
                {
                    err_string += Environment.NewLine + "Nie wybrałeś opcji przedziałów!";
                }

                //sprawdzanie czy granice przedziału są dobrze wpisane
                if (rdb_PrzedzialWybierany.Checked == true)
                {


                    //sprawdzanie wartosci dolnej granicy
                    try
                    {
                        //DGLPN = Convert.ToInt32(txt_DolnaGranica.Text);// -- dla wartości NULL convert nie wyrzuci błędu
                        //dlatego potrzebna opcja Parse
                       DGLPN = Int32.Parse(txt_DolnaGranica.Text);
                    }
                    catch (Exception)
                    {
                        err_string += Environment.NewLine + "Dolna Granica musi być liczbą całkowitą większą od zera!";
                    }
                    //sprawdzanie wartosci gornej granicy            

                    try
                    {
                        //GGLPN = Convert.ToInt32(txt_GornaGranica.Text); -- dla wartości null, convert nie wyrzuci błędu
                        //dlatego potrzebna opcja Parse
                        GGLPN = Int32.Parse(txt_GornaGranica.Text);
                    }
                    catch (Exception)
                    {
                        err_string += Environment.NewLine + "Górna Granica musi być liczbą całkowitą większą od zera!";
                    }

                    if (txt_DolnaGranica.Text == "" || txt_DolnaGranica.Text == null)
                    {
                        error_provider.SetError(txt_DolnaGranica, "Podaj wartość dolnej granicy!");
                    }
                    if (txt_GornaGranica.Text == "" || txt_GornaGranica.Text == null)
                    {
                        error_provider.SetError(txt_GornaGranica, "Podaj wartość górnej granicy!");
                    }
                }

                //sprawdzanie czy DGLPN < GGLPN

                if (string.IsNullOrEmpty(txt_DolnaGranica.Text) == false && string.IsNullOrWhiteSpace(txt_DolnaGranica.Text) == false && 
                    string.IsNullOrEmpty(txt_GornaGranica.Text) == false && string.IsNullOrWhiteSpace(txt_GornaGranica.Text) == false)
                    
                {
                    //DGLPN = Convert.ToInt32(txt_DolnaGranica.Text);
                    //GGLPN = Convert.ToInt32(txt_GornaGranica.Text);

                    if (DGLPN >= GGLPN)
                    {
                        err_string += Environment.NewLine + "Górna granica musi być większa od dolnej!";
                    }
                }

                //Msg Box jeśli wartości są nieprawidłowe
                if (err_string != "" && err_string != null) MessageBox.Show(err_string, "Wystąpił błąd!");
                //err_string = "";


            //obliczanie ilości nominałów
                if (err_string == "" || err_string == null)
                {
                    tab2_access = true;
                    // System.EventHandler = false;
                    tabControl1.SelectedTab = tab_nominaly;
                }
                if (rdb_DomyslnyPrzedzial.Checked == true) //jeśli odhaczony radio button 'przedział domyślny'
                {
                    //tl_nominaly = {{10,200}, {10,100}, {10, 50}, {10,20}, {10,10}, {10,5}, {10, 2}, {10,1}, {10, 0.5f}}
                }
                else if (rdb_PrzedzialWybierany.Checked == true) //jeśli odhaczony radio button 'przedział wybierany'
                {
                    //generowanie liczności poszczególnych nominałów
                    Random Rnd = new Random(); // utworzenie egzemplarza generatora liczb losowych z przedziału (0,1)

                    for (int k = 0; k < tl_nominaly.GetLength(0); k++)
                        tl_nominaly[k, 0] = (int)(Rnd.NextDouble() * (GGLPN - DGLPN) + DGLPN);
                }
        }

        private void rdb_PrzedzialWybierany_Click(object sender, EventArgs e)
        {
            //wyświetlanie text boxów do wprowadzenia wartości dolnej i górnej granicy
            //text boxy są domyślnie ustawione jako niewidoczne

            lbl_DolnaGranica.Visible = true;
            txt_DolnaGranica.Visible = true;
            lbl_GornaGranica.Visible = true;
            txt_GornaGranica.Visible = true;
        }

        private void rdb_DomyslnyPrzedzial_Click(object sender, EventArgs e)
        {
            //chowanie text boxów do wprowadzenia wartości dolnej i górnej granic

            if (lbl_DolnaGranica.Visible == true) lbl_DolnaGranica.Visible = false;
            if (txt_DolnaGranica.Visible == true) txt_DolnaGranica.Visible = false;
            if (lbl_GornaGranica.Visible == true) lbl_GornaGranica.Visible = false;
            if (txt_GornaGranica.Visible == true) txt_GornaGranica.Visible = false;
            txt_GornaGranica.Text = "";
            txt_DolnaGranica.Text = "";
        }


        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {   
            //kod do blokowania zakładek jeśli proces w poprzedniej zakładce nie został zakończony
            //if (tab2_access == false) e.Cancel = true;
            //if (tab2_access == true && tab3_access == false)
            //{
            //    tabControl1.SelectedTab = tab_nominaly;
            //    e.Cancel = true;
            //}

        }

        private void btn_koniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            var odp = MessageBox.Show("Nastąpi wyczyszczenie wszystkich wybranych opcji!" + Environment.NewLine + "Kontynuować?", "Uwaga!",MessageBoxButtons.YesNo);
            if (odp == DialogResult.Yes)
                    { 
                    //powrót do pierwszej zakładki
                    tabControl1.SelectedTab = tab_konfiguracja;
                    //resetowanie wszystkich wartości wprowadzonych przez użytkownika
                    cmb_waluta.Text = "";
                    lbl_DolnaGranica.Visible = false;
                    txt_DolnaGranica.Visible = false;
                    lbl_GornaGranica.Visible = false;
                    txt_GornaGranica.Visible = false;
                    txt_GornaGranica.Text = "";
                    txt_DolnaGranica.Text = "";
                    rdb_DomyslnyPrzedzial.Checked = false;
                    rdb_PrzedzialWybierany.Checked = false;
                    txt_kwota.Text = "";
                    dgv_ListaWyplaty.Rows.Clear();

                for (int z = 0; z < tl_nominaly.GetLength(0); z++)
                {
                    tl_nominaly[z, 0] = 10;
                }
        }             
        }

        private void btn_nastwyplata_Click(object sender, EventArgs e)
        {
            var odp = MessageBox.Show("Nastąpi przejście do okna wyboru kolejnej kwoty do wypłaty" + Environment.NewLine + "Kontynuować?", "Uwaga!", MessageBoxButtons.YesNo);
            if (odp == DialogResult.Yes)
            {
                //powrót do pierwszej zakładki
                tabControl1.SelectedTab = tab_nominaly;
                //resetowanie wartości kwoty oraz tabelki z wypłatą
                txt_kwota.Text = "";
                dgv_ListaWyplaty.Rows.Clear();
            }
        }
    }
}
