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
    public partial class fProdPost : Form
    {
        public fProdPost()
        {
            InitializeComponent();
        }

        private void exitprodpost_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fProdPost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Klienti". При необходимости она может быть перемещена или удалена.
            this.klientiTableAdapter.Fill(this.mazDataSet.Klienti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Sotrydniki". При необходимости она может быть перемещена или удалена.
            this.sotrydnikiTableAdapter.Fill(this.mazDataSet.Sotrydniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Postavshiki". При необходимости она может быть перемещена или удалена.
            this.postavshikiTableAdapter.Fill(this.mazDataSet.Postavshiki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Tovari". При необходимости она может быть перемещена или удалена.
            this.tovariTableAdapter.Fill(this.mazDataSet.Tovari);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Prodaja_tovarov". При необходимости она может быть перемещена или удалена.
            this.prodaja_tovarovTableAdapter.Fill(this.mazDataSet.Prodaja_tovarov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Postavka_tovarov". При необходимости она может быть перемещена или удалена.
            this.postavka_tovarovTableAdapter.Fill(this.mazDataSet.Postavka_tovarov);

        }

        private void savepostavka_Click(object sender, EventArgs e)
        {
            postavkatovarovBindingSource.EndEdit();
            postavka_tovarovTableAdapter.Update(mazDataSet.Postavka_tovarov);
        }

        private void saveprodaja_Click(object sender, EventArgs e)
        {
            prodajatovarovBindingSource.EndEdit();
            prodaja_tovarovTableAdapter.Update(mazDataSet.Prodaja_tovarov);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                            if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBoxprodaja.Text))
                            {
                                dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void delpostavka_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }

        private void delprodaja_Click(object sender, EventArgs e)
        {
            int a = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.Remove(dataGridView2.Rows[a]);
        }

        private void poiskpostavka_Click(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxpostavka.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
