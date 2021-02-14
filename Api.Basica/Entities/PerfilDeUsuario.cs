using Api.Basica.Domain.Entities.Base;
using Api.Basica.Domain.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System.Collections.Generic;

namespace Api.Basica.Domain.Entities
{
    public class PerfilDeUsuario : EntityBase
    {
        public string Descricao { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }

        protected override void Valida()
        {
            new AddNotifications<PerfilDeUsuario>(this)
                 .IfNullOrInvalidLength(x => x.Descricao, 6, 32, Message.X0_E_OBRIGATORIO.ToFormat("Nome do Perfil"));
        }
    }
}
