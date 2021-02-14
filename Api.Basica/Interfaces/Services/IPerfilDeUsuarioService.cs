using Api.Basica.Arguments.PerfilDeUsuario;
using Api.Basica.Interfaces.Services.Base;
using System.Collections.Generic;

namespace Api.Basica.Interfaces.Services
{
    public interface IPerfilDeUsuarioService : IServiceBase
    {
        IEnumerable<PerfilDeUsuarioResponse> Listar();
    }
}
