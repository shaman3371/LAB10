using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISMAZ
{
    public partial class Maimform : Form
    {
        public Maimform()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            
            ab.ShowDialog();
            ab.Close();
        }

        private void btnclients_Click(object sender, EventArgs e)
        {
            fClienti f2 = new fClienti();

            f2.ShowDialog();
            f2.Close();
        }

        private void btnpost_Click(object sender, EventArgs e)
        {
            fSotr f3 = new fSotr();

            f3.ShowDialog();
            f3.Close();
        }

        private void btntovars_Click(object sender, EventArgs e)
        {
            fTovari f4 = new fTovari();

            f4.ShowDialog();
            f4.Close();
        }

        private void prodajpostav_Click(object sender, EventArgs e)
        {
            fProdPost f5 = new fProdPost();

            f5.ShowDialog();
            f5.Close();
        }

        private void postavshiki_Click(object sender, EventArgs e)
        {
            fPostavshiki f6 = new fPostavshiki();

            f6.ShowDialog();
            f6.Close();
        }

        private void btnExitmain_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы хотите выйти из программы?", "Запрос",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question))
                Close();
        }

        private void Maimform_Load(object sender, EventArgs e)
        {

        }
    }
}
