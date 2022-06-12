namespace ChapeauUI.Forms
{
    partial class BedieningFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedieningFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBestellingOpnemen = new System.Windows.Forms.Button();
            this.btnTafelOverzicht = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBalk = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBalk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.pnlBalk);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 790);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maak een keuze";
            // 
            // btnBestellingOpnemen
            // 
            this.btnBestellingOpnemen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnBestellingOpnemen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBestellingOpnemen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBestellingOpnemen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnBestellingOpnemen.Location = new System.Drawing.Point(68, 304);
            this.btnBestellingOpnemen.Name = "btnBestellingOpnemen";
            this.btnBestellingOpnemen.Size = new System.Drawing.Size(216, 69);
            this.btnBestellingOpnemen.TabIndex = 1;
            this.btnBestellingOpnemen.Text = "Bestelling opnemen";
            this.btnBestellingOpnemen.UseVisualStyleBackColor = false;
            this.btnBestellingOpnemen.Click += new System.EventHandler(this.btnBestellingOpnemen_Click);
            // 
            // btnTafelOverzicht
            // 
            this.btnTafelOverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnTafelOverzicht.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTafelOverzicht.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTafelOverzicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnTafelOverzicht.Location = new System.Drawing.Point(68, 192);
            this.btnTafelOverzicht.Name = "btnTafelOverzicht";
            this.btnTafelOverzicht.Size = new System.Drawing.Size(216, 69);
            this.btnTafelOverzicht.TabIndex = 0;
            this.btnTafelOverzicht.Text = "Tafel overzicht";
            this.btnTafelOverzicht.UseVisualStyleBackColor = false;
            this.btnTafelOverzicht.Click += new System.EventHandler(this.btnTafelOverzicht_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(95)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBestellingOpnemen);
            this.panel2.Controls.Add(this.btnTafelOverzicht);
            this.panel2.Location = new System.Drawing.Point(394, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 471);
            this.panel2.TabIndex = 3;
            // 
            // pnlBalk
            // 
            this.pnlBalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(127)))));
            this.pnlBalk.Controls.Add(this.pbLogo);
            this.pnlBalk.Location = new System.Drawing.Point(18, 12);
            this.pnlBalk.Name = "pnlBalk";
            this.pnlBalk.Size = new System.Drawing.Size(1082, 62);
            this.pnlBalk.TabIndex = 28;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(495, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(114, 62);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 26;
            this.pbLogo.TabStop = false;
            // 
            // BedieningFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 789);
            this.Controls.Add(this.panel1);
            this.Name = "BedieningFrm";
            this.Text = "BedieningFrm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlBalk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnBestellingOpnemen;
        private Button btnTafelOverzicht;
        private Panel panel2;
        private Panel pnlBalk;
        private PictureBox pbLogo;
    }
}