using System;

namespace App.EcoAprender.Cqrs.Application.Comunicado.ViewModels
{
    public class ComunicadoAdicionarRequestViewModel
    {
        public DateTime Data { get; private set; }

        public string Titulo { get; private set; }

        public string Descricao { get; private set; }

        public int GrupoId { get; private set; }
    }
}
