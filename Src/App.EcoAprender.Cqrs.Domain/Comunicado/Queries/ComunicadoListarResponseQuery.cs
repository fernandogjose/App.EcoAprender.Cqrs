using System;

namespace App.EcoAprender.Cqrs.Domain.Comunicado.Queries
{
    public class ComunicadoListarResponseQuery
    {
        public int Id { get; private set; }

        public DateTime Data { get; private set; }

        public string Titulo { get; private set; }

        public string Descricao { get; private set; }

        public string Grupo { get; private set; }

        public ComunicadoListarResponseQuery(int id, DateTime data, string titulo, string descricao, string grupo)
        {
            Id = id;
            Data = data;
            Titulo = titulo;
            Descricao = descricao;
            Grupo = grupo;
        }
    }
}
