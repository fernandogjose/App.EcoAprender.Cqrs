using App.EcoAprender.Cqrs.Domain.Interfaces.Commands;
using System.Collections.Generic;

namespace App.EcoAprender.Cqrs.Domain.Commands
{
    public class AnuncioDeletarCommand : IRequestCommand
    {
        public int Id { get; set; }

        public List<string> Erros { get; set; }

        public void Validar()
        {
            if (Id == 0)
            {
                Erros.Add("Id é obrigatório");
            }
        }
    }
}
