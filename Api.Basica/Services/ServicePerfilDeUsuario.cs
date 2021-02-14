using Api.Basica.Arguments.PerfilDeUsuario;
using Api.Basica.Interfaces.Repositories;
using Api.Basica.Interfaces.Services;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;
using System.Linq;

namespace Api.Basica.Services
{
    public class ServicePerfilDeUsuario : Notifiable, IPerfilDeUsuarioService
    {
        private readonly IRepositoryPerfilDeUsuario _repositoryPerfilDeUsuario;

        public ServicePerfilDeUsuario(IRepositoryPerfilDeUsuario repositoryPerfilDeUsuario)
        {
            _repositoryPerfilDeUsuario = repositoryPerfilDeUsuario;
        }

        public IEnumerable<PerfilDeUsuarioResponse> Listar()
        {
            return _repositoryPerfilDeUsuario.Listar().ToList().Select(jogador => (PerfilDeUsuarioResponse)jogador).ToList();
        }
    }
}
