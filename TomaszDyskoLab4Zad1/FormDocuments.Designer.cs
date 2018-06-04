namespace TomaszDyskoLab4Zad1
{
    partial class FormDocuments
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxChooseTemplate = new System.Windows.Forms.ComboBox();
            this.labelChooseTemplate = new System.Windows.Forms.Label();
            this.buttonAddTemplate = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.labelContent = new System.Windows.Forms.Label();
            this.buttonMenage = new System.Windows.Forms.Button();
            this.openFileDialogSignatureImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddSignature = new System.Windows.Forms.Button();
            this.labelPictureName = new System.Windows.Forms.Label();
            this.buttonSaveDocument = new System.Windows.Forms.Button();
            this.buttonMenageDocuments = new System.Windows.Forms.Button();
            this.labelActiveUser = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(335, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(294, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Generuj dokumenty";
            // 
            // comboBoxChooseTemplate
            // 
            this.comboBoxChooseTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxChooseTemplate.FormattingEnabled = true;
            this.comboBoxChooseTemplate.Location = new System.Drawing.Point(407, 69);
            this.comboBoxChooseTemplate.Name = "comboBoxChooseTemplate";
            this.comboBoxChooseTemplate.Size = new System.Drawing.Size(343, 28);
            this.comboBoxChooseTemplate.TabIndex = 1;
            this.comboBoxChooseTemplate.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseTemplate_SelectedIndexChanged);
            // 
            // labelChooseTemplate
            // 
            this.labelChooseTemplate.AutoSize = true;
            this.labelChooseTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChooseTemplate.Location = new System.Drawing.Point(224, 72);
            this.labelChooseTemplate.Name = "labelChooseTemplate";
            this.labelChooseTemplate.Size = new System.Drawing.Size(177, 25);
            this.labelChooseTemplate.TabIndex = 2;
            this.labelChooseTemplate.Text = "Wybierz szablon:";
            // 
            // buttonAddTemplate
            // 
            this.buttonAddTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddTemplate.Location = new System.Drawing.Point(466, 383);
            this.buttonAddTemplate.Name = "buttonAddTemplate";
            this.buttonAddTemplate.Size = new System.Drawing.Size(135, 43);
            this.buttonAddTemplate.TabIndex = 3;
            this.buttonAddTemplate.Text = "Dodaj szablon";
            this.buttonAddTemplate.UseVisualStyleBackColor = true;
            this.buttonAddTemplate.Click += new System.EventHandler(this.buttonAddTemplate_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(225, 111);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nazwa:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(292, 111);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(172, 24);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxContent.Location = new System.Drawing.Point(229, 165);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(521, 170);
            this.textBoxContent.TabIndex = 6;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.Location = new System.Drawing.Point(225, 142);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(53, 20);
            this.labelContent.TabIndex = 7;
            this.labelContent.Text = "Treść:";
            // 
            // buttonMenage
            // 
            this.buttonMenage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenage.Location = new System.Drawing.Point(12, 62);
            this.buttonMenage.Name = "buttonMenage";
            this.buttonMenage.Size = new System.Drawing.Size(192, 43);
            this.buttonMenage.TabIndex = 8;
            this.buttonMenage.Text = "Zarządzaj szablonami";
            this.buttonMenage.UseVisualStyleBackColor = true;
            this.buttonMenage.Click += new System.EventHandler(this.buttonMenage_Click);
            // 
            // openFileDialogSignatureImage
            // 
            this.openFileDialogSignatureImage.FileName = "signature";
            this.openFileDialogSignatureImage.Filter = "Image files|*.jpg; *.jpeg; *.png;";
            // 
            // buttonAddSignature
            // 
            this.buttonAddSignature.Location = new System.Drawing.Point(579, 342);
            this.buttonAddSignature.Name = "buttonAddSignature";
            this.buttonAddSignature.Size = new System.Drawing.Size(170, 23);
            this.buttonAddSignature.TabIndex = 9;
            this.buttonAddSignature.Text = "Dodaj zdjęcie podpisu";
            this.buttonAddSignature.UseVisualStyleBackColor = true;
            this.buttonAddSignature.Click += new System.EventHandler(this.buttonAddSignature_Click);
            // 
            // labelPictureName
            // 
            this.labelPictureName.AutoSize = true;
            this.labelPictureName.Location = new System.Drawing.Point(229, 347);
            this.labelPictureName.Name = "labelPictureName";
            this.labelPictureName.Size = new System.Drawing.Size(105, 13);
            this.labelPictureName.TabIndex = 10;
            this.labelPictureName.Text = "Brak zdjęcia podpisu";
            // 
            // buttonSaveDocument
            // 
            this.buttonSaveDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveDocument.Location = new System.Drawing.Point(615, 382);
            this.buttonSaveDocument.Name = "buttonSaveDocument";
            this.buttonSaveDocument.Size = new System.Drawing.Size(135, 43);
            this.buttonSaveDocument.TabIndex = 11;
            this.buttonSaveDocument.Text = "Zapisz dokument";
            this.buttonSaveDocument.UseVisualStyleBackColor = true;
            this.buttonSaveDocument.Click += new System.EventHandler(this.buttonSaveDocument_Click);
            // 
            // buttonMenageDocuments
            // 
            this.buttonMenageDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenageDocuments.Location = new System.Drawing.Point(12, 111);
            this.buttonMenageDocuments.Name = "buttonMenageDocuments";
            this.buttonMenageDocuments.Size = new System.Drawing.Size(192, 43);
            this.buttonMenageDocuments.TabIndex = 12;
            this.buttonMenageDocuments.Text = "Zarządzaj dokumentami";
            this.buttonMenageDocuments.UseVisualStyleBackColor = true;
            this.buttonMenageDocuments.Click += new System.EventHandler(this.buttonMenageDocuments_Click);
            // 
            // labelActiveUser
            // 
            this.labelActiveUser.AutoSize = true;
            this.labelActiveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActiveUser.Location = new System.Drawing.Point(17, 13);
            this.labelActiveUser.Name = "labelActiveUser";
            this.labelActiveUser.Size = new System.Drawing.Size(158, 18);
            this.labelActiveUser.TabIndex = 13;
            this.labelActiveUser.Text = "Aktywny użytkownik";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUser.Location = new System.Drawing.Point(21, 37);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 18);
            this.labelUser.TabIndex = 14;
            this.labelUser.Text = "label1";
            // 
            // FormDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 488);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelActiveUser);
            this.Controls.Add(this.buttonMenageDocuments);
            this.Controls.Add(this.buttonSaveDocument);
            this.Controls.Add(this.labelPictureName);
            this.Controls.Add(this.buttonAddSignature);
            this.Controls.Add(this.buttonMenage);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAddTemplate);
            this.Controls.Add(this.labelChooseTemplate);
            this.Controls.Add(this.comboBoxChooseTemplate);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormDocuments";
            this.Text = "Dokumenty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxChooseTemplate;
        private System.Windows.Forms.Label labelChooseTemplate;
        private System.Windows.Forms.Button buttonAddTemplate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Button buttonMenage;
        private System.Windows.Forms.OpenFileDialog openFileDialogSignatureImage;
        private System.Windows.Forms.Button buttonAddSignature;
        private System.Windows.Forms.Label labelPictureName;
        private System.Windows.Forms.Button buttonSaveDocument;
        private System.Windows.Forms.Button buttonMenageDocuments;
        private System.Windows.Forms.Label labelActiveUser;
        private System.Windows.Forms.Label labelUser;
    }
}