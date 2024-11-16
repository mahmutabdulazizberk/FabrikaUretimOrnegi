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
            button1.Visible = true;
        }
        private bool düzenlemeModu = false;
        private void comboBoxLokasyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLokasyon.SelectedItem != null)
            {
                string CSVK = @"C:\Users\ÖmerSelimBERK\Desktop" + "\\" + $"{DateTime.Now:yyyy}_{comboBoxLokasyon.SelectedItem.ToString()}.csv";

                if (File.Exists(CSVK))
                {
                    var mesaj = MessageBox.Show(
                        $"Seçtiğiniz {comboBoxLokasyon.SelectedItem.ToString()} lokasyonu ve {DateTime.Now.Year} yılına ait bir CSV dosyası bulundu. Devam etmek ister misiniz?",
                        "Dosya Bulundu",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                    if (mesaj == DialogResult.Yes)
                    {
                        CSVYukle();
                        düzenlemeModu = true;
                        button1.Visible = true;
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

                if (düzenlemeModu == false) 
                {
                    try
                    {
                        long SeriNo = Convert.ToInt64(textBoxSeriNo.Text);
                        if (SeriNoKullanilmis(SeriNo))
                        {
                            MessageBox.Show("Bu Seri Numarası zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxSeriNo.Clear();
                            textBoxSeriNo.Focus();
                            return;
                        }
                        int ID = IDplus++;
                        dataGridViewTablo.Rows.Add(ID, SeriNo);
                        textBoxSeriNo.Clear();
                        textBoxSeriNo.Focus();
                        CSVKaydet();
                    }
                    catch
                    {
                        MessageBox.Show("Lütfen doğru Seri Numarası giriniz!");
                    }
                }
                else
                {
                    try
                    {
                        long SeriNo = Convert.ToInt64(textBoxSeriNo.Text);
                        if (SeriNoKullanilmis(SeriNo))
                        {
                            MessageBox.Show("Bu Seri Numarası zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxSeriNo.Clear();
                            textBoxSeriNo.Focus();
                            return;
                        }
                        int ID = IDplus++;
                        dataGridViewTablo.Rows.Add(ID, SeriNo);
                        textBoxSeriNo.Clear();
                        textBoxSeriNo.Focus();

                    }
                    catch
                    {
                        MessageBox.Show("Lütfen doğru Seri Numarası giriniz!");
                    }
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
                    string CSVK = CSVKonumu + "\\" + $"{DateTime.Now:yyyy}_{comboBoxLokasyon.Text}.csv";
                    using (StreamWriter writer = new StreamWriter(CSVK, true))
                    {
                        if (new FileInfo(CSVK).Length == 0)
                        {
                            writer.WriteLine("ID;SeriNumarasi");
                        }

                        for (int i = 0; i < dataGridViewTablo.Rows.Count; i++)
                        {
                            string id = " ";
                            string seriNo = " ";

                            if (dataGridViewTablo.Rows[i].Cells[0].Value != null)
                            {
                                id = dataGridViewTablo.Rows[i].Cells[0].Value.ToString();
                            }
                            if (dataGridViewTablo.Rows[i].Cells[1].Value != null)
                            {
                                seriNo = dataGridViewTablo.Rows[i].Cells[1].Value.ToString();
                            }

                            writer.WriteLine($"{id};{seriNo}");
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
                    string CSVK = CSVKonumu + "\\" + CSVAdı;
                    using (StreamWriter writer = new StreamWriter(CSVK, false))
                    {
                        if (new FileInfo(CSVK).Length == 0)
                        {
                            writer.WriteLine("ID;SeriNumarasi");
                        }

                        for (int i = 0; i < dataGridViewTablo.Rows.Count; i++)
                        {
                            string id = " ";
                            string seriNo = " ";

                            if (dataGridViewTablo.Rows[i].Cells[0].Value != null)
                            {
                                id = dataGridViewTablo.Rows[i].Cells[0].Value.ToString();
                            }
                            if (dataGridViewTablo.Rows[i].Cells[1].Value != null)
                            {
                                seriNo = dataGridViewTablo.Rows[i].Cells[1].Value.ToString();
                            }

                            writer.WriteLine($"{id};{seriNo}");
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
            string CSVK = @"C:\Users\ÖmerSelimBERK\Desktop" + "\\" + $"{DateTime.Now:yyyy}_{comboBoxLokasyon.Text}.csv";

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
            else
            {
                MessageBox.Show("Dosya bulunamadı!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string CSVKonumu = @"C:\Users\ÖmerSelimBERK\Desktop";
            string CSVAdı = $"{DateTime.Now:yyyy}_{comboBoxLokasyon.Text}.csv";
            string CSVK = CSVKonumu + "\\" + CSVAdı;

            try
            {
                using (StreamWriter writer = new StreamWriter(CSVK, false))
                {
                    writer.WriteLine("ID;SeriNumarasi");
                    for (int i = 0; i < dataGridViewTablo.Rows.Count; i++)
                    {
                        if (!dataGridViewTablo.Rows[i].IsNewRow)
                        {
                            string id = dataGridViewTablo.Rows[i].Cells[0].Value?.ToString() ?? "";
                            string seriNo = dataGridViewTablo.Rows[i].Cells[1].Value?.ToString() ?? "";
                            writer.WriteLine($"{id};{seriNo}");
                        }
                    }
                }
                MessageBox.Show("Veriler başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Hata oluştu:", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SeriNoKullanilmis(long SeriNo)
        {
            for (int i = 0; i < dataGridViewTablo.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridViewTablo.Rows[i];

                long.TryParse(row.Cells[1].Value.ToString(), out long mevcutSeriNo);
                if (mevcutSeriNo == SeriNo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}


            