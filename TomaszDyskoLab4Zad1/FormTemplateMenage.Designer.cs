namespace TomaszDyskoLab4Zad1
{
    partial class FormTemplateMenage
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
            this.dataGridViewTemplates = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxSelectIndex = new System.Windows.Forms.ComboBox();
            this.labelSelectIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTemplates
            // 
            this.dataGridViewTemplates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTemplates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemplates.Location = new System.Drawing.Point(1, 0);
            this.dataGridViewTemplates.Name = "dataGridViewTemplates";
            this.dataGridViewTemplates.Size = new System.Drawing.Size(642, 259);
            this.dataGridViewTemplates.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(354, 276);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 36);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxSelectIndex
            // 
            this.comboBoxSelectIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectIndex.FormattingEnabled = true;
            this.comboBoxSelectIndex.Location = new System.Drawing.Point(227, 285);
            this.comboBoxSelectIndex.Name = "comboBoxSelectIndex";
            this.comboBoxSelectIndex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectIndex.TabIndex = 2;
            // 
            // labelSelectIndex
            // 
            this.labelSelectIndex.AutoSize = true;
            this.labelSelectIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSelectIndex.Location = new System.Drawing.Point(98, 285);
            this.labelSelectIndex.Name = "labelSelectIndex";
            this.labelSelectIndex.Size = new System.Drawing.Size(113, 18);
            this.labelSelectIndex.TabIndex = 3;
            this.labelSelectIndex.Text = "Wybierz Indeks:";
            // 
            // FormTemplateMenage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 332);
            this.Controls.Add(this.labelSelectIndex);
            this.Controls.Add(this.comboBoxSelectIndex);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewTemplates);
            this.Name = "FormTemplateMenage";
            this.Text = "Zarządzaj szablonami";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTemplates;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxSelectIndex;
        private System.Windows.Forms.Label labelSelectIndex;
    }
}