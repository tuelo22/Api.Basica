using Api.Basica.Domain.Entities;
using Api.Basica.Infra.Persistence.Repositories.Base;
using Api.Basica.Interfaces.Repositories;
using System;

namespace Api.Basica.Infra.Persistence.Repositories
{
    public class RepositoryPerfilDeUsuario : RepositoryBase<PerfilDeUsuario, Guid>, IRepositoryPerfilDeUsuario
    {
        protected readonly BNCContext _context;

        public RepositoryPerfilDeUsuario(BNCContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
