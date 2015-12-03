using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamePratico.Models
{
    [Table("TipoEvento")]
    public class TipoEvento
    {
        [Key]
        [Column("TipoEventoID")]
        public int TipoEventoID { get; set; }
        [Column("Designação")]
        public string Designação { get; set; }

        public ICollection<Evento> Eventos{ get; set; }
    }
}