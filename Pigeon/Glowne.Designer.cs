namespace Pigeon
{
    partial class Glowne
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPodmiot = new System.Windows.Forms.Button();
            this.PodmiotyGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PodmiotyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddPodmiot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 37);
            this.panel1.TabIndex = 0;
            // 
            // AddPodmiot
            // 
            this.AddPodmiot.Location = new System.Drawing.Point(0, 0);
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
            this.PodmiotyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PodmiotyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PodmiotyGrid.Location = new System.Drawing.Point(0, 43);
            this.PodmiotyGrid.MultiSelect = false;
            this.PodmiotyGrid.Name = "PodmiotyGrid";
            this.PodmiotyGrid.ReadOnly = true;
            this.PodmiotyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PodmiotyGrid.Size = new System.Drawing.Size(691, 370);
            this.PodmiotyGrid.TabIndex = 1;
            this.PodmiotyGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PodmiotyGrid_CellDoubleClick);
            // 
            // Glowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 413);
            this.Controls.Add(this.PodmiotyGrid);
            this.Controls.Add(this.panel1);
            this.Name = "Glowne";
            this.Text = "Pigeon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PodmiotyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView PodmiotyGrid;
        private System.Windows.Forms.Button AddPodmiot;
    }
}

