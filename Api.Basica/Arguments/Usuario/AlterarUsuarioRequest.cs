using System;

namespace Api.Basica.Domain.Arguments.Usuario
{
    public class AlterarUsuarioRequest
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public Guid PerfilDeUsuarioId { get; set; }
    }
}
