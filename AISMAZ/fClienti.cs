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
    public partial class fClienti : Form
    {
        public fClienti()
        {
            InitializeComponent();
        }

        private void fClienti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Klienti". При необходимости она может быть перемещена или удалена.
            this.klientiTableAdapter.Fill(this.mazDataSet.Klienti);

        }

        private void exitclients_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveclients_Click(object sender, EventArgs e)
        {
            klientiBindingSource.EndEdit();
            klientiTableAdapter.Update(mazDataSet.Klienti);
        }

        private void delclients_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }

        private void poiskclients_Click(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxclients.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
