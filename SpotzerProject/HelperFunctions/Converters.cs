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
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject(objectCast.ToString(), _typeDictionary[type]);
            }
            catch (Exception err)
            {
                throw err;
            }
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
            try
            {
                var typeCast = _typeDictionary[line.ProductType];
                var castedLine = Convert.ChangeType(line.Website, typeCast);
                return castedLine;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
