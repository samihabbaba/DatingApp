using System.Threading.Tasks;
using DatingApp2.API.Models;

namespace DatingApp2.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user,string password);
        Task<User> Login(string username,string password);
        Task<bool> UserExists(string username);
        Task Register(string username, object password);
    }
}