using dotnetcore_fluent_validation.Models;
using FluentValidation;

namespace dotnetcore_fluent_validation.ValidationExtensions;

public sealed class ProductValidator: AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(product => product.Id).NotNull();
        RuleFor(product => product.Name).NotNull();
        RuleFor(product => product.Discount).LessThanOrEqualTo(10f).NotNull();
    }
}