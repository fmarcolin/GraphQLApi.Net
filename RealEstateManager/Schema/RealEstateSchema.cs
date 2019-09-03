using GraphQL;
using RealEstateManager.Queries;

namespace RealEstateManager.Schema
{
    public class RealEstateSchema : GraphQL.Types.Schema
    {
        public RealEstateSchema(IDependencyResolver resolver)
            :base(resolver)
        {
            Query = resolver.Resolve<PropertyQuery>();
        }
    }
}
