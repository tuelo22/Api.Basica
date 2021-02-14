using Api.Basica.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Api.Basica.Infra.Persistence.Map
{
    class MapPerfilDeUsuario : EntityTypeConfiguration<PerfilDeUsuario>
    {
        public MapPerfilDeUsuario()
        {
            ToTable("PerfilDeUsuario");
            HasKey(p => p.Id);
            Property(p => p.Descricao).HasMaxLength(300).IsRequired().HasColumnName("Descricao");
        }
    }
}
