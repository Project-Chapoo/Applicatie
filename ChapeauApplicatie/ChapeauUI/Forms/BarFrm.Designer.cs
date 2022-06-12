namespace ChapeauUI.Forms
{
    partial class BarFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarFrm));
            this.BarListview1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.BarListview2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.BarListview3 = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.opmerkingen3txt = new System.Windows.Forms.TextBox();
            this.opmerkingen2txt = new System.Windows.Forms.TextBox();
            this.opmerkingen1txt = new System.Windows.Forms.TextBox();
            this.btnGereed3 = new System.Windows.Forms.Button();
            this.btnGereed2 = new System.Windows.Forms.Button();
            this.btnGereed1 = new System.Windows.Forms.Button();
            this.lblTableNumber3 = new System.Windows.Forms.Label();
            this.lblTimeOrdered3 = new System.Windows.Forms.Label();
            this.lblTimeOrdered2 = new System.Windows.Forms.Label();
            this.lblTableNumber2 = new System.Windows.Forms.Label();
            this.lblTimeOrdered1 = new System.Windows.Forms.Label();
            this.lblTableNumber1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lblWaitingTime2 = new System.Windows.Forms.Label();
            this.lblWaitingTime3 = new System.Windows.Forms.Label();
            this.lblWaitingTime1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BarListview1
            // 
            this.BarListview1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7});
            this.BarListview1.FullRowSelect = true;
            this.BarListview1.Location = new System.Drawing.Point(44, 108);
            this.BarListview1.Name = "BarListview1";
            this.BarListview1.Size = new System.Drawing.Size(332, 546);
            this.BarListview1.TabIndex = 1;
            this.BarListview1.UseCompatibleStateImageBehavior = false;
            this.BarListview1.SelectedIndexChanged += new System.EventHandler(this.BarListview1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Description";
            this.columnHeader7.Width = 350;
            // 
            // BarListview2
            // 
            this.BarListview2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.BarListview2.FullRowSelect = true;
            this.BarListview2.Location = new System.Drawing.Point(438, 108);
            this.BarListview2.Name = "BarListview2";
            this.BarListview2.Size = new System.Drawing.Size(332, 546);
            this.BarListview2.TabIndex = 2;
            this.BarListview2.UseCompatibleStateImageBehavior = false;
            this.BarListview2.SelectedIndexChanged += new System.EventHandler(this.BarListview2_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 350;
            // 
            // BarListview3
            // 
            this.BarListview3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9});
            this.BarListview3.FullRowSelect = true;
            this.BarListview3.Location = new System.Drawing.Point(820, 108);
            this.BarListview3.Name = "BarListview3";
            this.BarListview3.Size = new System.Drawing.Size(332, 546);
            this.BarListview3.TabIndex = 3;
            this.BarListview3.UseCompatibleStateImageBehavior = false;
            this.BarListview3.SelectedIndexChanged += new System.EventHandler(this.BarListview3_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Amount";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Description";
            this.columnHeader9.Width = 350;
            // 
            // opmerkingen3txt
            // 
            this.opmerkingen3txt.Location = new System.Drawing.Point(822, 660);
            this.opmerkingen3txt.Name = "opmerkingen3txt";
            this.opmerkingen3txt.ReadOnly = true;
            this.opmerkingen3txt.Size = new System.Drawing.Size(332, 27);
            this.opmerkingen3txt.TabIndex = 20;
            // 
            // opmerkingen2txt
            // 
            this.opmerkingen2txt.Location = new System.Drawing.Point(438, 660);
            this.opmerkingen2txt.Name = "opmerkingen2txt";
            this.opmerkingen2txt.ReadOnly = true;
            this.opmerkingen2txt.Size = new System.Drawing.Size(332, 27);
            this.opmerkingen2txt.TabIndex = 19;
            // 
            // opmerkingen1txt
            // 
            this.opmerkingen1txt.Location = new System.Drawing.Point(45, 660);
            this.opmerkingen1txt.Name = "opmerkingen1txt";
            this.opmerkingen1txt.ReadOnly = true;
            this.opmerkingen1txt.Size = new System.Drawing.Size(332, 27);
            this.opmerkingen1txt.TabIndex = 18;
            // 
            // btnGereed3
            // 
            this.btnGereed3.Location = new System.Drawing.Point(822, 693);
            this.btnGereed3.Name = "btnGereed3";
            this.btnGereed3.Size = new System.Drawing.Size(332, 29);
            this.btnGereed3.TabIndex = 17;
            this.btnGereed3.Text = "Gereed";
            this.btnGereed3.UseVisualStyleBackColor = true;
            this.btnGereed3.Click += new System.EventHandler(this.btnGereed3_Click);
            // 
            // btnGereed2
            // 
            this.btnGereed2.Location = new System.Drawing.Point(438, 693);
            this.btnGereed2.Name = "btnGereed2";
            this.btnGereed2.Size = new System.Drawing.Size(332, 29);
            this.btnGereed2.TabIndex = 16;
            this.btnGereed2.Text = "Gereed";
            this.btnGereed2.UseVisualStyleBackColor = true;
            this.btnGereed2.Click += new System.EventHandler(this.btnGereed2_Click);
            // 
            // btnGereed1
            // 
            this.btnGereed1.Location = new System.Drawing.Point(45, 693);
            this.btnGereed1.Name = "btnGereed1";
            this.btnGereed1.Size = new System.Drawing.Size(332, 29);
            this.btnGereed1.TabIndex = 15;
            this.btnGereed1.Text = "Gereed";
            this.btnGereed1.UseVisualStyleBackColor = true;
            this.btnGereed1.Click += new System.EventHandler(this.btnGereed1_Click);
            // 
            // lblTableNumber3
            // 
            this.lblTableNumber3.AutoSize = true;
            this.lblTableNumber3.Location = new System.Drawing.Point(821, 85);
            this.lblTableNumber3.Name = "lblTableNumber3";
            this.lblTableNumber3.Size = new System.Drawing.Size(12, 20);
            this.lblTableNumber3.TabIndex = 26;
            this.lblTableNumber3.Text = ".";
            // 
            // lblTimeOrdered3
            // 
            this.lblTimeOrdered3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeOrdered3.Location = new System.Drawing.Point(953, 85);
            this.lblTimeOrdered3.Name = "lblTimeOrdered3";
            this.lblTimeOrdered3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTimeOrdered3.Size = new System.Drawing.Size(175, 20);
            this.lblTimeOrdered3.TabIndex = 25;
            this.lblTimeOrdered3.Text = "No Order Time Available";
            this.lblTimeOrdered3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTimeOrdered2
            // 
            this.lblTimeOrdered2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeOrdered2.Location = new System.Drawing.Point(594, 85);
            this.lblTimeOrdered2.Name = "lblTimeOrdered2";
            this.lblTimeOrdered2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTimeOrdered2.Size = new System.Drawing.Size(175, 20);
            this.lblTimeOrdered2.TabIndex = 24;
            this.lblTimeOrdered2.Text = "No Order Time Available";
            this.lblTimeOrdered2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTableNumber2
            // 
            this.lblTableNumber2.AutoSize = true;
            this.lblTableNumber2.Location = new System.Drawing.Point(437, 85);
            this.lblTableNumber2.Name = "lblTableNumber2";
            this.lblTableNumber2.Size = new System.Drawing.Size(12, 20);
            this.lblTableNumber2.TabIndex = 23;
            this.lblTableNumber2.Text = ".";
            // 
            // lblTimeOrdered1
            // 
            this.lblTimeOrdered1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeOrdered1.Location = new System.Drawing.Point(201, 85);
            this.lblTimeOrdered1.Name = "lblTimeOrdered1";
            this.lblTimeOrdered1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTimeOrdered1.Size = new System.Drawing.Size(175, 20);
            this.lblTimeOrdered1.TabIndex = 22;
            this.lblTimeOrdered1.Text = "No Order Time Available";
            this.lblTimeOrdered1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTableNumber1
            // 
            this.lblTableNumber1.AutoSize = true;
            this.lblTableNumber1.Location = new System.Drawing.Point(44, 85);
            this.lblTableNumber1.Name = "lblTableNumber1";
            this.lblTableNumber1.Size = new System.Drawing.Size(12, 20);
            this.lblTableNumber1.TabIndex = 21;
            this.lblTableNumber1.Text = ".";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(127)))));
            this.panel3.Controls.Add(this.btnLogOut);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.lblEmployeeName);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(44, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 62);
            this.panel3.TabIndex = 29;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnLogOut.Location = new System.Drawing.Point(1014, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 56);
            this.btnLogOut.TabIndex = 29;
            this.btnLogOut.Text = "Uitloggen";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 56);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblEmployeeName.Location = new System.Drawing.Point(958, 21);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmployeeName.Size = new System.Drawing.Size(42, 20);
            this.lblEmployeeName.TabIndex = 27;
            this.lblEmployeeName.Text = "label";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(480, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.Location = new System.Drawing.Point(1006, 755);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(146, 20);
            this.lblTimeNow.TabIndex = 30;
            this.lblTimeNow.Text = "HH:mm dd:MM:YYYY";
            // 
            // lblWaitingTime2
            // 
            this.lblWaitingTime2.AutoSize = true;
            this.lblWaitingTime2.Location = new System.Drawing.Point(524, 725);
            this.lblWaitingTime2.Name = "lblWaitingTime2";
            this.lblWaitingTime2.Size = new System.Drawing.Size(146, 20);
            this.lblWaitingTime2.TabIndex = 32;
            this.lblWaitingTime2.Text = "HH:mm dd:MM:YYYY";
            // 
            // lblWaitingTime3
            // 
            this.lblWaitingTime3.AutoSize = true;
            this.lblWaitingTime3.Location = new System.Drawing.Point(914, 725);
            this.lblWaitingTime3.Name = "lblWaitingTime3";
            this.lblWaitingTime3.Size = new System.Drawing.Size(146, 20);
            this.lblWaitingTime3.TabIndex = 33;
            this.lblWaitingTime3.Text = "HH:mm dd:MM:YYYY";
            // 
            // lblWaitingTime1
            // 
            this.lblWaitingTime1.AutoSize = true;
            this.lblWaitingTime1.Location = new System.Drawing.Point(130, 725);
            this.lblWaitingTime1.Name = "lblWaitingTime1";
            this.lblWaitingTime1.Size = new System.Drawing.Size(146, 20);
            this.lblWaitingTime1.TabIndex = 34;
            this.lblWaitingTime1.Text = "HH:mm dd:MM:YYYY";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1182, 803);
            this.Controls.Add(this.lblWaitingTime1);
            this.Controls.Add(this.lblWaitingTime3);
            this.Controls.Add(this.lblWaitingTime2);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblTableNumber3);
            this.Controls.Add(this.lblTimeOrdered3);
            this.Controls.Add(this.lblTimeOrdered2);
            this.Controls.Add(this.lblTableNumber2);
            this.Controls.Add(this.lblTimeOrdered1);
            this.Controls.Add(this.lblTableNumber1);
            this.Controls.Add(this.opmerkingen3txt);
            this.Controls.Add(this.opmerkingen2txt);
            this.Controls.Add(this.opmerkingen1txt);
            this.Controls.Add(this.btnGereed3);
            this.Controls.Add(this.btnGereed2);
            this.Controls.Add(this.btnGereed1);
            this.Controls.Add(this.BarListview3);
            this.Controls.Add(this.BarListview2);
            this.Controls.Add(this.BarListview1);
            this.Name = "BarFrm";
            this.Text = "BarFrm";
            this.Load += new System.EventHandler(this.BarFrm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView BarListview1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader7;
        private ListView BarListview2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView BarListview3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private TextBox opmerkingen3txt;
        private TextBox opmerkingen2txt;
        private TextBox opmerkingen1txt;
        private Button btnGereed3;
        private Button btnGereed2;
        private Button btnGereed1;
        private Label lblTableNumber3;
        private Label lblTimeOrdered3;
        private Label lblTimeOrdered2;
        private Label lblTableNumber2;
        private Label lblTimeOrdered1;
        private Label lblTableNumber1;
        private Panel panel3;
        private Label lblEmployeeName;
        private PictureBox pictureBox2;
        private Button btnBack;
        private Button btnLogOut;
        private Label lblTimeNow;
        private Label lblWaitingTime2;
        private Label lblWaitingTime3;
        private Label lblWaitingTime1;
        private System.Windows.Forms.Timer timer1;
    }
}