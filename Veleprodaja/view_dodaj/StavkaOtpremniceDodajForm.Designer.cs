﻿namespace Veleprodaja.view_dodaj
{
    partial class StavkaOtpremniceDodajForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblKalIznos = new System.Windows.Forms.Label();
            this.lblKalVeleprodajni = new System.Windows.Forms.Label();
            this.lblKalRabat = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gbKalkulacija = new System.Windows.Forms.GroupBox();
            this.lblDobavljacKalkulacije = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblRedniBrojKalkulacije = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgStavke = new System.Windows.Forms.DataGridView();
            this.colObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRabat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCIjenaSaRabatom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVeleprodajnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIznosSaRabatom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIzmjeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPonistiUnos = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSifraRobe = new System.Windows.Forms.TextBox();
            this.gbIzabranaRoba = new System.Windows.Forms.GroupBox();
            this.lblRobaJedinicaMjere = new System.Windows.Forms.Label();
            this.lblRobaNaziv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbStavka = new System.Windows.Forms.GroupBox();
            this.tbxVeleprodajnaCijena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxRabat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxKolicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbKalkulacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavke)).BeginInit();
            this.gbIzabranaRoba.SuspendLayout();
            this.gbStavka.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnPonistiUnos);
            this.splitContainer1.Panel2.Controls.Add(this.btnDodaj);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tbxSifraRobe);
            this.splitContainer1.Panel2.Controls.Add(this.gbIzabranaRoba);
            this.splitContainer1.Panel2.Controls.Add(this.gbStavka);
            this.splitContainer1.Size = new System.Drawing.Size(801, 491);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 18;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.gbKalkulacija);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgStavke);
            this.splitContainer2.Size = new System.Drawing.Size(801, 276);
            this.splitContainer2.SplitterDistance = 118;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblKalIznos);
            this.groupBox1.Controls.Add(this.lblKalVeleprodajni);
            this.groupBox1.Controls.Add(this.lblKalRabat);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(491, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrijednost na kalkulaciji";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Iznos sa rabatom";
            // 
            // lblKalIznos
            // 
            this.lblKalIznos.AutoSize = true;
            this.lblKalIznos.Location = new System.Drawing.Point(124, 71);
            this.lblKalIznos.Name = "lblKalIznos";
            this.lblKalIznos.Size = new System.Drawing.Size(41, 13);
            this.lblKalIznos.TabIndex = 11;
            this.lblKalIznos.Text = "label20";
            // 
            // lblKalVeleprodajni
            // 
            this.lblKalVeleprodajni.AutoSize = true;
            this.lblKalVeleprodajni.Location = new System.Drawing.Point(124, 19);
            this.lblKalVeleprodajni.Name = "lblKalVeleprodajni";
            this.lblKalVeleprodajni.Size = new System.Drawing.Size(41, 13);
            this.lblKalVeleprodajni.TabIndex = 9;
            this.lblKalVeleprodajni.Text = "label18";
            // 
            // lblKalRabat
            // 
            this.lblKalRabat.AutoSize = true;
            this.lblKalRabat.Location = new System.Drawing.Point(124, 45);
            this.lblKalRabat.Name = "lblKalRabat";
            this.lblKalRabat.Size = new System.Drawing.Size(41, 13);
            this.lblKalRabat.TabIndex = 10;
            this.lblKalRabat.Text = "label19";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Rabat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Veleprodajni iznos:";
            // 
            // gbKalkulacija
            // 
            this.gbKalkulacija.Controls.Add(this.lblDobavljacKalkulacije);
            this.gbKalkulacija.Controls.Add(this.lblDatum);
            this.gbKalkulacija.Controls.Add(this.lblRedniBrojKalkulacije);
            this.gbKalkulacija.Controls.Add(this.label14);
            this.gbKalkulacija.Controls.Add(this.label13);
            this.gbKalkulacija.Controls.Add(this.label12);
            this.gbKalkulacija.Location = new System.Drawing.Point(12, 12);
            this.gbKalkulacija.Name = "gbKalkulacija";
            this.gbKalkulacija.Size = new System.Drawing.Size(409, 91);
            this.gbKalkulacija.TabIndex = 0;
            this.gbKalkulacija.TabStop = false;
            this.gbKalkulacija.Text = "Podaci o otpremnici";
            // 
            // lblDobavljacKalkulacije
            // 
            this.lblDobavljacKalkulacije.AutoSize = true;
            this.lblDobavljacKalkulacije.Location = new System.Drawing.Point(129, 71);
            this.lblDobavljacKalkulacije.Name = "lblDobavljacKalkulacije";
            this.lblDobavljacKalkulacije.Size = new System.Drawing.Size(41, 13);
            this.lblDobavljacKalkulacije.TabIndex = 5;
            this.lblDobavljacKalkulacije.Text = "label17";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(129, 45);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 4;
            this.lblDatum.Text = "label16";
            // 
            // lblRedniBrojKalkulacije
            // 
            this.lblRedniBrojKalkulacije.AutoSize = true;
            this.lblRedniBrojKalkulacije.Location = new System.Drawing.Point(129, 19);
            this.lblRedniBrojKalkulacije.Name = "lblRedniBrojKalkulacije";
            this.lblRedniBrojKalkulacije.Size = new System.Drawing.Size(67, 13);
            this.lblRedniBrojKalkulacije.TabIndex = 3;
            this.lblRedniBrojKalkulacije.Text = "tbxRedniBroj";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Dobavljac:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Datum:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Redni broj:";
            // 
            // dgStavke
            // 
            this.dgStavke.AllowUserToAddRows = false;
            this.dgStavke.AllowUserToDeleteRows = false;
            this.dgStavke.AllowUserToOrderColumns = true;
            this.dgStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStavke.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colObject,
            this.colNaziv,
            this.colKolicina,
            this.colRabat,
            this.colCIjenaSaRabatom,
            this.colVeleprodajnaCijena,
            this.Iznos,
            this.colIznosSaRabatom,
            this.colIzmjeni});
            this.dgStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStavke.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgStavke.Location = new System.Drawing.Point(0, 0);
            this.dgStavke.Name = "dgStavke";
            this.dgStavke.ReadOnly = true;
            this.dgStavke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgStavke.RowHeadersVisible = false;
            this.dgStavke.Size = new System.Drawing.Size(801, 154);
            this.dgStavke.TabIndex = 13;
            // 
            // colObject
            // 
            this.colObject.HeaderText = "Column1";
            this.colObject.Name = "colObject";
            this.colObject.ReadOnly = true;
            this.colObject.Visible = false;
            // 
            // colNaziv
            // 
            this.colNaziv.HeaderText = "Naziv";
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.ReadOnly = true;
            // 
            // colKolicina
            // 
            this.colKolicina.HeaderText = "Kolicina";
            this.colKolicina.Name = "colKolicina";
            this.colKolicina.ReadOnly = true;
            // 
            // colRabat
            // 
            this.colRabat.HeaderText = "Rabat";
            this.colRabat.Name = "colRabat";
            this.colRabat.ReadOnly = true;
            // 
            // colCIjenaSaRabatom
            // 
            this.colCIjenaSaRabatom.HeaderText = "Cijena sa rabatom";
            this.colCIjenaSaRabatom.Name = "colCIjenaSaRabatom";
            this.colCIjenaSaRabatom.ReadOnly = true;
            // 
            // colVeleprodajnaCijena
            // 
            this.colVeleprodajnaCijena.HeaderText = "Veleprodajna cijena";
            this.colVeleprodajnaCijena.Name = "colVeleprodajnaCijena";
            this.colVeleprodajnaCijena.ReadOnly = true;
            // 
            // Iznos
            // 
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // colIznosSaRabatom
            // 
            this.colIznosSaRabatom.HeaderText = "Iznos sa rabatom";
            this.colIznosSaRabatom.Name = "colIznosSaRabatom";
            this.colIznosSaRabatom.ReadOnly = true;
            // 
            // colIzmjeni
            // 
            this.colIzmjeni.HeaderText = "Izmjeni";
            this.colIzmjeni.Name = "colIzmjeni";
            this.colIzmjeni.ReadOnly = true;
            // 
            // btnPonistiUnos
            // 
            this.btnPonistiUnos.Location = new System.Drawing.Point(529, 145);
            this.btnPonistiUnos.Name = "btnPonistiUnos";
            this.btnPonistiUnos.Size = new System.Drawing.Size(75, 23);
            this.btnPonistiUnos.TabIndex = 19;
            this.btnPonistiUnos.Text = "Ponisti unos";
            this.btnPonistiUnos.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(657, 146);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 20);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj stavku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv robe";
            // 
            // tbxSifraRobe
            // 
            this.tbxSifraRobe.Location = new System.Drawing.Point(94, 12);
            this.tbxSifraRobe.Name = "tbxSifraRobe";
            this.tbxSifraRobe.Size = new System.Drawing.Size(200, 20);
            this.tbxSifraRobe.TabIndex = 2;
            this.tbxSifraRobe.Leave += new System.EventHandler(this.tbxSifraRobe_Leave);
            // 
            // gbIzabranaRoba
            // 
            this.gbIzabranaRoba.Controls.Add(this.lblRobaJedinicaMjere);
            this.gbIzabranaRoba.Controls.Add(this.lblRobaNaziv);
            this.gbIzabranaRoba.Controls.Add(this.label4);
            this.gbIzabranaRoba.Controls.Add(this.label3);
            this.gbIzabranaRoba.Location = new System.Drawing.Point(12, 49);
            this.gbIzabranaRoba.Name = "gbIzabranaRoba";
            this.gbIzabranaRoba.Size = new System.Drawing.Size(332, 104);
            this.gbIzabranaRoba.TabIndex = 4;
            this.gbIzabranaRoba.TabStop = false;
            this.gbIzabranaRoba.Text = "Izabrana roba";
            // 
            // lblRobaJedinicaMjere
            // 
            this.lblRobaJedinicaMjere.AutoSize = true;
            this.lblRobaJedinicaMjere.Location = new System.Drawing.Point(224, 57);
            this.lblRobaJedinicaMjere.Name = "lblRobaJedinicaMjere";
            this.lblRobaJedinicaMjere.Size = new System.Drawing.Size(35, 13);
            this.lblRobaJedinicaMjere.TabIndex = 6;
            this.lblRobaJedinicaMjere.Text = "label5";
            // 
            // lblRobaNaziv
            // 
            this.lblRobaNaziv.AutoSize = true;
            this.lblRobaNaziv.Location = new System.Drawing.Point(224, 35);
            this.lblRobaNaziv.Name = "lblRobaNaziv";
            this.lblRobaNaziv.Size = new System.Drawing.Size(35, 13);
            this.lblRobaNaziv.TabIndex = 3;
            this.lblRobaNaziv.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jedinica mjere:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Naziv:";
            // 
            // gbStavka
            // 
            this.gbStavka.Controls.Add(this.tbxVeleprodajnaCijena);
            this.gbStavka.Controls.Add(this.label7);
            this.gbStavka.Controls.Add(this.tbxRabat);
            this.gbStavka.Controls.Add(this.label6);
            this.gbStavka.Controls.Add(this.tbxKolicina);
            this.gbStavka.Controls.Add(this.label2);
            this.gbStavka.Location = new System.Drawing.Point(400, 12);
            this.gbStavka.Name = "gbStavka";
            this.gbStavka.Size = new System.Drawing.Size(338, 127);
            this.gbStavka.TabIndex = 18;
            this.gbStavka.TabStop = false;
            this.gbStavka.Text = "Podaci o stavki";
            // 
            // tbxVeleprodajnaCijena
            // 
            this.tbxVeleprodajnaCijena.Location = new System.Drawing.Point(129, 94);
            this.tbxVeleprodajnaCijena.Name = "tbxVeleprodajnaCijena";
            this.tbxVeleprodajnaCijena.Size = new System.Drawing.Size(203, 20);
            this.tbxVeleprodajnaCijena.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cijena";
            // 
            // tbxRabat
            // 
            this.tbxRabat.Location = new System.Drawing.Point(129, 57);
            this.tbxRabat.Name = "tbxRabat";
            this.tbxRabat.Size = new System.Drawing.Size(203, 20);
            this.tbxRabat.TabIndex = 7;
            this.tbxRabat.TextChanged += new System.EventHandler(this.tbxRabat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rabat";
            // 
            // tbxKolicina
            // 
            this.tbxKolicina.Location = new System.Drawing.Point(129, 22);
            this.tbxKolicina.Name = "tbxKolicina";
            this.tbxKolicina.Size = new System.Drawing.Size(203, 20);
            this.tbxKolicina.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kolicina";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrisiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // obrisiToolStripMenuItem
            // 
            this.obrisiToolStripMenuItem.Name = "obrisiToolStripMenuItem";
            this.obrisiToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.obrisiToolStripMenuItem.Text = "Obrisi";
            this.obrisiToolStripMenuItem.Click += new System.EventHandler(this.obrisiToolStripMenuItem_Click);
            // 
            // StavkaOtpremniceDodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 515);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StavkaOtpremniceDodajForm";
            this.Text = "StavkaOtpremniceDodajForm";
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbKalkulacija.ResumeLayout(false);
            this.gbKalkulacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavke)).EndInit();
            this.gbIzabranaRoba.ResumeLayout(false);
            this.gbIzabranaRoba.PerformLayout();
            this.gbStavka.ResumeLayout(false);
            this.gbStavka.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblKalIznos;
        private System.Windows.Forms.Label lblKalVeleprodajni;
        private System.Windows.Forms.Label lblKalRabat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbKalkulacija;
        private System.Windows.Forms.Label lblDobavljacKalkulacije;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblRedniBrojKalkulacije;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        protected System.Windows.Forms.DataGridView dgStavke;
        private System.Windows.Forms.Button btnPonistiUnos;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSifraRobe;
        private System.Windows.Forms.GroupBox gbIzabranaRoba;
        private System.Windows.Forms.Label lblRobaJedinicaMjere;
        private System.Windows.Forms.Label lblRobaNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbStavka;
        private System.Windows.Forms.TextBox tbxVeleprodajnaCijena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxRabat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRabat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCIjenaSaRabatom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVeleprodajnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIznosSaRabatom;
        private System.Windows.Forms.DataGridViewButtonColumn colIzmjeni;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
    }
}