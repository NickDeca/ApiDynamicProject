using SpotzerProject.Interfaces._2ndApproach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotzerProject.Models._2ndApproach
{
    public class WebSiteDetails : PartnerA, IWebSiteDetails
    {
        public string TemplateId { get; set; }
        public string WebsiteBusinessName { get; set; }
        public string WebsiteAddressLine1 { get; set; }
        public string WebsiteAddressLine2 { get; set; }
        public string WebsiteCity { get; set; }
        public string WebsiteState { get; set; }
        public string WebsitePostCode { get; set; }
        public string WebsitePhone { get; set; }
        public string WebsiteEmail { get; set; }
        public string WebsiteMobile { get; set; }
    }
}
