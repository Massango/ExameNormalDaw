using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamePratico.Models
{
    [Table("Evento")]
    public class Evento
    {
        [Key]
        [Column("EventoID")]
        public int EventoID { get; set; }
        [Column("Titulo")]
        public string TituloEvento { get; set; }
        [Column("Descrição")]
        public String Descrição { get; set; }
        [Column("Local")]
        public string Local { get; set; }
        [Column("Agenda")]
        public string Agenda { get; set; }
        [Column("TipoDeEvento")]
        public int TipoDeEvento{ get; set; }
        public virtual TipoEvento TipoEventos { get; set; }
        [Column("DataEvento")]
        public DateTime DataEvento { get; set; }
        [Column("Activo")]
        [DefaultValue(false)]
        public bool Activo { get; set; }
        [Column("Participante")]
        public int Participante { get; set; }
        public virtual Participante Participantess { get; set; }
        public ICollection<Inscricao> Inscricao { get; set; }

    }
}