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
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(59, 377);
            this.btnPay.Margin = new System.Windows.Forms.Padding(6);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(143, 83);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnAddTip
            // 
            this.btnAddTip.Location = new System.Drawing.Point(281, 377);
            this.btnAddTip.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(78, 83);
            this.btnAddTip.TabIndex = 1;
            this.btnAddTip.Text = "+";
            this.btnAddTip.UseVisualStyleBackColor = true;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrder.Location = new System.Drawing.Point(59, 113);
            this.txtOrder.Margin = new System.Windows.Forms.Padding(6);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(300, 200);
            this.txtOrder.TabIndex = 3;
            this.txtOrder.UseCompatibleStateImageBehavior = false;
            this.txtOrder.View = System.Windows.Forms.View.Details;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 26);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 49);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(17, 497);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(126, 83);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnOrderStatus
            // 
            this.btnOrderStatus.Location = new System.Drawing.Point(269, 497);
            this.btnOrderStatus.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrderStatus.Name = "btnOrderStatus";
            this.btnOrderStatus.Size = new System.Drawing.Size(126, 83);
            this.btnOrderStatus.TabIndex = 6;
            this.btnOrderStatus.Text = "Order Status";
            this.btnOrderStatus.UseVisualStyleBackColor = true;
            // 
            // btnMenus
            // 
            this.btnMenus.Location = new System.Drawing.Point(143, 497);
            this.btnMenus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Size = new System.Drawing.Size(126, 83);
            this.btnMenus.TabIndex = 7;
            this.btnMenus.Text = "Menu\'s";
            this.btnMenus.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(359, 319);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 32);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Payingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 599);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnMenus);
            this.Controls.Add(this.btnOrderStatus);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.btnAddTip);
            this.Controls.Add(this.btnPay);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Payingfrm";
            this.Text = "Payingfrm";
            this.Load += new System.EventHandler(this.Payingfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPay;
        private Button btnAddTip;
        private ListView txtOrder;
        private Button btnBack;
        private Button btnPayment;
        private Button btnOrderStatus;
        private Button btnMenus;
        private Label lblTotalPrice;
    }
}