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
    public partial class FormLogIn : Form
    {
        /// <summary>
        /// Połączenie z contekstem bazy danych
        /// </summary>
        private readonly Models.AppContext context;
        /// <summary>
        /// Lista użytkowników
        /// </summary>
        private RWRepository<User> Users;
        /// <summary>
        /// Kontruktor bezparametrowy formularza logowania/rejestracji
        /// </summary>
        public FormLogIn()
        {
            InitializeComponent();
            context = new Models.AppContext();
            Users = new RWRepository<User>(context);
        }
        /// <summary>
        /// Metoda dodająca użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string password = textBoxPassword.Text;
            if (name != String.Empty && password != String.Empty && !Users.Find(name))
            {
                User newUser = new User()
                {
                    Name = name,
                    Password = password
                };
                Users.Create(newUser);
                MessageBox.Show("Dodano użytkownika.");
            }
            else
            {
                MessageBox.Show("Istnieje już użytkownik z taką nazwą!");
            }
        }
        /// <summary>
        /// Metoda otwierająca okno z dokumentami po kliknięciu przycisku "Zaloguj"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string password = textBoxPassword.Text;
            User newUser = new User()
            {
                Name = name,
                Password = password
            };
            //sprawdzam poprawność hasła
            if (Users.Check(newUser))
            {
                this.Hide();
                FormDocuments formDocuments = new FormDocuments(name, Users.CheckId(newUser));
                formDocuments.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nie ma takiego użytkownika w bazie.");
            }
        }
    }
}
