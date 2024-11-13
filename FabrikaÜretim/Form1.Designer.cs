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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxLokasyon = new System.Windows.Forms.ComboBox();
            this.textBoxSeriNo = new System.Windows.Forms.TextBox();
            this.dataGridViewTablo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonYukle = new System.Windows.Forms.Button();
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
            this.comboBoxLokasyon.Location = new System.Drawing.Point(412, 129);
            this.comboBoxLokasyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLokasyon.Name = "comboBoxLokasyon";
            this.comboBoxLokasyon.Size = new System.Drawing.Size(349, 37);
            this.comboBoxLokasyon.TabIndex = 0;
            this.comboBoxLokasyon.SelectedIndexChanged += new System.EventHandler(this.comboBoxLokasyon_SelectedIndexChanged);
            // 
            // textBoxSeriNo
            // 
            this.textBoxSeriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSeriNo.Location = new System.Drawing.Point(412, 174);
            this.textBoxSeriNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSeriNo.Name = "textBoxSeriNo";
            this.textBoxSeriNo.Size = new System.Drawing.Size(349, 34);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTablo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTablo.Location = new System.Drawing.Point(12, 288);
            this.dataGridViewTablo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTablo.Name = "dataGridViewTablo";
            this.dataGridViewTablo.RowHeadersVisible = false;
            this.dataGridViewTablo.RowHeadersWidth = 51;
            this.dataGridViewTablo.RowTemplate.Height = 24;
            this.dataGridViewTablo.Size = new System.Drawing.Size(816, 150);
            this.dataGridViewTablo.TabIndex = 2;
            this.dataGridViewTablo.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(156, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Seri Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(164, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fabrika Lokasyonu:";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(304, 242);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(115, 39);
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
            this.label3.Location = new System.Drawing.Point(51, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(755, 69);
            this.label3.TabIndex = 6;
            this.label3.Text = "DokuzTay Matbaa Tesisleri";
            // 
            // buttonYukle
            // 
            this.buttonYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYukle.Location = new System.Drawing.Point(425, 242);
            this.buttonYukle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonYukle.Name = "buttonYukle";
            this.buttonYukle.Size = new System.Drawing.Size(115, 39);
            this.buttonYukle.TabIndex = 7;
            this.buttonYukle.TabStop = false;
            this.buttonYukle.Text = "Yükle";
            this.buttonYukle.UseVisualStyleBackColor = true;
            this.buttonYukle.Click += new System.EventHandler(this.buttonYukle_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.buttonYukle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTablo);
            this.Controls.Add(this.textBoxSeriNo);
            this.Controls.Add(this.comboBoxLokasyon);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button buttonYukle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriNo;
    }
}

