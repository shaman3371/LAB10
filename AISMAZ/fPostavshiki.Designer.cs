
namespace AISMAZ
{
    partial class fPostavshiki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPostavshiki));
            this.exitpostavsh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPostavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typepostavshikovBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mazDataSet = new AISMAZ.MazDataSet();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikiTableAdapter = new AISMAZ.MazDataSetTableAdapters.PostavshikiTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typepostavshikovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_postavshikovTableAdapter = new AISMAZ.MazDataSetTableAdapters.Type_postavshikovTableAdapter();
            this.savepostavshik = new System.Windows.Forms.Button();
            this.savetype = new System.Windows.Forms.Button();
            this.delpostavshik = new System.Windows.Forms.Button();
            this.poiskpostavshik = new System.Windows.Forms.Button();
            this.deltype = new System.Windows.Forms.Button();
            this.poisktype = new System.Windows.Forms.Button();
            this.textBoxtype = new System.Windows.Forms.TextBox();
            this.textBoxpostavshik = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typepostavshikovBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typepostavshikovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitpostavsh
            // 
            this.exitpostavsh.Location = new System.Drawing.Point(843, 617);
            this.exitpostavsh.Name = "exitpostavsh";
            this.exitpostavsh.Size = new System.Drawing.Size(109, 32);
            this.exitpostavsh.TabIndex = 0;
            this.exitpostavsh.Text = "Закрыть";
            this.exitpostavsh.UseVisualStyleBackColor = true;
            this.exitpostavsh.Click += new System.EventHandler(this.exitpostavsh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPostavshikDataGridViewTextBoxColumn,
            this.companynameDataGridViewTextBoxColumn,
            this.iDTypeDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postavshikiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(146, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 171);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDPostavshikDataGridViewTextBoxColumn
            // 
            this.iDPostavshikDataGridViewTextBoxColumn.DataPropertyName = "ID_Postavshik";
            this.iDPostavshikDataGridViewTextBoxColumn.HeaderText = "ID_Postavshik";
            this.iDPostavshikDataGridViewTextBoxColumn.Name = "iDPostavshikDataGridViewTextBoxColumn";
            this.iDPostavshikDataGridViewTextBoxColumn.Visible = false;
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "Company_name";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "Наименование компании";
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            this.companynameDataGridViewTextBoxColumn.Width = 213;
            // 
            // iDTypeDataGridViewTextBoxColumn
            // 
            this.iDTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDTypeDataGridViewTextBoxColumn.DataPropertyName = "ID_Type";
            this.iDTypeDataGridViewTextBoxColumn.DataSource = this.typepostavshikovBindingSource1;
            this.iDTypeDataGridViewTextBoxColumn.DisplayMember = "Type_Name";
            this.iDTypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.iDTypeDataGridViewTextBoxColumn.Name = "iDTypeDataGridViewTextBoxColumn";
            this.iDTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDTypeDataGridViewTextBoxColumn.ValueMember = "ID_Type";
            this.iDTypeDataGridViewTextBoxColumn.Width = 67;
            // 
            // typepostavshikovBindingSource1
            // 
            this.typepostavshikovBindingSource1.DataMember = "Type_postavshikov";
            this.typepostavshikovBindingSource1.DataSource = this.mazDataSet;
            // 
            // mazDataSet
            // 
            this.mazDataSet.DataSetName = "MazDataSet";
            this.mazDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // postavshikiBindingSource
            // 
            this.postavshikiBindingSource.DataMember = "Postavshiki";
            this.postavshikiBindingSource.DataSource = this.mazDataSet;
            // 
            // postavshikiTableAdapter
            // 
            this.postavshikiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTypeDataGridViewTextBoxColumn1,
            this.typeNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.typepostavshikovBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(567, 323);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(253, 168);
            this.dataGridView2.TabIndex = 2;
            // 
            // iDTypeDataGridViewTextBoxColumn1
            // 
            this.iDTypeDataGridViewTextBoxColumn1.DataPropertyName = "ID_Type";
            this.iDTypeDataGridViewTextBoxColumn1.HeaderText = "ID_Type";
            this.iDTypeDataGridViewTextBoxColumn1.Name = "iDTypeDataGridViewTextBoxColumn1";
            this.iDTypeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "Type_Name";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "Наименование типа";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            // 
            // typepostavshikovBindingSource
            // 
            this.typepostavshikovBindingSource.DataMember = "Type_postavshikov";
            this.typepostavshikovBindingSource.DataSource = this.mazDataSet;
            // 
            // type_postavshikovTableAdapter
            // 
            this.type_postavshikovTableAdapter.ClearBeforeFill = true;
            // 
            // savepostavshik
            // 
            this.savepostavshik.Location = new System.Drawing.Point(816, 65);
            this.savepostavshik.Name = "savepostavshik";
            this.savepostavshik.Size = new System.Drawing.Size(109, 32);
            this.savepostavshik.TabIndex = 3;
            this.savepostavshik.Text = "Сохранить";
            this.toolTip1.SetToolTip(this.savepostavshik, "Сохранить компанию");
            this.savepostavshik.UseVisualStyleBackColor = true;
            this.savepostavshik.Click += new System.EventHandler(this.savepostavshik_Click);
            // 
            // savetype
            // 
            this.savetype.Location = new System.Drawing.Point(826, 337);
            this.savetype.Name = "savetype";
            this.savetype.Size = new System.Drawing.Size(109, 32);
            this.savetype.TabIndex = 4;
            this.savetype.Text = "Сохранить";
            this.toolTip1.SetToolTip(this.savetype, "Сохранить тип компании");
            this.savetype.UseVisualStyleBackColor = true;
            this.savetype.Click += new System.EventHandler(this.savetype_Click);
            // 
            // delpostavshik
            // 
            this.delpostavshik.Location = new System.Drawing.Point(816, 123);
            this.delpostavshik.Name = "delpostavshik";
            this.delpostavshik.Size = new System.Drawing.Size(109, 32);
            this.delpostavshik.TabIndex = 5;
            this.delpostavshik.Text = "Удалить";
            this.toolTip1.SetToolTip(this.delpostavshik, "Удалить компанию");
            this.delpostavshik.UseVisualStyleBackColor = true;
            this.delpostavshik.Click += new System.EventHandler(this.delpostavshik_Click);
            // 
            // poiskpostavshik
            // 
            this.poiskpostavshik.Location = new System.Drawing.Point(816, 187);
            this.poiskpostavshik.Name = "poiskpostavshik";
            this.poiskpostavshik.Size = new System.Drawing.Size(109, 32);
            this.poiskpostavshik.TabIndex = 6;
            this.poiskpostavshik.Text = "Поиск";
            this.toolTip1.SetToolTip(this.poiskpostavshik, "Поиск компании");
            this.poiskpostavshik.UseVisualStyleBackColor = true;
            this.poiskpostavshik.Click += new System.EventHandler(this.poiskpostavshik_Click);
            // 
            // deltype
            // 
            this.deltype.Location = new System.Drawing.Point(826, 400);
            this.deltype.Name = "deltype";
            this.deltype.Size = new System.Drawing.Size(109, 32);
            this.deltype.TabIndex = 7;
            this.deltype.Text = "Удалить";
            this.toolTip1.SetToolTip(this.deltype, "Удалить тип компании");
            this.deltype.UseVisualStyleBackColor = true;
            this.deltype.Click += new System.EventHandler(this.deltype_Click);
            // 
            // poisktype
            // 
            this.poisktype.Location = new System.Drawing.Point(826, 459);
            this.poisktype.Name = "poisktype";
            this.poisktype.Size = new System.Drawing.Size(109, 32);
            this.poisktype.TabIndex = 8;
            this.poisktype.Text = "Поиск";
            this.toolTip1.SetToolTip(this.poisktype, "Поиска типа компании");
            this.poisktype.UseVisualStyleBackColor = true;
            this.poisktype.Click += new System.EventHandler(this.poisktype_Click);
            // 
            // textBoxtype
            // 
            this.textBoxtype.Location = new System.Drawing.Point(740, 497);
            this.textBoxtype.Name = "textBoxtype";
            this.textBoxtype.Size = new System.Drawing.Size(195, 29);
            this.textBoxtype.TabIndex = 9;
            // 
            // textBoxpostavshik
            // 
            this.textBoxpostavshik.Location = new System.Drawing.Point(730, 225);
            this.textBoxpostavshik.Name = "textBoxpostavshik";
            this.textBoxpostavshik.Size = new System.Drawing.Size(195, 29);
            this.textBoxpostavshik.TabIndex = 10;
            // 
            // fPostavshiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 661);
            this.Controls.Add(this.textBoxpostavshik);
            this.Controls.Add(this.textBoxtype);
            this.Controls.Add(this.poisktype);
            this.Controls.Add(this.deltype);
            this.Controls.Add(this.poiskpostavshik);
            this.Controls.Add(this.delpostavshik);
            this.Controls.Add(this.savetype);
            this.Controls.Add(this.savepostavshik);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitpostavsh);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(980, 700);
            this.Name = "fPostavshiki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Просмотр поставщиков";
            this.Load += new System.EventHandler(this.fPostavshiki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typepostavshikovBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typepostavshikovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitpostavsh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MazDataSet mazDataSet;
        private System.Windows.Forms.BindingSource postavshikiBindingSource;
        private MazDataSetTableAdapters.PostavshikiTableAdapter postavshikiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource typepostavshikovBindingSource;
        private MazDataSetTableAdapters.Type_postavshikovTableAdapter type_postavshikovTableAdapter;
        private System.Windows.Forms.Button savepostavshik;
        private System.Windows.Forms.Button savetype;
        private System.Windows.Forms.BindingSource typepostavshikovBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPostavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delpostavshik;
        private System.Windows.Forms.Button poiskpostavshik;
        private System.Windows.Forms.Button deltype;
        private System.Windows.Forms.Button poisktype;
        private System.Windows.Forms.TextBox textBoxtype;
        private System.Windows.Forms.TextBox textBoxpostavshik;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}