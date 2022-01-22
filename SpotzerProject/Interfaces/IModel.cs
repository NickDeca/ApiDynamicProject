using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotzerProject.Models
{
    public interface IModel
    {
        int ID { get; set; }
        string ProductID { get; set; }
        string ProductType { get; set; }
        string Notes { get; set; }
        string Category { get; set; }
        //string Others { get; set; }
    }
}
