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
            this.label3 = new System.Windows.Forms.Label();
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
            "Osmaniye Fabrikası",
            "Göllüce Fabrikası"});
            this.comboBoxLokasyon.Location = new System.Drawing.Point(306, 135);
            this.comboBoxLokasyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLokasyon.Name = "comboBoxLokasyon";
            this.comboBoxLokasyon.Size = new System.Drawing.Size(458, 37);
            this.comboBoxLokasyon.TabIndex = 0;
            this.comboBoxLokasyon.SelectedIndexChanged += new System.EventHandler(this.comboBoxLokasyon_SelectedIndexChanged);
            // 
            // textBoxSeriNo
            // 
            this.textBoxSeriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSeriNo.Location = new System.Drawing.Point(306, 180);
            this.textBoxSeriNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSeriNo.Name = "textBoxSeriNo";
            this.textBoxSeriNo.Size = new System.Drawing.Size(458, 34);
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
            this.dataGridViewTablo.Size = new System.Drawing.Size(843, 150);
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
            this.label1.Location = new System.Drawing.Point(50, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Seri Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fabrika Lokasyonu:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriNo;
    }
}

