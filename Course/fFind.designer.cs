namespace Course
{
    partial class fFind
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBFind = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBFL = new System.Windows.Forms.GroupBox();
            this.rBFLN = new System.Windows.Forms.RadioButton();
            this.rBFLV = new System.Windows.Forms.RadioButton();
            this.gBM = new System.Windows.Forms.GroupBox();
            this.rBMB = new System.Windows.Forms.RadioButton();
            this.rBMM = new System.Windows.Forms.RadioButton();
            this.gBPrise = new System.Windows.Forms.GroupBox();
            this.rBPriseM = new System.Windows.Forms.RadioButton();
            this.rBPriseB = new System.Windows.Forms.RadioButton();
            this.bEsc = new System.Windows.Forms.Button();
            this.gBFL.SuspendLayout();
            this.gBM.SuspendLayout();
            this.gBPrise.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фільтри пошуку";
            // 
            // cBFind
            // 
            this.cBFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cBFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFind.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBFind.FormattingEnabled = true;
            this.cBFind.Items.AddRange(new object[] {
            "Всі пристрої",
            "Холодильники",
            "Морозильники",
            "Холодильники компресорні",
            "Холодильники абсорційні",
            "Морозильники компресорні",
            "Морозильники абсорційні"});
            this.cBFind.Location = new System.Drawing.Point(600, 22);
            this.cBFind.Name = "cBFind";
            this.cBFind.Size = new System.Drawing.Size(225, 31);
            this.cBFind.TabIndex = 1;
            this.cBFind.TextChanged += new System.EventHandler(this.cBFind_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Критерій пошуку";
            // 
            // gBFL
            // 
            this.gBFL.Controls.Add(this.rBFLN);
            this.gBFL.Controls.Add(this.rBFLV);
            this.gBFL.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBFL.Location = new System.Drawing.Point(21, 377);
            this.gBFL.Name = "gBFL";
            this.gBFL.Size = new System.Drawing.Size(166, 142);
            this.gBFL.TabIndex = 3;
            this.gBFL.TabStop = false;
            this.gBFL.Text = "Висота";
            // 
            // rBFLN
            // 
            this.rBFLN.AutoSize = true;
            this.rBFLN.Location = new System.Drawing.Point(29, 85);
            this.rBFLN.Name = "rBFLN";
            this.rBFLN.Size = new System.Drawing.Size(95, 23);
            this.rBFLN.TabIndex = 1;
            this.rBFLN.TabStop = true;
            this.rBFLN.Text = "Більше 150";
            this.rBFLN.UseVisualStyleBackColor = true;
            this.rBFLN.Click += new System.EventHandler(this.cBFind_TextChanged);
            // 
            // rBFLV
            // 
            this.rBFLV.AutoSize = true;
            this.rBFLV.Location = new System.Drawing.Point(28, 46);
            this.rBFLV.Name = "rBFLV";
            this.rBFLV.Size = new System.Drawing.Size(94, 23);
            this.rBFLV.TabIndex = 0;
            this.rBFLV.TabStop = true;
            this.rBFLV.Text = "Менше 150";
            this.rBFLV.UseVisualStyleBackColor = true;
            this.rBFLV.Click += new System.EventHandler(this.cBFind_TextChanged);
            // 
            // gBM
            // 
            this.gBM.Controls.Add(this.rBMB);
            this.gBM.Controls.Add(this.rBMM);
            this.gBM.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBM.Location = new System.Drawing.Point(21, 214);
            this.gBM.Name = "gBM";
            this.gBM.Size = new System.Drawing.Size(166, 142);
            this.gBM.TabIndex = 4;
            this.gBM.TabStop = false;
            this.gBM.Text = "Вага";
            // 
            // rBMB
            // 
            this.rBMB.AutoSize = true;
            this.rBMB.Location = new System.Drawing.Point(28, 82);
            this.rBMB.Name = "rBMB";
            this.rBMB.Size = new System.Drawing.Size(87, 23);
            this.rBMB.TabIndex = 1;
            this.rBMB.TabStop = true;
            this.rBMB.Text = "Більше 50";
            this.rBMB.UseVisualStyleBackColor = true;
            this.rBMB.Click += new System.EventHandler(this.cBFind_TextChanged);
            // 
            // rBMM
            // 
            this.rBMM.AutoSize = true;
            this.rBMM.Location = new System.Drawing.Point(28, 40);
            this.rBMM.Name = "rBMM";
            this.rBMM.Size = new System.Drawing.Size(90, 23);
            this.rBMM.TabIndex = 0;
            this.rBMM.TabStop = true;
            this.rBMM.Text = "Менше  50";
            this.rBMM.UseVisualStyleBackColor = true;
            this.rBMM.Click += new System.EventHandler(this.cBFind_TextChanged);
            // 
            // gBPrise
            // 
            this.gBPrise.Controls.Add(this.rBPriseM);
            this.gBPrise.Controls.Add(this.rBPriseB);
            this.gBPrise.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBPrise.Location = new System.Drawing.Point(21, 56);
            this.gBPrise.Name = "gBPrise";
            this.gBPrise.Size = new System.Drawing.Size(166, 142);
            this.gBPrise.TabIndex = 5;
            this.gBPrise.TabStop = false;
            this.gBPrise.Text = "Ціна";
            // 
            // rBPriseM
            // 
            this.rBPriseM.AutoSize = true;
            this.rBPriseM.Location = new System.Drawing.Point(26, 40);
            this.rBPriseM.Name = "rBPriseM";
            this.rBPriseM.Size = new System.Drawing.Size(114, 23);
            this.rBPriseM.TabIndex = 1;
            this.rBPriseM.TabStop = true;
            this.rBPriseM.Text = "Менше 15 000";
            this.rBPriseM.UseVisualStyleBackColor = true;
            this.rBPriseM.Click += new System.EventHandler(this.cBFind_TextChanged);
            // 
            // rBPriseB
            // 
            this.rBPriseB.AutoSize = true;
            this.rBPriseB.Location = new System.Drawing.Point(26, 78);
            this.rBPriseB.Name = "rBPriseB";
            this.rBPriseB.Size = new System.Drawing.Size(115, 23);
            this.rBPriseB.TabIndex = 0;
            this.rBPriseB.TabStop = true;
            this.rBPriseB.Text = "Більше 15 000";
            this.rBPriseB.UseVisualStyleBackColor = true;
            this.rBPriseB.Click += new System.EventHandler(this.cBFind_TextChanged);
            // 
            // bEsc
            // 
            this.bEsc.Location = new System.Drawing.Point(21, 553);
            this.bEsc.Name = "bEsc";
            this.bEsc.Size = new System.Drawing.Size(166, 40);
            this.bEsc.TabIndex = 6;
            this.bEsc.Text = "Скинути";
            this.bEsc.UseVisualStyleBackColor = true;
            this.bEsc.Click += new System.EventHandler(this.bEsc_Click);
            // 
            // fFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 626);
            this.Controls.Add(this.bEsc);
            this.Controls.Add(this.gBPrise);
            this.Controls.Add(this.gBM);
            this.Controls.Add(this.gBFL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBFind);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "fFind";
            this.Text = "Наші пропозиції";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fFind_Load);
            this.gBFL.ResumeLayout(false);
            this.gBFL.PerformLayout();
            this.gBM.ResumeLayout(false);
            this.gBM.PerformLayout();
            this.gBPrise.ResumeLayout(false);
            this.gBPrise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBFL;
        private System.Windows.Forms.RadioButton rBFLN;
        private System.Windows.Forms.RadioButton rBFLV;
        private System.Windows.Forms.GroupBox gBM;
        private System.Windows.Forms.RadioButton rBMB;
        private System.Windows.Forms.RadioButton rBMM;
        private System.Windows.Forms.GroupBox gBPrise;
        private System.Windows.Forms.RadioButton rBPriseM;
        private System.Windows.Forms.RadioButton rBPriseB;
        private System.Windows.Forms.Button bEsc;
    }
}