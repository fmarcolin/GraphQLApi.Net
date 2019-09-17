using GraphQL;
using RealEstateManager.Mutations;
using RealEstateManager.Queries;

namespace RealEstateManager.Schema
{
    public class RealEstateSchema : GraphQL.Types.Schema
    {
        public RealEstateSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<PropertyQuery>();
            Mutation = resolver.Resolve<PropertyMutation>();
        }
    }
}
