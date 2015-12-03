using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamePratico.Models
{
    [Table("Profissao")]
    public class Profissao
    {
        [Key]
        [Column("ProfissaoID")]
        public int TipoEventoID { get; set; }
        [Column("Designação")]
        public string Designação { get; set; }
        public ICollection<Participante> Participantes { get; set; }
    }
}