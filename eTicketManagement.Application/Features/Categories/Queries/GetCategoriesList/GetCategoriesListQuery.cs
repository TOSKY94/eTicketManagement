using eTicketManagement.Application.Features.Events.Queries.GetEventList;
using MediatR;

namespace eTicketManagement.Application.Features.Categories.Queries.GetCategoryList
{
    public class GetCategoriesListQuery: IRequest<List<CategoryListVm>>
    {

    }
}
