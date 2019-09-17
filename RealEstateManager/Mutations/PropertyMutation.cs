using GraphQL.Types;
using RealEstateManager.DataAccesss.Repositories.Contracts;
using RealEstateManager.Database.Models;
using RealEstateManager.Types.Property;

namespace RealEstateManager.Mutations
{
    public class PropertyMutation : ObjectGraphType
    {
        public PropertyMutation(IPropertyRepository propertyRepository)
        {
            Field<PropertyType>(
                "addProperty",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PropertyInputType>> { Name = "property" }),
                resolve: context =>
                {
                    var property = context.GetArgument<Property>("property");
                    return propertyRepository.Add(property);
                }
                );
        }
    }
}
