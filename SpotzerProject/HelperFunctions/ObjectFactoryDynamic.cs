using SpotzerProject.Interfaces;
using SpotzerProject.Models;

namespace SpotzerProject.HelperFunctions
{
    public class ObjectFactoryDynamic : IFactory
    {
        private Converters _converter;
        public ObjectFactoryDynamic()
        {
            _converter = new Converters();
        }

        /// <summary>
        /// Get the Json Data and dynamically convert the objects
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public ProductJson DynamicObjectAllocatorFactory(ProductJson data)
        {
            foreach (var line in data.LineItems)
            {
                line.Website = _converter.CastDynamicly(line.Website, line.ProductType);                
            }

            return data;
        }
    }
}
