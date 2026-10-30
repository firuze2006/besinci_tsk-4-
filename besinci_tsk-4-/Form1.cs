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


namespace besinci_tsk_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            TelebeForm yeniForm = new TelebeForm();
            yeniForm.ShowDialog();
        }

        private void btnHamisi_Click(object sender, EventArgs e)
        {
            lstTelebeler.Items.Clear();

            if (!File.Exists("telebeler.txt"))
            {
                MessageBox.Show("Hele telebe elave edilmeyib!");
                return;
            }

            string[] setirler = File.ReadAllLines("telebeler.txt");

            foreach (string setir in setirler)
            {
                string[] melumat = setir.Split(';');

                if (melumat.Length == 3)
                {
                    lstTelebeler.Items.Add(
                        "ID: " + melumat[0] +
                        " | Ad: " + melumat[1] +
                        " | Yas: " + melumat[2]
                    );
                }
            }
        }

        private void btnAxtar_Click(object sender, EventArgs e)
        {
            AxtarisForm yeniForm = new AxtarisForm();

            if (yeniForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string axtarilanAd = yeniForm.AxtarilanAd;

            lstTelebeler.Items.Clear();

            if (!File.Exists("telebeler.txt"))
            {
                MessageBox.Show("Telebe siyahisi bosdur!");
                return;
            }

            string[] setirler = File.ReadAllLines("telebeler.txt");

            bool tapildi = false;

            foreach (string setir in setirler)
            {
                string[] melumat = setir.Split(';');

                if (melumat.Length == 3 &&
                    melumat[1].Trim().Equals(
                        axtarilanAd,
                        StringComparison.OrdinalIgnoreCase))
                {
                    lstTelebeler.Items.Add(
                        "ID: " + melumat[0] +
                        " | Ad: " + melumat[1] +
                        " | Yas: " + melumat[2]
                    );

                    tapildi = true;
                }
            }

            if (!tapildi)
            {
                MessageBox.Show("Telebe tapilmadi!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstTelebeler.SelectedIndex == -1)
            {
                MessageBox.Show("Silmek ucun telebe secin!");
                return;
            }

            if (!File.Exists("telebeler.txt"))
            {
                MessageBox.Show("Telebe siyahisi bosdur!");
                return;
            }

            string secilen = lstTelebeler.SelectedItem.ToString();

            string id = secilen.Split('|')[0]
                .Replace("ID:", "").Trim();

            string[] setirler = File.ReadAllLines("telebeler.txt");

            List<string> yeniSetirler = new List<string>();

            foreach (string setir in setirler)
            {
                string[] melumat = setir.Split(';');

                if (melumat.Length == 3 && melumat[0] != id)
                {
                    yeniSetirler.Add(setir);
                }
            }

            File.WriteAllLines("telebeler.txt", yeniSetirler);

            MessageBox.Show("Telebe silindi!");

            lstTelebeler.Items.Clear();
            btnHamisi_Click(sender, e);
        }

        private void btnHamisiniSil_Click(object sender, EventArgs e)
        {
            if (!File.Exists("telebeler.txt"))
            {
                MessageBox.Show("Telebe siyahisi bosdur!");
                return;
            }

            DialogResult cavab = MessageBox.Show(
                "Butun telebeleri silmek isteyirsiniz?",
                "Tesdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (cavab == DialogResult.Yes)
            {
                File.WriteAllText("telebeler.txt", "");

                lstTelebeler.Items.Clear();

                MessageBox.Show("Butun telebeler silindi!");
            }
        }
    }
}

