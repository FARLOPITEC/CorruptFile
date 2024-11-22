using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CorromperFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_examine.Click += Button_examine_Click!;
            button_Corromper.Click += Button_Corromper_Click!;
            button_sanear.Click += Button_sanear_Click!;
        }

        private void Button_examine_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_examine.Text = openFileDialog.FileName;
                }
            }
        }

        private void Button_Corromper_Click(object? sender, EventArgs e)
        {
            string filePath = textBox_examine.Text;
            string key = textBox_key.Text;

            if (File.Exists(filePath) && !string.IsNullOrEmpty(key))
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);
                byte[] corruptedBytes = CorruptBytes(fileBytes, key);
                File.WriteAllBytes(filePath, corruptedBytes);
                MessageBox.Show("Fichero corrompido con éxito.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un fichero y proporcione una clave.");
            }
        }

        private void Button_sanear_Click(object? sender, EventArgs e)
        {
            string filePath = textBox_examine.Text;
            string key = textBox_key.Text;

            if (File.Exists(filePath) && !string.IsNullOrEmpty(key))
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);
                byte[] sanitizedBytes = SanitizeBytes(fileBytes, key);
                File.WriteAllBytes(filePath, sanitizedBytes);
                MessageBox.Show("Fichero saneado con éxito.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un fichero y proporcione una clave.");
            }
        }

        private byte[] CorruptBytes(byte[] bytes, string key)
        {
            int keyLength = key.Length;
            return bytes.Select((b, i) => (byte)(b ^ key[i % keyLength])).ToArray();
        }

        private byte[] SanitizeBytes(byte[] bytes, string key)
        {
            // La operación de corrupción es reversible, así que usamos el mismo método
            return CorruptBytes(bytes, key);
        }
    }
}

