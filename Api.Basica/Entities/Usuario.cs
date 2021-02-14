using Api.Basica.Domain.Entities.Base;
using Api.Basica.Domain.Extensions;
using Api.Basica.Domain.Resources;
using Api.Basica.Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;

namespace Api.Basica.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public Nome Nome { get; private set; }

        public string Senha { get; private set; }

        public Email Email { get; private set; }

        public Guid PerfilDeUsuarioId { get; set; }

        public PerfilDeUsuario PerfilDeUsuario { get; private set; }

        public DateTime DataCadastro { get; private set; }

        protected Usuario(){}

        public Usuario(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            Valida();
        }

        public Usuario(Guid id)
        {
            Email = new Email(id.ToString());
            Nome = new Nome(id.ToString(), id.ToString());
        }

        public Usuario(Nome nome, Email email, string senha, PerfilDeUsuario perfilDeUsuario)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            PerfilDeUsuario = perfilDeUsuario;

            Valida();
        }

        public void Alterar(Nome nome, Email email)
        {
            this.Nome = nome;
            this.Email = email;

            Valida();
        }

        public override string ToString()
        {
            return this.Nome.PrimeiroNome + " " + this.Nome.UltimoNome;
        }

        protected override void Valida()
        {
            AddNotifications(Nome);
            AddNotifications(Email);
            AddNotifications(PerfilDeUsuario);

            new AddNotifications<Usuario>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, Message.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Senha", "6", "32"));

            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }
        }
    }
}
