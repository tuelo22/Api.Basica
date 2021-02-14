using Api.Basica.Api.Controllers.Base;
using Api.Basica.Domain.Arguments.Usuario;
using Api.Basica.Infra.Transactions;
using Api.Basica.Interfaces.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Basica.Api.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IServiceUsuario _serviceUsuario;

        public UsuarioController(IUnitOfWork unitOfWork, IServiceUsuario serviceUsuario)
            : base(unitOfWork)
        {
            _serviceUsuario = serviceUsuario;
        }

        [Authorize]
        [Route("Alterar")]
        [HttpPut]
        public async Task<HttpResponseMessage> Alterar(AlterarUsuarioRequest request)
        {
            try
            {
                var response = _serviceUsuario.Alterar(request);

                return await ResponseAsync(response, _serviceUsuario);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarUsuarioRequest request)
        {
            try
            {
                var response = _serviceUsuario.Adicionar(request);

                return await ResponseAsync(response, _serviceUsuario);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Authorize]
        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _serviceUsuario.Listar();

                return await ResponseAsync(response, _serviceUsuario);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Authorize]
        [Route("Excluir")]
        [HttpDelete]
        public async Task<HttpResponseMessage> Excluir(Guid id)
        {
            try
            {
                var response = _serviceUsuario.Desativar(id);

                return await ResponseAsync(response, _serviceUsuario);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}