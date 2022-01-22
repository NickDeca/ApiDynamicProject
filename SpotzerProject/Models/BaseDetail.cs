using SpotzerProject.Interfaces._2ndApproach;
using SpotzerProject.Models._2ndApproach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotzerProject.Models
{
    public class BaseDetail : IBaseRequest
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
        public string CampaignName { get; set; }
        public string CampaignAddressLine1 { get; set; }
        public string CampaignPostCode { get; set; }
        public string CampaignRadius { get; set; }
        public string LeadPhoneNumber { get; set; }
        public string SMSPhoneNumber { get; set; }
        public string UniqueSellingPoint1 { get; set; }
        public string UniqueSellingPoint2 { get; set; }
        public string UniqueSellingPoint3 { get; set; }
        public string Offer { get; set; }
        public string DestinationURL { get; set; }
    }
}
