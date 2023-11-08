
namespace AISMAZ
{
    partial class fProdPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProdPost));
            this.exitprodpost = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDpostavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tovariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mazDataSet = new AISMAZ.MazDataSet();
            this.iDPostavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.postavshikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDSotrydnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sotrydnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateofpostavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcsesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavkatovarovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavka_tovarovTableAdapter = new AISMAZ.MazDataSetTableAdapters.Postavka_tovarovTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDprodajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTovaraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tovariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDSotrydnikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sotrydnikiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.klientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullpriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcsesprodannoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodajatovarovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodaja_tovarovTableAdapter = new AISMAZ.MazDataSetTableAdapters.Prodaja_tovarovTableAdapter();
            this.savepostavka = new System.Windows.Forms.Button();
            this.saveprodaja = new System.Windows.Forms.Button();
            this.tovariTableAdapter = new AISMAZ.MazDataSetTableAdapters.TovariTableAdapter();
            this.postavshikiTableAdapter = new AISMAZ.MazDataSetTableAdapters.PostavshikiTableAdapter();
            this.sotrydnikiTableAdapter = new AISMAZ.MazDataSetTableAdapters.SotrydnikiTableAdapter();
            this.klientiTableAdapter = new AISMAZ.MazDataSetTableAdapters.KlientiTableAdapter();
            this.delpostavka = new System.Windows.Forms.Button();
            this.poiskpostavka = new System.Windows.Forms.Button();
            this.delprodaja = new System.Windows.Forms.Button();
            this.poiskprodaja = new System.Windows.Forms.Button();
            this.textBoxpostavka = new System.Windows.Forms.TextBox();
            this.textBoxprodaja = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkatovarovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajatovarovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitprodpost
            // 
            this.exitprodpost.Location = new System.Drawing.Point(843, 617);
            this.exitprodpost.Name = "exitprodpost";
            this.exitprodpost.Size = new System.Drawing.Size(109, 32);
            this.exitprodpost.TabIndex = 0;
            this.exitprodpost.Text = "Закрыть";
            this.exitprodpost.UseVisualStyleBackColor = true;
            this.exitprodpost.Click += new System.EventHandler(this.exitprodpost_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpostavkaDataGridViewTextBoxColumn,
            this.iDTovaraDataGridViewTextBoxColumn,
            this.iDPostavshikDataGridViewTextBoxColumn,
            this.iDSotrydnikDataGridViewTextBoxColumn,
            this.dateofpostavkaDataGridViewTextBoxColumn,
            this.pcsesDataGridViewTextBoxColumn,
            this.fullpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postavkatovarovBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 213);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDpostavkaDataGridViewTextBoxColumn
            // 
            this.iDpostavkaDataGridViewTextBoxColumn.DataPropertyName = "ID_postavka";
            this.iDpostavkaDataGridViewTextBoxColumn.HeaderText = "ID_postavka";
            this.iDpostavkaDataGridViewTextBoxColumn.Name = "iDpostavkaDataGridViewTextBoxColumn";
            this.iDpostavkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDTovaraDataGridViewTextBoxColumn
            // 
            this.iDTovaraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDTovaraDataGridViewTextBoxColumn.DataPropertyName = "ID_Tovara";
            this.iDTovaraDataGridViewTextBoxColumn.DataSource = this.tovariBindingSource;
            this.iDTovaraDataGridViewTextBoxColumn.DisplayMember = "Tovar_name";
            this.iDTovaraDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.iDTovaraDataGridViewTextBoxColumn.Name = "iDTovaraDataGridViewTextBoxColumn";
            this.iDTovaraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDTovaraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDTovaraDataGridViewTextBoxColumn.ValueMember = "ID_Tovara";
            this.iDTovaraDataGridViewTextBoxColumn.Width = 83;
            // 
            // tovariBindingSource
            // 
            this.tovariBindingSource.DataMember = "Tovari";
            this.tovariBindingSource.DataSource = this.mazDataSet;
            // 
            // mazDataSet
            // 
            this.mazDataSet.DataSetName = "MazDataSet";
            this.mazDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDPostavshikDataGridViewTextBoxColumn
            // 
            this.iDPostavshikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDPostavshikDataGridViewTextBoxColumn.DataPropertyName = "ID_Postavshik";
            this.iDPostavshikDataGridViewTextBoxColumn.DataSource = this.postavshikiBindingSource;
            this.iDPostavshikDataGridViewTextBoxColumn.DisplayMember = "Company_name";
            this.iDPostavshikDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.iDPostavshikDataGridViewTextBoxColumn.Name = "iDPostavshikDataGridViewTextBoxColumn";
            this.iDPostavshikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDPostavshikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDPostavshikDataGridViewTextBoxColumn.ValueMember = "ID_Postavshik";
            this.iDPostavshikDataGridViewTextBoxColumn.Width = 125;
            // 
            // postavshikiBindingSource
            // 
            this.postavshikiBindingSource.DataMember = "Postavshiki";
            this.postavshikiBindingSource.DataSource = this.mazDataSet;
            // 
            // iDSotrydnikDataGridViewTextBoxColumn
            // 
            this.iDSotrydnikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDSotrydnikDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrydnik";
            this.iDSotrydnikDataGridViewTextBoxColumn.DataSource = this.sotrydnikiBindingSource;
            this.iDSotrydnikDataGridViewTextBoxColumn.DisplayMember = "Surname";
            this.iDSotrydnikDataGridViewTextBoxColumn.HeaderText = "Принявший сотрудник";
            this.iDSotrydnikDataGridViewTextBoxColumn.Name = "iDSotrydnikDataGridViewTextBoxColumn";
            this.iDSotrydnikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDSotrydnikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDSotrydnikDataGridViewTextBoxColumn.ValueMember = "ID_Sotrydnik";
            // 
            // sotrydnikiBindingSource
            // 
            this.sotrydnikiBindingSource.DataMember = "Sotrydniki";
            this.sotrydnikiBindingSource.DataSource = this.mazDataSet;
            // 
            // dateofpostavkaDataGridViewTextBoxColumn
            // 
            this.dateofpostavkaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dateofpostavkaDataGridViewTextBoxColumn.DataPropertyName = "Dateof_postavka";
            this.dateofpostavkaDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateofpostavkaDataGridViewTextBoxColumn.Name = "dateofpostavkaDataGridViewTextBoxColumn";
            this.dateofpostavkaDataGridViewTextBoxColumn.Width = 21;
            // 
            // pcsesDataGridViewTextBoxColumn
            // 
            this.pcsesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pcsesDataGridViewTextBoxColumn.DataPropertyName = "pcses";
            this.pcsesDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.pcsesDataGridViewTextBoxColumn.Name = "pcsesDataGridViewTextBoxColumn";
            this.pcsesDataGridViewTextBoxColumn.Width = 91;
            // 
            // fullpriceDataGridViewTextBoxColumn
            // 
            this.fullpriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.fullpriceDataGridViewTextBoxColumn.DataPropertyName = "Full_price";
            this.fullpriceDataGridViewTextBoxColumn.HeaderText = "Общая цена";
            this.fullpriceDataGridViewTextBoxColumn.Name = "fullpriceDataGridViewTextBoxColumn";
            this.fullpriceDataGridViewTextBoxColumn.Width = 21;
            // 
            // postavkatovarovBindingSource
            // 
            this.postavkatovarovBindingSource.DataMember = "Postavka_tovarov";
            this.postavkatovarovBindingSource.DataSource = this.mazDataSet;
            // 
            // postavka_tovarovTableAdapter
            // 
            this.postavka_tovarovTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDprodajaDataGridViewTextBoxColumn,
            this.iDTovaraDataGridViewTextBoxColumn1,
            this.iDSotrydnikDataGridViewTextBoxColumn1,
            this.iDClientDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.fullpriceDataGridViewTextBoxColumn1,
            this.pcsesprodannoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.prodajatovarovBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 311);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(837, 217);
            this.dataGridView2.TabIndex = 2;
            // 
            // iDprodajaDataGridViewTextBoxColumn
            // 
            this.iDprodajaDataGridViewTextBoxColumn.DataPropertyName = "ID_prodaja";
            this.iDprodajaDataGridViewTextBoxColumn.HeaderText = "ID_prodaja";
            this.iDprodajaDataGridViewTextBoxColumn.Name = "iDprodajaDataGridViewTextBoxColumn";
            this.iDprodajaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDTovaraDataGridViewTextBoxColumn1
            // 
            this.iDTovaraDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDTovaraDataGridViewTextBoxColumn1.DataPropertyName = "ID_Tovara";
            this.iDTovaraDataGridViewTextBoxColumn1.DataSource = this.tovariBindingSource1;
            this.iDTovaraDataGridViewTextBoxColumn1.DisplayMember = "Tovar_name";
            this.iDTovaraDataGridViewTextBoxColumn1.HeaderText = "Товар";
            this.iDTovaraDataGridViewTextBoxColumn1.Name = "iDTovaraDataGridViewTextBoxColumn1";
            this.iDTovaraDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDTovaraDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDTovaraDataGridViewTextBoxColumn1.ValueMember = "ID_Tovara";
            this.iDTovaraDataGridViewTextBoxColumn1.Width = 83;
            // 
            // tovariBindingSource1
            // 
            this.tovariBindingSource1.DataMember = "Tovari";
            this.tovariBindingSource1.DataSource = this.mazDataSet;
            // 
            // iDSotrydnikDataGridViewTextBoxColumn1
            // 
            this.iDSotrydnikDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDSotrydnikDataGridViewTextBoxColumn1.DataPropertyName = "ID_Sotrydnik";
            this.iDSotrydnikDataGridViewTextBoxColumn1.DataSource = this.sotrydnikiBindingSource1;
            this.iDSotrydnikDataGridViewTextBoxColumn1.DisplayMember = "Surname";
            this.iDSotrydnikDataGridViewTextBoxColumn1.HeaderText = "Принявший сотрудник";
            this.iDSotrydnikDataGridViewTextBoxColumn1.Name = "iDSotrydnikDataGridViewTextBoxColumn1";
            this.iDSotrydnikDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDSotrydnikDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDSotrydnikDataGridViewTextBoxColumn1.ValueMember = "ID_Sotrydnik";
            // 
            // sotrydnikiBindingSource1
            // 
            this.sotrydnikiBindingSource1.DataMember = "Sotrydniki";
            this.sotrydnikiBindingSource1.DataSource = this.mazDataSet;
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            this.iDClientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.DataSource = this.klientiBindingSource;
            this.iDClientDataGridViewTextBoxColumn.DisplayMember = "cust_surname";
            this.iDClientDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            this.iDClientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDClientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDClientDataGridViewTextBoxColumn.ValueMember = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.Width = 93;
            // 
            // klientiBindingSource
            // 
            this.klientiBindingSource.DataMember = "Klienti";
            this.klientiBindingSource.DataSource = this.mazDataSet;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // fullpriceDataGridViewTextBoxColumn1
            // 
            this.fullpriceDataGridViewTextBoxColumn1.DataPropertyName = "Full_price";
            this.fullpriceDataGridViewTextBoxColumn1.HeaderText = "Общая стоимость";
            this.fullpriceDataGridViewTextBoxColumn1.Name = "fullpriceDataGridViewTextBoxColumn1";
            // 
            // pcsesprodannoDataGridViewTextBoxColumn
            // 
            this.pcsesprodannoDataGridViewTextBoxColumn.DataPropertyName = "Pcses_prodanno";
            this.pcsesprodannoDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.pcsesprodannoDataGridViewTextBoxColumn.Name = "pcsesprodannoDataGridViewTextBoxColumn";
            // 
            // prodajatovarovBindingSource
            // 
            this.prodajatovarovBindingSource.DataMember = "Prodaja_tovarov";
            this.prodajatovarovBindingSource.DataSource = this.mazDataSet;
            // 
            // prodaja_tovarovTableAdapter
            // 
            this.prodaja_tovarovTableAdapter.ClearBeforeFill = true;
            // 
            // savepostavka
            // 
            this.savepostavka.Location = new System.Drawing.Point(855, 45);
            this.savepostavka.Name = "savepostavka";
            this.savepostavka.Size = new System.Drawing.Size(109, 32);
            this.savepostavka.TabIndex = 3;
            this.savepostavka.Text = "Сохранить";
            this.toolTip1.SetToolTip(this.savepostavka, "Сохранить поставку");
            this.savepostavka.UseVisualStyleBackColor = true;
            this.savepostavka.Click += new System.EventHandler(this.savepostavka_Click);
            // 
            // saveprodaja
            // 
            this.saveprodaja.Location = new System.Drawing.Point(855, 326);
            this.saveprodaja.Name = "saveprodaja";
            this.saveprodaja.Size = new System.Drawing.Size(109, 32);
            this.saveprodaja.TabIndex = 4;
            this.saveprodaja.Text = "Сохранить";
            this.toolTip1.SetToolTip(this.saveprodaja, "Сохранить продажу");
            this.saveprodaja.UseVisualStyleBackColor = true;
            this.saveprodaja.Click += new System.EventHandler(this.saveprodaja_Click);
            // 
            // tovariTableAdapter
            // 
            this.tovariTableAdapter.ClearBeforeFill = true;
            // 
            // postavshikiTableAdapter
            // 
            this.postavshikiTableAdapter.ClearBeforeFill = true;
            // 
            // sotrydnikiTableAdapter
            // 
            this.sotrydnikiTableAdapter.ClearBeforeFill = true;
            // 
            // klientiTableAdapter
            // 
            this.klientiTableAdapter.ClearBeforeFill = true;
            // 
            // delpostavka
            // 
            this.delpostavka.Location = new System.Drawing.Point(855, 126);
            this.delpostavka.Name = "delpostavka";
            this.delpostavka.Size = new System.Drawing.Size(109, 32);
            this.delpostavka.TabIndex = 5;
            this.delpostavka.Text = "Удалить";
            this.toolTip1.SetToolTip(this.delpostavka, " Удалить поставку");
            this.delpostavka.UseVisualStyleBackColor = true;
            this.delpostavka.Click += new System.EventHandler(this.delpostavka_Click);
            // 
            // poiskpostavka
            // 
            this.poiskpostavka.Location = new System.Drawing.Point(855, 212);
            this.poiskpostavka.Name = "poiskpostavka";
            this.poiskpostavka.Size = new System.Drawing.Size(109, 32);
            this.poiskpostavka.TabIndex = 6;
            this.poiskpostavka.Text = "Поиск";
            this.toolTip1.SetToolTip(this.poiskpostavka, "Поиск поставки");
            this.poiskpostavka.UseVisualStyleBackColor = true;
            this.poiskpostavka.Click += new System.EventHandler(this.poiskpostavka_Click);
            // 
            // delprodaja
            // 
            this.delprodaja.Location = new System.Drawing.Point(855, 410);
            this.delprodaja.Name = "delprodaja";
            this.delprodaja.Size = new System.Drawing.Size(109, 32);
            this.delprodaja.TabIndex = 7;
            this.delprodaja.Text = "Удалить";
            this.toolTip1.SetToolTip(this.delprodaja, "Удалить продажу");
            this.delprodaja.UseVisualStyleBackColor = true;
            this.delprodaja.Click += new System.EventHandler(this.delprodaja_Click);
            // 
            // poiskprodaja
            // 
            this.poiskprodaja.Location = new System.Drawing.Point(855, 496);
            this.poiskprodaja.Name = "poiskprodaja";
            this.poiskprodaja.Size = new System.Drawing.Size(109, 32);
            this.poiskprodaja.TabIndex = 8;
            this.poiskprodaja.Text = "Поиск";
            this.toolTip1.SetToolTip(this.poiskprodaja, "Поиск продажи");
            this.poiskprodaja.UseVisualStyleBackColor = true;
            this.poiskprodaja.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxpostavka
            // 
            this.textBoxpostavka.Location = new System.Drawing.Point(769, 250);
            this.textBoxpostavka.Name = "textBoxpostavka";
            this.textBoxpostavka.Size = new System.Drawing.Size(195, 29);
            this.textBoxpostavka.TabIndex = 9;
            // 
            // textBoxprodaja
            // 
            this.textBoxprodaja.Location = new System.Drawing.Point(769, 534);
            this.textBoxprodaja.Name = "textBoxprodaja";
            this.textBoxprodaja.Size = new System.Drawing.Size(195, 29);
            this.textBoxprodaja.TabIndex = 10;
            // 
            // fProdPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 661);
            this.Controls.Add(this.textBoxprodaja);
            this.Controls.Add(this.textBoxpostavka);
            this.Controls.Add(this.poiskprodaja);
            this.Controls.Add(this.delprodaja);
            this.Controls.Add(this.poiskpostavka);
            this.Controls.Add(this.delpostavka);
            this.Controls.Add(this.saveprodaja);
            this.Controls.Add(this.savepostavka);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitprodpost);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(980, 700);
            this.Name = "fProdPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Просмотр продаж и поставок";
            this.Load += new System.EventHandler(this.fProdPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkatovarovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodajatovarovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitprodpost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MazDataSet mazDataSet;
        private System.Windows.Forms.BindingSource postavkatovarovBindingSource;
        private MazDataSetTableAdapters.Postavka_tovarovTableAdapter postavka_tovarovTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource prodajatovarovBindingSource;
        private MazDataSetTableAdapters.Prodaja_tovarovTableAdapter prodaja_tovarovTableAdapter;
        private System.Windows.Forms.Button savepostavka;
        private System.Windows.Forms.Button saveprodaja;
        private System.Windows.Forms.BindingSource tovariBindingSource;
        private MazDataSetTableAdapters.TovariTableAdapter tovariTableAdapter;
        private System.Windows.Forms.BindingSource postavshikiBindingSource;
        private MazDataSetTableAdapters.PostavshikiTableAdapter postavshikiTableAdapter;
        private System.Windows.Forms.BindingSource sotrydnikiBindingSource;
        private MazDataSetTableAdapters.SotrydnikiTableAdapter sotrydnikiTableAdapter;
        private System.Windows.Forms.BindingSource tovariBindingSource1;
        private System.Windows.Forms.BindingSource sotrydnikiBindingSource1;
        private System.Windows.Forms.BindingSource klientiBindingSource;
        private MazDataSetTableAdapters.KlientiTableAdapter klientiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpostavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDTovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDPostavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDSotrydnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofpostavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcsesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDprodajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDTovaraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDSotrydnikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullpriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcsesprodannoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delpostavka;
        private System.Windows.Forms.Button poiskpostavka;
        private System.Windows.Forms.Button delprodaja;
        private System.Windows.Forms.Button poiskprodaja;
        private System.Windows.Forms.TextBox textBoxpostavka;
        private System.Windows.Forms.TextBox textBoxprodaja;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}