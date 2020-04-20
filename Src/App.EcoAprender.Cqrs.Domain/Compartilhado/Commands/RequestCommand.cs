using System.Collections.Generic;

namespace App.EcoAprender.Cqrs.Domain.Compartilhado.Commands
{
    public abstract class RequestCommand
    {
        public abstract List<string> Validar();
    }
}
