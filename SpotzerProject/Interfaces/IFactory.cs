using SpotzerProject.HelperFunctions;
using SpotzerProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotzerProject.Interfaces
{
    public interface IFactory
    {
        ProductJson DynamicObjectAllocatorFactory(ProductJson data);

    }
}
