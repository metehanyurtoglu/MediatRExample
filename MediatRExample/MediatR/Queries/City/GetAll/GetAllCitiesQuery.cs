using MediatR;

namespace MediatRExample.MediatR.Queries.City.GetAll
{
    public class GetAllCitiesQuery : IRequest<List<GetCityViewModel>>
    {
    }
}
