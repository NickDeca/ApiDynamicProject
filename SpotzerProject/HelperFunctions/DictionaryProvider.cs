using SpotzerProject.Interfaces;
using SpotzerProject.Models;
using System;
using System.Collections.Generic;

namespace SpotzerProject.HelperFunctions
{
    public class DictionaryProvider : IDictionaryProvider
    {
        public DictionaryProvider()
        {
            DataType = new Dictionary<string, Type>
                {
                    { "Paid Search", typeof(Adwordcampaign) },
                    { "sample string 18", typeof(Websitedetails) }
                };
        }


        public Dictionary<string, Type> DataType { get; }
    }
}
