using SpotzerProject.Interfaces;
using SpotzerProject.Models;
using System;
using System.Collections.Generic;

namespace SpotzerProject.HelperFunctions
{
    public class Converters : IConverterSp
    {
        private Dictionary<string, Type> _typeDictionary;
        public Converters()
        {
            _typeDictionary = new Dictionary<string, Type>
                {
                    { "Paid Search", typeof(Adwordcampaign) },
                    { "sample string 18", typeof(Websitedetails) }
                };
        }

        public dynamic CastDynamicly(dynamic objectCast, string type)
        {
            if (!_typeDictionary.ContainsKey(type))
                throw new Exception($"Project Type {type}");

            return Newtonsoft.Json.JsonConvert.DeserializeObject(objectCast.ToString(), _typeDictionary[type]);
        }

        public T JsonToObject<T>(string input) where T : class
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(input);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public dynamic ConvertDynamiclyFromDictionary(BaseModel line)
        {
            var typeCast = _typeDictionary[line.ProductType];
            if (typeCast == null)
                throw new Exception($"Project Type {line.ProductType}");
            try
            {
                var castedLine = Convert.ChangeType(line.Website, typeCast);
                return castedLine;
            }
            catch (Exception err)
            {
                throw new Exception($"Conversion of Product to {line.ProductType} failed");
            }
        }
    }
}
