namespace ChapeauUI.Forms
{
    partial class KeukenFrm2
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
            this.KeukenListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.KeukenListView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.KeukenListView3 = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.lblTableNumber1 = new System.Windows.Forms.Label();
            this.lblTimeOrdered1 = new System.Windows.Forms.Label();
            this.btnGereed1 = new System.Windows.Forms.Button();
            this.btnGereed2 = new System.Windows.Forms.Button();
            this.btnGereed3 = new System.Windows.Forms.Button();
            this.lblTableNumber2 = new System.Windows.Forms.Label();
            this.lblTimeOrdered2 = new System.Windows.Forms.Label();
            this.lblTimeOrdered3 = new System.Windows.Forms.Label();
            this.lblTableNumber3 = new System.Windows.Forms.Label();
            this.opmerkingen1txt = new System.Windows.Forms.TextBox();
            this.opmerkingen2txt = new System.Windows.Forms.TextBox();
            this.opmerkingen3txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KeukenListView1
            // 
            this.KeukenListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7});
            this.KeukenListView1.FullRowSelect = true;
            this.KeukenListView1.Location = new System.Drawing.Point(42, 120);
            this.KeukenListView1.Name = "KeukenListView1";
            this.KeukenListView1.Size = new System.Drawing.Size(332, 546);
            this.KeukenListView1.TabIndex = 0;
            this.KeukenListView1.UseCompatibleStateImageBehavior = false;
            this.KeukenListView1.SelectedIndexChanged += new System.EventHandler(this.KeukenListView1_SelectedIndexChanged);
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
            // KeukenListView2
            // 
            this.KeukenListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8});
            this.KeukenListView2.FullRowSelect = true;
            this.KeukenListView2.Location = new System.Drawing.Point(435, 120);
            this.KeukenListView2.MultiSelect = false;
            this.KeukenListView2.Name = "KeukenListView2";
            this.KeukenListView2.Size = new System.Drawing.Size(332, 546);
            this.KeukenListView2.TabIndex = 1;
            this.KeukenListView2.UseCompatibleStateImageBehavior = false;
            this.KeukenListView2.SelectedIndexChanged += new System.EventHandler(this.KeukenListView2_SelectedIndexChanged);
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
            // columnHeader8
            // 
            this.columnHeader8.Text = "Description";
            this.columnHeader8.Width = 350;
            // 
            // KeukenListView3
            // 
            this.KeukenListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9});
            this.KeukenListView3.FullRowSelect = true;
            this.KeukenListView3.Location = new System.Drawing.Point(819, 120);
            this.KeukenListView3.Name = "KeukenListView3";
            this.KeukenListView3.Size = new System.Drawing.Size(332, 546);
            this.KeukenListView3.TabIndex = 2;
            this.KeukenListView3.UseCompatibleStateImageBehavior = false;
            this.KeukenListView3.SelectedIndexChanged += new System.EventHandler(this.KeukenListView3_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Amount";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Description";
            this.columnHeader9.Width = 350;
            // 
            // lblTableNumber1
            // 
            this.lblTableNumber1.AutoSize = true;
            this.lblTableNumber1.Location = new System.Drawing.Point(42, 97);
            this.lblTableNumber1.Name = "lblTableNumber1";
            this.lblTableNumber1.Size = new System.Drawing.Size(50, 20);
            this.lblTableNumber1.TabIndex = 3;
            this.lblTableNumber1.Text = "label1";
            // 
            // lblTimeOrdered1
            // 
            this.lblTimeOrdered1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeOrdered1.Location = new System.Drawing.Point(199, 97);
            this.lblTimeOrdered1.Name = "lblTimeOrdered1";
            this.lblTimeOrdered1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTimeOrdered1.Size = new System.Drawing.Size(175, 20);
            this.lblTimeOrdered1.TabIndex = 4;
            this.lblTimeOrdered1.Text = "No Order Time Available";
            this.lblTimeOrdered1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnGereed1
            // 
            this.btnGereed1.Location = new System.Drawing.Point(42, 705);
            this.btnGereed1.Name = "btnGereed1";
            this.btnGereed1.Size = new System.Drawing.Size(332, 29);
            this.btnGereed1.TabIndex = 5;
            this.btnGereed1.Text = "Gereed";
            this.btnGereed1.UseVisualStyleBackColor = true;
            this.btnGereed1.Click += new System.EventHandler(this.btnGereed1_Click);
            // 
            // btnGereed2
            // 
            this.btnGereed2.Location = new System.Drawing.Point(435, 705);
            this.btnGereed2.Name = "btnGereed2";
            this.btnGereed2.Size = new System.Drawing.Size(332, 29);
            this.btnGereed2.TabIndex = 6;
            this.btnGereed2.Text = "Gereed";
            this.btnGereed2.UseVisualStyleBackColor = true;
            this.btnGereed2.Click += new System.EventHandler(this.btnGereed2_Click);
            // 
            // btnGereed3
            // 
            this.btnGereed3.Location = new System.Drawing.Point(819, 705);
            this.btnGereed3.Name = "btnGereed3";
            this.btnGereed3.Size = new System.Drawing.Size(332, 29);
            this.btnGereed3.TabIndex = 7;
            this.btnGereed3.Text = "Gereed";
            this.btnGereed3.UseVisualStyleBackColor = true;
            this.btnGereed3.Click += new System.EventHandler(this.btnGereed3_Click);
            // 
            // lblTableNumber2
            // 
            this.lblTableNumber2.AutoSize = true;
            this.lblTableNumber2.Location = new System.Drawing.Point(435, 97);
            this.lblTableNumber2.Name = "lblTableNumber2";
            this.lblTableNumber2.Size = new System.Drawing.Size(50, 20);
            this.lblTableNumber2.TabIndex = 8;
            this.lblTableNumber2.Text = "label1";
            // 
            // lblTimeOrdered2
            // 
            this.lblTimeOrdered2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeOrdered2.Location = new System.Drawing.Point(592, 97);
            this.lblTimeOrdered2.Name = "lblTimeOrdered2";
            this.lblTimeOrdered2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTimeOrdered2.Size = new System.Drawing.Size(175, 20);
            this.lblTimeOrdered2.TabIndex = 9;
            this.lblTimeOrdered2.Text = "No Order Time Available";
            this.lblTimeOrdered2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTimeOrdered3
            // 
            this.lblTimeOrdered3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeOrdered3.Location = new System.Drawing.Point(951, 97);
            this.lblTimeOrdered3.Name = "lblTimeOrdered3";
            this.lblTimeOrdered3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTimeOrdered3.Size = new System.Drawing.Size(175, 20);
            this.lblTimeOrdered3.TabIndex = 10;
            this.lblTimeOrdered3.Text = "No Order Time Available";
            this.lblTimeOrdered3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTableNumber3
            // 
            this.lblTableNumber3.AutoSize = true;
            this.lblTableNumber3.Location = new System.Drawing.Point(819, 97);
            this.lblTableNumber3.Name = "lblTableNumber3";
            this.lblTableNumber3.Size = new System.Drawing.Size(50, 20);
            this.lblTableNumber3.TabIndex = 11;
            this.lblTableNumber3.Text = "label1";
            // 
            // opmerkingen1txt
            // 
            this.opmerkingen1txt.Location = new System.Drawing.Point(42, 672);
            this.opmerkingen1txt.Name = "opmerkingen1txt";
            this.opmerkingen1txt.ReadOnly = true;
            this.opmerkingen1txt.Size = new System.Drawing.Size(332, 27);
            this.opmerkingen1txt.TabIndex = 12;
            // 
            // opmerkingen2txt
            // 
            this.opmerkingen2txt.Location = new System.Drawing.Point(435, 672);
            this.opmerkingen2txt.Name = "opmerkingen2txt";
            this.opmerkingen2txt.ReadOnly = true;
            this.opmerkingen2txt.Size = new System.Drawing.Size(332, 27);
            this.opmerkingen2txt.TabIndex = 13;
            // 
            // opmerkingen3txt
            // 
            this.opmerkingen3txt.Location = new System.Drawing.Point(819, 672);
            this.opmerkingen3txt.Name = "opmerkingen3txt";
            this.opmerkingen3txt.ReadOnly = true;
            this.opmerkingen3txt.Size = new System.Drawing.Size(332, 27);
            this.opmerkingen3txt.TabIndex = 14;
            // 
            // KeukenFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1182, 803);
            this.Controls.Add(this.opmerkingen3txt);
            this.Controls.Add(this.opmerkingen2txt);
            this.Controls.Add(this.opmerkingen1txt);
            this.Controls.Add(this.lblTableNumber3);
            this.Controls.Add(this.lblTimeOrdered3);
            this.Controls.Add(this.lblTimeOrdered2);
            this.Controls.Add(this.lblTableNumber2);
            this.Controls.Add(this.btnGereed3);
            this.Controls.Add(this.btnGereed2);
            this.Controls.Add(this.btnGereed1);
            this.Controls.Add(this.lblTimeOrdered1);
            this.Controls.Add(this.lblTableNumber1);
            this.Controls.Add(this.KeukenListView3);
            this.Controls.Add(this.KeukenListView2);
            this.Controls.Add(this.KeukenListView1);
            this.Name = "KeukenFrm2";
            this.Text = "KeukenFrm2";
            this.Load += new System.EventHandler(this.KeukenFrm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView KeukenListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView KeukenListView2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView KeukenListView3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label lblTableNumber1;
        private Label lblTimeOrdered1;
        private Button btnGereed1;
        private Button btnGereed2;
        private Button btnGereed3;
        private Label lblTableNumber2;
        private Label lblTimeOrdered2;
        private Label lblTimeOrdered3;
        private Label lblTableNumber3;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private TextBox opmerkingen1txt;
        private TextBox opmerkingen2txt;
        private TextBox opmerkingen3txt;
    }
}