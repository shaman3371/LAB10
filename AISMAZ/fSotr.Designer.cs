
namespace AISMAZ
{
    partial class fSotr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSotr));
            this.exitsotr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSotrydnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDoljnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.doljnostiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mazDataSet = new AISMAZ.MazDataSet();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ystrdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotrydnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrydnikiTableAdapter = new AISMAZ.MazDataSetTableAdapters.SotrydnikiTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDoljnostiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenDoljonstiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doljnostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doljnostiTableAdapter = new AISMAZ.MazDataSetTableAdapters.DoljnostiTableAdapter();
            this.savesotr = new System.Windows.Forms.Button();
            this.savedoljn = new System.Windows.Forms.Button();
            this.doljnostiSotrydnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delsotr = new System.Windows.Forms.Button();
            this.poisksotr = new System.Windows.Forms.Button();
            this.textBoxsotr = new System.Windows.Forms.TextBox();
            this.deldoljn = new System.Windows.Forms.Button();
            this.poiskdoljn = new System.Windows.Forms.Button();
            this.textBoxdoljn = new System.Windows.Forms.TextBox();
            this.btnsaveWord = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiSotrydnikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitsotr
            // 
            this.exitsotr.Location = new System.Drawing.Point(843, 617);
            this.exitsotr.Name = "exitsotr";
            this.exitsotr.Size = new System.Drawing.Size(109, 32);
            this.exitsotr.TabIndex = 0;
            this.exitsotr.Text = "Закрыть";
            this.exitsotr.UseVisualStyleBackColor = true;
            this.exitsotr.Click += new System.EventHandler(this.exitsotr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSotrydnikDataGridViewTextBoxColumn,
            this.iDDoljnostiDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.bDDateDataGridViewTextBoxColumn,
            this.ystrdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sotrydnikiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 295);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDSotrydnikDataGridViewTextBoxColumn
            // 
            this.iDSotrydnikDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrydnik";
            this.iDSotrydnikDataGridViewTextBoxColumn.HeaderText = "ID_Sotrydnik";
            this.iDSotrydnikDataGridViewTextBoxColumn.Name = "iDSotrydnikDataGridViewTextBoxColumn";
            this.iDSotrydnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDoljnostiDataGridViewTextBoxColumn
            // 
            this.iDDoljnostiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDoljnostiDataGridViewTextBoxColumn.DataPropertyName = "ID_Doljnosti";
            this.iDDoljnostiDataGridViewTextBoxColumn.DataSource = this.doljnostiBindingSource1;
            this.iDDoljnostiDataGridViewTextBoxColumn.DisplayMember = "Naimen_Doljonsti";
            this.iDDoljnostiDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.iDDoljnostiDataGridViewTextBoxColumn.Name = "iDDoljnostiDataGridViewTextBoxColumn";
            this.iDDoljnostiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDoljnostiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDoljnostiDataGridViewTextBoxColumn.ValueMember = "ID_Doljnosti";
            this.iDDoljnostiDataGridViewTextBoxColumn.Width = 126;
            // 
            // doljnostiBindingSource1
            // 
            this.doljnostiBindingSource1.DataMember = "Doljnosti";
            this.doljnostiBindingSource1.DataSource = this.mazDataSet;
            // 
            // mazDataSet
            // 
            this.mazDataSet.DataSetName = "MazDataSet";
            this.mazDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 107;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "middle_name";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.Width = 111;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 67;
            // 
            // bDDateDataGridViewTextBoxColumn
            // 
            this.bDDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bDDateDataGridViewTextBoxColumn.DataPropertyName = "BD_Date";
            this.bDDateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.bDDateDataGridViewTextBoxColumn.Name = "bDDateDataGridViewTextBoxColumn";
            // 
            // ystrdateDataGridViewTextBoxColumn
            // 
            this.ystrdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ystrdateDataGridViewTextBoxColumn.DataPropertyName = "ystr_date";
            this.ystrdateDataGridViewTextBoxColumn.HeaderText = "Дата устройства";
            this.ystrdateDataGridViewTextBoxColumn.Name = "ystrdateDataGridViewTextBoxColumn";
            // 
            // sotrydnikiBindingSource
            // 
            this.sotrydnikiBindingSource.DataMember = "Sotrydniki";
            this.sotrydnikiBindingSource.DataSource = this.mazDataSet;
            // 
            // sotrydnikiTableAdapter
            // 
            this.sotrydnikiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDoljnostiDataGridViewTextBoxColumn1,
            this.naimenDoljonstiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.doljnostiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(182, 402);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(346, 159);
            this.dataGridView2.TabIndex = 2;
            // 
            // iDDoljnostiDataGridViewTextBoxColumn1
            // 
            this.iDDoljnostiDataGridViewTextBoxColumn1.DataPropertyName = "ID_Doljnosti";
            this.iDDoljnostiDataGridViewTextBoxColumn1.HeaderText = "ИД_Должность";
            this.iDDoljnostiDataGridViewTextBoxColumn1.Name = "iDDoljnostiDataGridViewTextBoxColumn1";
            this.iDDoljnostiDataGridViewTextBoxColumn1.Visible = false;
            // 
            // naimenDoljonstiDataGridViewTextBoxColumn
            // 
            this.naimenDoljonstiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naimenDoljonstiDataGridViewTextBoxColumn.DataPropertyName = "Naimen_Doljonsti";
            this.naimenDoljonstiDataGridViewTextBoxColumn.HeaderText = "Наименование должности";
            this.naimenDoljonstiDataGridViewTextBoxColumn.Name = "naimenDoljonstiDataGridViewTextBoxColumn";
            // 
            // doljnostiBindingSource
            // 
            this.doljnostiBindingSource.DataMember = "Doljnosti";
            this.doljnostiBindingSource.DataSource = this.mazDataSet;
            // 
            // doljnostiTableAdapter
            // 
            this.doljnostiTableAdapter.ClearBeforeFill = true;
            // 
            // savesotr
            // 
            this.savesotr.Location = new System.Drawing.Point(843, 159);
            this.savesotr.Name = "savesotr";
            this.savesotr.Size = new System.Drawing.Size(109, 32);
            this.savesotr.TabIndex = 3;
            this.savesotr.Text = "Сохранить";
            this.toolTip1.SetToolTip(this.savesotr, "Сохранить сотрудника");
            this.savesotr.UseVisualStyleBackColor = true;
            this.savesotr.Click += new System.EventHandler(this.savesotr_Click);
            // 
            // savedoljn
            // 
            this.savedoljn.Location = new System.Drawing.Point(534, 401);
            this.savedoljn.Name = "savedoljn";
            this.savedoljn.Size = new System.Drawing.Size(109, 32);
            this.savedoljn.TabIndex = 4;
            this.savedoljn.Text = "Сохранить";
            this.toolTip1.SetToolTip(this.savedoljn, "Сохранить должность");
            this.savedoljn.UseVisualStyleBackColor = true;
            this.savedoljn.Click += new System.EventHandler(this.savedoljn_Click);
            // 
            // doljnostiSotrydnikiBindingSource
            // 
            this.doljnostiSotrydnikiBindingSource.DataMember = "DoljnostiSotrydniki";
            this.doljnostiSotrydnikiBindingSource.DataSource = this.doljnostiBindingSource;
            // 
            // delsotr
            // 
            this.delsotr.Location = new System.Drawing.Point(843, 230);
            this.delsotr.Name = "delsotr";
            this.delsotr.Size = new System.Drawing.Size(109, 32);
            this.delsotr.TabIndex = 5;
            this.delsotr.Text = "Удалить";
            this.toolTip1.SetToolTip(this.delsotr, "Удалить сотрудника");
            this.delsotr.UseVisualStyleBackColor = true;
            this.delsotr.Click += new System.EventHandler(this.delsotr_Click);
            // 
            // poisksotr
            // 
            this.poisksotr.Location = new System.Drawing.Point(843, 308);
            this.poisksotr.Name = "poisksotr";
            this.poisksotr.Size = new System.Drawing.Size(109, 32);
            this.poisksotr.TabIndex = 6;
            this.poisksotr.Text = "Поиск";
            this.toolTip1.SetToolTip(this.poisksotr, "Поиск сотрудника");
            this.poisksotr.UseVisualStyleBackColor = true;
            this.poisksotr.Click += new System.EventHandler(this.poisksotr_Click);
            // 
            // textBoxsotr
            // 
            this.textBoxsotr.Location = new System.Drawing.Point(757, 346);
            this.textBoxsotr.Name = "textBoxsotr";
            this.textBoxsotr.Size = new System.Drawing.Size(195, 29);
            this.textBoxsotr.TabIndex = 7;
            // 
            // deldoljn
            // 
            this.deldoljn.Location = new System.Drawing.Point(534, 464);
            this.deldoljn.Name = "deldoljn";
            this.deldoljn.Size = new System.Drawing.Size(109, 32);
            this.deldoljn.TabIndex = 8;
            this.deldoljn.Text = "Удалить";
            this.toolTip1.SetToolTip(this.deldoljn, "Удалить должность");
            this.deldoljn.UseVisualStyleBackColor = true;
            this.deldoljn.Click += new System.EventHandler(this.deldoljn_Click);
            // 
            // poiskdoljn
            // 
            this.poiskdoljn.Location = new System.Drawing.Point(534, 529);
            this.poiskdoljn.Name = "poiskdoljn";
            this.poiskdoljn.Size = new System.Drawing.Size(109, 32);
            this.poiskdoljn.TabIndex = 9;
            this.poiskdoljn.Text = "Поиск";
            this.toolTip1.SetToolTip(this.poiskdoljn, "Поиск должности");
            this.poiskdoljn.UseVisualStyleBackColor = true;
            this.poiskdoljn.Click += new System.EventHandler(this.poiskdoljn_Click);
            // 
            // textBoxdoljn
            // 
            this.textBoxdoljn.Location = new System.Drawing.Point(448, 567);
            this.textBoxdoljn.Name = "textBoxdoljn";
            this.textBoxdoljn.Size = new System.Drawing.Size(195, 29);
            this.textBoxdoljn.TabIndex = 10;
            // 
            // btnsaveWord
            // 
            this.btnsaveWord.Location = new System.Drawing.Point(666, 617);
            this.btnsaveWord.Name = "btnsaveWord";
            this.btnsaveWord.Size = new System.Drawing.Size(146, 32);
            this.btnsaveWord.TabIndex = 11;
            this.btnsaveWord.Text = "Экспорт в ворд";
            this.toolTip1.SetToolTip(this.btnsaveWord, "Экспорт сотрудника в ворд");
            this.btnsaveWord.UseVisualStyleBackColor = true;
            this.btnsaveWord.Click += new System.EventHandler(this.btnsaveWord_Click);
            // 
            // fSotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 661);
            this.Controls.Add(this.btnsaveWord);
            this.Controls.Add(this.textBoxdoljn);
            this.Controls.Add(this.poiskdoljn);
            this.Controls.Add(this.deldoljn);
            this.Controls.Add(this.textBoxsotr);
            this.Controls.Add(this.poisksotr);
            this.Controls.Add(this.delsotr);
            this.Controls.Add(this.savedoljn);
            this.Controls.Add(this.savesotr);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitsotr);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(980, 700);
            this.Name = "fSotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление сотрудниками предприятия";
            this.Load += new System.EventHandler(this.fSotr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiSotrydnikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitsotr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MazDataSet mazDataSet;
        private System.Windows.Forms.BindingSource sotrydnikiBindingSource;
        private MazDataSetTableAdapters.SotrydnikiTableAdapter sotrydnikiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource doljnostiBindingSource;
        private MazDataSetTableAdapters.DoljnostiTableAdapter doljnostiTableAdapter;
        private System.Windows.Forms.Button savesotr;
        private System.Windows.Forms.Button savedoljn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDoljnostiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenDoljonstiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doljnostiBindingSource1;
        private System.Windows.Forms.BindingSource doljnostiSotrydnikiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrydnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDDoljnostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ystrdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delsotr;
        private System.Windows.Forms.Button poisksotr;
        private System.Windows.Forms.TextBox textBoxsotr;
        private System.Windows.Forms.Button deldoljn;
        private System.Windows.Forms.Button poiskdoljn;
        private System.Windows.Forms.TextBox textBoxdoljn;
        private System.Windows.Forms.Button btnsaveWord;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}