﻿namespace Pigeon
{
    partial class PodmiotForm
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
            this.PodmiotTabs = new System.Windows.Forms.TabControl();
            this.OgólneTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.AdresyGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrDomu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrLokalu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodPocztowy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wojewodztwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KontaktyTab = new System.Windows.Forms.TabPage();
            this.KontaktyGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.AddKontakt = new System.Windows.Forms.Button();
            this.AddAdres = new System.Windows.Forms.Button();
            this.ID_kontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wartosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PodmiotTabs.SuspendLayout();
            this.OgólneTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdresyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.KontaktyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KontaktyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PodmiotTabs
            // 
            this.PodmiotTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PodmiotTabs.Controls.Add(this.OgólneTab);
            this.PodmiotTabs.Controls.Add(this.KontaktyTab);
            this.PodmiotTabs.Location = new System.Drawing.Point(0, 36);
            this.PodmiotTabs.Name = "PodmiotTabs";
            this.PodmiotTabs.SelectedIndex = 0;
            this.PodmiotTabs.Size = new System.Drawing.Size(547, 263);
            this.PodmiotTabs.TabIndex = 0;
            // 
            // OgólneTab
            // 
            this.OgólneTab.Controls.Add(this.label2);
            this.OgólneTab.Controls.Add(this.AdresyGrid);
            this.OgólneTab.Controls.Add(this.label3);
            this.OgólneTab.Controls.Add(this.pictureBox1);
            this.OgólneTab.Controls.Add(this.textBox1);
            this.OgólneTab.Controls.Add(this.label1);
            this.OgólneTab.Location = new System.Drawing.Point(4, 22);
            this.OgólneTab.Name = "OgólneTab";
            this.OgólneTab.Padding = new System.Windows.Forms.Padding(3);
            this.OgólneTab.Size = new System.Drawing.Size(539, 237);
            this.OgólneTab.TabIndex = 0;
            this.OgólneTab.Text = "Ogólne";
            this.OgólneTab.UseVisualStyleBackColor = true;
            this.OgólneTab.Enter += new System.EventHandler(this.OgólneTab_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adresy:";
            // 
            // AdresyGrid
            // 
            this.AdresyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdresyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.AdresyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdresyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Typ,
            this.Ulica,
            this.NrDomu,
            this.NrLokalu,
            this.KodPocztowy,
            this.Miasto,
            this.Wojewodztwo,
            this.Kraj});
            this.AdresyGrid.Location = new System.Drawing.Point(8, 66);
            this.AdresyGrid.MultiSelect = false;
            this.AdresyGrid.Name = "AdresyGrid";
            this.AdresyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdresyGrid.Size = new System.Drawing.Size(365, 163);
            this.AdresyGrid.TabIndex = 6;
            this.AdresyGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdresyGrid_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Typ
            // 
            this.Typ.DataPropertyName = "Typ";
            this.Typ.HeaderText = "Typ";
            this.Typ.Name = "Typ";
            this.Typ.Width = 50;
            // 
            // Ulica
            // 
            this.Ulica.DataPropertyName = "Ulica";
            this.Ulica.HeaderText = "Ulica";
            this.Ulica.Name = "Ulica";
            this.Ulica.Width = 56;
            // 
            // NrDomu
            // 
            this.NrDomu.DataPropertyName = "NrDomu";
            this.NrDomu.HeaderText = "Numer Domu";
            this.NrDomu.Name = "NrDomu";
            this.NrDomu.Width = 94;
            // 
            // NrLokalu
            // 
            this.NrLokalu.DataPropertyName = "NrLokalu";
            this.NrLokalu.HeaderText = "Numer Lokalu";
            this.NrLokalu.Name = "NrLokalu";
            this.NrLokalu.Width = 98;
            // 
            // KodPocztowy
            // 
            this.KodPocztowy.DataPropertyName = "KodPocztowy";
            this.KodPocztowy.HeaderText = "Kod Pocztowy";
            this.KodPocztowy.Name = "KodPocztowy";
            // 
            // Miasto
            // 
            this.Miasto.DataPropertyName = "Miasto";
            this.Miasto.HeaderText = "Miasto";
            this.Miasto.Name = "Miasto";
            this.Miasto.Width = 63;
            // 
            // Wojewodztwo
            // 
            this.Wojewodztwo.DataPropertyName = "Wojewodztwo";
            this.Wojewodztwo.HeaderText = "Województwo";
            this.Wojewodztwo.Name = "Wojewodztwo";
            this.Wojewodztwo.Width = 99;
            // 
            // Kraj
            // 
            this.Kraj.DataPropertyName = "Kraj";
            this.Kraj.HeaderText = "Kraj";
            this.Kraj.Name = "Kraj";
            this.Kraj.Width = 50;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(376, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zdjęcie:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(379, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa:";
            // 
            // KontaktyTab
            // 
            this.KontaktyTab.Controls.Add(this.KontaktyGrid);
            this.KontaktyTab.Location = new System.Drawing.Point(4, 22);
            this.KontaktyTab.Name = "KontaktyTab";
            this.KontaktyTab.Padding = new System.Windows.Forms.Padding(3);
            this.KontaktyTab.Size = new System.Drawing.Size(539, 237);
            this.KontaktyTab.TabIndex = 1;
            this.KontaktyTab.Text = "Kontakty";
            this.KontaktyTab.UseVisualStyleBackColor = true;
            this.KontaktyTab.Enter += new System.EventHandler(this.KontaktyTab_Enter);
            this.KontaktyTab.Leave += new System.EventHandler(this.KontaktyTab_Leave);
            // 
            // KontaktyGrid
            // 
            this.KontaktyGrid.AllowUserToAddRows = false;
            this.KontaktyGrid.AllowUserToDeleteRows = false;
            this.KontaktyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KontaktyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KontaktyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_kontakt,
            this.Nazwa,
            this.Wartosc});
            this.KontaktyGrid.Location = new System.Drawing.Point(3, 6);
            this.KontaktyGrid.MultiSelect = false;
            this.KontaktyGrid.Name = "KontaktyGrid";
            this.KontaktyGrid.ReadOnly = true;
            this.KontaktyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KontaktyGrid.Size = new System.Drawing.Size(530, 228);
            this.KontaktyGrid.TabIndex = 0;
            this.KontaktyGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KontaktyGrid_CellContentClick);
            this.KontaktyGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KontaktyGrid_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zapisz i zamknij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddKontakt
            // 
            this.AddKontakt.Location = new System.Drawing.Point(134, 2);
            this.AddKontakt.Name = "AddKontakt";
            this.AddKontakt.Size = new System.Drawing.Size(114, 29);
            this.AddKontakt.TabIndex = 1;
            this.AddKontakt.Text = "Nowy kontakt";
            this.AddKontakt.UseVisualStyleBackColor = true;
            this.AddKontakt.Visible = false;
            this.AddKontakt.Click += new System.EventHandler(this.AddKontakt_Click);
            // 
            // AddAdres
            // 
            this.AddAdres.Location = new System.Drawing.Point(134, 2);
            this.AddAdres.Name = "AddAdres";
            this.AddAdres.Size = new System.Drawing.Size(114, 29);
            this.AddAdres.TabIndex = 2;
            this.AddAdres.Text = "Nowy Adres";
            this.AddAdres.UseVisualStyleBackColor = true;
            this.AddAdres.Click += new System.EventHandler(this.AddAdres_Click);
            // 
            // ID_kontakt
            // 
            this.ID_kontakt.DataPropertyName = "Id";
            this.ID_kontakt.FillWeight = 18.27411F;
            this.ID_kontakt.HeaderText = "ID";
            this.ID_kontakt.Name = "ID_kontakt";
            this.ID_kontakt.ReadOnly = true;
            // 
            // Nazwa
            // 
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.FillWeight = 140.8629F;
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // Wartosc
            // 
            this.Wartosc.DataPropertyName = "Wartość";
            this.Wartosc.FillWeight = 140.8629F;
            this.Wartosc.HeaderText = "Wartość";
            this.Wartosc.Name = "Wartosc";
            this.Wartosc.ReadOnly = true;
            // 
            // PodmiotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 299);
            this.Controls.Add(this.AddAdres);
            this.Controls.Add(this.AddKontakt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PodmiotTabs);
            this.MinimumSize = new System.Drawing.Size(563, 338);
            this.Name = "PodmiotForm";
            this.Text = "Podmiot";
            this.Load += new System.EventHandler(this.PodmiotForm_Load);
            this.PodmiotTabs.ResumeLayout(false);
            this.OgólneTab.ResumeLayout(false);
            this.OgólneTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdresyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.KontaktyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KontaktyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PodmiotTabs;
        private System.Windows.Forms.TabPage OgólneTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage KontaktyTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView KontaktyGrid;
        private System.Windows.Forms.Button AddKontakt;
        private System.Windows.Forms.DataGridView AdresyGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulica;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrDomu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrLokalu;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodPocztowy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wojewodztwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_kontakt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wartosc;
    }
}