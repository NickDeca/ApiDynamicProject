using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotzerProject.Interfaces._2ndApproach
{
    public interface IWebSiteDetails
    {
        string TemplateId { get; set; }
        string WebsiteBusinessName { get; set; }
        string WebsiteAddressLine1 { get; set; }
        string WebsiteAddressLine2 { get; set; }
        string WebsiteCity { get; set; }
        string WebsiteState { get; set; }
        string WebsitePostCode { get; set; }
        string WebsitePhone { get; set; }
        string WebsiteEmail { get; set; }
        string WebsiteMobile { get; set; }

    }
}

