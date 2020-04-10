using App.EcoAprender.Cqrs.Application.Interfaces;
using App.EcoAprender.Cqrs.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace App.EcoAprender.Cqrs.Api.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginAppService _loginAppService;

        public LoginController(ILoginAppService loginAppService)
        {
            _loginAppService = loginAppService;
        }

        [HttpPost("entrar")]
        [ProducesResponseType(typeof(ResponseViewModel), (int)HttpStatusCode.OK)]
        public IActionResult Entrar(LoginViewModel request)
        {
            ResponseViewModel response = _loginAppService.Entrar(request);
            return Ok(response);
        }
    }
}