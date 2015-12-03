using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ExamePratico.Models
{
    public class ProjectoDB : DbContext
    {
        public ProjectoDB()
        {

            //Configuration.ProxyCreationEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
            { Database.Connection.ConnectionString = @"Server=Massango-PC;Database=ExameDAW; uid=sa; pwd=Massango93"; }
        } 
        
        public DbSet<Evento> Eventos{ get; set; }
        
        public DbSet<Participante> Participantes { get; set; }

        public DbSet<Profissao> Profissoes { get; set; }

        public DbSet<TipoEvento> TipoEventos { get; set; }

        public DbSet<TipoParticipante> TipoParticipantes { get; set; }

        public DbSet<Inscricao> Inscricoes { get; set; }




        //Comentar e fazer build uma vez, depois de feito o build tirar os comments
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<DefaultContext, Configuration>());
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


        }

        public DbSet<OutrosParticipantes> OutrosParticipantes { get; set; }
    }
}