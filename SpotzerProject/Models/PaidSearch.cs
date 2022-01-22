using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotzerProject.Models
{

    public class PaidSearch : BaseModel
    {
        public Adwordcampaign AdWordCampaign { get; set; }

        public PaidSearch(Adwordcampaign others)
        {
            AdWordCampaign = others;
        }
    }

    public class Adwordcampaign : IByProduct
    {
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
