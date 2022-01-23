using SpotzerProject.Interfaces;
using SpotzerProject.Models;
using System;
using System.Collections.Generic;

namespace SpotzerProject.HelperFunctions
{
    public class Converters : IConverterSp
    {
        private Dictionary<string,Type> _typeDictionary;
        public Converters(IDictionaryProvider provider)
        {
            _typeDictionary = provider.DataType;
                //new Dictionary<string, Type>
                //{
                //    { "Paid Search", typeof(Adwordcampaign) },
                //    { "sample string 18", typeof(Websitedetails) }
                //};
        }

        /// <summary>
        /// Gets an object and converts to Type from dictionary based on the type string
        /// </summary>
        /// <param name="objectCast"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public dynamic CastDynamicly(dynamic objectCast, string type)
        {
            ValidateJson(objectCast, type);

            return Newtonsoft.Json.JsonConvert.DeserializeObject(objectCast.ToString(), _typeDictionary[type]);
        }

        /// <summary>
        /// Gets a Json string converts it to abstract class T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public T JsonToObject<T>(string input) where T : class
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(input);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        /// <summary>
        /// Gets a LineItems object and bast on the Product Type it dynamically convert it to the corresponding class from the dictionary
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
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
    
        private void ValidateJson(dynamic objectCast, string type)
        {
            if (type == null)
                throw new Exception("No Product Type found in Json. Invalid Json");

            if (objectCast == null)
                throw new Exception("No Details found in Json. Invalid Json");

            if (!_typeDictionary.ContainsKey(type))
                throw new Exception($"Project Type {type}");
        }
    }
}
