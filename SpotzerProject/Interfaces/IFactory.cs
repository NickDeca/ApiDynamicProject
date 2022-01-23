using SpotzerProject.Models;

namespace SpotzerProject.Interfaces
{
    public interface IFactory
    {
        ProductJson DynamicObjectAllocatorFactory(ProductJson data);

    }
}
