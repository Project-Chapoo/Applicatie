namespace ChapeauUI.Forms
{
    partial class Payingfrm
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
            this.btnPay = new System.Windows.Forms.Button();
            this.btnAddTip = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnOrderStatus = new System.Windows.Forms.Button();
            this.btnMenus = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.lblBTW = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPay.Location = new System.Drawing.Point(2, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(86, 26);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnAddTip
            // 
            this.btnAddTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnAddTip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnAddTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTip.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTip.Location = new System.Drawing.Point(2, 2);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(26, 26);
            this.btnAddTip.TabIndex = 1;
            this.btnAddTip.Text = "+";
            this.btnAddTip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTip.UseVisualStyleBackColor = false;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrder.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrder.Location = new System.Drawing.Point(13, 42);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(200, 145);
            this.txtOrder.TabIndex = 3;
            this.txtOrder.UseCompatibleStateImageBehavior = false;
            this.txtOrder.View = System.Windows.Forms.View.Details;
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
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayment.Location = new System.Drawing.Point(2, 2);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(78, 36);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnOrderStatus
            // 
            this.btnOrderStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrderStatus.Location = new System.Drawing.Point(162, 2);
            this.btnOrderStatus.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrderStatus.Name = "btnOrderStatus";
            this.btnOrderStatus.Size = new System.Drawing.Size(78, 36);
            this.btnOrderStatus.TabIndex = 6;
            this.btnOrderStatus.Text = "Bestelling";
            this.btnOrderStatus.UseVisualStyleBackColor = true;
            this.btnOrderStatus.Click += new System.EventHandler(this.btnOrderStatus_Click);
            // 
            // btnMenus
            // 
            this.btnMenus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenus.Location = new System.Drawing.Point(82, 2);
            this.btnMenus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Size = new System.Drawing.Size(78, 36);
            this.btnMenus.TabIndex = 7;
            this.btnMenus.Text = "Menu\'s";
            this.btnMenus.UseVisualStyleBackColor = true;
            this.btnMenus.Click += new System.EventHandler(this.btnMenus_Click);
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnComment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComment.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComment.Location = new System.Drawing.Point(2, 2);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(46, 26);
            this.btnComment.TabIndex = 9;
            this.btnComment.Text = "Toev.";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // lblBTW
            // 
            this.lblBTW.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBTW.ForeColor = System.Drawing.Color.White;
            this.lblBTW.Location = new System.Drawing.Point(11, 190);
            this.lblBTW.Name = "lblBTW";
            this.lblBTW.Size = new System.Drawing.Size(179, 16);
            this.lblBTW.TabIndex = 10;
            this.lblBTW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(11, 206);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(179, 16);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 26);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.panel2.Location = new System.Drawing.Point(11, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 149);
            this.panel2.TabIndex = 12;
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
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.panel4.Controls.Add(this.btnPay);
            this.panel4.Location = new System.Drawing.Point(22, 234);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 30);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.panel5.Controls.Add(this.btnAddTip);
            this.panel5.Location = new System.Drawing.Point(118, 234);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 30);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.panel6.Controls.Add(this.btnComment);
            this.panel6.Location = new System.Drawing.Point(154, 234);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 30);
            this.panel6.TabIndex = 16;
            // 
            // Payingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBTW);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payingfrm";
            this.Text = "Payingfrm";
            this.Load += new System.EventHandler(this.Payingfrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPay;
        private Button btnAddTip;
        private ListView txtOrder;
        private Button btnBack;
        private Button btnPayment;
        private Button btnOrderStatus;
        private Button btnMenus;
        private Button btnComment;
        private Label lblBTW;
        private Label lblTotalPrice;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}