using Api.Basica.Domain.Entities;
using Api.Basica.Domain.Interfaces.Repositories.Base;
using System;

namespace Api.Basica.Domain.Interfaces.Repositories
{
    public interface IRepositoryUsuario : IRepositoryBase<Usuario, Guid>
    {
    }
}
