using HotChocolate.Types;

namespace WebAppDocker.SchemaStitching.Query
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetGadget())
                .Type<GadgetType>();
        }
    }
}