namespace Обработчик_строк
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
            this.список_студентов = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Поле_Ввода = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Добавить_строку = new System.Windows.Forms.Button();
            this.Вставить_строку = new System.Windows.Forms.Button();
            this.Изменить_строку = new System.Windows.Forms.Button();
            this.Удалить_из_списка = new System.Windows.Forms.Button();
            this.Очистить_список = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // список_студентов
            // 
            this.список_студентов.AutoSize = true;
            this.список_студентов.Location = new System.Drawing.Point(63, 9);
            this.список_студентов.Name = "список_студентов";
            this.список_студентов.Size = new System.Drawing.Size(98, 13);
            this.список_студентов.TabIndex = 0;
            this.список_студентов.Text = "Список студентов";
            this.список_студентов.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 303);
            this.listBox1.TabIndex = 1;
            // 
            // Поле_Ввода
            // 
            this.Поле_Ввода.AutoSize = true;
            this.Поле_Ввода.Location = new System.Drawing.Point(476, 9);
            this.Поле_Ввода.Name = "Поле_Ввода";
            this.Поле_Ввода.Size = new System.Drawing.Size(67, 13);
            this.Поле_Ввода.TabIndex = 2;
            this.Поле_Ввода.Text = "Поле Ввода";
            this.Поле_Ввода.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(479, 25);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(196, 20);
            this.TextBox1.TabIndex = 3;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Добавить_строку
            // 
            this.Добавить_строку.Location = new System.Drawing.Point(479, 51);
            this.Добавить_строку.Name = "Добавить_строку";
            this.Добавить_строку.Size = new System.Drawing.Size(113, 35);
            this.Добавить_строку.TabIndex = 4;
            this.Добавить_строку.Text = "Добавить строку";
            this.Добавить_строку.UseVisualStyleBackColor = true;
            this.Добавить_строку.Click += new System.EventHandler(this.Добавить_строку_Click);
            // 
            // Вставить_строку
            // 
            this.Вставить_строку.Location = new System.Drawing.Point(479, 92);
            this.Вставить_строку.Name = "Вставить_строку";
            this.Вставить_строку.Size = new System.Drawing.Size(113, 35);
            this.Вставить_строку.TabIndex = 5;
            this.Вставить_строку.Text = "Вставить строку";
            this.Вставить_строку.UseVisualStyleBackColor = true;
            this.Вставить_строку.Click += new System.EventHandler(this.Вставить_строку_Click);
            // 
            // Изменить_строку
            // 
            this.Изменить_строку.Location = new System.Drawing.Point(479, 133);
            this.Изменить_строку.Name = "Изменить_строку";
            this.Изменить_строку.Size = new System.Drawing.Size(113, 35);
            this.Изменить_строку.TabIndex = 6;
            this.Изменить_строку.Text = "Изменить строку";
            this.Изменить_строку.UseVisualStyleBackColor = true;
            this.Изменить_строку.Click += new System.EventHandler(this.Изменить_строку_Click);
            // 
            // Удалить_из_списка
            // 
            this.Удалить_из_списка.Location = new System.Drawing.Point(479, 174);
            this.Удалить_из_списка.Name = "Удалить_из_списка";
            this.Удалить_из_списка.Size = new System.Drawing.Size(113, 35);
            this.Удалить_из_списка.TabIndex = 7;
            this.Удалить_из_списка.Text = "Удалить из списка";
            this.Удалить_из_списка.UseVisualStyleBackColor = true;
            this.Удалить_из_списка.Click += new System.EventHandler(this.Удалить_из_списка_Click);
            // 
            // Очистить_список
            // 
            this.Очистить_список.Location = new System.Drawing.Point(479, 215);
            this.Очистить_список.Name = "Очистить_список";
            this.Очистить_список.Size = new System.Drawing.Size(113, 35);
            this.Очистить_список.TabIndex = 8;
            this.Очистить_список.Text = "Очистить список";
            this.Очистить_список.UseVisualStyleBackColor = true;
            this.Очистить_список.Click += new System.EventHandler(this.Очистить_список_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(479, 271);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(113, 35);
            this.Open.TabIndex = 9;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(479, 312);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(113, 35);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 395);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Очистить_список);
            this.Controls.Add(this.Удалить_из_списка);
            this.Controls.Add(this.Изменить_строку);
            this.Controls.Add(this.Вставить_строку);
            this.Controls.Add(this.Добавить_строку);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Поле_Ввода);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.список_студентов);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label список_студентов;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Поле_Ввода;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Добавить_строку;
        private System.Windows.Forms.Button Вставить_строку;
        private System.Windows.Forms.Button Изменить_строку;
        private System.Windows.Forms.Button Удалить_из_списка;
        private System.Windows.Forms.Button Очистить_список;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

