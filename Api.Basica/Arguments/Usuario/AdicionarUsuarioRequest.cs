using Api.Basica.Domain.Interfaces.Arguments;
using System;

namespace Api.Basica.Domain.Arguments.Usuario
{
    public class AdicionarUsuarioRequest : IRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public Guid PerfilDeUsuarioId { get; set; }
    }
}
