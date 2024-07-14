using AutoMapper;
using eTicketManagement.Application.Contracts.Persistence;
using eTicketManagement.Domain.Entities;
using MediatR;

namespace eTicketManagement.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCammandHandler: IRequestHandler<CreateCategoryCommand, CreateCategoryCommandResponse>
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCammandHandler(IMapper mapper, IRepository<Category> categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var createCategoryCammandResponse = new CreateCategoryCommandResponse();
            var validator = new CreateCategoryCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createCategoryCammandResponse.Success = false;
                createCategoryCammandResponse.ValidationErrors = new List<string>();

                foreach (var error in validationResult.Errors)
                {
                    createCategoryCammandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if (createCategoryCammandResponse.Success)
            {
                var category = new Category() { CategoryName = request.CategoryName };
                category = await _categoryRepository.Add(category);
                createCategoryCammandResponse.Category = _mapper.Map<CreateCategoryDto>(category);

            }
            return createCategoryCammandResponse;
        }
    }
}
