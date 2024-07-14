using AutoMapper;
using eTicketManagement.Application.Contracts.Persistence;
using eTicketManagement.Application.Features.Events.Queries.GetEventDetail;
using eTicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQueryHandler: IRequestHandler<GetCategoriesListWithEventsQuery, List<CategoryEventListVm>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesListWithEventsQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryEventListVm>> Handle(GetCategoriesListWithEventsQuery request, CancellationToken cancellationToken)
        {
            var list = await _categoryRepository.GetCategoriesWithEvents(request.IncludeHistory);

            return _mapper.Map<List<CategoryEventListVm>>(list);
        }
    }
}
