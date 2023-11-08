
namespace AISMAZ
{
    partial class Maimform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maimform));
            this.btnclients = new System.Windows.Forms.Button();
            this.btnpost = new System.Windows.Forms.Button();
            this.btntovars = new System.Windows.Forms.Button();
            this.prodajpostav = new System.Windows.Forms.Button();
            this.postavshiki = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.btnExitmain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclients
            // 
            this.btnclients.Location = new System.Drawing.Point(188, 215);
            this.btnclients.Name = "btnclients";
            this.btnclients.Size = new System.Drawing.Size(175, 73);
            this.btnclients.TabIndex = 0;
            this.btnclients.Text = "Клиенты";
            this.btnclients.UseVisualStyleBackColor = true;
            this.btnclients.Click += new System.EventHandler(this.btnclients_Click);
            // 
            // btnpost
            // 
            this.btnpost.Location = new System.Drawing.Point(422, 215);
            this.btnpost.Name = "btnpost";
            this.btnpost.Size = new System.Drawing.Size(175, 73);
            this.btnpost.TabIndex = 1;
            this.btnpost.Text = "Управление сотрудниками и должностями";
            this.btnpost.UseVisualStyleBackColor = true;
            this.btnpost.Click += new System.EventHandler(this.btnpost_Click);
            // 
            // btntovars
            // 
            this.btntovars.Location = new System.Drawing.Point(656, 215);
            this.btntovars.Name = "btntovars";
            this.btntovars.Size = new System.Drawing.Size(175, 73);
            this.btntovars.TabIndex = 2;
            this.btntovars.Text = "Управление товарами";
            this.btntovars.UseVisualStyleBackColor = true;
            this.btntovars.Click += new System.EventHandler(this.btntovars_Click);
            // 
            // prodajpostav
            // 
            this.prodajpostav.Location = new System.Drawing.Point(308, 350);
            this.prodajpostav.Name = "prodajpostav";
            this.prodajpostav.Size = new System.Drawing.Size(175, 73);
            this.prodajpostav.TabIndex = 3;
            this.prodajpostav.Text = "Продажи и поставки";
            this.prodajpostav.UseVisualStyleBackColor = true;
            this.prodajpostav.Click += new System.EventHandler(this.prodajpostav_Click);
            // 
            // postavshiki
            // 
            this.postavshiki.Location = new System.Drawing.Point(542, 350);
            this.postavshiki.Name = "postavshiki";
            this.postavshiki.Size = new System.Drawing.Size(175, 73);
            this.postavshiki.TabIndex = 4;
            this.postavshiki.Text = "Поставщики";
            this.postavshiki.UseVisualStyleBackColor = true;
            this.postavshiki.Click += new System.EventHandler(this.postavshiki_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(722, 618);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(128, 31);
            this.about.TabIndex = 5;
            this.about.Text = "О программе";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // btnExitmain
            // 
            this.btnExitmain.Location = new System.Drawing.Point(876, 618);
            this.btnExitmain.Name = "btnExitmain";
            this.btnExitmain.Size = new System.Drawing.Size(120, 31);
            this.btnExitmain.TabIndex = 6;
            this.btnExitmain.Text = "Выход";
            this.btnExitmain.UseVisualStyleBackColor = true;
            this.btnExitmain.Click += new System.EventHandler(this.btnExitmain_Click);
            // 
            // Maimform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.btnExitmain);
            this.Controls.Add(this.about);
            this.Controls.Add(this.postavshiki);
            this.Controls.Add(this.prodajpostav);
            this.Controls.Add(this.btntovars);
            this.Controls.Add(this.btnpost);
            this.Controls.Add(this.btnclients);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "Maimform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление подсистемами";
            this.Load += new System.EventHandler(this.Maimform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclients;
        private System.Windows.Forms.Button btnpost;
        private System.Windows.Forms.Button btntovars;
        private System.Windows.Forms.Button prodajpostav;
        private System.Windows.Forms.Button postavshiki;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button btnExitmain;
    }
}

