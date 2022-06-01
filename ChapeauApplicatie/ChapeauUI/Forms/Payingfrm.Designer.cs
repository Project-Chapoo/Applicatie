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
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(22, 191);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(77, 39);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnAddTip
            // 
            this.btnAddTip.Location = new System.Drawing.Point(105, 191);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(42, 39);
            this.btnAddTip.TabIndex = 1;
            this.btnAddTip.Text = "+";
            this.btnAddTip.UseVisualStyleBackColor = true;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrder.Location = new System.Drawing.Point(13, 41);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(200, 130);
            this.txtOrder.TabIndex = 3;
            this.txtOrder.UseCompatibleStateImageBehavior = false;
            this.txtOrder.View = System.Windows.Forms.View.Details;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(9, 233);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(68, 39);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnOrderStatus
            // 
            this.btnOrderStatus.Location = new System.Drawing.Point(145, 233);
            this.btnOrderStatus.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrderStatus.Name = "btnOrderStatus";
            this.btnOrderStatus.Size = new System.Drawing.Size(68, 39);
            this.btnOrderStatus.TabIndex = 6;
            this.btnOrderStatus.Text = "Order Status";
            this.btnOrderStatus.UseVisualStyleBackColor = true;
            // 
            // btnMenus
            // 
            this.btnMenus.Location = new System.Drawing.Point(77, 233);
            this.btnMenus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Size = new System.Drawing.Size(68, 39);
            this.btnMenus.TabIndex = 7;
            this.btnMenus.Text = "Menu\'s";
            this.btnMenus.UseVisualStyleBackColor = true;
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(153, 192);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(51, 39);
            this.btnComment.TabIndex = 9;
            this.btnComment.Text = "Toev.";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // Payingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 281);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.btnMenus);
            this.Controls.Add(this.btnOrderStatus);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.btnAddTip);
            this.Controls.Add(this.btnPay);
            this.Name = "Payingfrm";
            this.Text = "Payingfrm";
            this.Load += new System.EventHandler(this.Payingfrm_Load);
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
    }
}