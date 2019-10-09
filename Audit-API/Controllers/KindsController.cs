using System.Threading.Tasks;
using Audit_API.Data;
using Microsoft.AspNetCore.Mvc;

namespace Audit_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KindsController : ControllerBase
    {
        private readonly IAuditRepository _repo;
        private readonly DataContext _context;
        public KindsController(IAuditRepository repo, DataContext context)
        {
            _context = context;
            _repo = repo;
        }

        [HttpGet("{id}", Name = "GetKind")]
        public async Task<IActionResult> GetKind(int id)
        {
            var user = await _repo.GetKind(id);
            return Ok(user);
        }
    }
}