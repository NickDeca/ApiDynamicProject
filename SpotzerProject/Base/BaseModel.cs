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

        // Binds the Json name WebsiteDetails and sets the value of the dynamic field _details. 
        // Returns the field _details
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

        // Binds the Json name AdWordCampaign and sets the value of the dynamic field _details. 
        // Returns the field _details
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
    }
}
