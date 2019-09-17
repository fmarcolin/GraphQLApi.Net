using RealEstateManager.DataAccesss.Repositories.Contracts;
using RealEstateManager.Database;
using RealEstateManager.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateManager.DataAccesss.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly RealEstateContext _dbContext;

        public PropertyRepository(RealEstateContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Property Add(Property property)
        {
            _dbContext.Add(property);
            _dbContext.SaveChanges();
            return property;
        }

        public IEnumerable<Property> GetAll()
        {
            return _dbContext.Properties;
        }

        public Property GetById(int propertyId)
        {
            return _dbContext.Properties.SingleOrDefault(x => x.Id == propertyId);
        }
    }
}
