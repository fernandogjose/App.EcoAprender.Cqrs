using App.EcoAprender.Cqrs.Domain.Commands;
using App.EcoAprender.Cqrs.Domain.Interfaces.Commands;

namespace App.EcoAprender.Cqrs.Domain.Interfaces.Handles
{
    public interface IHandler<T> where T : IRequestCommand
    {
        ResponseCommand Handle(T requestCommand);
    }
}
