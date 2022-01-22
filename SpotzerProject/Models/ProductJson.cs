using SpotzerProject.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotzerProject.Models
{
    public class ProductJson2ndApproach
    {
        //public ProductJson()
        //{
        //    LineItems = new();
        //}

        public string Partner { get; set; }
        public string OrderID { get; set; }
        public string TypeOfOrder { get; set; }
        public string SubmittedBy { get; set; }
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public List<BaseRequest> LineItems { get; set; }
    }


    public class ProductJson
    {
        public string Partner { get; set; }
        public string OrderID { get; set; }
        public string TypeOfOrder { get; set; }
        public string SubmittedBy { get; set; }
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public List<BaseModel> LineItems { get; set; }
    }
}
