using Api.Basica.Domain.Entities.Base;
using Api.Basica.Domain.Interfaces.Arguments;
using System;

namespace Api.Basica.Domain.Arguments.Base
{
    public class AdicionarResponseBase : IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }

        public static explicit operator AdicionarResponseBase(EntityBase entidade)
        {
            return new AdicionarResponseBase()
            {
                Id = entidade.Id,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO

            };
        }
    }
}
