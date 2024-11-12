namespace FabrikaÜretim
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxLokasyon = new System.Windows.Forms.ComboBox();
            this.textBoxSeriNo = new System.Windows.Forms.TextBox();
            this.dataGridViewTablo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLokasyon
            // 
            this.comboBoxLokasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxLokasyon.FormattingEnabled = true;
            this.comboBoxLokasyon.Items.AddRange(new object[] {
            "Kahramanmaraş Fabrikası",
            "Ankara Fabrikası",
            "İstanbul Fabrikası",
            "Osmaniye Fabrikası"});
            this.comboBoxLokasyon.Location = new System.Drawing.Point(309, 105);
            this.comboBoxLokasyon.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLokasyon.Name = "comboBoxLokasyon";
            this.comboBoxLokasyon.Size = new System.Drawing.Size(263, 30);
            this.comboBoxLokasyon.TabIndex = 0;
            this.comboBoxLokasyon.SelectedIndexChanged += new System.EventHandler(this.comboBoxLokasyon_SelectedIndexChanged);
            // 
            // textBoxSeriNo
            // 
            this.textBoxSeriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSeriNo.Location = new System.Drawing.Point(309, 141);
            this.textBoxSeriNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSeriNo.Name = "textBoxSeriNo";
            this.textBoxSeriNo.Size = new System.Drawing.Size(263, 28);
            this.textBoxSeriNo.TabIndex = 1;
            this.textBoxSeriNo.TabStop = false;
            this.textBoxSeriNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSeriNo_KeyDown);
            // 
            // dataGridViewTablo
            // 
            this.dataGridViewTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SeriNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTablo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTablo.Location = new System.Drawing.Point(9, 234);
            this.dataGridViewTablo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTablo.Name = "dataGridViewTablo";
            this.dataGridViewTablo.RowHeadersVisible = false;
            this.dataGridViewTablo.RowHeadersWidth = 51;
            this.dataGridViewTablo.RowTemplate.Height = 24;
            this.dataGridViewTablo.Size = new System.Drawing.Size(612, 122);
            this.dataGridViewTablo.TabIndex = 2;
            this.dataGridViewTablo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Seri Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fabrika Lokasyonu:";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(228, 197);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(86, 32);
            this.buttonKaydet.TabIndex = 5;
            this.buttonKaydet.TabStop = false;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(605, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "DokuzTay Matbaa Tesisleri";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(319, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Yükle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // SeriNo
            // 
            this.SeriNo.HeaderText = "SeriNumarasi";
            this.SeriNo.MinimumWidth = 6;
            this.SeriNo.Name = "SeriNo";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTablo);
            this.Controls.Add(this.textBoxSeriNo);
            this.Controls.Add(this.comboBoxLokasyon);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Fabrika Üretim Takip";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLokasyon;
        private System.Windows.Forms.TextBox textBoxSeriNo;
        private System.Windows.Forms.DataGridView dataGridViewTablo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriNo;
    }
}

