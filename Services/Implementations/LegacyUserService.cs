
using System.Text.Json;
using System.Xml.Linq;
using AdapterDesignPattern.Entitites;

namespace AdapterDesignPattern.Services.Implementations
{
    public class LegacyUserService
    {
        public string GetAllUsers()
        {
            // Mock a legacy call
            return "[{\"Name\":\"Talles\",\"Age\":27},{\"Name\":\"Jane\",\"Age\":54}]";
        } 
    }
}