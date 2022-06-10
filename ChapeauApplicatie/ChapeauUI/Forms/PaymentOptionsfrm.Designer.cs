﻿namespace ChapeauUI.Forms
{
    partial class PaymentOptionsfrm
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
            this.btnCashPayment = new System.Windows.Forms.Button();
            this.btnCardPayment = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOrderStatus = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnMenus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCashPayment
            // 
            this.btnCashPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnCashPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashPayment.Location = new System.Drawing.Point(2, 2);
            this.btnCashPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnCashPayment.Name = "btnCashPayment";
            this.btnCashPayment.Size = new System.Drawing.Size(222, 88);
            this.btnCashPayment.TabIndex = 12;
            this.btnCashPayment.Text = "Contant";
            this.btnCashPayment.UseVisualStyleBackColor = false;
            this.btnCashPayment.Click += new System.EventHandler(this.btnCashPayment_Click);
            // 
            // btnCardPayment
            // 
            this.btnCardPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnCardPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardPayment.Location = new System.Drawing.Point(2, 2);
            this.btnCardPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnCardPayment.Name = "btnCardPayment";
            this.btnCardPayment.Size = new System.Drawing.Size(222, 88);
            this.btnCardPayment.TabIndex = 13;
            this.btnCardPayment.Text = "Pin";
            this.btnCardPayment.UseVisualStyleBackColor = false;
            this.btnCardPayment.Click += new System.EventHandler(this.btnCardPayment_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(127)))));
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 26);
            this.panel4.TabIndex = 26;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.panel3.Controls.Add(this.btnOrderStatus);
            this.panel3.Controls.Add(this.btnPayment);
            this.panel3.Controls.Add(this.btnMenus);
            this.panel3.Location = new System.Drawing.Point(0, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 40);
            this.panel3.TabIndex = 27;
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
            this.btnOrderStatus.Click += new System.EventHandler(this.btnOrderStatus_Click);
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.btnCashPayment);
            this.panel1.Location = new System.Drawing.Point(5, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 92);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(127)))));
            this.panel2.Controls.Add(this.btnCardPayment);
            this.panel2.Location = new System.Drawing.Point(5, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 92);
            this.panel2.TabIndex = 29;
            // 
            // PaymentOptionsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentOptionsfrm";
            this.Text = "PaymentOptionsfrm";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCashPayment;
        private Button btnCardPayment;
        private Panel panel4;
        private Button btnBack;
        private Panel panel3;
        private Button btnOrderStatus;
        private Button btnPayment;
        private Button btnMenus;
        private Panel panel1;
        private Panel panel2;
    }
}