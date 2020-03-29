using App.EcoAprender.Cqrs.Application.Interfaces;
using App.EcoAprender.Cqrs.Application.ViewModels;
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
        public IActionResult Listar()
        {
            ResponseViewModel response = _comunicadoAppService.Listar();
            return Ok(response);
        }
    }
}