using System;
using Microsoft.AspNetCore.Mvc;
using SpotzerProject.Interfaces;
using SpotzerProject.Models;

namespace SpotzerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotzeWebController : ControllerBase
    {
        private IFactory _factory;

        /// <summary>
        /// DI with Simple Injector of ObjectFactoryDynamic object
        /// </summary>
        /// <param name="factory"></param>
        public SpotzeWebController(IFactory factory)
        {
            _factory = factory;
        }


        [HttpPost]
        [Route("ReadApi")]
        public IActionResult ReadApi([FromBody] ProductJson data)
        {
            try
            {
                var dataDynamicObject = _factory.DynamicObjectAllocatorFactory(data);
                return Ok("Product received");
            }
            catch (Exception err)
            {
                return Content(err.Message);
            }
        }        
    }
}
