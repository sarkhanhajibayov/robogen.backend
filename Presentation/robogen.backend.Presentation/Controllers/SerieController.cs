using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using robogen.backend.Application.Repositories;

namespace robogen.backend.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        private readonly ISerieReadRepository _serieReadRepository;
        private readonly IMapper _mapper;

        public SerieController(ISerieReadRepository serieReadRepository, IMapper mapper)
        {
            _serieReadRepository = serieReadRepository;
            _mapper = mapper;
        }

        [HttpGet, Route("get-all")]
        public IActionResult GetAllSeries()
        {
            try
            {
                // Retrieve all products from the repository
                var series = _serieReadRepository.GetAll();
                ;
                ;

                // Check if any products were found
                if (series == null || !series.Any())
                {
                    return NotFound("No series found.");
                }


                // Return the mapped DTOs as a JSON response
                return Ok(series);
            }
            catch (Exception ex)
            {
                // Handle any exceptions and return a 500 Internal Server Error response
                return StatusCode(500, $"An error occurred while retrieving products: {ex.Message}");
            }
        }
    }
}
