using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace CompanyEmployees.Presentation.Controllers
{
    public class CompaniesController
    {
        [Route("api/[companies]")]
        [ApiController]
        public class CompanyController : ControllerBase
        {
            
        }
    }
}