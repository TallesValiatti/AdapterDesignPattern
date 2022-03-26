using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using AdapterDesignPattern.Entitites;
using AdapterDesignPattern.Services.Interfaces;

namespace AdapterDesignPattern.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly LegacyUserService _legacyUserService;
        public UserService()
        {
            _legacyUserService = new LegacyUserService();
        }

        #nullable disable
        public ServiceResult<IEnumerable<User>> GetAll()
        {
            try
            {
                var json = _legacyUserService.GetAllUsers();

                if(string.IsNullOrEmpty(json))
                   return ServiceResult<IEnumerable<User>>.CreateSuccessfulResult(new List<User>());
                
                var users =  JsonSerializer.Deserialize<IEnumerable<User>>(json);
                
                return ServiceResult<IEnumerable<User>>.CreateSuccessfulResult(users);
            }
            catch (System.Exception ex)
            {
                return ServiceResult<IEnumerable<User>>.CreateFailedResult(ex.Message);
            }
        }
    }
}

