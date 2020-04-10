using App.EcoAprender.Cqrs.Application.Interfaces;
using App.EcoAprender.Cqrs.Application.ViewModels;
using App.EcoAprender.Cqrs.Domain.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Models;

namespace App.EcoAprender.Cqrs.Application.AppServices
{
    public class LoginAppService : ILoginAppService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginAppService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public ResponseViewModel Entrar(LoginViewModel request)
        {
            Usuario usuarioRequest = new Usuario();
            usuarioRequest.PreencherLogin(request.Email, request.Senha);

            Usuario usuarioResponse = _usuarioRepository.Login(usuarioRequest);
            
            ResponseViewModel response = new ResponseViewModel(true, usuarioResponse);
            return response;
        }
    }
}
