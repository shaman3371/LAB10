using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace AISMAZ
{
    public partial class fSotr : Form
    {
        public fSotr()
        {
            InitializeComponent();
        }

        private void exitsotr_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fSotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Doljnosti". При необходимости она может быть перемещена или удалена.
            this.doljnostiTableAdapter.Fill(this.mazDataSet.Doljnosti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mazDataSet.Sotrydniki". При необходимости она может быть перемещена или удалена.
            this.sotrydnikiTableAdapter.Fill(this.mazDataSet.Sotrydniki);

        }

        private void savesotr_Click(object sender, EventArgs e)
        {
            sotrydnikiBindingSource.EndEdit();
            sotrydnikiTableAdapter.Update(mazDataSet.Sotrydniki);
        }

        private void savedoljn_Click(object sender, EventArgs e)
        {
            doljnostiBindingSource.EndEdit();
            doljnostiTableAdapter.Update(mazDataSet.Doljnosti);
        }

        private void poisksotr_Click(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxsotr.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void delsotr_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }

        private void deldoljn_Click(object sender, EventArgs e)
        {
            int a = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.Remove(dataGridView2.Rows[a]);
        }

        private void poiskdoljn_Click(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                            if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBoxdoljn.Text))
                            {
                                dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsaveWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Файлы Word (*.doc; *.docx)|*.doc?";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                // Экспорт в Word
                string fn = System.IO.Directory.GetCurrentDirectory() + "\\sotr_card.docx";
                int r = dataGridView1.CurrentCell.RowIndex;

                var dolj = dataGridView1.Rows[r].Cells[1].FormattedValue.ToString();
                var familia = dataGridView1.Rows[r].Cells[2].FormattedValue.ToString();
                var imya = dataGridView1.Rows[r].Cells[3].FormattedValue.ToString();
                var otchest = dataGridView1.Rows[r].Cells[4].FormattedValue.ToString();
                var pol = dataGridView1.Rows[r].Cells[5].FormattedValue.ToString();
                var datarojd = dataGridView1.Rows[r].Cells[6].FormattedValue.ToString();
                var datapriem = dataGridView1.Rows[r].Cells[7].FormattedValue.ToString();

                Word.Application wordApp = new Word.Application();
                wordApp.Visible = false;
                Word.Document wordDocument = wordApp.Documents.Open(fn);

                ReplaceWordStub("{ID_Doljnost}", dolj, wordDocument);
                ReplaceWordStub("{Surname}", familia, wordDocument);
                ReplaceWordStub("{Name}", imya, wordDocument);
                ReplaceWordStub("{middle_name}", otchest, wordDocument);
                ReplaceWordStub("{Sex}", pol, wordDocument);
                ReplaceWordStub("{BD_Date}", datarojd, wordDocument);
                ReplaceWordStub("{ystr_date}", datapriem, wordDocument);



                wordDocument.SaveAs2(sd.FileName);
                wordApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
            }
        }
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document
wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
