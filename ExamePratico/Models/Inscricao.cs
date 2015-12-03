using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamePratico.Models
{
    [Table("Inscricao")]
    public class Inscricao
    {

        public int InscricaoID { get; set; }

        public int Participante { get; set; }
        public virtual OutrosParticipantes Participantes { get; set; }

        public int Evento { get; set; }
        public virtual Evento Eventos { get; set; }

        public DateTime DataInscricao { get; set; }

        [DefaultValue(false)]
        public bool EstadoDoEvento { get; set; }
    }
}