
namespace AISMAZ
{
    partial class fTovari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTovari));
            this.exittovars = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDTovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.proizvoditeliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mazDataSet = new AISMAZ.MazDataSet();
            this.iDCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stranaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buypriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovariTableAdapter = new AISMAZ.MazDataSetTableAdapters.TovariTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDManufacturerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvoditeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvoditeliTableAdapter = new AISMAZ.MazDataSetTableAdapters.ProizvoditeliTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDCountryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stranaTableAdapter = new AISMAZ.MazDataSetTableAdapters.StranaTableAdapter();
            this.savetovari = new System.Windows.Forms.Button();
            this.savemanuf = new System.Windows.Forms.Button();
            this.savestrana = new System.Windows.Forms.Button();
            this.deltovari = new System.Windows.Forms.Button();
            this.poisktovari = new System.Windows.Forms.Button();
            this.textBoxtovari = new System.Windows.Forms.TextBox();
            this.delmanuf = new System.Windows.Forms.Button();
            this.poiskmanuf = new System.Windows.Forms.Button();
            this.textBoxmanuf = new System.Windows.Forms.TextBox();
            this.textBoxstrana = new System.Windows.Forms.TextBox();
            this.delstrana = new System.Windows.Forms.Button();
            this.poiskstrana = new System.Windows.Forms.Button();
            this.stranaTovariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stranaTovariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proizvoditeliTovariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditeliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stranaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stranaTovariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stranaTovariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditeliTovariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exittovars
            // 
            this.exittovars.Location = new System.Drawing.Point(843, 617);
            this.exittovars.Name = "exittovars";
            this.exittovars.Size = new System.Drawing.Size(109, 32);
            this.exittovars.TabIndex = 0;
            this.exittovars.Text = "Закрыть";
            this.exittovars.UseVisualStyleBackColor = true;
            this.exittovars.Click += new System.EventHandler(this.exittovars_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTovaraDataGridViewTextBoxColumn,
            this.tovarnameDataGridViewTextBoxColumn,
            this.iDManufacturerDataGridViewTextBoxColumn,
            this.iDCountryDataGridViewTextBoxColumn,
            this.buypriceDataGridViewTextBoxColumn,
            this.sellpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tovariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 270);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDTovaraDataGridViewTextBoxColumn
            // 
            this.iDTovaraDataGridViewTextBoxColumn.DataPropertyName = "ID_Tovara";
            this.iDTovaraDataGridViewTextBoxColumn.HeaderText = "ID_Tovara";
            this.iDTovaraDataGridViewTextBoxColumn.Name = "iDTovaraDataGridViewTextBoxColumn";
            this.iDTovaraDataGridViewTextBoxColumn.Visible = false;
            // 
            // tovarnameDataGridViewTextBoxColumn
            // 
            this.tovarnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tovarnameDataGridViewTextBoxColumn.DataPropertyName = "Tovar_name";
            this.tovarnameDataGridViewTextBoxColumn.HeaderText = "Наименование товара";
            this.tovarnameDataGridViewTextBoxColumn.Name = "tovarnameDataGridViewTextBoxColumn";
            this.tovarnameDataGridViewTextBoxColumn.Width = 190;
            // 
            // iDManufacturerDataGridViewTextBoxColumn
            // 
            this.iDManufacturerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDManufacturerDataGridViewTextBoxColumn.DataPropertyName = "ID_Manufacturer";
            this.iDManufacturerDataGridViewTextBoxColumn.DataSource = this.proizvoditeliBindingSource1;
            this.iDManufacturerDataGridViewTextBoxColumn.DisplayMember = "Manufacturer_name";
            this.iDManufacturerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.iDManufacturerDataGridViewTextBoxColumn.Name = "iDManufacturerDataGridViewTextBoxColumn";
            this.iDManufacturerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDManufacturerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDManufacturerDataGridViewTextBoxColumn.ValueMember = "ID_Manufacturer";
            this.iDManufacturerDataGridViewTextBoxColumn.Width = 158;
            // 
            // proizvoditeliBindingSource1
            // 
            this.proizvoditeliBindingSource1.DataMember = "Proizvoditeli";
            this.proizvoditeliBindingSource1.DataSource = this.mazDataSet;
            // 
            // mazDataSet
            // 
            this.mazDataSet.DataSetName = "MazDataSet";
            this.mazDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDCountryDataGridViewTextBoxColumn
            // 
            this.iDCountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDCountryDataGridViewTextBoxColumn.DataPropertyName = "ID_Country";
            this.iDCountryDataGridViewTextBoxColumn.DataSource = this.stranaBindingSource;
            this.iDCountryDataGridViewTextBoxColumn.DisplayMember = "Country_Name";
            this.iDCountryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.iDCountryDataGridViewTextBoxColumn.Name = "iDCountryDataGridViewTextBoxColumn";
            this.iDCountryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDCountryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDCountryDataGridViewTextBoxColumn.ValueMember = "ID_Country";
            this.iDCountryDataGridViewTextBoxColumn.Width = 92;
            // 
            // stranaBindingSource
            // 
            this.stranaBindingSource.DataMember = "Strana";
            this.stranaBindingSource.DataSource = this.mazDataSet;
            // 
            // buypriceDataGridViewTextBoxColumn
            // 
            this.buypriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buypriceDataGridViewTextBoxColumn.DataPropertyName = "Buy_price";
            this.buypriceDataGridViewTextBoxColumn.HeaderText = "Цена закупки";
            this.buypriceDataGridViewTextBoxColumn.Name = "buypriceDataGridViewTextBoxColumn";
            // 
            // sellpriceDataGridViewTextBoxColumn
            // 
            this.sellpriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellpriceDataGridViewTextBoxColumn.DataPropertyName = "Sell_price";
            this.sellpriceDataGridViewTextBoxColumn.HeaderText = "Цена продажи";
            this.sellpriceDataGridViewTextBoxColumn.Name = "sellpriceDataGridViewTextBoxColumn";
            // 
            // tovariBindingSource
            // 
            this.tovariBindingSource.DataMember = "Tovari";
            this.tovariBindingSource.DataSource = this.mazDataSet;
            // 
            // tovariTableAdapter
            // 
            this.tovariTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDManufacturerDataGridViewTextBoxColumn1,
            this.manufacturernameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.proizvoditeliBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 352);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(302, 163);
            this.dataGridView2.TabIndex = 2;
            // 
            // iDManufacturerDataGridViewTextBoxColumn1
            // 
            this.iDManufacturerDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDManufacturerDataGridViewTextBoxColumn1.DataPropertyName = "ID_Manufacturer";
            this.iDManufacturerDataGridViewTextBoxColumn1.HeaderText = "ИД_Производитель";
            this.iDManufacturerDataGridViewTextBoxColumn1.Name = "iDManufacturerDataGridViewTextBoxColumn1";
            this.iDManufacturerDataGridViewTextBoxColumn1.Visible = false;
            // 
            // manufacturernameDataGridViewTextBoxColumn
            // 
            this.manufacturernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manufacturernameDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer_name";
            this.manufacturernameDataGridViewTextBoxColumn.HeaderText = "Наименование производителя";
            this.manufacturernameDataGridViewTextBoxColumn.Name = "manufacturernameDataGridViewTextBoxColumn";
            // 
            // proizvoditeliBindingSource
            // 
            this.proizvoditeliBindingSource.DataMember = "Proizvoditeli";
            this.proizvoditeliBindingSource.DataSource = this.mazDataSet;
            // 
            // proizvoditeliTableAdapter
            // 
            this.proizvoditeliTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCountryDataGridViewTextBoxColumn1,
            this.countryNameDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.stranaBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(525, 352);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(220, 163);
            this.dataGridView3.TabIndex = 3;
            // 
            // iDCountryDataGridViewTextBoxColumn1
            // 
            this.iDCountryDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDCountryDataGridViewTextBoxColumn1.DataPropertyName = "ID_Country";
            this.iDCountryDataGridViewTextBoxColumn1.HeaderText = "ИД_Страна";
            this.iDCountryDataGridViewTextBoxColumn1.Name = "iDCountryDataGridViewTextBoxColumn1";
            this.iDCountryDataGridViewTextBoxColumn1.Visible = false;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "Country_Name";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "Название страны";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            // 
            // stranaTableAdapter
            // 
            this.stranaTableAdapter.ClearBeforeFill = true;
            // 
            // savetovari
            // 
            this.savetovari.Location = new System.Drawing.Point(792, 102);
            this.savetovari.Name = "savetovari";
            this.savetovari.Size = new System.Drawing.Size(109, 32);
            this.savetovari.TabIndex = 4;
            this.savetovari.Text = "Сохранить";
            this.toolTip1.SetToolTip(this.savetovari, "Сохранить товар");
            this.savetovari.UseVisualStyleBackColor = true;
            this.savetovari.Click += new System.EventHandler(this.savetovari_Click);
            // 
            // savemanuf
            // 
            this.savemanuf.Location = new System.Drawing.Point(320, 407);
            this.savemanuf.Name = "savemanuf";
            this.savemanuf.Size = new System.Drawing.Size(109, 32);
            this.savemanuf.TabIndex = 5;
            this.savemanuf.Text = "Сохранить";
            this.toolTip1.SetToolTip(this.savemanuf, "Сохранить производителя");
            this.savemanuf.UseVisualStyleBackColor = true;
            this.savemanuf.Click += new System.EventHandler(this.savemanuf_Click);
            // 
            // savestrana
            // 
            this.savestrana.Location = new System.Drawing.Point(751, 407);
            this.savestrana.Name = "savestrana";
            this.savestrana.Size = new System.Drawing.Size(109, 32);
            this.savestrana.TabIndex = 6;
            this.savestrana.Text = "Сохранить";
            this.toolTip1.SetToolTip(this.savestrana, "Сохранить страну");
            this.savestrana.UseVisualStyleBackColor = true;
            this.savestrana.Click += new System.EventHandler(this.savestrana_Click);
            // 
            // deltovari
            // 
            this.deltovari.Location = new System.Drawing.Point(792, 140);
            this.deltovari.Name = "deltovari";
            this.deltovari.Size = new System.Drawing.Size(109, 32);
            this.deltovari.TabIndex = 7;
            this.deltovari.Text = "Удалить";
            this.toolTip1.SetToolTip(this.deltovari, "Удалить товар");
            this.deltovari.UseVisualStyleBackColor = true;
            this.deltovari.Click += new System.EventHandler(this.deltovari_Click);
            // 
            // poisktovari
            // 
            this.poisktovari.Location = new System.Drawing.Point(792, 178);
            this.poisktovari.Name = "poisktovari";
            this.poisktovari.Size = new System.Drawing.Size(109, 32);
            this.poisktovari.TabIndex = 8;
            this.poisktovari.Text = "Поиск";
            this.toolTip1.SetToolTip(this.poisktovari, "Поиск товара");
            this.poisktovari.UseVisualStyleBackColor = true;
            this.poisktovari.Click += new System.EventHandler(this.poisktovari_Click);
            // 
            // textBoxtovari
            // 
            this.textBoxtovari.Location = new System.Drawing.Point(751, 216);
            this.textBoxtovari.Name = "textBoxtovari";
            this.textBoxtovari.Size = new System.Drawing.Size(195, 29);
            this.textBoxtovari.TabIndex = 9;
            // 
            // delmanuf
            // 
            this.delmanuf.Location = new System.Drawing.Point(320, 445);
            this.delmanuf.Name = "delmanuf";
            this.delmanuf.Size = new System.Drawing.Size(109, 32);
            this.delmanuf.TabIndex = 10;
            this.delmanuf.Text = "Удалить";
            this.toolTip1.SetToolTip(this.delmanuf, "Удалить производителя");
            this.delmanuf.UseVisualStyleBackColor = true;
            this.delmanuf.Click += new System.EventHandler(this.delmanuf_Click);
            // 
            // poiskmanuf
            // 
            this.poiskmanuf.Location = new System.Drawing.Point(320, 483);
            this.poiskmanuf.Name = "poiskmanuf";
            this.poiskmanuf.Size = new System.Drawing.Size(109, 32);
            this.poiskmanuf.TabIndex = 11;
            this.poiskmanuf.Text = "Поиск";
            this.toolTip1.SetToolTip(this.poiskmanuf, "Поиск производителя");
            this.poiskmanuf.UseVisualStyleBackColor = true;
            this.poiskmanuf.Click += new System.EventHandler(this.poiskmanuf_Click);
            // 
            // textBoxmanuf
            // 
            this.textBoxmanuf.Location = new System.Drawing.Point(234, 521);
            this.textBoxmanuf.Name = "textBoxmanuf";
            this.textBoxmanuf.Size = new System.Drawing.Size(195, 29);
            this.textBoxmanuf.TabIndex = 12;
            // 
            // textBoxstrana
            // 
            this.textBoxstrana.Location = new System.Drawing.Point(665, 521);
            this.textBoxstrana.Name = "textBoxstrana";
            this.textBoxstrana.Size = new System.Drawing.Size(195, 29);
            this.textBoxstrana.TabIndex = 13;
            // 
            // delstrana
            // 
            this.delstrana.Location = new System.Drawing.Point(751, 445);
            this.delstrana.Name = "delstrana";
            this.delstrana.Size = new System.Drawing.Size(109, 32);
            this.delstrana.TabIndex = 14;
            this.delstrana.Text = "Удалить";
            this.toolTip1.SetToolTip(this.delstrana, "Удалить страну");
            this.delstrana.UseVisualStyleBackColor = true;
            this.delstrana.Click += new System.EventHandler(this.delstrana_Click);
            // 
            // poiskstrana
            // 
            this.poiskstrana.Location = new System.Drawing.Point(751, 483);
            this.poiskstrana.Name = "poiskstrana";
            this.poiskstrana.Size = new System.Drawing.Size(109, 32);
            this.poiskstrana.TabIndex = 15;
            this.poiskstrana.Text = "Поиск";
            this.toolTip1.SetToolTip(this.poiskstrana, "Поиск страны");
            this.poiskstrana.UseVisualStyleBackColor = true;
            this.poiskstrana.Click += new System.EventHandler(this.poiskstrana_Click);
            // 
            // stranaTovariBindingSource
            // 
            this.stranaTovariBindingSource.DataMember = "StranaTovari";
            this.stranaTovariBindingSource.DataSource = this.stranaBindingSource;
            // 
            // stranaTovariBindingSource1
            // 
            this.stranaTovariBindingSource1.DataMember = "StranaTovari";
            this.stranaTovariBindingSource1.DataSource = this.stranaBindingSource;
            // 
            // proizvoditeliTovariBindingSource
            // 
            this.proizvoditeliTovariBindingSource.DataMember = "ProizvoditeliTovari";
            this.proizvoditeliTovariBindingSource.DataSource = this.proizvoditeliBindingSource;
            // 
            // fTovari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 661);
            this.Controls.Add(this.poiskstrana);
            this.Controls.Add(this.delstrana);
            this.Controls.Add(this.textBoxstrana);
            this.Controls.Add(this.textBoxmanuf);
            this.Controls.Add(this.poiskmanuf);
            this.Controls.Add(this.delmanuf);
            this.Controls.Add(this.textBoxtovari);
            this.Controls.Add(this.poisktovari);
            this.Controls.Add(this.deltovari);
            this.Controls.Add(this.savestrana);
            this.Controls.Add(this.savemanuf);
            this.Controls.Add(this.savetovari);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exittovars);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(980, 700);
            this.Name = "fTovari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Взаимодействие с товарами и некоторыми доплнительными атрибутами";
            this.Load += new System.EventHandler(this.fTovari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditeliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stranaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stranaTovariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stranaTovariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditeliTovariBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exittovars;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MazDataSet mazDataSet;
        private System.Windows.Forms.BindingSource tovariBindingSource;
        private MazDataSetTableAdapters.TovariTableAdapter tovariTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource proizvoditeliBindingSource;
        private MazDataSetTableAdapters.ProizvoditeliTableAdapter proizvoditeliTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource stranaBindingSource;
        private MazDataSetTableAdapters.StranaTableAdapter stranaTableAdapter;
        private System.Windows.Forms.Button savetovari;
        private System.Windows.Forms.Button savemanuf;
        private System.Windows.Forms.Button savestrana;
        private System.Windows.Forms.Button deltovari;
        private System.Windows.Forms.Button poisktovari;
        private System.Windows.Forms.TextBox textBoxtovari;
        private System.Windows.Forms.Button delmanuf;
        private System.Windows.Forms.Button poiskmanuf;
        private System.Windows.Forms.TextBox textBoxmanuf;
        private System.Windows.Forms.TextBox textBoxstrana;
        private System.Windows.Forms.Button delstrana;
        private System.Windows.Forms.Button poiskstrana;
        private System.Windows.Forms.BindingSource stranaTovariBindingSource;
        private System.Windows.Forms.BindingSource stranaTovariBindingSource1;
        private System.Windows.Forms.BindingSource proizvoditeliBindingSource1;
        private System.Windows.Forms.BindingSource proizvoditeliTovariBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buypriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDManufacturerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCountryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}