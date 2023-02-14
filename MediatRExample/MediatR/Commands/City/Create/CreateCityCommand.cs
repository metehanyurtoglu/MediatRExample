using MediatR;

namespace MediatRExample.MediatR.Commands.City.Create
{
    public class CreateCityCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Population { get; set; }
    }
}
