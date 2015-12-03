using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamePratico.Models
{
    [Table("Participante")]
    public class Participante
    {
        [Key]
        [Column("ParticipanteID")]
        public int ParticipanteID { get; set; }
        [Column("Nome")]
        public string NomeParticipante { get; set; }
        [Column("Apelido")]
        public String Apelido { get; set; }
        [Column("NivelAcademico")]
        public string NivelAcademico { get; set; }
        [Column("DataNascimento")]
        public DateTime DataNascimento { get; set; }
        [Column("Genero")]
        public String Genero { get; set; }
        [Column("Telefone")]
        public string Telefone { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Profissao")]
        public int Profissao { get; set; }
        public virtual Profissao Profissoes { get; set; }
    }
}