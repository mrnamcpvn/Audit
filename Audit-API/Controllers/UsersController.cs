using System.Threading.Tasks;
using Audit_API.Data;
using Audit_API.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Audit_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAuditRepository _repo;
        private readonly IMapper _mapper;
        public UsersController(IAuditRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);
            var userToReturn = _mapper.Map<UserForDetailDto>(user);
            return Ok(userToReturn);
        }
    }
}