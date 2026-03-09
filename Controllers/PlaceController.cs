using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tripzy.Core.Dtos;
using Tripzy.Core.Services; 

namespace Tripzy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlaceController : ControllerBase
    {
        // private readonly IPlaceService _placeService;

        // public PlaceController(IPlaceService placeService)
        // {
        //     _placeService = placeService;
        // }

        // // GET /place/city/5?category=Restaurant&region=Kadikoy
        // [HttpGet("city/{cityId}")]
        // public async Task<ActionResult<IEnumerable<PlaceDto>>> GetByCity(int cityId, [FromQuery] string? category = null, [FromQuery] string? region = null)
        // {
        //     var result = await _placeService.GetByCityAsync(cityId, category, region);
        //     return Ok(result);
        // }

        // // GET /place/123
        // [HttpGet("{id}")]
        // public async Task<ActionResult<PlaceDto>> Get(int id)
        // {
        //     var place = await _placeService.GetByIdAsync(id);
        //     if (place == null) return NotFound();
        //     return Ok(place);
        // }

        // // GET /place/search?q=cafe&cityId=5
        // [HttpGet("search")]
        // public async Task<ActionResult<IEnumerable<PlaceDto>>> Search([FromQuery] string q, [FromQuery] int? cityId = null)
        // {
        //     var result = await _placeService.SearchAsync(q, cityId);
        //     return Ok(result);
        // }

        // // POST /place/123/reviews
        // [Authorize]
        // [HttpPost("{id}/reviews")]
        // public async Task<ActionResult> AddReview(int id, [FromBody] ReviewCreateDto dto)
        // {
        //     var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        //     await _placeService.AddReviewAsync(id, userId!, dto);
        //     return CreatedAtAction(nameof(Get), new { id }, null);
        // }

        // // POST /place/123/favorite  (toggles favorite)
        // [Authorize]
        // [HttpPost("{id}/favorite")]
        // public async Task<ActionResult> ToggleFavorite(int id)
        // {
        //     var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        //     await _placeService.ToggleFavoriteAsync(id, userId!);
        //     return NoContent();
        // }
    }
}