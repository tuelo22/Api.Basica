using Api.Basica.Domain.Entities;
using Api.Basica.Domain.Interfaces.Repositories;
using Api.Basica.Infra.Persistence.Repositories.Base;
using System;

namespace Api.Basica.Infra.Persistence.Repositories
{
    public class RepositoryUsuario : RepositoryBase<Usuario, Guid>, IRepositoryUsuario
    {
        protected readonly BNCContext _context;

        public RepositoryUsuario(BNCContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
