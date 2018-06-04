using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaszDyskoLab4Zad1.Models;
using TomaszDyskoLab4Zad1.Repositories;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TomaszDyskoLab4Zad1
{
    public partial class FormDocumentsMenage : Form
    {
        /// <summary>
        /// Połączenie z contekstem bazy danych
        /// </summary>
        private readonly Models.AppContext context;
        /// <summary>
        /// Lista szablonów
        /// </summary>
        private RWRepository<Models.Document> Documents;
        /// <summary>
        /// Lista użytkowników
        /// </summary>
        private RWRepository<User> Users;
        /// <summary>
        /// Konstruktor bezparametrowy formularza generowania dokumentów
        /// </summary>
        public FormDocumentsMenage()
        {
            InitializeComponent();
            context = new Models.AppContext();
            Documents = new RWRepository<Models.Document>(context);
            Users = new RWRepository<User>(context);
            BindDataGridView();
            BindComboBox();
        }
        /// <summary>
        /// Metoda wiążąca datagridview z bazą danych szablonów
        /// </summary>
        public void BindDataGridView()
        {
            dataGridViewDocuments.DataSource = Documents.GetAll().Select(
                x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Content = x.Content,
                    AuthorId = x.AuthorId,
                    TemplateId = x.TemplateId
                }
                ).ToList();
        }
        /// <summary>
        /// Metoda wiążąca comboBoxa z listą id
        /// </summary>
        public void BindComboBox()
        {
            List<Models.Document> templates = Documents.GetAll();
            comboBoxSelectIndex.Items.Clear();
            foreach (Models.Document item in templates)
            {
                comboBoxSelectIndex.Items.Add(item.Id);
            }
        }
        /// <summary>
        /// Metoda usuwająca wybrany wiersz z tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Documents.Delete(Int32.Parse(comboBoxSelectIndex.SelectedItem.ToString()));
            BindDataGridView();
            BindComboBox();
        }
        /// <summary>
        /// Przycisk generujący plik pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGeneratePdf_Click(object sender, EventArgs e)
        {
            //Tworzę pobieram zaznaczony dokument i aktywnego uzytkownika 
            Models.Document selected = Documents.GetById(Int32.Parse(comboBoxSelectIndex.SelectedItem.ToString()));
            User author = Users.GetById(selected.AuthorId);
            //tworze nowy dokument iTextSharp
            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pdf File |*.pdf";
            //Rozpoczynam procedurę zapisywania do pliku pdf
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();
                    Paragraph paragraph = new Paragraph(selected.Name);
                    paragraph.Font = FontFactory.GetFont("Arial", 18.0f , BaseColor.BLACK);
                    document.Add(paragraph);
                    paragraph = new Paragraph("Autor: " + author.Name);
                    document.Add(paragraph);
                    paragraph = new Paragraph(selected.Content);
                    paragraph.Font = FontFactory.GetFont("Arial", 12.0f, BaseColor.BLACK);
                    document.Add(paragraph);
                    paragraph = new Paragraph("Podpis:");
                    paragraph.Font = FontFactory.GetFont("Arial", 12.0f, BaseColor.BLACK);
                    document.Add(paragraph);
                    iTextSharp.text.Image signature = iTextSharp.text.Image.GetInstance(selected.Image);
                    signature.ScaleAbsolute(159f, 159f);
                    document.Add(signature);
                    document.Close();
                    MessageBox.Show("Pozytywnie zapisano!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
