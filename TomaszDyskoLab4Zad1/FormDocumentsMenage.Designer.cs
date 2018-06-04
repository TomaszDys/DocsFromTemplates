namespace TomaszDyskoLab4Zad1
{
    partial class FormDocumentsMenage
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
            this.labelSelectIndex = new System.Windows.Forms.Label();
            this.comboBoxSelectIndex = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewDocuments = new System.Windows.Forms.DataGridView();
            this.buttonGeneratePdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectIndex
            // 
            this.labelSelectIndex.AutoSize = true;
            this.labelSelectIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSelectIndex.Location = new System.Drawing.Point(12, 286);
            this.labelSelectIndex.Name = "labelSelectIndex";
            this.labelSelectIndex.Size = new System.Drawing.Size(113, 18);
            this.labelSelectIndex.TabIndex = 7;
            this.labelSelectIndex.Text = "Wybierz indeks:";
            // 
            // comboBoxSelectIndex
            // 
            this.comboBoxSelectIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectIndex.FormattingEnabled = true;
            this.comboBoxSelectIndex.Location = new System.Drawing.Point(133, 287);
            this.comboBoxSelectIndex.Name = "comboBoxSelectIndex";
            this.comboBoxSelectIndex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectIndex.TabIndex = 6;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(260, 278);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 36);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewDocuments
            // 
            this.dataGridViewDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDocuments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocuments.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewDocuments.Name = "dataGridViewDocuments";
            this.dataGridViewDocuments.Size = new System.Drawing.Size(642, 259);
            this.dataGridViewDocuments.TabIndex = 4;
            // 
            // buttonGeneratePdf
            // 
            this.buttonGeneratePdf.Location = new System.Drawing.Point(483, 278);
            this.buttonGeneratePdf.Name = "buttonGeneratePdf";
            this.buttonGeneratePdf.Size = new System.Drawing.Size(152, 36);
            this.buttonGeneratePdf.TabIndex = 8;
            this.buttonGeneratePdf.Text = "Generuj Pdfa";
            this.buttonGeneratePdf.UseVisualStyleBackColor = true;
            this.buttonGeneratePdf.Click += new System.EventHandler(this.buttonGeneratePdf_Click);
            // 
            // FormDocumentsMenage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 321);
            this.Controls.Add(this.buttonGeneratePdf);
            this.Controls.Add(this.labelSelectIndex);
            this.Controls.Add(this.comboBoxSelectIndex);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewDocuments);
            this.Name = "FormDocumentsMenage";
            this.Text = "FormDocumentsMenage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectIndex;
        private System.Windows.Forms.ComboBox comboBoxSelectIndex;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewDocuments;
        private System.Windows.Forms.Button buttonGeneratePdf;
    }
}