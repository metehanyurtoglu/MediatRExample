using MediatR;

namespace MediatRExample.MediatR.Queries.City.GetById
{
    public class GetCityByIdQuery : IRequest<GetCityViewModel>
    {
        public Guid Id { get; set; }
    }
}
