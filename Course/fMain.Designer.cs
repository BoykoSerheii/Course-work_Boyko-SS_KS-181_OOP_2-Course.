namespace Course
{
    partial class fMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lFind = new System.Windows.Forms.Label();
            this.lEditing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lFind
            // 
            this.lFind.AutoSize = true;
            this.lFind.BackColor = System.Drawing.Color.Transparent;
            this.lFind.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFind.ForeColor = System.Drawing.Color.Blue;
            this.lFind.Location = new System.Drawing.Point(73, 224);
            this.lFind.Name = "lFind";
            this.lFind.Size = new System.Drawing.Size(80, 33);
            this.lFind.TabIndex = 0;
            this.lFind.Text = "Пошук";
            this.lFind.Click += new System.EventHandler(this.lFind_Click);
            // 
            // lEditing
            // 
            this.lEditing.AutoSize = true;
            this.lEditing.BackColor = System.Drawing.Color.Transparent;
            this.lEditing.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEditing.ForeColor = System.Drawing.Color.Blue;
            this.lEditing.Location = new System.Drawing.Point(401, 9);
            this.lEditing.Name = "lEditing";
            this.lEditing.Size = new System.Drawing.Size(172, 33);
            this.lEditing.TabIndex = 1;
            this.lEditing.Text = "Редагування БД";
            this.lEditing.Click += new System.EventHandler(this.lEditing_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Course.Properties.Resources.PicH;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 380);
            this.Controls.Add(this.lEditing);
            this.Controls.Add(this.lFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fMain";
            this.Text = "Робота з базою даних побутових холодильних установок";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFind;
        private System.Windows.Forms.Label lEditing;
    }
}

