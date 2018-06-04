using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszDyskoLab4Zad1.Models
{
    public class Document : Entity
    {
        /// <summary>
        /// Nazwa dokumentu
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Zawartość dokumentu
        /// </summary>
        [Required]
        public string Content { get; set; }
        /// <summary>
        /// Obrazek podpisu
        /// </summary>
        [Required]
        public byte[] Image { get; set; }
        /// <summary>
        /// Klucz obcy id użytego szablonu
        /// </summary>
        [ForeignKey("TemplateId")]
        public virtual Template Template { get; set; }
        public int? TemplateId { get; set; }
        /// <summary>
        /// Klucz obcy id autora
        /// </summary>
        [ForeignKey("AuthorId")]
        public virtual User User { get; set; }
        public int AuthorId { get; set; }
    }
}
