namespace Course
{
    partial class fEditing
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
            this.tabHRD = new System.Windows.Forms.TabControl();
            this.tabHRC = new System.Windows.Forms.TabPage();
            this.tabHRA = new System.Windows.Forms.TabPage();
            this.tabFC = new System.Windows.Forms.TabPage();
            this.tabFA = new System.Windows.Forms.TabPage();
            this.tabHRD.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHRD
            // 
            this.tabHRD.Controls.Add(this.tabHRC);
            this.tabHRD.Controls.Add(this.tabHRA);
            this.tabHRD.Controls.Add(this.tabFC);
            this.tabHRD.Controls.Add(this.tabFA);
            this.tabHRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHRD.Location = new System.Drawing.Point(0, 0);
            this.tabHRD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabHRD.Name = "tabHRD";
            this.tabHRD.SelectedIndex = 0;
            this.tabHRD.Size = new System.Drawing.Size(779, 396);
            this.tabHRD.TabIndex = 0;
            // 
            // tabHRC
            // 
            this.tabHRC.AutoScroll = true;
            this.tabHRC.Location = new System.Drawing.Point(4, 32);
            this.tabHRC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabHRC.Name = "tabHRC";
            this.tabHRC.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabHRC.Size = new System.Drawing.Size(771, 360);
            this.tabHRC.TabIndex = 0;
            this.tabHRC.Text = "Холодильник компресорний";
            this.tabHRC.UseVisualStyleBackColor = true;
            this.tabHRC.Click += new System.EventHandler(this.tabHRC_Click);
            // 
            // tabHRA
            // 
            this.tabHRA.Location = new System.Drawing.Point(4, 32);
            this.tabHRA.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabHRA.Name = "tabHRA";
            this.tabHRA.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabHRA.Size = new System.Drawing.Size(771, 360);
            this.tabHRA.TabIndex = 1;
            this.tabHRA.Text = "Холодильник абсорбційний";
            this.tabHRA.UseVisualStyleBackColor = true;
            this.tabHRA.Click += new System.EventHandler(this.tabHRA_Click);
            // 
            // tabFC
            // 
            this.tabFC.Location = new System.Drawing.Point(4, 32);
            this.tabFC.Name = "tabFC";
            this.tabFC.Size = new System.Drawing.Size(771, 360);
            this.tabFC.TabIndex = 2;
            this.tabFC.Text = "Морозилка компресорна";
            this.tabFC.UseVisualStyleBackColor = true;
            this.tabFC.Click += new System.EventHandler(this.tabFC_Click);
            // 
            // tabFA
            // 
            this.tabFA.Location = new System.Drawing.Point(4, 32);
            this.tabFA.Name = "tabFA";
            this.tabFA.Size = new System.Drawing.Size(771, 360);
            this.tabFA.TabIndex = 3;
            this.tabFA.Text = "Морозилка абсорбційна";
            this.tabFA.UseVisualStyleBackColor = true;
            this.tabFA.Click += new System.EventHandler(this.tabFA_Click);
            // 
            // fEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 396);
            this.Controls.Add(this.tabHRD);
            this.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "fEditing";
            this.Text = "Редагування БД ПХП";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fEditing_FormClosed);
            this.Load += new System.EventHandler(this.fEditing_Load);
            this.Shown += new System.EventHandler(this.fEditing_Shown);
            this.tabHRD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabHRD;
        private System.Windows.Forms.TabPage tabHRC;
        private System.Windows.Forms.TabPage tabHRA;
        private System.Windows.Forms.TabPage tabFC;
        private System.Windows.Forms.TabPage tabFA;
    }
}