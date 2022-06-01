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
            this.btnMenus = new System.Windows.Forms.Button();
            this.btnOrderStatus = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtbTip = new System.Windows.Forms.TextBox();
            this.btnAddTip = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTwoEuro
            // 
            this.btnTwoEuro.Location = new System.Drawing.Point(24, 113);
            this.btnTwoEuro.Margin = new System.Windows.Forms.Padding(6);
            this.btnTwoEuro.Name = "btnTwoEuro";
            this.btnTwoEuro.Size = new System.Drawing.Size(93, 107);
            this.btnTwoEuro.TabIndex = 0;
            this.btnTwoEuro.Text = "€2";
            this.btnTwoEuro.UseVisualStyleBackColor = true;
            this.btnTwoEuro.Click += new System.EventHandler(this.btnTwoEuro_Click);
            // 
            // btnFiveEuro
            // 
            this.btnFiveEuro.Location = new System.Drawing.Point(160, 113);
            this.btnFiveEuro.Margin = new System.Windows.Forms.Padding(6);
            this.btnFiveEuro.Name = "btnFiveEuro";
            this.btnFiveEuro.Size = new System.Drawing.Size(93, 107);
            this.btnFiveEuro.TabIndex = 1;
            this.btnFiveEuro.Text = "€5";
            this.btnFiveEuro.UseVisualStyleBackColor = true;
            this.btnFiveEuro.Click += new System.EventHandler(this.btnFiveEuro_Click);
            // 
            // btnTenEuro
            // 
            this.btnTenEuro.Location = new System.Drawing.Point(303, 113);
            this.btnTenEuro.Margin = new System.Windows.Forms.Padding(6);
            this.btnTenEuro.Name = "btnTenEuro";
            this.btnTenEuro.Size = new System.Drawing.Size(93, 107);
            this.btnTenEuro.TabIndex = 2;
            this.btnTenEuro.Text = "€10";
            this.btnTenEuro.UseVisualStyleBackColor = true;
            this.btnTenEuro.Click += new System.EventHandler(this.btnTenEuro_Click);
            // 
            // btnMenus
            // 
            this.btnMenus.Location = new System.Drawing.Point(143, 497);
            this.btnMenus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Size = new System.Drawing.Size(126, 83);
            this.btnMenus.TabIndex = 10;
            this.btnMenus.Text = "Menu\'s";
            this.btnMenus.UseVisualStyleBackColor = true;
            // 
            // btnOrderStatus
            // 
            this.btnOrderStatus.Location = new System.Drawing.Point(269, 497);
            this.btnOrderStatus.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrderStatus.Name = "btnOrderStatus";
            this.btnOrderStatus.Size = new System.Drawing.Size(126, 83);
            this.btnOrderStatus.TabIndex = 9;
            this.btnOrderStatus.Text = "Order Status";
            this.btnOrderStatus.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(17, 497);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(126, 83);
            this.btnPayment.TabIndex = 8;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txtbTip
            // 
            this.txtbTip.Location = new System.Drawing.Point(24, 258);
            this.txtbTip.Margin = new System.Windows.Forms.Padding(6);
            this.txtbTip.Name = "txtbTip";
            this.txtbTip.PlaceholderText = "The extra amount / the new target";
            this.txtbTip.Size = new System.Drawing.Size(368, 39);
            this.txtbTip.TabIndex = 12;
            this.txtbTip.TextChanged += new System.EventHandler(this.txtbTip_TextChanged);
            // 
            // btnAddTip
            // 
            this.btnAddTip.Location = new System.Drawing.Point(137, 367);
            this.btnAddTip.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(139, 53);
            this.btnAddTip.TabIndex = 3;
            this.btnAddTip.Text = "Add Tip";
            this.btnAddTip.UseVisualStyleBackColor = true;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 26);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 49);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalPrice.Location = new System.Drawing.Point(24, 316);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(372, 32);
            this.lblTotalPrice.TabIndex = 14;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tipfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 599);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtbTip);
            this.Controls.Add(this.btnMenus);
            this.Controls.Add(this.btnOrderStatus);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnAddTip);
            this.Controls.Add(this.btnTenEuro);
            this.Controls.Add(this.btnFiveEuro);
            this.Controls.Add(this.btnTwoEuro);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Tipfrm";
            this.Text = "Tipfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTwoEuro;
        private Button btnFiveEuro;
        private Button btnTenEuro;
        private Button btnMenus;
        private Button btnOrderStatus;
        private Button btnPayment;
        private TextBox txtbTip;
        private Button btnAddTip;
        private Button btnBack;
        private Label lblTotalPrice;
    }
}