using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotzerProject.Interfaces._2ndApproach
{
    public interface IPaidSearchDetails
    {
        string CampaignName { get; set; }
        string CampaignAddressLine1 { get; set; }
        string CampaignPostCode { get; set; }
        string CampaignRadius { get; set; }
        string LeadPhoneNumber { get; set; }
        string SMSPhoneNumber { get; set; }
        string UniqueSellingPoint1 { get; set; }
        string UniqueSellingPoint2 { get; set; }
        string UniqueSellingPoint3 { get; set; }
        string Offer { get; set; }
        string DestinationURL { get; set; }
    }
}
