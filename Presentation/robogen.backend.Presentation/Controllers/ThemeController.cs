using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using robogen.backend.Application.Repositories;
using robogen.backend.Persistence.Repositories;

namespace robogen.backend.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThemeController : ControllerBase
    {
        private readonly IThemeReadRepository _themeReadRepository;
        private readonly IMapper _mapper;

        public ThemeController(IThemeReadRepository themeReadRepository, IMapper mapper)
        {
            _themeReadRepository = themeReadRepository;
            _mapper = mapper;
        }

        [HttpGet, Route("get-all")]
        public IActionResult GetAllThemes()
        {
            try
            {
                // Retrieve all products from the repository
                var themes = _themeReadRepository.GetAll();
                ;
                ;

                // Check if any products were found
                if (themes == null || !themes.Any())
                {
                    return NotFound("No themes found.");
                }


                // Return the mapped DTOs as a JSON response
                return Ok(themes);
            }
            catch (Exception ex)
            {
                // Handle any exceptions and return a 500 Internal Server Error response
                return StatusCode(500, $"An error occurred while retrieving products: {ex.Message}");
            }
        }
    }
}
