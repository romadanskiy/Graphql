using HotChocolate.Types;
using HT.Models;

namespace HT.Schemes;

public class DeviceType: ObjectType<Device>
{
    protected override void Configure(IObjectTypeDescriptor<Device> descriptor)
    {
        descriptor
            .Field(f => f.Id)
            .Type<StringType>();
        
        descriptor
            .Field(f => f.Name)
            .Type<StringType>();

        descriptor
            .Field(f => f.Category.CategoryName)
            .Type<StringType>();
    }
}