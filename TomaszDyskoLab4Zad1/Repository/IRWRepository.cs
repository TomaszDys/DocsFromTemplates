using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomaszDyskoLab4Zad1.Models;

namespace TomaszDyskoZad1.Repositories
{
    public interface IRWRepository<T> where T : Entity
    {
        /// <summary>
        /// Metoda zwracająca baze do listy generycznej
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();
        /// <summary>
        /// Metoda pobierająca obiekt po podaniu Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);
        /// <summary>
        /// Metoda sprawdzająca czy jest już nazwa użytkownika
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool Check(User user);
        /// <summary>
        /// Metoda zwracająca Id użytkownika
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int CheckId(User user);
        /// <summary>
        /// Metoda zwracająca Id użytkownika o danym haśle i nazwie
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool Find(string name);
        /// <summary>
        /// Metoda usuwająca obiekt z bazy
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
        /// <summary>
        /// Metoda tworząca nowy obiekt w bazie
        /// </summary>
        /// <param name="entity"></param>
        void Create(T entity);
    }
}
