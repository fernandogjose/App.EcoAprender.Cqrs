using App.EcoAprender.Cqrs.Application.Interfaces;
using App.EcoAprender.Cqrs.Application.ViewModels;
using App.EcoAprender.Cqrs.Domain.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Models;
using AutoMapper;
using System.Collections.Generic;

namespace App.EcoAprender.Cqrs.Application.AppServices
{
    public class ComunicadoAppService : IComunicadoAppService
    {
        private readonly IComunicadoRepository _comunicadoRepository;

        public ComunicadoAppService(IComunicadoRepository comunicadoRepository)
        {
            _comunicadoRepository = comunicadoRepository;
        }

        public ResponseViewModel Listar()
        {
            IEnumerable<Comunicado> comunicadosResponse = _comunicadoRepository.Listar();
            ResponseViewModel response = new ResponseViewModel(true, comunicadosResponse);
            return response;
        }
    }
}
