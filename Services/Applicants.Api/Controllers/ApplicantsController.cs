

using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Applicants.Api.Services;
using Applicants.Api.Models;


namespace Applicants.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ApplicantsController : Controller
    {
        private readonly IApplicantRepository _applicantRepository;

        public ApplicantsController(IApplicantRepository applicantRepository){
            _applicantRepository = applicantRepository;
        }

        /// <summary>
        /// Gets applicants list
        /// </summary>
        /// <returns>Returns applicants list</returns>      
        /// <response code="200">Returns applicants list</response>
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<IEnumerable<Applicant>> Get()
        {
            return await _applicantRepository.GetAll();
        }
    }
}
