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
            label1.Visible = false;
            textBoxSeriNo.Visible = false;
            dataGridViewTablo.Visible = false;
            buttonKaydet.Visible = false;   

        }
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
                try
                {
                    dataGridViewTablo.AllowUserToAddRows = false; // boş satırı kaldırıyoruz
                    long SeriNo = Convert.ToInt64(textBoxSeriNo.Text);
                    int ID = dataGridViewTablo.Rows.Count + 1; //satır sayısına 1 ekle
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

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string CSVKonumu = @"C:\Users\ÖmerSelimBERK\Desktop";
                string CSVAdı = $"{DateTime.Now:yyyy}_{comboBoxLokasyon.Text}.csv";
                string CSVK = Path.Combine(CSVKonumu, CSVAdı);

                using (StreamWriter writer = new StreamWriter(CSVK))
                {
                    writer.WriteLine("ID;SeriNumarasi"); // Başlık satırında da ; kullanılıyor
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
                MessageBox.Show("Verileriniz başarılı bir şekilde kaydedildi!", "Kaydedildi", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Verileriniz kaydedilemedi lütfen tekrar deneyiniz!","Kaydedilemedi", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}