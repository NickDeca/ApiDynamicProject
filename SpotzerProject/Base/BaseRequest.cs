using SpotzerProject.Models;
using SpotzerProject.Models._2ndApproach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotzerProject.Base
{
    public class BaseRequest : BaseModel
    {
        public AdWordCampaign AdWordCampaign { get; set; }
        public WebSiteDetails WebsiteDetails { get; set; }
    }
}
