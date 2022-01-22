﻿using SpotzerProject.Interfaces;
using SpotzerProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotzerProject.HelperFunctions
{
    public class ObjectFactoryDynamic : IFactory
    {
        private Converters _converter;
        public ObjectFactoryDynamic()
        {
            _converter = new Converters();
        }


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