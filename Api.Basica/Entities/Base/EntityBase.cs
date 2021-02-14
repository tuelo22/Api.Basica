using prmToolkit.NotificationPattern;
using System;

namespace Api.Basica.Domain.Entities.Base
{
    public abstract class EntityBase : Notifiable
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
            Ativo = true;
        }

        public Guid Id { get; private set; }

        public bool Ativo { get; private set; }

        protected abstract void Valida();

        public virtual void Inativar()
        {
            Ativo = false;
        }

    }
}
