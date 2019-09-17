using RealEstateManager.Database.Models;
using System.Collections.Generic;

namespace RealEstateManager.DataAccesss.Repositories.Contracts
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetAll();
        Property GetById(int propertyId);
        Property Add(Property property);
    }
}
