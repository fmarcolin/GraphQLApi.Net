﻿using GraphQL.Types;
using RealEstateManager.DataAccesss.Repositories.Contracts;
using RealEstateManager.Types.Payment;

namespace RealEstateManager.Types.Property
{
    public class PropertyType : ObjectGraphType<Database.Models.Property>
    {
        public PropertyType(IPaymentRepository paymentRepository)
        {
            Field(x => x.Id).Description("Property Id");
            Field(x => x.Name).Description("Name of the property");
            Field(x => x.Family);
            Field(x => x.City);
            Field(x => x.Street);
            Field<ListGraphType<PaymentType>>("payments",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "last", Description = "teste" }),
                resolve: context =>
                {
                    var lastItemsFilter = context.GetArgument<int?>("last");
                    return lastItemsFilter != null
                        ? paymentRepository.GetAllForProperty(context.Source.Id, lastItemsFilter.Value)
                        : paymentRepository.GetAllForProperty(context.Source.Id);
                });
        }
    }
}
