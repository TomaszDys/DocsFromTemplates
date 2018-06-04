using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszDyskoLab4Zad1.Models
{
    public class User : Entity
    {
        /// <summary>
        /// Nazwa Użytkownika
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Hasło użytkownika
        /// </summary>
        [Required]
        public string Password { get; set; }
        public virtual List<Document> Documents { get; set; }
    }
}
