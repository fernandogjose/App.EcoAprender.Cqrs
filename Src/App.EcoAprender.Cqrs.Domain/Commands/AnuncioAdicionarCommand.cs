using App.EcoAprender.Cqrs.Domain.Interfaces.Commands;
using System.Collections.Generic;

namespace App.EcoAprender.Cqrs.Domain.Commands
{
    public class AnuncioAdicionarCommand : IRequestCommand
    {
        public int Marca { get; set; }

        public int Modelo { get; set; }

        public int Versao { get; set; }

        public int Ano { get; set; }

        public int Quilometragem { get; set; }

        public string Observacao { get; set; }

        public List<string> Erros { get; set; }

        public void Validar()
        {
            Erros = new List<string>(0);

            if (Marca == 0)
            {
                Erros.Add("Marca é obrigatório");
            }

            if (Modelo == 0)
            {
                Erros.Add("Modelo é obrigatório");
            }

            if (Versao == 0)
            {
                Erros.Add("Versão é obrigatório");
            }
        }
    }
}
