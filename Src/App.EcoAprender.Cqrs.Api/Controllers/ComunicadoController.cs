using App.EcoAprender.Cqrs.Application.Compartilhado.ViewModels;
using App.EcoAprender.Cqrs.Application.Comunicado.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace App.EcoAprender.Cqrs.Api.Controllers
{
    [Route("api/comunicado")]
    [ApiController]
    public class ComunicadoController : ControllerBase
    {
        private readonly IComunicadoAppService _comunicadoAppService;

        public ComunicadoController(IComunicadoAppService comunicadoAppService)
        {
            _comunicadoAppService = comunicadoAppService;
        }

        [HttpGet("listar")]
        [ProducesResponseType(typeof(ResponseViewModel), (int)HttpStatusCode.OK)]
        public IActionResult ListarAsync()
        {
            ResponseViewModel response = _comunicadoAppService.Listar();
            return Ok(response);
        }
    }
}