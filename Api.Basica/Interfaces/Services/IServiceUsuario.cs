using Api.Basica.Domain.Arguments.Base;
using Api.Basica.Domain.Arguments.Usuario;
using Api.Basica.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace Api.Basica.Interfaces.Services
{
    public interface IServiceUsuario : IServiceBase
    {
        UsuarioResponse Autenticar(AutenticarUsuarioRequest request);

        AdicionarResponseBase Adicionar(AdicionarUsuarioRequest request);

        ResponseBase Alterar(AlterarUsuarioRequest request);

        IEnumerable<UsuarioResponse> Listar();

        ResponseBase Desativar(Guid Id);
    }
}
