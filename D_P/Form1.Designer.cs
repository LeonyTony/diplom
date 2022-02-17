
namespace D_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.check = new System.Windows.Forms.Button();
            this.watch = new System.Windows.Forms.Button();
            this.explore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check.BackgroundImage")));
            this.check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check.Font = new System.Drawing.Font("Comic Sans MS", 16.13793F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check.Location = new System.Drawing.Point(410, 371);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(329, 109);
            this.check.TabIndex = 7;
            this.check.Text = "Проверить свои знания\r\n";
            this.check.UseVisualStyleBackColor = true;
            // 
            // watch
            // 
            this.watch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("watch.BackgroundImage")));
            this.watch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.watch.Font = new System.Drawing.Font("Comic Sans MS", 16.13793F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watch.Location = new System.Drawing.Point(655, 206);
            this.watch.Name = "watch";
            this.watch.Size = new System.Drawing.Size(329, 109);
            this.watch.TabIndex = 6;
            this.watch.Text = "Смотреть обучающие ролики\r\n\r\n";
            this.watch.UseVisualStyleBackColor = true;
            this.watch.Click += new System.EventHandler(this.watch_Click);
            // 
            // explore
            // 
            this.explore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("explore.BackgroundImage")));
            this.explore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.explore.Font = new System.Drawing.Font("Comic Sans MS", 16.13793F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explore.Location = new System.Drawing.Point(198, 206);
            this.explore.Name = "explore";
            this.explore.Size = new System.Drawing.Size(329, 109);
            this.explore.TabIndex = 5;
            this.explore.Text = "Изучить правила безопасности\r\n";
            this.explore.UseVisualStyleBackColor = true;
            this.explore.Click += new System.EventHandler(this.explore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 26.06896F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(375, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Книга безопасности";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.check);
            this.Controls.Add(this.watch);
            this.Controls.Add(this.explore);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button watch;
        private System.Windows.Forms.Button explore;
        private System.Windows.Forms.Label label1;
    }
}

