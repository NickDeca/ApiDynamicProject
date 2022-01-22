using SpotzerProject.Models;

namespace SpotzerProject.Interfaces
{
    public interface IConverterSp 
    {
        dynamic CastDynamicly(dynamic objectCast, string type);//where T : class;
        T JsonToObject<T>(string input) where T : class;
        dynamic ConvertDynamiclyFromDictionary(BaseModel line);
    }
}
