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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FabrikaÜretim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            textBoxSeriNo.Visible = false;
            dataGridViewTablo.Visible = false;
        }
        private void comboBoxLokasyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLokasyon.SelectedItem != null)
            {
                string CSVKonumu = @"C:\Users\ÖmerSelimBERK\Desktop";
                string CSVAdı = $"{DateTime.Now:yyyy}_{comboBoxLokasyon.SelectedItem.ToString()}.csv";
                string CSVK = Path.Combine(CSVKonumu, CSVAdı);
                if (File.Exists(CSVK))
                {
                    var result = MessageBox.Show($"Seçtiğiniz {comboBoxLokasyon.SelectedItem.ToString()} lokasyonu ve {DateTime.Now.Year} yılına ait bir CSV dosyası bulundu. Devam etmek ister misiniz?", "Dosya Bulundu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        CSVYukle();
                    }
                }
                comboBoxLokasyon.Enabled = false;
                label1.Visible = true;
                textBoxSeriNo.Visible = true;
                dataGridViewTablo.Visible = true;
            }

        }
        int IDplus = 1;
        private void textBoxSeriNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                try
                {
                    long SeriNo = Convert.ToInt64(textBoxSeriNo.Text);
                    int ID = IDplus++;
                    dataGridViewTablo.Rows.Add(ID, SeriNo);
                    CSVKaydet();
                    textBoxSeriNo.Clear();
                    textBoxSeriNo.Focus();
                }
                catch
                {
                    MessageBox.Show("Lütfen doğru Seri Numarası giriniz!");
                }
            }
        }
        private int SonID(string CSVK)
        {
            int sonID = 0;

            if (File.Exists(CSVK))
            {
                using (StreamReader reader = new StreamReader(CSVK))
                {
                    string satır;
                    string sonsatır = null;
                    while ((satır = reader.ReadLine()) != null)
                    {
                        sonsatır = satır;
                    }
                    if (!string.IsNullOrEmpty(sonsatır))
                    {
                        string[] values = sonsatır.Split(';');
                        if (values.Length > 0 && int.TryParse(values[0], out sonID))
                        {
                            return sonID;
                        }
                    }
                }
            }
            return sonID;
        }
        private void CSVKaydet()
        {
            string CSVKonumu = @"C:\Users\ÖmerSelimBERK\Desktop";

            if (File.Exists(CSVKonumu))
            {
                try
                {
                    string CSVAdı = $"{DateTime.Now:yyyy}_{comboBoxLokasyon.Text}.csv";
                    string CSVK = Path.Combine(CSVKonumu, CSVAdı);

                    using (StreamWriter writer = new StreamWriter(CSVK, true))
                    {
                        if (new FileInfo(CSVK).Length == 0)
                        {
                            writer.WriteLine("ID;SeriNumarasi");
                        }
                        for (int i = 0; i < dataGridViewTablo.Rows.Count; i++)
                        {
                            if (!dataGridViewTablo.Rows[i].IsNewRow) // Yeni satırı hariç tut
                            {
                                string id = dataGridViewTablo.Rows[i].Cells[0].Value?.ToString() ?? ""; // ID sütunu
                                string seriNo = dataGridViewTablo.Rows[i].Cells[1].Value?.ToString() ?? ""; // SeriNumarasi sütunu

                                writer.WriteLine($"{id};{seriNo}");
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Verileriniz kaydedilemedi lütfen tekrar deneyiniz!", "Kaydedilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    string CSVAdı = $"{DateTime.Now:yyyy}_{comboBoxLokasyon.Text}.csv";
                    string CSVK = Path.Combine(CSVKonumu, CSVAdı);

                    using (StreamWriter writer = new StreamWriter(CSVK, false))
                    {
                        if (new FileInfo(CSVK).Length == 0)
                        {
                            writer.WriteLine("ID;SeriNumarasi"); // Başlık satırında da ; kullanılıyor
                        }
                        for (int i = 0; i < dataGridViewTablo.Rows.Count; i++)
                        {
                            if (!dataGridViewTablo.Rows[i].IsNewRow) // Yeni satırı hariç tut
                            {
                                string id = dataGridViewTablo.Rows[i].Cells[0].Value?.ToString() ?? ""; // ID sütunu
                                string seriNo = dataGridViewTablo.Rows[i].Cells[1].Value?.ToString() ?? ""; // SeriNumarasi sütunu

                                writer.WriteLine($"{id};{seriNo}");
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Verileriniz kaydedilemedi lütfen tekrar deneyiniz!", "Kaydedilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CSVYukle()
        {
            string CSVKonumu = @"C:\Users\ÖmerSelimBERK\Desktop";
            string CSVAdı = $"{DateTime.Now:yyyy}_{comboBoxLokasyon.Text}.csv";
            string CSVK = Path.Combine(CSVKonumu, CSVAdı);
            if (File.Exists(CSVK))
            {
                IDplus = SonID(CSVK) + 1;
                using (StreamReader reader = new StreamReader(CSVK))
                {
                    string satır;
                    reader.ReadLine();
                    while ((satır = reader.ReadLine()) != null)
                    {
                        string[] values = satır.Split(';');
                        if (values.Length > 1)
                        {
                            dataGridViewTablo.Rows.Add(values[0], values[1]);
                        }
                        else
                        {
                            MessageBox.Show("Hatalı veri formatı: " + satır);
                        }
                    }
                }
            }
            else MessageBox.Show("Dosya bulunamadı!");
        }
    }
}