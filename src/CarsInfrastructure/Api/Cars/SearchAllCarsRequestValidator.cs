using FluentValidation;
using Infrastructure.Web.Api.Common.Validation;
using Infrastructure.Web.Api.Interfaces.Operations.Cars;
using JetBrains.Annotations;

namespace CarsInfrastructure.Api.Cars;

[UsedImplicitly]
public class SearchAllCarsRequestValidator : AbstractValidator<SearchAllCarsRequest>
{
    public SearchAllCarsRequestValidator(IHasSearchOptionsValidator hasSearchOptionsValidator)
    {
        Include(hasSearchOptionsValidator);
    }
}