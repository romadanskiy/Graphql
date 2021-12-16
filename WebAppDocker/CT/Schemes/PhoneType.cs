using CT.Models;
using HotChocolate.Types;

namespace CT.Schemes;

public class PhoneType: ObjectType<Phone>
{
    protected override void Configure(IObjectTypeDescriptor<Phone> descriptor)
    {
        descriptor
            .Field(f => f.Id)
            .Type<StringType>();
        
        descriptor
            .Field(f => f.Manufacturer.Manufacturer)
            .Type<StringType>();

        descriptor
            .Field(f => f.Model)
            .Type<StringType>();
    }
}