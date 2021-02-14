using Api.Basica.Api.Controllers.Base;
using Api.Basica.Infra.Transactions;
using Api.Basica.Interfaces.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Basica.Api.Controllers
{
    [RoutePrefix("api/PerfilDeUsuario")]
    public class PerfilDeUsuarioController : ControllerBase
    {
        private readonly IPerfilDeUsuarioService _perfilDeUsuarioService;

        public PerfilDeUsuarioController(IUnitOfWork unitOfWork, IPerfilDeUsuarioService perfilDeUsuarioService)
            : base(unitOfWork)
        {
            _perfilDeUsuarioService = perfilDeUsuarioService;
        }

        [Authorize]
        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _perfilDeUsuarioService.Listar();

                return await ResponseAsync(response, _perfilDeUsuarioService);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

    }
}