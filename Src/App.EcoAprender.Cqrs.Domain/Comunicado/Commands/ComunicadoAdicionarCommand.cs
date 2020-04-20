using App.EcoAprender.Cqrs.Domain.Compartilhado.Commands;
using MediatR;
using System;
using System.Collections.Generic;

namespace App.EcoAprender.Cqrs.Domain.Comunicado.Commands
{
    public class ComunicadoAdicionarCommand : RequestCommand, IRequest<ResponseCommand>
    {
        public DateTime Data { get; private set; }

        public string Titulo { get; private set; }

        public string Descricao { get; private set; }

        public int GrupoId { get; private set; }

        public ComunicadoAdicionarCommand(DateTime data, string titulo, string descricao, int grupoId)
        {
            Data = data;
            Titulo = titulo;
            Descricao = descricao;
            GrupoId = grupoId;
        }

        public override List<string> Validar()
        {
            List<string> response = new List<string>(0);

            if (string.IsNullOrEmpty(Titulo))
            {
                response.Add("Titulo é obrigatório");
            }

            if (string.IsNullOrEmpty(Descricao))
            {
                response.Add("Descrição é obrigatório");
            }

            if (GrupoId == 0)
            {
                response.Add("Grupo é obrigatório");
            }

            return response;
        }
    }
}
