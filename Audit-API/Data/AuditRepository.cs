using System.Threading.Tasks;
using Audit_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Audit_API.Data
{
    public class AuditRepository : IAuditRepository
    {
        private readonly DataContext _context;
        public AuditRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Kind> GetKind(int id)
        {
            var kind =  await _context.Kind.FirstOrDefaultAsync(x => x.id == id);
            return kind;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.User.FirstOrDefaultAsync(x => x.id == id);
            return user;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}