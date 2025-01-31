using AivenIOMySql.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AivenIOMySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBConnectionController : ControllerBase
    {
        private readonly ApplicationDBContext _appDBContext;

        public DBConnectionController(ApplicationDBContext context)
        {
            _appDBContext = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetDBData()
        {
            try
            {
                var data = await _appDBContext.TestTable.ToListAsync();

                return new JsonResult(data);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
