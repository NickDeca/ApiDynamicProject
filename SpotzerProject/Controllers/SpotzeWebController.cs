using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleInjector;
using SpotzerProject.Base;
using SpotzerProject.HelperFunctions;
using SpotzerProject.Interfaces;
using SpotzerProject.Models;

namespace SpotzerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotzeWebController : ControllerBase
    {
        private IFactory _factory;
        public SpotzeWebController(IFactory factory)
        {
            _factory = factory;
        }

        // TODO inheritance polla 8a kanoun sto ProductJson gia na mporoume na valoume osa 8eloume
        [HttpPost]
        [Route("ReadApi")]
        public void ReadApi([FromBody] ProductJson data)
        {
            try
            {
                var dataDynamicObject = _factory.DynamicObjectAllocatorFactory(data);

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


    }


}
