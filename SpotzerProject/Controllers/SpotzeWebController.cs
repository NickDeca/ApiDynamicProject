using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpotzerProject.Base;
using SpotzerProject.Models;

namespace SpotzerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotzeWebController : ControllerBase
    {

        // Todo na mpei sto appsettings, only getter new class singleton instansiate in start
        public Dictionary<string, Type> TypeDictionary = new Dictionary<string, Type>
                {
                    { "Paid Search", typeof(Adwordcampaign) },
                    { "sample string 18", typeof(Websitedetails) }
                };


        // TODO inheritance polla 8a kanoun sto ProductJson gia na mporoume na valoume osa 8eloume
        [HttpPost]
        [Route("ReadApi")]
        public void ReadApi([FromBody] ProductJson data)
        {
            try
            {
                var dataDynamicObject = DynamicObjectAllocatorFactory(data);

                //var dataObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductJson>("");
            }
            catch (Exception err)
            {

            }
        }

        [HttpPost]
        [Route("ReadApi2ndApproach")]
        public IActionResult ReadApi2ndApproach([FromBody] ProductJson baseRequest)
        {
            try
            {

                return Ok("Product received.");
            }catch(Exception err)
            {
                return  Content(err.Message);
            }
        }

        private ProductJson DynamicObjectAllocatorFactory(ProductJson data)
        {
            foreach (var line in data.LineItems)
            {
                try
                {
                    var typeCast = TypeDictionary[line.ProductType];
                    var debug = Convert.ChangeType(line.Website , typeCast);

                }catch(Exception err) 
                {  }
                if (line.ProductType.ToString().Equals("Paid Search"))
                {
                    dynamic dynamic1 = CastDynamicly<Adwordcampaign>(line.PaidSearch);
                    PaidSearch sdsdd = dynamic1;
                }
                else
                {
                    dynamic dynamic = CastDynamicly<Websitedetails>(line.Website);
                    Website sdsd2 = dynamic;
                }
            }

            return data;
        }

        private T CastDynamicly<T>(dynamic objectCast) where T : class
        {
            try
            {
                //return JsonSerializer.Deserialize<T>(objectCast.ToString());
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(objectCast.ToString());
                //return (T)objectCast;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private T JsonToObject<T>(string input) where T : class
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
    }


}
