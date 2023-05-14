using MvcStartApp.Models;
using System.Threading.Tasks;

namespace MvcStartApp.Repository
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}
