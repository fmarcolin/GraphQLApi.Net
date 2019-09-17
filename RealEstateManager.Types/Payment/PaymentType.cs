using GraphQL.Types;

namespace RealEstateManager.Types.Payment
{
    public class PaymentType : ObjectGraphType<Database.Models.Payment>
    {
        public PaymentType()
        {
            Field(x => x.Id);
            Field(x => x.Value);
            Field(x => x.DateCreated);
            Field(x => x.DateOverdue);
            Field(x => x.Paid);
        }
    }
}
