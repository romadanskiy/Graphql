using HotChocolate.Types;

namespace CT.Schemes;

public class QueryType : ObjectType<Query>
{
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
    {
        descriptor
            .Field(f => f.GetPhone())
            .Type<PhoneType>();
    }
}