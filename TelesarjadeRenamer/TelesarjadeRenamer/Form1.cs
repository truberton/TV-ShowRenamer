using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TelesarjadeRenamer
{
    public partial class Form1 : Form
    {
        public string text;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            text = objTextBox.Text;

            if (!text.EndsWith(@"\"))
            {
                text += @"\";
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Palun täida PATH textbox");
                return;
            }
            Kustutamine kustutamine = new Kustutamine();
            kustutamine.ShowDialog();
        }

        private void Move_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Palun täida PATH textbox");
                return;
            }
            string[] AllFolders = Directory.GetDirectories(text);
            foreach (string folder in AllFolders)
            {
                string[] AllFiles = Directory.GetFiles(folder);
                foreach (string file in AllFiles)
                {
                    if (File.Exists(text + Path.GetFileName(file)))
                    {
                        MessageBox.Show(text + Path.GetFileName(file) + " juba eksisteerib");
                    }
                    else
                    {
                        File.Move(file, text + Path.GetFileName(file));
                    }
                }
            }
            MessageBox.Show("Kõik on folderitest välja toodud!");
            //Console.WriteLine("Kustutada kõik folderid? (y/n)");
            DialogResult res = MessageBox.Show("Kustutada kõik folderid?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                foreach (string folder in AllFolders)
                {
                    Directory.Delete(folder, true);
                }
                MessageBox.Show("Kõik folderid kustutatud");
            }
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Palun täida PATH textbox");
                return;
            }
            Popup popup = new Popup();
            popup.ShowDialog(); 
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }
    }
}
