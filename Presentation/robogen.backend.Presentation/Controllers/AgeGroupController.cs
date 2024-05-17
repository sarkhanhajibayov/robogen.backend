using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using robogen.backend.Application.Repositories;

namespace robogen.backend.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgeGroupController : ControllerBase
    {
        private readonly IAgeGroupReadRepository _ageGroupReadRepository;
        private readonly IMapper _mapper;

        public AgeGroupController(IAgeGroupReadRepository ageGroupReadRepository, IMapper mapper)
        {
            _ageGroupReadRepository = ageGroupReadRepository;
            _mapper = mapper;
        }

        [HttpGet, Route("get-all")]
        public IActionResult GetAllAgeGroups()
        {
            try
            {
                // Retrieve all products from the repository
                var ageGroups = _ageGroupReadRepository.GetAll();
                ;
                ;

                // Check if any products were found
                if (ageGroups == null || !ageGroups.Any())
                {
                    return NotFound("No age groups found.");
                }


                // Return the mapped DTOs as a JSON response
                return Ok(ageGroups);
            }
            catch (Exception ex)
            {
                // Handle any exceptions and return a 500 Internal Server Error response
                return StatusCode(500, $"An error occurred while retrieving products: {ex.Message}");
            }
        }
    }
}

