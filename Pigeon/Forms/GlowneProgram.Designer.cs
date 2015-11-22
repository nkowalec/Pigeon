namespace Pigeon.Forms
{
    partial class GlowneProgram
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
            this.Opcje = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Zadania = new System.Windows.Forms.Button();
            this.Wiadomosci = new System.Windows.Forms.Button();
            this.Podmioty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Opcje
            // 
            this.Opcje.Image = global::Pigeon.Properties.Resources.configuration_edit;
            this.Opcje.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Opcje.Location = new System.Drawing.Point(12, 237);
            this.Opcje.Name = "Opcje";
            this.Opcje.Size = new System.Drawing.Size(230, 69);
            this.Opcje.TabIndex = 4;
            this.Opcje.Text = "Ustawienia\r\n(Zmień konfigurację)\r\n";
            this.Opcje.UseVisualStyleBackColor = true;
            this.Opcje.Click += new System.EventHandler(this.Opcje_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close.Image = global::Pigeon.Properties.Resources.Close1;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.Location = new System.Drawing.Point(12, 312);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(227, 69);
            this.Close.TabIndex = 3;
            this.Close.Text = "Zamknij\r\n(Zamyka program)\r\n";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Zadania
            // 
            this.Zadania.Image = global::Pigeon.Properties.Resources.task;
            this.Zadania.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Zadania.Location = new System.Drawing.Point(12, 162);
            this.Zadania.Name = "Zadania";
            this.Zadania.Size = new System.Drawing.Size(230, 69);
            this.Zadania.TabIndex = 2;
            this.Zadania.Text = "Zadania\r\n(Zarządzaj zadaniami)";
            this.Zadania.UseVisualStyleBackColor = true;
            // 
            // Wiadomosci
            // 
            this.Wiadomosci.Image = global::Pigeon.Properties.Resources.Envelope;
            this.Wiadomosci.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Wiadomosci.Location = new System.Drawing.Point(12, 87);
            this.Wiadomosci.Name = "Wiadomosci";
            this.Wiadomosci.Size = new System.Drawing.Size(230, 69);
            this.Wiadomosci.TabIndex = 1;
            this.Wiadomosci.Text = "Wiadomości\r\n(Wysłane i nowe)\r\n";
            this.Wiadomosci.UseVisualStyleBackColor = true;
            this.Wiadomosci.Click += new System.EventHandler(this.Wiadomosci_Click);
            // 
            // Podmioty
            // 
            this.Podmioty.BackColor = System.Drawing.SystemColors.Control;
            this.Podmioty.Image = global::Pigeon.Properties.Resources.person;
            this.Podmioty.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Podmioty.Location = new System.Drawing.Point(12, 12);
            this.Podmioty.Name = "Podmioty";
            this.Podmioty.Size = new System.Drawing.Size(230, 69);
            this.Podmioty.TabIndex = 0;
            this.Podmioty.Text = "Podmioty\r\n(Zarządzaj kontaktami)\r\n";
            this.Podmioty.UseVisualStyleBackColor = false;
            this.Podmioty.Click += new System.EventHandler(this.Podmioty_Click);
            // 
            // GlowneProgram
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(251, 390);
            this.Controls.Add(this.Opcje);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Zadania);
            this.Controls.Add(this.Wiadomosci);
            this.Controls.Add(this.Podmioty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(271, 433);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(271, 433);
            this.Name = "GlowneProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pigeon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Podmioty;
        private System.Windows.Forms.Button Wiadomosci;
        private System.Windows.Forms.Button Zadania;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Opcje;
    }
}