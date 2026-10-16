using System;
using System.Windows.Forms;

namespace tapsiriq4
{
    public partial class Form1 : Form
    {
        int sual = 0, bal = 0;

        string[] suallar =
        {
            "Hansı heyvan miyoldayır?",
            "Hansı heyvanın xortumu var?",
            "Hansı heyvan yumurta qoyur?",
            "Hansı heyvanın boynu uzundur?",
            "Hansı heyvan hürür?"
        };

        string[,] cavablar =
        {
            { "Pişik", "İt", "İnək", "At" },
            { "Qoyun", "Fil", "Dovşan", "Keçi" },
            { "Toyuq", "Pişik", "İt", "At" },
            { "Zürafə", "Ayı", "Canavar", "Donuz" },
            { "İt", "İnək", "At", "Dovşan" }
        };

        int[] duzgunCavablar = { 0, 1, 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();

            btnNovbeti.Click += btnNovbeti_Click;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = suallar.Length;

            SualGoster();
        }

        void SualGoster()
        {
            lblSual.Text = (sual + 1) + ". " + suallar[sual];

            rb1.Text = "A) " + cavablar[sual, 0];
            rb2.Text = "B) " + cavablar[sual, 1];
            rb3.Text = "C) " + cavablar[sual, 2];
            rb4.Text = "D) " + cavablar[sual, 3];

            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
        }

        private void btnNovbeti_Click(object sender, EventArgs e)
        {
            int secim;

            if (rb1.Checked) secim = 0;
            else if (rb2.Checked) secim = 1;
            else if (rb3.Checked) secim = 2;
            else if (rb4.Checked) secim = 3;
            else
            {
                MessageBox.Show("Cavab seçin!");
                return;
            }

            if (secim == duzgunCavablar[sual])
                bal++;

            sual++;
            progressBar1.Value = sual;

            if (sual < suallar.Length)
            {
                SualGoster();
            }
            else
            {
                DialogResult cavab = MessageBox.Show(
                    "Nəticə: " + bal + " / " + suallar.Length +
                    "\nYenidən başlamaq istəyirsiniz?（＞人＜；）",
                    "Test bitdi ToT",
                    MessageBoxButtons.YesNo);

                if (cavab == DialogResult.Yes)
                {
                    sual = 0;
                    bal = 0;
                    progressBar1.Value = 0;
                    SualGoster();
                }
                else
                {
                    Close();
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}