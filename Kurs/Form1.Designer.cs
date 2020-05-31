namespace Kurs
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьОбъектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруВСпискеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруПоездаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьОбъектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруВСпискеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруПоездаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруПоездаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поНаправлениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 406);
            this.dataGridView1.TabIndex = 4;
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сгенерироватьToolStripMenuItem,
            this.добавитьToolStripMenuItem1,
            this.редактироватьОбъектToolStripMenuItem,
            this.удалитьОбъектToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.добавитьПарольToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.добавитьToolStripMenuItem.Text = "Меню";
            // 
            // сгенерироватьToolStripMenuItem
            // 
            this.сгенерироватьToolStripMenuItem.Name = "сгенерироватьToolStripMenuItem";
            this.сгенерироватьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.сгенерироватьToolStripMenuItem.Text = "Сгенерировать";
            this.сгенерироватьToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьToolStripMenuItem_Click_1);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить объект";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // редактироватьОбъектToolStripMenuItem
            // 
            this.редактироватьОбъектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруВСпискеToolStripMenuItem1,
            this.поНомеруПоездаToolStripMenuItem2});
            this.редактироватьОбъектToolStripMenuItem.Name = "редактироватьОбъектToolStripMenuItem";
            this.редактироватьОбъектToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.редактироватьОбъектToolStripMenuItem.Text = "Редактировать объект";
            // 
            // поНомеруВСпискеToolStripMenuItem1
            // 
            this.поНомеруВСпискеToolStripMenuItem1.Name = "поНомеруВСпискеToolStripMenuItem1";
            this.поНомеруВСпискеToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.поНомеруВСпискеToolStripMenuItem1.Text = "По номеру в списке";
            this.поНомеруВСпискеToolStripMenuItem1.Click += new System.EventHandler(this.поНомеруВСпискеToolStripMenuItem1_Click);
            // 
            // поНомеруПоездаToolStripMenuItem2
            // 
            this.поНомеруПоездаToolStripMenuItem2.Name = "поНомеруПоездаToolStripMenuItem2";
            this.поНомеруПоездаToolStripMenuItem2.Size = new System.Drawing.Size(185, 22);
            this.поНомеруПоездаToolStripMenuItem2.Text = "По номеру поезда";
            this.поНомеруПоездаToolStripMenuItem2.Click += new System.EventHandler(this.поНомеруПоездаToolStripMenuItem2_Click);
            // 
            // удалитьОбъектToolStripMenuItem
            // 
            this.удалитьОбъектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруВСпискеToolStripMenuItem,
            this.поНомеруПоездаToolStripMenuItem});
            this.удалитьОбъектToolStripMenuItem.Name = "удалитьОбъектToolStripMenuItem";
            this.удалитьОбъектToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.удалитьОбъектToolStripMenuItem.Text = "Удалить объект";
            // 
            // поНомеруВСпискеToolStripMenuItem
            // 
            this.поНомеруВСпискеToolStripMenuItem.Name = "поНомеруВСпискеToolStripMenuItem";
            this.поНомеруВСпискеToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.поНомеруВСпискеToolStripMenuItem.Text = "По номеру в списке";
            this.поНомеруВСпискеToolStripMenuItem.Click += new System.EventHandler(this.поНомеруВСпискеToolStripMenuItem_Click);
            // 
            // поНомеруПоездаToolStripMenuItem
            // 
            this.поНомеруПоездаToolStripMenuItem.Name = "поНомеруПоездаToolStripMenuItem";
            this.поНомеруПоездаToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.поНомеруПоездаToolStripMenuItem.Text = "По номеру поезда";
            this.поНомеруПоездаToolStripMenuItem.Click += new System.EventHandler(this.поНомеруПоездаToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // добавитьПарольToolStripMenuItem
            // 
            this.добавитьПарольToolStripMenuItem.Name = "добавитьПарольToolStripMenuItem";
            this.добавитьПарольToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.добавитьПарольToolStripMenuItem.Text = "Добавить пароль";
            this.добавитьПарольToolStripMenuItem.Click += new System.EventHandler(this.добавитьПарольToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруПоездаToolStripMenuItem1,
            this.поНаправлениюToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поНомеруПоездаToolStripMenuItem1
            // 
            this.поНомеруПоездаToolStripMenuItem1.Name = "поНомеруПоездаToolStripMenuItem1";
            this.поНомеруПоездаToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.поНомеруПоездаToolStripMenuItem1.Text = "По номеру поезда";
            this.поНомеруПоездаToolStripMenuItem1.Click += new System.EventHandler(this.поНомеруПоездаToolStripMenuItem1_Click);
            // 
            // поНаправлениюToolStripMenuItem
            // 
            this.поНаправлениюToolStripMenuItem.Name = "поНаправлениюToolStripMenuItem";
            this.поНаправлениюToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.поНаправлениюToolStripMenuItem.Text = "По направлению";
            this.поНаправлениюToolStripMenuItem.Click += new System.EventHandler(this.поНаправлениюToolStripMenuItem_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Enabled = false;
            this.BackBtn.Location = new System.Drawing.Point(114, 1);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 30;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 445);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПарольToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьОбъектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНомеруПоездаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНомеруВСпискеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНомеруПоездаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поНаправлениюToolStripMenuItem;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.ToolStripMenuItem редактироватьОбъектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНомеруВСпискеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поНомеруПоездаToolStripMenuItem2;
    }
}

