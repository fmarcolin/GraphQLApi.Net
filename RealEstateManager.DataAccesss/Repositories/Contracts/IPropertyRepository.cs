using RealEstateManager.Database.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RealEstateManager.DataAccesss.Repositories.Contracts
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetAll();
    }
}
