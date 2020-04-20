using App.EcoAprender.Cqrs.Application.Compartilhado.ViewModels;
using App.EcoAprender.Cqrs.Application.Usuario.Interfaces;
using App.EcoAprender.Cqrs.Application.Usuario.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace App.EcoAprender.Cqrs.Api.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public LoginController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        [HttpPost("entrar")]
        [ProducesResponseType(typeof(ResponseViewModel), (int)HttpStatusCode.OK)]
        public IActionResult Entrar(UsuarioLoginRequestViewModel request)
        {
            ResponseViewModel response = _usuarioAppService.Login(request);
            return Ok(response);
        }
    }
}