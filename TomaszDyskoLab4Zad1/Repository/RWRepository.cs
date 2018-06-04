using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaszDyskoLab4Zad1.Models;
using TomaszDyskoZad1.Repositories;

namespace TomaszDyskoLab4Zad1.Repositories
{
    public class RWRepository<T> : IRWRepository<T> where T : Entity
    {
        private readonly Models.AppContext context;
        public RWRepository(Models.AppContext context)
        {
            this.context = context;
        }
        public bool Check(User user)
        {
            var userNew = context.Users.Where(u =>
            u.Name == user.Name && u.Password == user.Password).SingleOrDefault();
            if (userNew == null)
                return false;
            return true;
        }
        public int CheckId(User user)
        {
            var userNew = context.Users.Where(u =>
            u.Name == user.Name && u.Password == user.Password).SingleOrDefault();
            return userNew.Id;
        }
        public void Create(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            try
            {
                var template = context.Set<T>().Where(x => x.Id == id).SingleOrDefault();
                context.Set<T>().Remove(template);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Być może coś używa tego szablonu");
            }
        }

        public bool Find(string name)
        {
            var price = context.Users.Where(u =>
            u.Name == name).SingleOrDefault();
            if (price == null)
                return false;
            return true;
        }
        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            var item = context.Set<T>().Where(x => x.Id == id).SingleOrDefault();
            return item;
        }
    }
}
