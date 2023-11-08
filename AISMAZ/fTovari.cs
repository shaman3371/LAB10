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
    public partial class fTovari : Form
    {
        public fTovari()
        {
            InitializeComponent();
        }

        private void exittovars_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fTovari_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Strana". При необходимости она может быть перемещена или удалена.
            this.stranaTableAdapter.Fill(this.mazDataSet.Strana);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Proizvoditeli". При необходимости она может быть перемещена или удалена.
            this.proizvoditeliTableAdapter.Fill(this.mazDataSet.Proizvoditeli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Tovari". При необходимости она может быть перемещена или удалена.
            this.tovariTableAdapter.Fill(this.mazDataSet.Tovari);

        }

        private void savetovari_Click(object sender, EventArgs e)
        {
            tovariBindingSource.EndEdit();
            tovariTableAdapter.Update(mazDataSet.Tovari);
        }

        private void savemanuf_Click(object sender, EventArgs e)
        {
            proizvoditeliBindingSource.EndEdit();
            proizvoditeliTableAdapter.Update(mazDataSet.Proizvoditeli);
        }

        private void savestrana_Click(object sender, EventArgs e)
        {
            stranaBindingSource.EndEdit();
            stranaTableAdapter.Update(mazDataSet.Strana);
        }



        private void deltovari_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }

        private void delmanuf_Click(object sender, EventArgs e)
        {
            int a = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.Remove(dataGridView2.Rows[a]);
        }

        private void delstrana_Click(object sender, EventArgs e)
        {
            int a = dataGridView3.CurrentRow.Index;
            dataGridView3.Rows.Remove(dataGridView3.Rows[a]);
        }

        private void poisktovari_Click(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxtovari.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void poiskmanuf_Click(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                            if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBoxmanuf.Text))
                            {
                                dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void poiskstrana_Click(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    dataGridView3.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView3.ColumnCount; j++)
                        if (dataGridView3.Rows[i].Cells[j].Value != null)
                            if (dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(textBoxstrana.Text))
                            {
                                dataGridView3.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
