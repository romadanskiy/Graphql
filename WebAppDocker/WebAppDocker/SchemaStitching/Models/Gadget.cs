using HotChocolate;
using HotChocolate.Types;

namespace WebAppDocker.SchemaStitching.Models
{
    public class Gadget
    {
        [GraphQLType(typeof(IdType))] public int Id { get; set; }
        public string Model { get; set; } = null!;

        public Items Manufacturer { get; set; } = null!;

        public string Name { get; set; } = null!;
        // public Category Category { get; set; } = null!;
    }

    public class Items
    {
        public string Manufacturer { get; set; } = null!;
    }
    
}