using System;

namespace Api.Basica.Arguments.PerfilDeUsuario
{
    public class PerfilDeUsuarioResponse
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public static explicit operator PerfilDeUsuarioResponse(Domain.Entities.PerfilDeUsuario entidade)
        {
            return new PerfilDeUsuarioResponse()
            {
                Id = entidade.Id,
                Descricao = entidade.Descricao
            };
        }
    }
}
