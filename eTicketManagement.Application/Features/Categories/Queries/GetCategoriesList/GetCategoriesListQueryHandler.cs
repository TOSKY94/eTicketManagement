using AutoMapper;
using eTicketManagement.Application.Contracts.Persistence;
using eTicketManagement.Application.Features.Events.Queries.GetEventList;
using eTicketManagement.Domain.Entities;
using MediatR;

namespace eTicketManagement.Application.Features.Categories.Queries.GetCategoryList
{
    public class GetCategoriesListQueryHandler: IRequestHandler<GetCategoriesListQuery, List<CategoryListVm>>
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesListQueryHandler(IMapper mapper, IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<List<CategoryListVm>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var allCategories = (await _categoryRepository.ListAll()).OrderBy(c => c.CategoryName);
            return _mapper.Map<List<CategoryListVm>>(allCategories);
        }
    }
}
