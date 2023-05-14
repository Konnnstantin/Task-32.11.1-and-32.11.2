using MvcStartApp.Models;
using MvcStartApp.Repository;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace MvcStartApp.Models.Repository
{
    public class LoggerRepository : ILoggerRepository
    {
        private BlogContext _blogContext;

        public LoggerRepository(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public async Task AddLogger(Request request)
        {
            var entry = _blogContext.Entry(request);
            
            request.Id = new Guid();
            request.Date = DateTime.Now;


            if (entry.State == EntityState.Detached)
                await _blogContext.Requests.AddAsync(request);
         
            await _blogContext.SaveChangesAsync();
        }

        public async Task<Request[]> GetLoggers()
        {
            return await _blogContext.Requests.ToArrayAsync();
        }
    }
    
}
