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

namespace TomaszDyskoLab4Zad1
{
    public partial class FormTemplateMenage : Form
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
        /// Konstruktor bezparametrowy formularza generowania dokumentów
        /// </summary>
        public FormTemplateMenage()
        {
            InitializeComponent();
            context = new Models.AppContext();
            Templates = new RWRepository<Template>(context);
            BindDataGridView();
            BindComboBox();
        }
        /// <summary>
        /// Metoda wiążąca datagridview z bazą danych szablonów
        /// </summary>
        public void BindDataGridView()
        {
            dataGridViewTemplates.DataSource = Templates.GetAll().Select(
                x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Content = x.Content
                }
                ).ToList();
        }
        /// <summary>
        /// Metoda wiążąca comboBoxa z listą id
        /// </summary>
        public void BindComboBox()
        {
            List<Template> templates = Templates.GetAll();
            comboBoxSelectIndex.Items.Clear();
            foreach (Template item in templates)
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
            Templates.Delete(Int32.Parse(comboBoxSelectIndex.SelectedItem.ToString()));
            BindDataGridView();
            BindComboBox();
        }
    }
}
