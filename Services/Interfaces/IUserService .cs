using AdapterDesignPattern.Entitites;

namespace AdapterDesignPattern.Services.Interfaces
{
    public interface IUserService 
    {
       ServiceResult<IEnumerable<User>> GetAll();
    }
}