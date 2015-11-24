namespace Pigeon.Forms
{
    partial class ZadaniaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaZadańToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszUstawieniaTabeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.ZadaniaGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formularzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszUstawieniaTabeliToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Przypomnienie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wyprzedzenie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZadaniaGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaZadańToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // tabelaZadańToolStripMenuItem
            // 
            this.tabelaZadańToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszUstawieniaTabeliToolStripMenuItem});
            this.tabelaZadańToolStripMenuItem.Name = "tabelaZadańToolStripMenuItem";
            this.tabelaZadańToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.tabelaZadańToolStripMenuItem.Text = "Tabela zadań";
            // 
            // zapiszUstawieniaTabeliToolStripMenuItem
            // 
            this.zapiszUstawieniaTabeliToolStripMenuItem.Name = "zapiszUstawieniaTabeliToolStripMenuItem";
            this.zapiszUstawieniaTabeliToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.zapiszUstawieniaTabeliToolStripMenuItem.Text = "Zapisz ustawienia tabeli";
            this.zapiszUstawieniaTabeliToolStripMenuItem.Click += new System.EventHandler(this.zapiszUstawieniaTabeliToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nowe zadanie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZadaniaGrid
            // 
            this.ZadaniaGrid.AllowUserToAddRows = false;
            this.ZadaniaGrid.AllowUserToDeleteRows = false;
            this.ZadaniaGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZadaniaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZadaniaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nazwa,
            this.Opis,
            this.Data,
            this.Przypomnienie,
            this.Wyprzedzenie});
            this.ZadaniaGrid.Location = new System.Drawing.Point(0, 75);
            this.ZadaniaGrid.MultiSelect = false;
            this.ZadaniaGrid.Name = "ZadaniaGrid";
            this.ZadaniaGrid.ReadOnly = true;
            this.ZadaniaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ZadaniaGrid.Size = new System.Drawing.Size(599, 324);
            this.ZadaniaGrid.TabIndex = 2;
            this.ZadaniaGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZadaniaGrid_CellDoubleClick);
            this.ZadaniaGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZadaniaGrid_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularzToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.zapiszUstawieniaTabeliToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 70);
            // 
            // formularzToolStripMenuItem
            // 
            this.formularzToolStripMenuItem.Name = "formularzToolStripMenuItem";
            this.formularzToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.formularzToolStripMenuItem.Text = "Formularz";
            this.formularzToolStripMenuItem.Click += new System.EventHandler(this.formularzToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // zapiszUstawieniaTabeliToolStripMenuItem1
            // 
            this.zapiszUstawieniaTabeliToolStripMenuItem1.Name = "zapiszUstawieniaTabeliToolStripMenuItem1";
            this.zapiszUstawieniaTabeliToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.zapiszUstawieniaTabeliToolStripMenuItem1.Text = "Zapisz ustawienia tabeli";
            this.zapiszUstawieniaTabeliToolStripMenuItem1.Click += new System.EventHandler(this.zapiszUstawieniaTabeliToolStripMenuItem1_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Nazwa
            // 
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Przypomnienie
            // 
            this.Przypomnienie.DataPropertyName = "Przypomnienie";
            this.Przypomnienie.HeaderText = "Przypomnienie";
            this.Przypomnienie.Name = "Przypomnienie";
            this.Przypomnienie.ReadOnly = true;
            // 
            // Wyprzedzenie
            // 
            this.Wyprzedzenie.DataPropertyName = "Wyprzedzenie";
            this.Wyprzedzenie.HeaderText = "Wyprzedzenie";
            this.Wyprzedzenie.Name = "Wyprzedzenie";
            this.Wyprzedzenie.ReadOnly = true;
            // 
            // ZadaniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 399);
            this.Controls.Add(this.ZadaniaGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ZadaniaForm";
            this.Text = "Zadania";
            this.Load += new System.EventHandler(this.ZadaniaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZadaniaGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ZadaniaGrid;
        private System.Windows.Forms.ToolStripMenuItem tabelaZadańToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszUstawieniaTabeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formularzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszUstawieniaTabeliToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Przypomnienie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wyprzedzenie;
    }
}