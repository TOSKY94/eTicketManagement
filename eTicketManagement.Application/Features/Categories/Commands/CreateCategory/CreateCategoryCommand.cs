﻿using MediatR;

namespace eTicketManagement.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand: IRequest<CreateCategoryCommandResponse>
    {
        public string CategoryName { get; set; } = string.Empty;
    }
}
