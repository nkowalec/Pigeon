namespace Pigeon
{
    partial class PodmiotyGlowne
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPodmiot = new System.Windows.Forms.Button();
            this.PodmiotyGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formularzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszUstawieniaTabeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PodmiotyGrid)).BeginInit();
            this.CxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddPodmiot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 48);
            this.panel1.TabIndex = 0;
            // 
            // AddPodmiot
            // 
            this.AddPodmiot.Location = new System.Drawing.Point(4, 3);
            this.AddPodmiot.Name = "AddPodmiot";
            this.AddPodmiot.Size = new System.Drawing.Size(134, 37);
            this.AddPodmiot.TabIndex = 0;
            this.AddPodmiot.Text = "Nowy Podmiot";
            this.AddPodmiot.UseVisualStyleBackColor = true;
            this.AddPodmiot.Click += new System.EventHandler(this.AddPodmiot_Click);
            // 
            // PodmiotyGrid
            // 
            this.PodmiotyGrid.AllowUserToAddRows = false;
            this.PodmiotyGrid.AllowUserToDeleteRows = false;
            this.PodmiotyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PodmiotyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PodmiotyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PodmiotyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nazwa});
            this.PodmiotyGrid.Location = new System.Drawing.Point(0, 43);
            this.PodmiotyGrid.MultiSelect = false;
            this.PodmiotyGrid.Name = "PodmiotyGrid";
            this.PodmiotyGrid.ReadOnly = true;
            this.PodmiotyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PodmiotyGrid.Size = new System.Drawing.Size(691, 370);
            this.PodmiotyGrid.TabIndex = 1;
            this.PodmiotyGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PodmiotyGrid_CellDoubleClick);
            this.PodmiotyGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PodmiotyGrid_MouseDown);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.FillWeight = 15.22843F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nazwa
            // 
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.FillWeight = 184.7716F;
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // CxMenu
            // 
            this.CxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularzToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.zapiszUstawieniaTabeliToolStripMenuItem});
            this.CxMenu.Name = "CxMenu";
            this.CxMenu.Size = new System.Drawing.Size(199, 92);
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
            // zapiszUstawieniaTabeliToolStripMenuItem
            // 
            this.zapiszUstawieniaTabeliToolStripMenuItem.Name = "zapiszUstawieniaTabeliToolStripMenuItem";
            this.zapiszUstawieniaTabeliToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.zapiszUstawieniaTabeliToolStripMenuItem.Text = "Zapisz ustawienia tabeli";
            this.zapiszUstawieniaTabeliToolStripMenuItem.Click += new System.EventHandler(this.zapiszUstawieniaTabeliToolStripMenuItem_Click);
            // 
            // PodmiotyGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 406);
            this.Controls.Add(this.PodmiotyGrid);
            this.Controls.Add(this.panel1);
            this.Name = "PodmiotyGlowne";
            this.Text = "Podmioty";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PodmiotyGrid)).EndInit();
            this.CxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddPodmiot;
        private System.Windows.Forms.DataGridView PodmiotyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.ContextMenuStrip CxMenu;
        private System.Windows.Forms.ToolStripMenuItem formularzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszUstawieniaTabeliToolStripMenuItem;
    }
}

