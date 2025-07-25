﻿using FluentValidation;
using Isrotel.Domain.Optima.Models.Main;

namespace Isrotel.Framework.Validation;

public class OptimaPlanDataValidator : AbstractValidator<PlanData>, IOptimaPlanCodeValidator
{
    public OptimaPlanDataValidator()
    {
        RuleFor(x => x.Name).SetValidator(new OptimaPlanCodeValidator<PlanData>());
    }

    public bool IsPlanCodeValid(PlanData planData)
    {
        var validationResult = this.Validate(planData);
        return validationResult.IsValid;
    }
}

public interface IOptimaPlanCodeValidator
{
    bool IsPlanCodeValid(PlanData planData);
}
