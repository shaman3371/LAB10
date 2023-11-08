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
    public partial class fPostavshiki : Form
    {
        public fPostavshiki()
        {
            InitializeComponent();
        }

        private void exitpostavsh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fPostavshiki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Type_postavshikov". При необходимости она может быть перемещена или удалена.
            this.type_postavshikovTableAdapter.Fill(this.mazDataSet.Type_postavshikov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Postavshiki". При необходимости она может быть перемещена или удалена.
            this.postavshikiTableAdapter.Fill(this.mazDataSet.Postavshiki);

        }

        private void savepostavshik_Click(object sender, EventArgs e)
        {
            postavshikiBindingSource.EndEdit();
            postavshikiTableAdapter.Update(mazDataSet.Postavshiki);
        }

        private void savetype_Click(object sender, EventArgs e)
        {
            typepostavshikovBindingSource.EndEdit();
            type_postavshikovTableAdapter.Update(mazDataSet.Type_postavshikov);
        }

        private void delpostavshik_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }

        private void deltype_Click(object sender, EventArgs e)
        {
            int a = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.Remove(dataGridView2.Rows[a]);
        }

        private void poiskpostavshik_Click(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxpostavshik.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }


        private void poisktype_Click(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                            if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBoxtype.Text))
                            {
                                dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                }
            }

        }
    }
}
