using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace besinci_tsk_4_
{
    public partial class AxtarisForm : Form
    {
        public string AxtarilanAd
        {
            get { return txtAxtaris.Text.Trim(); }
        }
        public AxtarisForm()
        {
            InitializeComponent();
        }


        private void btnAxtar_Click(object sender, EventArgs e)
        {
            string ad = txtAxtaris.Text.Trim();

            if (ad == "")
            {
                MessageBox.Show("Ad daxil edin!");
                return;
            }

            if (!ad.All(char.IsLetter))
            {
                MessageBox.Show("Duzgun ad daxil edin! Ad yalniz herflerden ibaret olmalidir.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
