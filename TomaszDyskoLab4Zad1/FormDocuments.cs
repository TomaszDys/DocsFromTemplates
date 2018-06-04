using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaszDyskoLab4Zad1.Models;
using TomaszDyskoLab4Zad1.Repositories;

namespace TomaszDyskoLab4Zad1
{
    public partial class FormDocuments : Form
    {
        /// <summary>
        /// Połączenie z contekstem bazy danych
        /// </summary>
        private readonly Models.AppContext context;
        /// <summary>
        /// Lista szablonów
        /// </summary>
        private RWRepository<Template> Templates;
        /// <summary>
        /// Lista dokumentów
        /// </summary>
        private RWRepository<Document> Documents;
        /// <summary>
        /// Właściwość przechowująca id autora dokumentu
        /// </summary>
        public int ActiveAuthorId { get; set; }
        /// <summary>
        /// Konstruktor bezparametrowy formularza generowania dokumentów
        /// </summary>
        public FormDocuments(string name, int activeId)
        {
            InitializeComponent();
            context = new Models.AppContext();
            Templates = new RWRepository<Template>(context);
            Documents = new RWRepository<Document>(context);
            BindTemplates();
            labelUser.Text = name;
            ActiveAuthorId = activeId;
        }
        /// <summary>
        /// Metoda wiążąca comboBoxa z listą nazw szablonów
        /// </summary>
        public void BindTemplates()
        {
            List<Template> templates = Templates.GetAll();
            comboBoxChooseTemplate.Items.Clear();
            foreach (Template item in templates)
            {
                comboBoxChooseTemplate.Items.Add(new ComboBoxItem(item.Name,item.Id));
            }
        }
        /// <summary>
        /// metoda zmieniająca wartości text boxów na te które występują w szablonie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxChooseTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Template> templates = Templates.GetAll();
            textBoxName.Text = templates[comboBoxChooseTemplate.SelectedIndex].Name;
            textBoxContent.Text = templates[comboBoxChooseTemplate.SelectedIndex].Content;
        }
        /// <summary>
        /// Metoda doająca szablon do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTemplate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "")
            {
                Template template = new Template()
                {
                    Name = textBoxName.Text,
                    Content = textBoxContent.Text
                };
                Templates.Create(template);
                comboBoxChooseTemplate.Items.Add(template.Name);
                MessageBox.Show("Pomyślnie zapisano!");
            }
            else
            {
                MessageBox.Show("Musisz podać nazwę szablonu!");
            }
        }

        private void buttonMenage_Click(object sender, EventArgs e)
        {
            FormTemplateMenage formTemplateMenage = new FormTemplateMenage();
            formTemplateMenage.ShowDialog();
            BindTemplates();
        }
        /// <summary>
        /// Metoda dodająca ścieżkę do obrazku podpisu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddSignature_Click(object sender, EventArgs e)
        {
            if (openFileDialogSignatureImage.ShowDialog() == DialogResult.OK)
            {
                labelPictureName.Text = openFileDialogSignatureImage.SafeFileName;
            }
        }
        /// <summary>
        /// Metoda zapisująca dokument
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveDocument_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && labelPictureName.Text != "Brak zdjęcia podpisu" && comboBoxChooseTemplate.SelectedItem != null)
            {
                Document document = new Document()
                {
                    Name = textBoxName.Text,
                    Content = textBoxContent.Text,
                    Image = File.ReadAllBytes(openFileDialogSignatureImage.FileName),
                    TemplateId = ((ComboBoxItem)comboBoxChooseTemplate.SelectedItem).HiddenValue,
                    AuthorId = ActiveAuthorId
                };
                Documents.Create(document);
                MessageBox.Show("Pomyślnie zapisano!");
            }
            else
            {
                MessageBox.Show("Musisz podać nazwę dokumentu, treść, wybrać szablon bądź zapisać nowy oraz dodać skan podpisu!");
            }
        }
        /// <summary>
        /// Metoda otwierająca okno zarządzana dokumentami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenageDocuments_Click(object sender, EventArgs e)
        {
            FormDocumentsMenage formDocumentsMenage = new FormDocumentsMenage();
            formDocumentsMenage.ShowDialog();
        }
    }
}
