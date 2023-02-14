using MediatR;

namespace MediatRExample.MediatR.Commands.City.Create
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, Guid>
    {
        public Task<Guid> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            //Create City using by Repository

            return Task.FromResult(Guid.NewGuid());
        }
    }
}
