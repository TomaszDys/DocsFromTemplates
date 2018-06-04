using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszDyskoLab4Zad1.Models
{
    public class Template : Entity
    {
        /// <summary>
        /// Nazwa szblonu
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Zawartość szablonu
        /// </summary>
        [Required]
        public string Content { get; set; }
        public virtual List<Document> Documents { get; set; }
    }
}
