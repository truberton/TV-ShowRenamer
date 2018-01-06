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
    public partial class Kustutamine : Form
    {
        public string failiTüüp;

        public Kustutamine()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            failiTüüp = objTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
            string text = ((Form1)f).text;

            string[] AllFiles = Directory.GetFiles(text, "*" + failiTüüp);

            foreach (string file in AllFiles)
            {
                File.Delete(file);
            }
            MessageBox.Show("Kõik " + failiTüüp + " failid on kustutatud");
            this.Close();
        }

        private void Kustutamine_Load(object sender, EventArgs e)
        {

        }
    }
}
