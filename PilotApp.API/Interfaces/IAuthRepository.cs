using System.Threading.Tasks;
using Pilotapp.API.Models;

namespace PilotApp.API.Interfaces
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string userName, string password);
         Task<bool> UserExists(string userName);
    }
}