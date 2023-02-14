using MediatR;

namespace MediatRExample.MediatR.Queries.City.GetById
{
    public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, GetCityViewModel>
    {
        public Task<GetCityViewModel> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            //Get City from Repository

            var viewModel = new GetCityViewModel()
            {
                Name = "Ankara",
                Population = "5.663.000"
            };

            return Task.FromResult(viewModel);
        }
    }
}
