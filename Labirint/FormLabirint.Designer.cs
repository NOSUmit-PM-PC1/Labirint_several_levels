namespace Labirint
{
    partial class FormLabirint
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
            this.dataGridViewLab = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ComboBoxLevels = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLab
            // 
            this.dataGridViewLab.AllowUserToAddRows = false;
            this.dataGridViewLab.AllowUserToDeleteRows = false;
            this.dataGridViewLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLab.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLab.Name = "dataGridViewLab";
            this.dataGridViewLab.ReadOnly = true;
            this.dataGridViewLab.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewLab.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComboBoxLevels});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ComboBoxLevels
            // 
            this.ComboBoxLevels.Items.AddRange(new object[] {
            "Уровень 1",
            "Уровень 2"});
            this.ComboBoxLevels.Name = "ComboBoxLevels";
            this.ComboBoxLevels.Size = new System.Drawing.Size(121, 25);
            this.ComboBoxLevels.TextChanged += new System.EventHandler(this.ComboBoxLevels_TextChanged);
            // 
            // FormLabirint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewLab);
            this.Name = "FormLabirint";
            this.Text = "Лабиринт";
            this.Load += new System.EventHandler(this.FormLabirint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLab)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLab;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox ComboBoxLevels;
    }
}

