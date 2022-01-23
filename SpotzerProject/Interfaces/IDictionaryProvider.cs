using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotzerProject.Interfaces
{
    public interface IDictionaryProvider
    {
        Dictionary<string, Type> DataType { get; }
    }
}
