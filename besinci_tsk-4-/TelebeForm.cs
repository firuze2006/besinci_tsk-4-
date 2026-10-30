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
    public partial class TelebeForm : Form
    {
        public TelebeForm()
        {
            InitializeComponent();
        }

        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();

            if (ad == "")
            {
                MessageBox.Show("Adi daxil edin!");
                return;
            }

            if (!ad.All(char.IsLetter))
            {
                MessageBox.Show("Ad yalniz herflerden ibaret olmalidir!");
                return;
            }

            if (!int.TryParse(txtYas.Text, out int yas) || yas <= 0)
            {
                MessageBox.Show("Yasi duzgun daxil edin!");
                return;
            }

            int id = 1;

            if (File.Exists("telebeler.txt"))
            {
                string[] setirler = File.ReadAllLines("telebeler.txt");
                id = setirler.Length + 1;
            }

            using (StreamWriter yaz = new StreamWriter("telebeler.txt", true))
            {
                yaz.WriteLine(id + ";" + ad + ";" + yas);
            }

            MessageBox.Show("Telebe elave edildi!");
            this.Close();
        }
    }
}
