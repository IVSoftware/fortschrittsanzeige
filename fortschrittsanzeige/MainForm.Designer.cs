namespace fortschrittsanzeige
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Vorname = new System.Windows.Forms.TextBox();
            this.Nachname = new System.Windows.Forms.TextBox();
            this.PLZ = new System.Windows.Forms.TextBox();
            this.Wohnort = new System.Windows.Forms.TextBox();
            this.Hausnummer = new System.Windows.Forms.TextBox();
            this.Straße = new System.Windows.Forms.TextBox();
            this.Fortschrittsanzeige = new System.Windows.Forms.ProgressBar();
            this.Sendebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vorname
            // 
            this.Vorname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vorname.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vorname.Location = new System.Drawing.Point(30, 14);
            this.Vorname.Margin = new System.Windows.Forms.Padding(5);
            this.Vorname.Name = "Vorname";
            this.Vorname.PlaceholderText = "Vorname";
            this.Vorname.Size = new System.Drawing.Size(350, 45);
            this.Vorname.TabIndex = 0;
            // 
            // Nachname
            // 
            this.Nachname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nachname.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nachname.Location = new System.Drawing.Point(30, 69);
            this.Nachname.Margin = new System.Windows.Forms.Padding(5);
            this.Nachname.Name = "Nachname";
            this.Nachname.PlaceholderText = "Nachname";
            this.Nachname.Size = new System.Drawing.Size(350, 45);
            this.Nachname.TabIndex = 1;
            // 
            // PLZ
            // 
            this.PLZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PLZ.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PLZ.Location = new System.Drawing.Point(30, 124);
            this.PLZ.Margin = new System.Windows.Forms.Padding(5);
            this.PLZ.Name = "PLZ";
            this.PLZ.PlaceholderText = "PLZ";
            this.PLZ.Size = new System.Drawing.Size(350, 45);
            this.PLZ.TabIndex = 2;
            // 
            // Wohnort
            // 
            this.Wohnort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Wohnort.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Wohnort.Location = new System.Drawing.Point(30, 179);
            this.Wohnort.Margin = new System.Windows.Forms.Padding(5);
            this.Wohnort.Name = "Wohnort";
            this.Wohnort.PlaceholderText = "Wohnort";
            this.Wohnort.Size = new System.Drawing.Size(350, 45);
            this.Wohnort.TabIndex = 3;
            // 
            // Hausnummer
            // 
            this.Hausnummer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hausnummer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hausnummer.Location = new System.Drawing.Point(30, 234);
            this.Hausnummer.Margin = new System.Windows.Forms.Padding(5);
            this.Hausnummer.Name = "Hausnummer";
            this.Hausnummer.PlaceholderText = "Hausnummer";
            this.Hausnummer.Size = new System.Drawing.Size(350, 45);
            this.Hausnummer.TabIndex = 4;
            // 
            // Straße
            // 
            this.Straße.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Straße.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Straße.Location = new System.Drawing.Point(30, 289);
            this.Straße.Margin = new System.Windows.Forms.Padding(5);
            this.Straße.Name = "Straße";
            this.Straße.PlaceholderText = "Straße";
            this.Straße.Size = new System.Drawing.Size(350, 45);
            this.Straße.TabIndex = 5;
            // 
            // Fortschrittsanzeige
            // 
            this.Fortschrittsanzeige.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Fortschrittsanzeige.Location = new System.Drawing.Point(0, 402);
            this.Fortschrittsanzeige.Name = "Fortschrittsanzeige";
            this.Fortschrittsanzeige.Size = new System.Drawing.Size(438, 34);
            this.Fortschrittsanzeige.TabIndex = 2;
            // 
            // Sendebutton
            // 
            this.Sendebutton.Enabled = false;
            this.Sendebutton.Location = new System.Drawing.Point(268, 351);
            this.Sendebutton.Name = "Sendebutton";
            this.Sendebutton.Size = new System.Drawing.Size(112, 34);
            this.Sendebutton.TabIndex = 6;
            this.Sendebutton.Text = "SEND";
            this.Sendebutton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 436);
            this.Controls.Add(this.Sendebutton);
            this.Controls.Add(this.PLZ);
            this.Controls.Add(this.Nachname);
            this.Controls.Add(this.Straße);
            this.Controls.Add(this.Hausnummer);
            this.Controls.Add(this.Wohnort);
            this.Controls.Add(this.Vorname);
            this.Controls.Add(this.Fortschrittsanzeige);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProgressBar Fortschrittsanzeige;
        private TextBox Vorname;
        private TextBox Nachname;
        private TextBox PLZ;
        private TextBox Wohnort;
        private TextBox Hausnummer;
        private TextBox Straße;
        private Button Sendebutton;
    }
}