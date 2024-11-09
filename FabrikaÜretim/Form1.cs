using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabrikaÜretim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridViewTablo.Columns["ID"].ValueType = typeof(int);
            dataGridViewTablo.Columns["SeriNumarasi"].ValueType = typeof(string);
            label1.Visible = false;
            textBoxSeriNo.Visible = false;
            dataGridViewTablo.Visible = false;
            buttonKaydet.Visible = false;   

        }
        private int idSayac = 1;

        private void comboBoxLokasyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLokasyon.SelectedItem != null)
            {
                comboBoxLokasyon.Enabled = false;
                label1.Visible = true;
                textBoxSeriNo.Visible = true;
                dataGridViewTablo.Visible = true;
                buttonKaydet.Visible = true;
            }
        }
        private void textBoxSeriNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                string seriNo = textBoxSeriNo.Text;

                if (!string.IsNullOrEmpty(seriNo))
                {
                    dataGridViewTablo.Rows.Add(idSayac, seriNo);
                    idSayac++;
                    textBoxSeriNo.Clear();
                }
                else
                {
                    MessageBox.Show("Lütfen bir seri numarası girin.");
                }
            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, $"{DateTime.Now:yyyy}_{comboBoxLokasyon.Text}.csv");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("ID;SeriNumarasi");

                    foreach (DataGridViewRow row in dataGridViewTablo.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string id = row.Cells["ID"].Value?.ToString();
                            string seriNumarasi = row.Cells["SeriNumarasi"].Value?.ToString();

                            writer.WriteLine($"{id};{seriNumarasi}");
                        }
                    }
                }
                MessageBox.Show("Veriler başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lokasyonu ComboBox'tan al
                string lokasyon = comboBoxLokasyon.Text;
                if (string.IsNullOrWhiteSpace(lokasyon))
                {
                    MessageBox.Show("Lütfen bir lokasyon seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Masaüstü yolunu al ve dosya yolunu oluştur
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = $"{DateTime.Now.Year}_{lokasyon}.csv";
                string filePath = Path.Combine(desktopPath, fileName);

                // Dosya mevcut mu kontrol et
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"Bu yıl ve lokasyona ait dosya bulunamadı: {fileName}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // CSV dosyasını oku ve DataGridView'e yükle
                using (StreamReader reader = new StreamReader(filePath))
                {
                    dataGridViewTablo.Rows.Clear(); // Mevcut verileri temizle
                    dataGridViewTablo.Columns.Clear(); // Eski sütunları temizle

                    // İlk satırda sütun başlıkları var, bunları ekle
                    string headerLine = reader.ReadLine();
                    if (headerLine != null)
                    {
                        string[] headers = headerLine.Split(',');
                        foreach (string header in headers)
                        {
                            dataGridViewTablo.Columns.Add(header, header);
                        }
                    }

                    // Diğer satırları oku ve DataGridView'e ekle
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        dataGridViewTablo.Rows.Add(values);
                    }
                }

                MessageBox.Show("Veriler başarıyla yüklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}