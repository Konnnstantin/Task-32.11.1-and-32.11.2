using Microsoft.Extensions.Logging;
using MvcStartApp.Models;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Repository
{
    public interface ILoggerRepository
    {
        Task AddLogger(Request request);
        Task<Request[]> GetLoggers();
    }
}
