namespace ChapeauUI.Forms
{
    partial class Tipfrm
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
            this.btnTwoEuro = new System.Windows.Forms.Button();
            this.btnFiveEuro = new System.Windows.Forms.Button();
            this.btnTenEuro = new System.Windows.Forms.Button();
            this.txtbTip = new System.Windows.Forms.TextBox();
            this.btnAddTip = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOrderStatus = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnMenus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTwoEuro
            // 
            this.btnTwoEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnTwoEuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwoEuro.Location = new System.Drawing.Point(2, 2);
            this.btnTwoEuro.Name = "btnTwoEuro";
            this.btnTwoEuro.Size = new System.Drawing.Size(50, 50);
            this.btnTwoEuro.TabIndex = 0;
            this.btnTwoEuro.Text = "€2";
            this.btnTwoEuro.UseVisualStyleBackColor = false;
            this.btnTwoEuro.Click += new System.EventHandler(this.btnTwoEuro_Click);
            // 
            // btnFiveEuro
            // 
            this.btnFiveEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnFiveEuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiveEuro.Location = new System.Drawing.Point(2, 2);
            this.btnFiveEuro.Name = "btnFiveEuro";
            this.btnFiveEuro.Size = new System.Drawing.Size(50, 50);
            this.btnFiveEuro.TabIndex = 1;
            this.btnFiveEuro.Text = "€5";
            this.btnFiveEuro.UseVisualStyleBackColor = false;
            this.btnFiveEuro.Click += new System.EventHandler(this.btnFiveEuro_Click);
            // 
            // btnTenEuro
            // 
            this.btnTenEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnTenEuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTenEuro.Location = new System.Drawing.Point(2, 2);
            this.btnTenEuro.Name = "btnTenEuro";
            this.btnTenEuro.Size = new System.Drawing.Size(50, 50);
            this.btnTenEuro.TabIndex = 2;
            this.btnTenEuro.Text = "€10";
            this.btnTenEuro.UseVisualStyleBackColor = false;
            this.btnTenEuro.Click += new System.EventHandler(this.btnTenEuro_Click);
            // 
            // txtbTip
            // 
            this.txtbTip.Location = new System.Drawing.Point(33, 155);
            this.txtbTip.Name = "txtbTip";
            this.txtbTip.PlaceholderText = "The extra amount / the new target";
            this.txtbTip.Size = new System.Drawing.Size(175, 23);
            this.txtbTip.TabIndex = 12;
            this.txtbTip.TextChanged += new System.EventHandler(this.txtbTip_TextChanged);
            // 
            // btnAddTip
            // 
            this.btnAddTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnAddTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTip.Location = new System.Drawing.Point(2, 2);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(111, 26);
            this.btnAddTip.TabIndex = 3;
            this.btnAddTip.Text = "Add Tip";
            this.btnAddTip.UseVisualStyleBackColor = false;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(23, 126);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(194, 15);
            this.lblTotalPrice.TabIndex = 14;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.panel3.Controls.Add(this.btnOrderStatus);
            this.panel3.Controls.Add(this.btnPayment);
            this.panel3.Controls.Add(this.btnMenus);
            this.panel3.Location = new System.Drawing.Point(0, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 40);
            this.panel3.TabIndex = 22;
            // 
            // btnOrderStatus
            // 
            this.btnOrderStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrderStatus.Location = new System.Drawing.Point(162, 2);
            this.btnOrderStatus.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrderStatus.Name = "btnOrderStatus";
            this.btnOrderStatus.Size = new System.Drawing.Size(78, 36);
            this.btnOrderStatus.TabIndex = 6;
            this.btnOrderStatus.Text = "Bestelling";
            this.btnOrderStatus.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayment.Location = new System.Drawing.Point(2, 2);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(78, 36);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnMenus
            // 
            this.btnMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenus.Location = new System.Drawing.Point(82, 2);
            this.btnMenus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Size = new System.Drawing.Size(78, 36);
            this.btnMenus.TabIndex = 7;
            this.btnMenus.Text = "Menu\'s";
            this.btnMenus.UseVisualStyleBackColor = false;
            this.btnMenus.Click += new System.EventHandler(this.btnMenus_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.btnAddTip);
            this.panel1.Location = new System.Drawing.Point(64, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 30);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.btnTwoEuro);
            this.panel2.Location = new System.Drawing.Point(23, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 54);
            this.panel2.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(127)))));
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 26);
            this.panel4.TabIndex = 25;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(20, 20);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.panel5.Controls.Add(this.btnTenEuro);
            this.panel5.Location = new System.Drawing.Point(163, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(54, 54);
            this.panel5.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.panel6.Controls.Add(this.btnFiveEuro);
            this.panel6.Location = new System.Drawing.Point(95, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(54, 54);
            this.panel6.TabIndex = 26;
            // 
            // Tipfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtbTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tipfrm";
            this.Text = "Tipfrm";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTwoEuro;
        private Button btnFiveEuro;
        private Button btnTenEuro;
        private TextBox txtbTip;
        private Button btnAddTip;
        private Label lblTotalPrice;
        private Panel panel3;
        private Button btnOrderStatus;
        private Button btnPayment;
        private Button btnMenus;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Button btnBack;
        private Panel panel5;
        private Panel panel6;
    }
}