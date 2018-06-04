using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszDyskoLab4Zad1.Models
{
    public class AppContext : DbContext
    {
        public AppContext() : base("AppContext")
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
    }
}
