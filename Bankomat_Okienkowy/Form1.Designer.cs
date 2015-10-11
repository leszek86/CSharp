namespace Bankomat_Okienkowy
{
    partial class f_Bankomat
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_konfiguracja = new System.Windows.Forms.TabPage();
            this.btn_NextTab1 = new System.Windows.Forms.Button();
            this.txt_GornaGranica = new System.Windows.Forms.TextBox();
            this.lbl_GornaGranica = new System.Windows.Forms.Label();
            this.txt_DolnaGranica = new System.Windows.Forms.TextBox();
            this.lbl_DolnaGranica = new System.Windows.Forms.Label();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_waluta = new System.Windows.Forms.Label();
            this.cmb_waluta = new System.Windows.Forms.ComboBox();
            this.grbox_nominaly = new System.Windows.Forms.GroupBox();
            this.rdb_PrzedzialWybierany = new System.Windows.Forms.RadioButton();
            this.rdb_DomyslnyPrzedzial = new System.Windows.Forms.RadioButton();
            this.grbox_przedzialy = new System.Windows.Forms.GroupBox();
            this.tab_nominaly = new System.Windows.Forms.TabPage();
            this.btn_accept = new System.Windows.Forms.Button();
            this.lbl_wprowadzanie_kwoty = new System.Windows.Forms.Label();
            this.txt_kwota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_wyplata = new System.Windows.Forms.TabPage();
            this.btn_nastwyplata = new System.Windows.Forms.Button();
            this.btn_koniec = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.dgv_ListaWyplaty = new System.Windows.Forms.DataGridView();
            this.LiczbaWyplacanegoNominalu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiczbaWyplacanychNominalow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RodzajNominalu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waluta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.error_provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPodsumowanie = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_konfiguracja.SuspendLayout();
            this.grbox_nominaly.SuspendLayout();
            this.tab_nominaly.SuspendLayout();
            this.tab_wyplata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaWyplaty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_konfiguracja);
            this.tabControl1.Controls.Add(this.tab_nominaly);
            this.tabControl1.Controls.Add(this.tab_wyplata);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 494);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tab_konfiguracja
            // 
            this.tab_konfiguracja.BackColor = System.Drawing.Color.Silver;
            this.tab_konfiguracja.Controls.Add(this.btn_NextTab1);
            this.tab_konfiguracja.Controls.Add(this.txt_GornaGranica);
            this.tab_konfiguracja.Controls.Add(this.lbl_GornaGranica);
            this.tab_konfiguracja.Controls.Add(this.txt_DolnaGranica);
            this.tab_konfiguracja.Controls.Add(this.lbl_DolnaGranica);
            this.tab_konfiguracja.Controls.Add(this.lbl_title2);
            this.tab_konfiguracja.Controls.Add(this.lbl_title);
            this.tab_konfiguracja.Controls.Add(this.lbl_waluta);
            this.tab_konfiguracja.Controls.Add(this.cmb_waluta);
            this.tab_konfiguracja.Controls.Add(this.grbox_nominaly);
            this.tab_konfiguracja.Controls.Add(this.grbox_przedzialy);
            this.tab_konfiguracja.Location = new System.Drawing.Point(4, 22);
            this.tab_konfiguracja.Name = "tab_konfiguracja";
            this.tab_konfiguracja.Padding = new System.Windows.Forms.Padding(3);
            this.tab_konfiguracja.Size = new System.Drawing.Size(656, 468);
            this.tab_konfiguracja.TabIndex = 0;
            this.tab_konfiguracja.Text = "Konfiguracja";
            // 
            // btn_NextTab1
            // 
            this.btn_NextTab1.Location = new System.Drawing.Point(489, 168);
            this.btn_NextTab1.Name = "btn_NextTab1";
            this.btn_NextTab1.Size = new System.Drawing.Size(90, 33);
            this.btn_NextTab1.TabIndex = 10;
            this.btn_NextTab1.Text = "DALEJ";
            this.btn_NextTab1.UseVisualStyleBackColor = true;
            this.btn_NextTab1.Click += new System.EventHandler(this.btn_NextTab1_Click);
            // 
            // txt_GornaGranica
            // 
            this.txt_GornaGranica.Location = new System.Drawing.Point(248, 363);
            this.txt_GornaGranica.Name = "txt_GornaGranica";
            this.txt_GornaGranica.Size = new System.Drawing.Size(100, 20);
            this.txt_GornaGranica.TabIndex = 8;
            this.txt_GornaGranica.Visible = false;
            // 
            // lbl_GornaGranica
            // 
            this.lbl_GornaGranica.AutoSize = true;
            this.lbl_GornaGranica.Location = new System.Drawing.Point(248, 336);
            this.lbl_GornaGranica.Name = "lbl_GornaGranica";
            this.lbl_GornaGranica.Size = new System.Drawing.Size(102, 13);
            this.lbl_GornaGranica.TabIndex = 7;
            this.lbl_GornaGranica.Text = "Podaj górną granicę";
            this.lbl_GornaGranica.Visible = false;
            // 
            // txt_DolnaGranica
            // 
            this.txt_DolnaGranica.Location = new System.Drawing.Point(248, 298);
            this.txt_DolnaGranica.Name = "txt_DolnaGranica";
            this.txt_DolnaGranica.Size = new System.Drawing.Size(100, 20);
            this.txt_DolnaGranica.TabIndex = 6;
            this.txt_DolnaGranica.Visible = false;
            // 
            // lbl_DolnaGranica
            // 
            this.lbl_DolnaGranica.AutoSize = true;
            this.lbl_DolnaGranica.Location = new System.Drawing.Point(248, 271);
            this.lbl_DolnaGranica.Name = "lbl_DolnaGranica";
            this.lbl_DolnaGranica.Size = new System.Drawing.Size(101, 13);
            this.lbl_DolnaGranica.TabIndex = 5;
            this.lbl_DolnaGranica.Text = "Podaj dolną granicę";
            this.lbl_DolnaGranica.Visible = false;
            // 
            // lbl_title2
            // 
            this.lbl_title2.AutoSize = true;
            this.lbl_title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_title2.Location = new System.Drawing.Point(48, 44);
            this.lbl_title2.Name = "lbl_title2";
            this.lbl_title2.Size = new System.Drawing.Size(280, 13);
            this.lbl_title2.TabIndex = 4;
            this.lbl_title2.Text = "(wybór sposobu zliczania ilości nominałów w bankomacie)";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_title.Location = new System.Drawing.Point(48, 24);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(105, 20);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "BANKOMAT";
            // 
            // lbl_waluta
            // 
            this.lbl_waluta.AutoSize = true;
            this.lbl_waluta.Location = new System.Drawing.Point(49, 103);
            this.lbl_waluta.Name = "lbl_waluta";
            this.lbl_waluta.Size = new System.Drawing.Size(82, 13);
            this.lbl_waluta.TabIndex = 2;
            this.lbl_waluta.Text = "Wybierz walutę:";
            // 
            // cmb_waluta
            // 
            this.cmb_waluta.FormattingEnabled = true;
            this.cmb_waluta.Items.AddRange(new object[] {
            "PLN",
            "EUR",
            "USD"});
            this.cmb_waluta.Location = new System.Drawing.Point(52, 119);
            this.cmb_waluta.Name = "cmb_waluta";
            this.cmb_waluta.Size = new System.Drawing.Size(121, 21);
            this.cmb_waluta.TabIndex = 1;
            this.cmb_waluta.Text = "...";
            // 
            // grbox_nominaly
            // 
            this.grbox_nominaly.Controls.Add(this.rdb_PrzedzialWybierany);
            this.grbox_nominaly.Controls.Add(this.rdb_DomyslnyPrzedzial);
            this.grbox_nominaly.Location = new System.Drawing.Point(20, 156);
            this.grbox_nominaly.Name = "grbox_nominaly";
            this.grbox_nominaly.Size = new System.Drawing.Size(435, 55);
            this.grbox_nominaly.TabIndex = 0;
            this.grbox_nominaly.TabStop = false;
            this.grbox_nominaly.Text = "Wybierz sposób obliczania ilości nominałów w bankomacie";
            // 
            // rdb_PrzedzialWybierany
            // 
            this.rdb_PrzedzialWybierany.AutoSize = true;
            this.rdb_PrzedzialWybierany.Location = new System.Drawing.Point(210, 28);
            this.rdb_PrzedzialWybierany.Name = "rdb_PrzedzialWybierany";
            this.rdb_PrzedzialWybierany.Size = new System.Drawing.Size(209, 17);
            this.rdb_PrzedzialWybierany.TabIndex = 1;
            this.rdb_PrzedzialWybierany.TabStop = true;
            this.rdb_PrzedzialWybierany.Text = "Ilość wybierana z podanego przedziału";
            this.rdb_PrzedzialWybierany.UseVisualStyleBackColor = true;
            this.rdb_PrzedzialWybierany.Click += new System.EventHandler(this.rdb_PrzedzialWybierany_Click);
            // 
            // rdb_DomyslnyPrzedzial
            // 
            this.rdb_DomyslnyPrzedzial.AutoSize = true;
            this.rdb_DomyslnyPrzedzial.Location = new System.Drawing.Point(10, 28);
            this.rdb_DomyslnyPrzedzial.Name = "rdb_DomyslnyPrzedzial";
            this.rdb_DomyslnyPrzedzial.Size = new System.Drawing.Size(95, 17);
            this.rdb_DomyslnyPrzedzial.TabIndex = 0;
            this.rdb_DomyslnyPrzedzial.TabStop = true;
            this.rdb_DomyslnyPrzedzial.Text = "Domyślna ilość";
            this.rdb_DomyslnyPrzedzial.UseVisualStyleBackColor = true;
            this.rdb_DomyslnyPrzedzial.Click += new System.EventHandler(this.rdb_DomyslnyPrzedzial_Click);
            // 
            // grbox_przedzialy
            // 
            this.grbox_przedzialy.Location = new System.Drawing.Point(230, 237);
            this.grbox_przedzialy.Name = "grbox_przedzialy";
            this.grbox_przedzialy.Size = new System.Drawing.Size(225, 174);
            this.grbox_przedzialy.TabIndex = 11;
            this.grbox_przedzialy.TabStop = false;
            this.grbox_przedzialy.Text = "Podaj granicę ilości nominałów";
            this.grbox_przedzialy.Visible = false;
            // 
            // tab_nominaly
            // 
            this.tab_nominaly.BackColor = System.Drawing.Color.DarkSalmon;
            this.tab_nominaly.Controls.Add(this.btn_accept);
            this.tab_nominaly.Controls.Add(this.lbl_wprowadzanie_kwoty);
            this.tab_nominaly.Controls.Add(this.txt_kwota);
            this.tab_nominaly.Controls.Add(this.label1);
            this.tab_nominaly.Controls.Add(this.label2);
            this.tab_nominaly.Location = new System.Drawing.Point(4, 22);
            this.tab_nominaly.Name = "tab_nominaly";
            this.tab_nominaly.Padding = new System.Windows.Forms.Padding(3);
            this.tab_nominaly.Size = new System.Drawing.Size(656, 468);
            this.tab_nominaly.TabIndex = 1;
            this.tab_nominaly.Text = "Nominały";
            this.tab_nominaly.Click += new System.EventHandler(this.tab_nominaly_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(296, 165);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(90, 33);
            this.btn_accept.TabIndex = 9;
            this.btn_accept.Text = "AKCEPTACJA";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // lbl_wprowadzanie_kwoty
            // 
            this.lbl_wprowadzanie_kwoty.AutoSize = true;
            this.lbl_wprowadzanie_kwoty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_wprowadzanie_kwoty.Location = new System.Drawing.Point(48, 140);
            this.lbl_wprowadzanie_kwoty.Name = "lbl_wprowadzanie_kwoty";
            this.lbl_wprowadzanie_kwoty.Size = new System.Drawing.Size(178, 16);
            this.lbl_wprowadzanie_kwoty.TabIndex = 8;
            this.lbl_wprowadzanie_kwoty.Text = "Podaj kwotę do wypłaty:";
            // 
            // txt_kwota
            // 
            this.txt_kwota.Location = new System.Drawing.Point(84, 172);
            this.txt_kwota.Name = "txt_kwota";
            this.txt_kwota.Size = new System.Drawing.Size(100, 20);
            this.txt_kwota.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "(zarządzanie zliczaniem ilości nominałów w bankomacie)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "BANKOMAT";
            // 
            // tab_wyplata
            // 
            this.tab_wyplata.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tab_wyplata.Controls.Add(this.lblPodsumowanie);
            this.tab_wyplata.Controls.Add(this.btn_nastwyplata);
            this.tab_wyplata.Controls.Add(this.btn_koniec);
            this.tab_wyplata.Controls.Add(this.btn_Reset);
            this.tab_wyplata.Controls.Add(this.dgv_ListaWyplaty);
            this.tab_wyplata.Controls.Add(this.label3);
            this.tab_wyplata.Controls.Add(this.label4);
            this.tab_wyplata.Location = new System.Drawing.Point(4, 22);
            this.tab_wyplata.Name = "tab_wyplata";
            this.tab_wyplata.Padding = new System.Windows.Forms.Padding(3);
            this.tab_wyplata.Size = new System.Drawing.Size(656, 468);
            this.tab_wyplata.TabIndex = 2;
            this.tab_wyplata.Text = "Wypłata";
            // 
            // btn_nastwyplata
            // 
            this.btn_nastwyplata.Location = new System.Drawing.Point(94, 364);
            this.btn_nastwyplata.Name = "btn_nastwyplata";
            this.btn_nastwyplata.Size = new System.Drawing.Size(129, 33);
            this.btn_nastwyplata.TabIndex = 12;
            this.btn_nastwyplata.Text = "NASTĘPNA WYPŁATA";
            this.btn_nastwyplata.UseVisualStyleBackColor = true;
            this.btn_nastwyplata.Click += new System.EventHandler(this.btn_nastwyplata_Click);
            // 
            // btn_koniec
            // 
            this.btn_koniec.Location = new System.Drawing.Point(440, 364);
            this.btn_koniec.Name = "btn_koniec";
            this.btn_koniec.Size = new System.Drawing.Size(90, 33);
            this.btn_koniec.TabIndex = 11;
            this.btn_koniec.Text = "KONIEC";
            this.btn_koniec.UseVisualStyleBackColor = true;
            this.btn_koniec.Click += new System.EventHandler(this.btn_koniec_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(281, 364);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(90, 33);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "RESETUJ";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // dgv_ListaWyplaty
            // 
            this.dgv_ListaWyplaty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaWyplaty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LiczbaWyplacanegoNominalu,
            this.LiczbaWyplacanychNominalow,
            this.RodzajNominalu,
            this.Waluta});
            this.dgv_ListaWyplaty.Location = new System.Drawing.Point(34, 100);
            this.dgv_ListaWyplaty.Name = "dgv_ListaWyplaty";
            this.dgv_ListaWyplaty.ReadOnly = true;
            this.dgv_ListaWyplaty.Size = new System.Drawing.Size(593, 248);
            this.dgv_ListaWyplaty.TabIndex = 9;
            // 
            // LiczbaWyplacanegoNominalu
            // 
            this.LiczbaWyplacanegoNominalu.HeaderText = "Wartość wypłacanego nominału";
            this.LiczbaWyplacanegoNominalu.Name = "LiczbaWyplacanegoNominalu";
            this.LiczbaWyplacanegoNominalu.ReadOnly = true;
            this.LiczbaWyplacanegoNominalu.Width = 140;
            // 
            // LiczbaWyplacanychNominalow
            // 
            this.LiczbaWyplacanychNominalow.HeaderText = "Liczba wypłacanych nominałów";
            this.LiczbaWyplacanychNominalow.Name = "LiczbaWyplacanychNominalow";
            this.LiczbaWyplacanychNominalow.ReadOnly = true;
            this.LiczbaWyplacanychNominalow.Width = 150;
            // 
            // RodzajNominalu
            // 
            this.RodzajNominalu.HeaderText = "Rodzaj Nominału (banknot lub moneta)";
            this.RodzajNominalu.Name = "RodzajNominalu";
            this.RodzajNominalu.ReadOnly = true;
            this.RodzajNominalu.Width = 150;
            // 
            // Waluta
            // 
            this.Waluta.HeaderText = "Waluta";
            this.Waluta.Name = "Waluta";
            this.Waluta.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(46, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(wypłata gotówki)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(46, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "BANKOMAT";
            // 
            // error_provider
            // 
            this.error_provider.ContainerControl = this;
            // 
            // lblPodsumowanie
            // 
            this.lblPodsumowanie.AutoSize = true;
            this.lblPodsumowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodsumowanie.Location = new System.Drawing.Point(47, 81);
            this.lblPodsumowanie.Name = "lblPodsumowanie";
            this.lblPodsumowanie.Size = new System.Drawing.Size(23, 16);
            this.lblPodsumowanie.TabIndex = 14;
            this.lblPodsumowanie.Text = "---";
            // 
            // f_Bankomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 495);
            this.Controls.Add(this.tabControl1);
            this.Name = "f_Bankomat";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bankomat";
            this.tabControl1.ResumeLayout(false);
            this.tab_konfiguracja.ResumeLayout(false);
            this.tab_konfiguracja.PerformLayout();
            this.grbox_nominaly.ResumeLayout(false);
            this.grbox_nominaly.PerformLayout();
            this.tab_nominaly.ResumeLayout(false);
            this.tab_nominaly.PerformLayout();
            this.tab_wyplata.ResumeLayout(false);
            this.tab_wyplata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaWyplaty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_konfiguracja;
        private System.Windows.Forms.TabPage tab_nominaly;
        private System.Windows.Forms.TabPage tab_wyplata;
        private System.Windows.Forms.GroupBox grbox_nominaly;
        private System.Windows.Forms.RadioButton rdb_PrzedzialWybierany;
        private System.Windows.Forms.RadioButton rdb_DomyslnyPrzedzial;
        private System.Windows.Forms.Label lbl_waluta;
        private System.Windows.Forms.ComboBox cmb_waluta;
        private System.Windows.Forms.Label lbl_title2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_wprowadzanie_kwoty;
        private System.Windows.Forms.TextBox txt_kwota;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.DataGridView dgv_ListaWyplaty;
        private System.Windows.Forms.TextBox txt_GornaGranica;
        private System.Windows.Forms.Label lbl_GornaGranica;
        private System.Windows.Forms.TextBox txt_DolnaGranica;
        private System.Windows.Forms.Label lbl_DolnaGranica;
        private System.Windows.Forms.Button btn_NextTab1;
        private System.Windows.Forms.Button btn_koniec;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.GroupBox grbox_przedzialy;
        private System.Windows.Forms.ErrorProvider error_provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiczbaWyplacanegoNominalu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiczbaWyplacanychNominalow;
        private System.Windows.Forms.DataGridViewTextBoxColumn RodzajNominalu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waluta;
        private System.Windows.Forms.Button btn_nastwyplata;
        private System.Windows.Forms.Label lblPodsumowanie;
    }
}

