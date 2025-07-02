using FluentValidation;
using Isrotel.Domain.Optima.Models;

namespace Isrotel.Framework.Validation;

public class BoardBaseValidator : AbstractValidator<BoardBase>
{
    public BoardBaseValidator()
    {
        RuleFor(x => x.BoardBaseCode)
            .NotEmpty().WithMessage("BoardBaseCode is required.")
            .WithMessage("BoardBaseCode must be not empty");
    }
}
