using Newtonsoft.Json;

namespace SpotzerProject.Models
{
    public class BaseModel : IModel
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ProductType { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }

        private dynamic _details;

        [JsonProperty("WebsiteDetails")]
        public dynamic Website
        {
            get
            { return _details; }
            set
            {
                _details = value;
            }
        }

        [JsonProperty("AdWordCampaign")]
        public dynamic PaidSearch
        {
            get
            { return _details; }
            set
            {
                _details = value;
            }
        }
        //public IByProduct OthersTh { get; set; }
    }
}
