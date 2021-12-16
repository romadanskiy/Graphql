using HotChocolate.Types;
using WebAppDocker.SchemaStitching.Models;

namespace WebAppDocker.SchemaStitching.Query
{
    public class GadgetType : ObjectType<Gadget>
    {
        protected override void Configure(IObjectTypeDescriptor<Gadget> descriptor)
        {
            descriptor
                .Field(f => f.Id)
                .Type<StringType>();

            descriptor
                .Field(f => f.Name)
                .Type<StringType>();

            // descriptor
            //     .Field(f => f.Category.CategoryName)
            //     .Type<StringType>();

            descriptor
                .Field(f => f.Model)
                .Type<StringType>();

            descriptor
                .Field(f => f.Manufacturer.Manufacturer)
                .Type<StringType>();
        }
    }
}