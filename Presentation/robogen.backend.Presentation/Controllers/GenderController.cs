using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using robogen.backend.Application.Repositories;

namespace robogen.backend.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : Controller
    {
        private readonly IGenderReadRepository _genderReadRepository;
        private readonly IMapper _mapper;

        public GenderController(IGenderReadRepository genderReadRepository, IMapper mapper)
        {
            _genderReadRepository = genderReadRepository;
            _mapper = mapper;
        }

        [HttpGet, Route("get-all")]
        public IActionResult GetAllGenders()
        {
            try
            {
                // Retrieve all products from the repository
                var genders = _genderReadRepository.GetAll();
                ;
                ;

                // Check if any products were found
                if (genders == null || !genders.Any())
                {
                    return NotFound("No genders found.");
                }


                // Return the mapped DTOs as a JSON response
                return Ok(genders);
            }
            catch (Exception ex)
            {
                // Handle any exceptions and return a 500 Internal Server Error response
                return StatusCode(500, $"An error occurred while retrieving products: {ex.Message}");
            }
        }
    }
}

