using MediatR;
using MediatRExample.MediatR.Queries.City.GetById;

namespace MediatRExample.MediatR.Queries.City.GetAll
{
    public class GetAllCitiesQueryHandler : IRequestHandler<GetAllCitiesQuery, List<GetCityViewModel>>
    {
        public Task<List<GetCityViewModel>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
        {
            //Get All Cities from Repository

            var viewModel = new List<GetCityViewModel>()
            {
                new GetCityViewModel()
                {
                    Name = "Ankara",
                    Population  = "5.663.000"
                },
                new GetCityViewModel()
                {
                    Name = "İstanbul",
                    Population = "15.460.000"
                },
                new GetCityViewModel() {
                    Name = "İzmir",
                    Population = "4.367.000"
                }
            };

            return Task.FromResult(viewModel);
        }
    }
}
