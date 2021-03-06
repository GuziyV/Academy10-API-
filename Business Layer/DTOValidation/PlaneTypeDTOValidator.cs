﻿using Data_Access_Layer.Models;
using FluentValidation;
using Shared.DTos;

namespace Business_Layer.DTOValidation
{
    public class PlaneTypeDTOValidator : AbstractValidator<PlaneTypeDTO>
    {
        public PlaneTypeDTOValidator()
        {
            RuleFor(p => p.Model).NotEmpty();
        }
    }
}