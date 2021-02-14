using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Api.Basica.Domain.Entities;
using MySql.Data.Entity;

namespace Api.Basica.Infra.Persistence
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BNCContext : DbContext
    {
        public BNCContext() : base("banco")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Usuario> Usuarios { get; set; }
        public IDbSet<PerfilDeUsuario> PerfilDeUsuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remove a pluralização dos nomes das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Remove exclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Setar para usar varchar ou invés de nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            //Caso eu esqueça de informar o tamanho do campo ele irá colocar varchar de 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            //Mapeia as entidades
            //Adiciona entidades mapeadas - Automaticamente via Assembly
            modelBuilder.Configurations.AddFromAssembly(typeof(BNCContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
