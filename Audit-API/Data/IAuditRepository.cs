using System.Threading.Tasks;
using Audit_API.Models;

namespace Audit_API.Data
{
    public interface IAuditRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<Kind> GetKind(int id);

        Task<User> GetUser(int id);
    }
}