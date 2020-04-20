using App.EcoAprender.Cqrs.Application.Compartilhado.ViewModels;
using App.EcoAprender.Cqrs.Application.Usuario.Interfaces;
using App.EcoAprender.Cqrs.Application.Usuario.ViewModels;
using App.EcoAprender.Cqrs.Domain.Usuario.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Usuario.Queries;

namespace App.EcoAprender.Cqrs.Application.Usuario.AppServices
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioAppService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public ResponseViewModel Login(UsuarioLoginRequestViewModel request)
        {
            UsuarioLoginRequestQuery usuarioLoginRequestQuery = new UsuarioLoginRequestQuery(request.Senha, request.Email);
            UsuarioLoginResponseQuery usuarioLoginResponseQuery = _usuarioRepository.Login(usuarioLoginRequestQuery);

            if (usuarioLoginResponseQuery == null)
            {
                return new ResponseViewModel(false, "E-mail/Senha inválido", usuarioLoginResponseQuery);
            }

            return new ResponseViewModel(true, "Login realizado com sucesso", usuarioLoginResponseQuery);
        }
    }
}
