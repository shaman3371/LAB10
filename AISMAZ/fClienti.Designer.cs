
namespace AISMAZ
{
    partial class fClienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fClienti));
            this.exitclients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custmiddleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custmobphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mazDataSet = new AISMAZ.MazDataSet();
            this.klientiTableAdapter = new AISMAZ.MazDataSetTableAdapters.KlientiTableAdapter();
            this.saveclients = new System.Windows.Forms.Button();
            this.delclients = new System.Windows.Forms.Button();
            this.poiskclients = new System.Windows.Forms.Button();
            this.textBoxclients = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // exitclients
            // 
            this.exitclients.Location = new System.Drawing.Point(843, 617);
            this.exitclients.Name = "exitclients";
            this.exitclients.Size = new System.Drawing.Size(109, 32);
            this.exitclients.TabIndex = 0;
            this.exitclients.Text = "Закрыть";
            this.exitclients.UseVisualStyleBackColor = true;
            this.exitclients.Click += new System.EventHandler(this.exitclients_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClientDataGridViewTextBoxColumn,
            this.custsurnameDataGridViewTextBoxColumn,
            this.custnameDataGridViewTextBoxColumn,
            this.custmiddleDataGridViewTextBoxColumn,
            this.custmobphoneDataGridViewTextBoxColumn,
            this.custaddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klientiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(108, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 338);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            this.iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.HeaderText = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            this.iDClientDataGridViewTextBoxColumn.Visible = false;
            // 
            // custsurnameDataGridViewTextBoxColumn
            // 
            this.custsurnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.custsurnameDataGridViewTextBoxColumn.DataPropertyName = "cust_surname";
            this.custsurnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.custsurnameDataGridViewTextBoxColumn.Name = "custsurnameDataGridViewTextBoxColumn";
            this.custsurnameDataGridViewTextBoxColumn.Width = 107;
            // 
            // custnameDataGridViewTextBoxColumn
            // 
            this.custnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.custnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name";
            this.custnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.custnameDataGridViewTextBoxColumn.Name = "custnameDataGridViewTextBoxColumn";
            this.custnameDataGridViewTextBoxColumn.Width = 69;
            // 
            // custmiddleDataGridViewTextBoxColumn
            // 
            this.custmiddleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.custmiddleDataGridViewTextBoxColumn.DataPropertyName = "cust_middle";
            this.custmiddleDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.custmiddleDataGridViewTextBoxColumn.Name = "custmiddleDataGridViewTextBoxColumn";
            this.custmiddleDataGridViewTextBoxColumn.Width = 111;
            // 
            // custmobphoneDataGridViewTextBoxColumn
            // 
            this.custmobphoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.custmobphoneDataGridViewTextBoxColumn.DataPropertyName = "cust_mobphone";
            this.custmobphoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.custmobphoneDataGridViewTextBoxColumn.Name = "custmobphoneDataGridViewTextBoxColumn";
            this.custmobphoneDataGridViewTextBoxColumn.Width = 103;
            // 
            // custaddressDataGridViewTextBoxColumn
            // 
            this.custaddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.custaddressDataGridViewTextBoxColumn.DataPropertyName = "cust_address";
            this.custaddressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.custaddressDataGridViewTextBoxColumn.Name = "custaddressDataGridViewTextBoxColumn";
            // 
            // klientiBindingSource
            // 
            this.klientiBindingSource.DataMember = "Klienti";
            this.klientiBindingSource.DataSource = this.mazDataSet;
            // 
            // mazDataSet
            // 
            this.mazDataSet.DataSetName = "MazDataSet";
            this.mazDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientiTableAdapter
            // 
            this.klientiTableAdapter.ClearBeforeFill = true;
            // 
            // saveclients
            // 
            this.saveclients.Location = new System.Drawing.Point(812, 259);
            this.saveclients.Name = "saveclients";
            this.saveclients.Size = new System.Drawing.Size(109, 32);
            this.saveclients.TabIndex = 2;
            this.saveclients.Text = "Сохранить";
            this.saveclients.UseVisualStyleBackColor = true;
            this.saveclients.Click += new System.EventHandler(this.saveclients_Click);
            // 
            // delclients
            // 
            this.delclients.Location = new System.Drawing.Point(812, 316);
            this.delclients.Name = "delclients";
            this.delclients.Size = new System.Drawing.Size(109, 32);
            this.delclients.TabIndex = 3;
            this.delclients.Text = "Удалить";
            this.delclients.UseVisualStyleBackColor = true;
            this.delclients.Click += new System.EventHandler(this.delclients_Click);
            // 
            // poiskclients
            // 
            this.poiskclients.Location = new System.Drawing.Point(812, 378);
            this.poiskclients.Name = "poiskclients";
            this.poiskclients.Size = new System.Drawing.Size(109, 32);
            this.poiskclients.TabIndex = 4;
            this.poiskclients.Text = "Поиск";
            this.poiskclients.UseVisualStyleBackColor = true;
            this.poiskclients.Click += new System.EventHandler(this.poiskclients_Click);
            // 
            // textBoxclients
            // 
            this.textBoxclients.Location = new System.Drawing.Point(726, 416);
            this.textBoxclients.Name = "textBoxclients";
            this.textBoxclients.Size = new System.Drawing.Size(195, 29);
            this.textBoxclients.TabIndex = 5;
            // 
            // fClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 661);
            this.Controls.Add(this.textBoxclients);
            this.Controls.Add(this.poiskclients);
            this.Controls.Add(this.delclients);
            this.Controls.Add(this.saveclients);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitclients);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(980, 700);
            this.Name = "fClienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Взаимодействие с клиентами";
            this.Load += new System.EventHandler(this.fClienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitclients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MazDataSet mazDataSet;
        private System.Windows.Forms.BindingSource klientiBindingSource;
        private MazDataSetTableAdapters.KlientiTableAdapter klientiTableAdapter;
        private System.Windows.Forms.Button saveclients;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custmiddleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custmobphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delclients;
        private System.Windows.Forms.Button poiskclients;
        private System.Windows.Forms.TextBox textBoxclients;
    }
}