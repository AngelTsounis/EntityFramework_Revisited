using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]

public class PokemonController : Controller
{
    private readonly AppDbContext _context;
    public PokemonController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetPokemons()
    {

        var retrieveAllPokemons = await _context.Pokemons.ToListAsync();
        return Ok(retrieveAllPokemons);
    }
}

